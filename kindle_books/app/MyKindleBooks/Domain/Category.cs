using System.Collections.Generic;

namespace MyKindleBooks.Domain
{
    public class Category
    {
        public Category() {
            Subcategories = new List<Subcategory>();
        }

        public virtual string Name { get; set; }
        public virtual int ProductCategoryID { get; set; }
        public virtual ICollection<Subcategory> Subcategories { get; set; }
    }
}