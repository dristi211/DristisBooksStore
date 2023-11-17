using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
using System.Threading.Tasks;

namespace DristisBooks.Models.ViewModels
{
   public class ProductVM
    {
        public Product Product { get; set; }  //Display all the product details

        public IEnumerable<SelectListItem> CategoryList { get; set; }    //install package "Microsoft.AspNetCore.Mvc.ViewFeatures package
        public IEnumerable<SelectListItem> CoverTypeList { get; set; }
    }
}
