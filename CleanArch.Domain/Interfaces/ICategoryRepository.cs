using CleanArch.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArch.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        //GET e GetById
        Task<IEnumerable<Category>> GetCategories();
        Task<Category> GetById(int? id);
        
        //POST
        Task<Category> Create(Category category);

        //UPDATE
        Task<Category> Update(Category category);

        //REMOVE
        Task<Category> Remove(Category category);
    }
}
