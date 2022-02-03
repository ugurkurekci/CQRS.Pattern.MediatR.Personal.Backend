using Data.Entities;

namespace Repository.Abstracts;

public interface IAboutRepository
{
    public Task AddAsync(About about);
}