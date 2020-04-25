using System.Collections.Generic;

namespace CodersInRio.Function
{
    public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public double Price {get;set;}

        public static List<Book> GetBooks() 
        {
            return new List<Book>() {
                new Book() 
                {
                    Author = "Robert C. Martin",
                    BookName = "Clean Coder",
                    Price = 29.99D,
                    Id = 1
                },
                new Book() 
                {
                    Author = "Robert C. Martin",
                    BookName = "Clean Architect",
                    Price = 59.99D,
                    Id = 2
                },
                new Book() 
                {
                    Author = "Eric Evans",
                    BookName = "Domain Drive Design",
                    Price = 39.99D,
                    Id = 3
                }
            };

        }
    }
}