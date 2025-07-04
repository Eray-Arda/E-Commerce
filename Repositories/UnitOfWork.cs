namespace App.Repositories;

    public class UnitOfWork(AppDdContext context) : IUnitOfWork
    {
        public Task<int> SaveChangesAsync()
        {
            return context.SaveChangesAsync();
        }
    }

