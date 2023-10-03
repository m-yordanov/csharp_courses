using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBoxData.Models
{
    public class Box
    {
        private const string PropertyZeroOrNegativeExceptionMessage = "{0} cannot be zero or negative.";

        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length
        {
            get => length;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format(PropertyZeroOrNegativeExceptionMessage, nameof(Length)));
                }
                length = value;
            }
        }
        public double Width
        {
            get => width;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format(PropertyZeroOrNegativeExceptionMessage, nameof(Width)));
                }
                width = value;
            }
        }
        public double Height
        {
            get => height;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format(PropertyZeroOrNegativeExceptionMessage, nameof(Height)));
                }
                height = value;
            }
        }

        public double SurfaceArea()
            => 2 * Length * Width + LateralSurfaceArea();

        public double LateralSurfaceArea()
            => 2 * Length * Height + 2 * Width * Height;

        public double Volume()
            => Width * Length * Height;
    }
}
