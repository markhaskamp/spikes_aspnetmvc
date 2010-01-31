using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.MobileControls;

namespace MyKindleBooks.Models
{
    public class BookRepository
    {
        private IEnumerable<Books> books;

        public static IList<Books> SampleData() {
            IList<Books> foo = new List<Books>();
            foo.Add(new Books() {
                                    Author = "Laszlo Mero, Gosi-Greguss",
                                    OrderDate = new DateTime(2010, 1, 31),
                                    Title = "Moral Calculations: Game Theory, Logi, and Human Frailty"
                                });
            foo.Add(new Books() {
                                    Author = "Chad Orzel",
                                    OrderDate = new DateTime(2009, 12, 22),
                                    Title = "How to Teach Physics to Your Dog"
                                });
            foo.Add(new Books() {
                                    Author = "Christopher Mcdougall",
                                    OrderDate = new DateTime(2009, 11, 11),
                                    Title = "Born to Run"
                                });
            foo.Add(new Books() {
                                    Author = "Brian Cox",
                                    OrderDate = new DateTime(2009, 10, 28),
                                    Title = "Why Does E=m2?"
                                });
            foo.Add(new Books() {
                                    Author = "Jon Loeliger",
                                    OrderDate = new DateTime(2009, 10, 20),
                                    Title = "Version Control with Git"
                                });
            foo.Add(new Books() {
                                    Author = "Joe Posnanski",
                                    OrderDate = new DateTime(2009, 9, 15),
                                    Title = "The Machine"
                                });

            return foo;
        }
    }
}
