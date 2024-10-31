using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TripTrackerAPI.Context;
using TripTrackerAPI.Dtos;
using TripTrackerAPI.Models;
using TripTrackerAPI.Repository.Interface;

namespace TripTrackerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItinerariesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IItineraries _repository;


        public ItinerariesController(IItineraries repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var especialidades = await _repository.GetItineraries();

            return especialidades.Any()
                ? Ok(especialidades)
                : NotFound("não encontrado");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (id <= 0) return BadRequest("Inválido");
            var itinerarie = _repository.GetItinerariesById(id);

            var itinerarieReturn = _mapper.Map<ItinerariesDto>(itinerarie);


            return itinerarieReturn != null
                ? Ok(itinerarieReturn)
                : NotFound("Não encontrado");
        }
        [HttpPost]
        public async Task<IActionResult> Post(ItinerarieAddDto itinerarie)
        {
      
        if (string.IsNullOrEmpty(itinerarie.title)) return BadRequest("Dados inválidos");

        var itinerarieAdd = _mapper.Map<Itineraries>(itinerarie);
         _repository.Add(itinerarieAdd);


        return await _repository.SaveChangesAsync()
        ? Ok("Aadicionado")
        : BadRequest("Erro ao adicionar");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id)
        {
            if (id <= 0) return BadRequest("Inválido");

            var itinerarie = _repository.GetItinerariesById(id);

            if (itinerarie == null) return NotFound("Especialidade não existe na base de dados");
            
            
            
            _repository.Update(itinerarie);


            return await _repository.SaveChangesAsync()
                ? Ok("Atualizado")
                : BadRequest("Erro ao atualizar");
        }

        [HttpDelete("{id}")]
        public async Task <IActionResult> Delete(int id)
        {
            if (id <= 0) return BadRequest("Inválido");
            var itinerarie = _repository.GetItinerariesById(id);

            _repository.Delete(itinerarie);

            return await _repository.SaveChangesAsync()
                ? Ok("Deletado")
                : BadRequest("Erro ao Deletar");
        }
    }
}
