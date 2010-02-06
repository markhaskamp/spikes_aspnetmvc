using System.Collections.Generic;

namespace MyKindleBooks.Domain
{
    public class Category
    {
        private ICollection<Subcategory> _subcategories = new List<Subcategory>();
        public virtual string Name { get; set; }
        public virtual int ProductCategoryID { get; set; }
        public virtual ICollection<Subcategory> subcategories {
            get {
                return _subcategories;
            }
            set {
                _subcategories = value;
            }
        }
    }
}