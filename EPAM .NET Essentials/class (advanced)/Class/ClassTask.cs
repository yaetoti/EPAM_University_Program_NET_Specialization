using System;
using System.Collections.Generic;
using System.Linq;

namespace Class
{
    public class Rectangle
    {
        private double sideA;
        private double sideB;

        public Rectangle(double a, double b)
        {
            sideA = a;
            sideB = b;
        }

        public Rectangle(double a)
        {
            sideA = a;
            sideB = 5;
        }

        public Rectangle()
        {
            sideA = 4;
            sideB = 3;
        }

        public double GetSideA()
        {
            return sideA;
        }

        public double GetSideB()
        {
            return sideB;
        }

        public double Area()
        {
            return sideB * sideB;
        }

        public double Perimeter()
        {
            return (sideA + sideB) * 2;
        }

        public bool IsSquare()
        {
            return sideA == sideB;
        }

        public void ReplaceSides()
        {
            (sideA, sideB) = (sideB, sideA);
        }
    }

    public class ArrayRectangles
    {
        private readonly Rectangle[] rectangle_array;
        private int size = 0;

        public ArrayRectangles(int n)
        {
            rectangle_array = new Rectangle[n];
        }

        public ArrayRectangles(params Rectangle[] rectangle_array)
        {
            this.rectangle_array = new Rectangle[rectangle_array.Length];
            for (int i = 0; i < rectangle_array.Length; i++)
            {
                this.rectangle_array[i] = rectangle_array[i];
                if (size == 0 && rectangle_array[i] is null)
                {
                    size = i;
                }
            }
        }

        public bool AddRectangle(Rectangle rectangle)
        {
            if (size == rectangle_array.Length)
            {
                return false;
            }

            rectangle_array[size++] = rectangle;
            return true;
        }

        public int NumberMaxArea()
        {
            int resultIndex = 0;
            double resultArea = double.MinValue;

            for (int i = 0; i < size; ++i)
            {
                double currArea = rectangle_array[i].Area();
                if (currArea > resultArea)
                {
                    resultIndex = i;
                    resultArea = currArea;
                }
            }

            return resultIndex;
        }

        public int NumberMinPerimeter()
        {
            int resultIndex = 0;
            double resultPerimeter = double.MaxValue;

            for (int i = 0; i < size; ++i)
            {
                double currPerimeter = rectangle_array[i].Perimeter();
                if (currPerimeter < resultPerimeter)
                {
                    resultIndex = i;
                    resultPerimeter = currPerimeter;
                }
            }

            return resultIndex;
        }

        public int NumberSquare()
        {
            int result = 0;

            for (int i = 1; i < rectangle_array.Length; ++i)
            {
                if (rectangle_array[i].IsSquare())
                {
                    ++result;
                }
            }

            return result;
        }
    }
}
