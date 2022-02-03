using Data.Entities;

namespace Repository.Abstracts;

public interface IPhotoRepository
{
    public Task AddAsync(Photo photo);
}