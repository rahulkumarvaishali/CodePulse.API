using CodePulse.API.Model.Domain;

namespace CodePulse.API.Repositories.Interface
{
    public interface ICategoryRepository
    {
        Task<Category> CreateAsync(Category category);
    }
}
