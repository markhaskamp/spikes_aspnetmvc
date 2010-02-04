using System;

namespace MyKindleBooks.Domain
{
    public class Category
    {
        public virtual Guid rowguid { get; set; }
        public virtual string Name { get; set; }
        public virtual int ProductCategoryID { get; set; }
    }
}