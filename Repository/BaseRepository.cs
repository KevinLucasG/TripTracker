using Microsoft.EntityFrameworkCore;
using TripTrackerAPI.Context;
using TripTrackerAPI.Repository.Interface;

namespace TripTrackerAPI.Repository
{
    public class BaseRepository : IBaseRepository
    {
        public readonly TripTrackerContext _context;
        public BaseRepository(TripTrackerContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity)
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity)
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void Update<T>(T entity)
        {
            _context.Update(entity);
        }
    }
}
