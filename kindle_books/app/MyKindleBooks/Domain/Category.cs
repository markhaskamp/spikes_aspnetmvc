using System;
using System.Collections.Generic;

namespace MyKindleBooks.Domain
{
    public class Category
    {
        public Category() {
            subcategories = new List<Subcategory>();
        }

        public virtual string Name { get; set; }
        public virtual int ProductCategoryID { get; set; }
        public virtual ICollection<Subcategory> subcategories { get; set; }
    }
}