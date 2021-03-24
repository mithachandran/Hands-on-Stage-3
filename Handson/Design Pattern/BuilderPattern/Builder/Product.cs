using System;
using System.Collections.Generic;

namespace Builder
{
    class Product
    {
        private int noOfSweet;
        private int noOfSavory;

        public Product()
        {
            noOfSweet = 0;
            noOfSavory = 0;
        }

        public void AddSweet(int count)
        {
            noOfSweet += count;
        }

        public void AddSavory(int count)
        {
            noOfSavory += count;
        }

        public void Show(string s)
        {
            if(s=="child")
            {
                Console.WriteLine($"Child  contains {noOfSweet} Sweets and {noOfSavory} Savories");
            } else
            {
                Console.WriteLine($"adult  contains {noOfSweet} Sweets and {noOfSavory} Savories");
            }
            
            Console.ReadKey();
        }
    }
}