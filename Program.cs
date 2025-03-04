using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_NTU_CS_FL_1197___Library_Managment_System
{
    class Book
    {
        public string Name;
        public string Writer;
        public string BookID;
        public double Cost;

        void ShowDetails()
        {
            Console.WriteLine($"Title: {Name}\tAuthor: {Writer}\tBook ID: {BookID}\tPrice: {Cost} PKR");
        }

        void CalculateDiscount(double percent)
        {
            double newPrice = Cost - (Cost * (percent / 100));
            Console.WriteLine($"\nAfter applying a {percent}% discount, the final price of the book is: {newPrice} PKR");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("====================================");
            Console.WriteLine("        Library Management System        ");
            Console.WriteLine("====================================");
            Console.WriteLine("\nBook Details:");
            Console.WriteLine("------------------------------------------------");

            Book book1 = new Book();
            book1.Name = "Code Mastery";
            book1.Writer = "Ali Raza";
            book1.BookID = "B987";
            book1.Cost = 4500;

            book1.ShowDetails();
            book1.CalculateDiscount(25);
        }
    }
}
