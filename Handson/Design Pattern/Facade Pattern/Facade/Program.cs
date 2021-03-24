﻿using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapeMaker = new ShapeMaker();

            shapeMaker.drawCircle();
            shapeMaker.drawRectangle();
            shapeMaker.drawSquare();

            Console.ReadKey();
        }
    }
}
