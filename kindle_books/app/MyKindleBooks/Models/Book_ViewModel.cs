using System.Collections.Generic;
using System.Linq;

namespace MyKindleBooks.Models
{
    public class Book_ViewModel
    {
        private IList<Books> _allBooks = new List<Books>();
        public IList<Books> AllBooks {
            get { return _allBooks; }
            set { _allBooks = value;  }
        }
 
        public bool showAuthorLabel { get; set; }
        public string authorLabel { get; set; }

        public Book_ViewModel() {
            showAuthorLabel = false;
        }
    }
}
