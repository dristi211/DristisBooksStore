﻿using DristisBooks.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DristisBooksStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller

    {
        private readonly IUnitOfWork _unitOfWrok;

        public CategoryController(IUnitOfWork unitOfWrok)
        {
            _unitOfWrok = unitOfWrok;
        }
        public IActionResult Index()
        {
            return View();
        }

        //API calls here 
        #region API CALLS
        [HttpGet]

        public IActionResult GetAll()
        {
            //return NotFound();
            var allObj = _unitOfWrok.Category.GetAll();
            return Json(new { data = allObj });
        }
        #endregion
    }
}
