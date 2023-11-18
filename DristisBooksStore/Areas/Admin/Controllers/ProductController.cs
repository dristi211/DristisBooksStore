﻿using DristisBooks.DataAccess.Repository.IRepository;
using DristisBooks.DataAccess.Repository;
using DristisBooks.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DristisBooks.Models.ViewModels;

namespace DristisBooksStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostEnvironment;               //to upload images on the server inside wwwroot

        public ProductController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _hostEnvironment = hostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)  //action method for Upsert
        {
             ProductVM productVM = new ProductVM()
            {

                Product = new Product(),
                    CategoryList = _unitOfWork.Category.GetAll().Select(i => new SelectListItem
                    {
                        Text = i.Name,
                        Value = i.Id.ToString()
                    }),

                CoverTypeList = _unitOfWork.CoverType.GetAll().Select(i => new SelectListItem

                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                }),

            };
            
            if (id == null)
            {
                //this is for create
                return View(productVM);
            }
            //this is for edit
            productVM.Product = _unitOfWork.Product.Get(id.GetValueOrDefault());

            if (productVM.Product == null)
            {
                return NotFound();
            }
            return View(productVM);
        }

        //use HTTP POST to define the post-action method
        [HttpPost]
        [ValidateAntiForgeryToken]

      /*  public IActionResult Upsert(CoverType covertype)
        {
            if (ModelState.IsValid)                   //checks all validation in the model (e.g. Name required) to increase security
            {
                if (covertype.Id == 0)
                {
                    _unitOfWork.Product.Add(covertype);
                    _unitOfWork.Save();

                }
                else
                {
                    _unitOfWork.CoverType.Update(covertype);
                }

                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));        //to see all the categories
            }
            return View(covertype);
        }*/

        //API calls here 
        #region API CALLS
        [HttpGet]

        public IActionResult GetAll()
        {
            //return NotFound();
            var allObj = _unitOfWork.Product.GetAll(inccludeProperties: "Category, CoverType");
            return Json(new { data = allObj });
        }

        [HttpDelete]

        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.Product.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            _unitOfWork.Product.Remove(objFromDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete successful" });
        }

        #endregion
    }
}

    

