namespace TripTrackerAPI.Repository.Interface
{
    public interface IBaseRepository
    {
        public void Add <T>(T entity);
        public void Update <T>(T entity);
        public void Delete <T>(T entity);

        Task<bool> SaveChangesAsync();
    }

}
