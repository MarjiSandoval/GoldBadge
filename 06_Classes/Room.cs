using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Classes
{
    public class Room
    {
        /*
        Create a Room class that has three properties: one each for the length, width, and height.
        Create a method that calculates total square footage.
        We also would like to include some constants that the define a minimum and maximum length, width, and height.
        When setting the properties, make sure to compare the values to the min/max and only set them if the value is valid.
    Bonus:
        Create a method that calculates total lateral surface area.
        Only allow the properties to be set from inside the class itself
        Throw an exception if the given value is outside the permitted range.
        Test the code like we did with the Vehicle tests.
        */
        
        public Room(double l) { }
        public Room(int length, int width, int height )
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public Room(double l, double w, double h) : this(l)
        {
            this.w = w;
            this.h = h;
        }

        private const double MaxLength = 30;
        private const double MinLength = 6;
        private const double MaxWidth = 30;
        private const double MinWidth = 6;
        private const double MaxHeight = 15;
        private const double MinHeight = 9;
        private double w;
        private double h;

        private double _length { get; set; }
        public double Length 
        {
            get
            {
                return _length;
            } 
            private set
            {
                if (value < MinLength || value > MaxLength)
                {
                    throw new ArgumentException($"The length should be between {MinLength} & {MaxHeight}");
                }
                else
                    _length = value;
            }
        }
        private double _width { get; set; }
        public double Width
        {
            get
            {
                return _width;
            }
            private set
            {
                if (value < MinWidth || value > MaxWidth)
                {
                    throw new ArgumentException($"The width should be between {MinWidth} & {MaxWidth}");
                }
                else
                    _width = value;
            }
        }
                
        private double _height { get; set; }
        public double Height 
        { 
            get
            {
                return _height;
            } 
            private set
            {
                if (value < MinHeight || value > MaxHeight)
                {
                    throw new ArgumentException($"The height should be between {MinLength} & {MaxHeight}");
                }
                else
                    _height = value;
            } 
        }

        public double CalculateSquareFootage()
        {
            return Length * Width;
        }

        public double CalculateLateralSurfaceArea()
        {
            double lengthLSA = _length * _height * 2;
            double widthLSA = _width * _height * 2;
            return lengthLSA + widthLSA;

        }
            
    }
}
