using AssignmentData.Repository;
using Microsoft.AspNetCore.Mvc;
using AssignmentData.DataAccess;
using AssignmentData.Models.Domain;
using System;

namespace AssignmentUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductsRepository _productRepo;

        public ProductController(IProductsRepository productRepo)
        {
            _productRepo = productRepo;
        }

        public async Task<IActionResult> Add()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Add(Products product1)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(product1);
                bool addProductResult = await _productRepo.AddAsync(product1);
                if (addProductResult)
                    TempData["msg"] = "Successfully added";
                else
                    TempData["msg"] = "Could not added";
            }
            catch (Exception ex)
            {
                TempData["msg"] = "Could not added";
            }
            return RedirectToAction(nameof(Add));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var product = await _productRepo.GetByIdAsync(id);
            //if (product == null)
            //    return NotFound();
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Products product1)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(product1);
                var updateResult = await _productRepo.UpdateAsync(product1);
                if (updateResult)
                    TempData["msg"] = "Updated succesfully";
                else
                    TempData["msg"] = "Could not updated";

            }
            catch (Exception ex)
            {
                TempData["msg"] = "Could not updated";
            }
            return View(product1);
        }

        public async Task<IActionResult> DisplayAll()
        {
            var product = await _productRepo.GetAllAsync();
            return View(product);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var deleteResult = await _productRepo.DeleteAsync(id);
            return RedirectToAction(nameof(DisplayAll));
        }

    }
}
