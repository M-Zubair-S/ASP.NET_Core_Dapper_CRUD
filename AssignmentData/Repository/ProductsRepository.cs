using AssignmentData.DataAccess;
using AssignmentData.Models.Domain;
using System;


namespace AssignmentData.Repository
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly ISqlDataAccess _db;

        public ProductsRepository(ISqlDataAccess db)
        {
            _db = db;
        }

        public async Task<bool> AddAsync(Products product)
        {
            try
            {
                await _db.SaveData("sp_create_product", new { product.Product, product.Discription, product.Created });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> UpdateAsync(Products product)
        {
            try
            {

                await _db.SaveData("sp_update_product", product);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                await _db.SaveData("sp_delete_product", new { Id = id });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<Products?> GetByIdAsync(int id)
        {
            IEnumerable<Products> result = await _db.GetData<Products, dynamic>("sp_get_product", new { Id = id });
            return result.FirstOrDefault();
        }

        public async Task<IEnumerable<Products>> GetAllAsync()
        {
            string query = "sp_get_allproduct";
            return await _db.GetData<Products, dynamic>(query, new { });
        }

    }
}
