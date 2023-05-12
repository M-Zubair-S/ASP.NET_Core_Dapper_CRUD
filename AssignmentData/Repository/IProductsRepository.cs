using AssignmentData.Models.Domain;
using System;

namespace AssignmentData.Repository
{
    public interface IProductsRepository
    {
        Task<bool> AddAsync(Products person);
        Task<bool> UpdateAsync(Products person);
        Task<bool> DeleteAsync(int id);
        Task<Products?> GetByIdAsync(int id);
        Task<IEnumerable<Products>> GetAllAsync();
    }
}