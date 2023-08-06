using CodePulse.API.Data;
using CodePulse.API.Model.Domain;
using CodePulse.API.Model.DTO;
using CodePulse.API.Repositories.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodePulse.API.Controllers
{
    //https://localhost:xxxx/api/categories
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository categoryRepository;

        //private readonly ApplicationDbContext dbContext;

        //public CategoriesController(ApplicationDbContext dbContext)
        //{
        //    this.dbContext = dbContext;
        //}
        //
        public CategoriesController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryRequestDto request)
        {
            //Map Dto to Domain Model
            var category = new Category
            {
                Name = request.Name,
                UrlHandle = request.UrlHandle,
            };
            
            await categoryRepository.CreateAsync(category);

            //Domain model to DTO
            var response = new CategoryDto
            {
                Id = category.Id,
                Name = category.Name,
                UrlHandle = request.UrlHandle
            };

            return Ok();
        }
    }
}
