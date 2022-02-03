using Data.Entities;
using Data.ProjectDBContexts;
using Repository.Abstracts;

namespace Repository.Concrete
{
    public class PhotoRepository : IPhotoRepository
    {
        private readonly ProjectDbContext _projectDbContext;

        public PhotoRepository(ProjectDbContext projectDbContext)
        {
            _projectDbContext = projectDbContext;
        }

        public async Task AddAsync(Photo photo)
        {
            _projectDbContext.Add(photo);
            await _projectDbContext.SaveChangesAsync();
        }
    }
}