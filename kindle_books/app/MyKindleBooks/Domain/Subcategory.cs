
namespace MyKindleBooks.Domain
{
    public class Subcategory
    {
        virtual public int ProductSubcategoryID { get; set; }
        virtual public string Name { get; set; }
        virtual public Category Category { get; set; }
    }
}
