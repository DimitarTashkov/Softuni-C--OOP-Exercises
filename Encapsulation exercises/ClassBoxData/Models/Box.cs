﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBoxData.Models
{
    public class Box
    {
        private const string PropertyValueMessage = "{0} cannot be zero or negative.";

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
            get{ return length; }

            set 
            { 
                if(value< 0)
                {
                    throw new ArgumentException(string.Format(PropertyValueMessage,nameof(Length)));
                }
                length = value;
            }
        }
        public double Width 
        {
            get { return width; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(string.Format(PropertyValueMessage, nameof(Width))) ;
                }
                width = value;
            }
        }
        public double Height 
        { 
            get { return height; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(string.Format(PropertyValueMessage, nameof(Height)));
                }
                height = value;
            }
        }

            public double SurfaceArea() => 2 * Length * Width + LateralSurfaceArea();
            public double LateralSurfaceArea() => 2 * Length * Height + 2 * Width * Height;
            public double Volume() => Length * Width * Height;

    }
}
