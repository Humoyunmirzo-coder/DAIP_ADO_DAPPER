using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN.Models
{
    public  class Book
    {
        public int Id { get; set; }
        public  string Name { get; set; }
        public string Price { get; set; }

        private Book book;

        public Book GetBook()
        {
            return book;
        }
        public override string ToString()
        {
            return $" Id = {Id} \n Name = {Name}\n Prise = {Price}  \n Book = {book} ";
        }

        public void SetBook(Book value)
        {
            book = value;
        }

        Book() { }

        
    }
}
