using System;
using System.Collections.Generic;
using System.Text;

namespace OopConptsDemo
{
    class Romance
    {
        /* Astraction from Books Class - Parent, you just need to know which methods
        of the object are available to call and which input parameters are needed to
        trigger a specific operation. But you don’t need to understand how this method
        is implemented and which kinds of actions it has to perform to create the expected
        result.*/

        public string Genre { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int NumberOfGenres { get; set; }
        public decimal Price { get; set; }

        public decimal value;
        private decimal price;
        {
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
        }
    }
}


 
               

   
               


           

        
       

