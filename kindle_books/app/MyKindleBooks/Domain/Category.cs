using System;
using Iesi.Collections.Generic;

namespace MyKindleBooks.Domain
{
    public class Category
    {
        public virtual Guid rowguid { get; set; }
        public virtual string Name { get; set; }
        public virtual int ProductCategoryID { get; set; }
        public virtual ISet<Subcategory> subcategories { get; set; }
    }
}