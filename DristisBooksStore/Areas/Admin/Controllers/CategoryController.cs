using DristisBooks.DataAccess.Repository.IRepository;
using DristisBooks.Models;
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

        public IActionResult Upsert(int? id)  //action method for Upsert
        {
            CategoryController category = new Category();  //using DristisBooks.Models;
            if(id == null)
            {
                //this is for create
                return View(category);
            }
            //this is for edit
            category = _unitOfWrok.Category.Get(id.GetValueOrDefault());
            if(category == null)
            {
                return NotFound();
            }
            return View(category);
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

        public static implicit operator CategoryController(Category v)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
