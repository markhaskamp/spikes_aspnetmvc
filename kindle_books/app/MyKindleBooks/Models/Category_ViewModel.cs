using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyKindleBooks.Domain;

namespace MyKindleBooks.Models
{
    public class Category_ViewModel
    {
        private IList<Category> _allCategories = new List<Category>();
        public IList<Category> AllCategories
        {
            get { return _allCategories; }
            set { _allCategories = value; }
        }

        private IList<Subcategory> _allSubCategories = new List<Subcategory>();
        public IList<Subcategory> AllSubcategories { 
            get { return _allSubCategories; }
            set { _allSubCategories = value; }
        }
    }
}
