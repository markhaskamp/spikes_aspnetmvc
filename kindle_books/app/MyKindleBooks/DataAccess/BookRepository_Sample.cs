using System;
using System.Collections.Generic;
using MyKindleBooks.Domain;

namespace MyKindleBooks.DataAccess
{
    public class BookRepository_Sample : IBookRepository
    {
        private IList<Books> books;

        public IList<Books> getAllBooks() {
            books = new List<Books>();
            books.Add(new Books()
                    {
                        Author = "Laszlo Mero, Gosi-Greguss",
                        OrderDate = new DateTime(2010, 1, 31),
                        Title = "Moral Calculations: Game Theory, Logic, and Human Frailty"
                    });
            books.Add(new Books()
                    {
                        Author = "Chad Orzel",
                        OrderDate = new DateTime(2009, 12, 22),
                        Title = "How to Teach Physics to Your Dog"
                    });
            books.Add(new Books()
                    {
                        Author = "Christopher Mcdougall",
                        OrderDate = new DateTime(2009, 11, 11),
                        Title = "Born to Run"
                    });
            books.Add(new Books()
                    {
                        Author = "Brian Cox",
                        OrderDate = new DateTime(2009, 10, 28),
                        Title = "Why Does E=mc2?"
                    });
            books.Add(new Books()
                    {
                        Author = "Jon Loeliger",
                        OrderDate = new DateTime(2009, 10, 20),
                        Title = "Version Control with Git"
                    });
            books.Add(new Books()
                    {
                        Author = "Joe Posnanski",
                        OrderDate = new DateTime(2009, 9, 15),
                        Title = "The Machine"
                    });

            return books;
        }
    }
}