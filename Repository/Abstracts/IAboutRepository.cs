namespace Repository.Abstracts;

public interface IAboutRepository
{
    public Task<IReadOnlyList<ProjectModel>> Get();

    public Task AddAsync(Project project);

    public Task UpdateAsync(Project project);

    Task<Project> GetByIdAsync(int id);
}
