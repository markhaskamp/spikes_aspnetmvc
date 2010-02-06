using System;
using Iesi.Collections.Generic;

namespace MyKindleBooks.Domain
{
    public class Category
    {
        private ISet<Subcategory> _subcategories = new HashedSet<Subcategory>();

        public virtual Guid rowguid { get; set; }
        public virtual string Name { get; set; }
        public virtual int ProductCategoryID { get; set; }
        public virtual ISet<Subcategory> subcategories {
            get {
                return _subcategories;
            }
            set {
                _subcategories = value;
            }
        }
    }
}