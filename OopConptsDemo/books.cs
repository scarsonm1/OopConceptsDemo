using System;
using System.Collections.Generic;
using System.Text;

namespace OopConbooksptsDemo
{
    class Books
            {
        /* Create, abstraction allows us to take a look at a concept */
        public string Genre { get; set; }
        public string Title { get; set; }
        public int Year {get; set;}
        public int NumberOfGenres {get; set;}
        public decimal Price { get;  set; }

        private decimal price;

          {
         /*Encapsulation - Encapsulation is achieved by hiding internal structure
          of the object as well as implementation of its methods. All that is public
          is an interface to work with the specific object that is controlled by 
          developer as its creator. */
         
           get
            { 
                return price;
            }
           set
              {
                if (value< 0)
                {
                    price = 0;
                else
                {
                    price = value;
                }

          static void Main(String[] args)
          {
           /* Inheritance - 
            Books books = new books();
            Romance romance = new romance();
            Describe(book);
            Describe(romance);
          }
          
          /*Polymorphism - is the ability of an object to take on many forms. 
            The most common use of polymorphism in OOP occurs when a parent 
            class reference is used to refer to a child class object*/
          
          static void Decribe(Titles.books)
          {
            Console.WriteLine("The Genre of this book is  " + Genre);
            Console.WriteLine("The Title this book is  " + Title);
            Console.WriteLine("The year of this book is  " + year + " and price $, " + price);

          }


                
 
     }


    }
}
