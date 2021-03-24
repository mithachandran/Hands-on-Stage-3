using System;

namespace Builder
{
    public class Program
    {
        public static void Main()
        {
            var shop = new Director_Shop();

            var childBuilder = new childBuilder();
            var adultBuilder = new AdultBuilder();

            shop.Construct(childBuilder);
            var childPackage = childBuilder.GetResult();
            childPackage.Show("child");

            shop.Construct(adultBuilder);
            var adultPackage = adultBuilder.GetResult();
            adultPackage.Show("adult");
        }
    }
}