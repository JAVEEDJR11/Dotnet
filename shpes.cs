﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Assignment
{
    public class Shpes
    {
        public Location c;
        public string ToString()
        {
            return string.Empty;
        }
        public double Area(double res)
        {
            return res;
        }

        public double Perimeter(double res)
        {
            return res;
        }
    }

    public class Location
    {
        private double x, y;
    }

    public class Rectange : Shpes
    {
        public double side1;
        public double side2;
    }

    public class Circle : Shpes
    {
        public double radius;
    }
}