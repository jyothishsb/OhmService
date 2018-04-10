using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OhmService.Models
{
    public class OhmConstants
    {
        public OhmConstants()
        {
    
    }

        public static OhmConstants Instance
        {
            get
            {
                if (mInstance == null)
                {
                    mInstance = new OhmConstants();
                }
                return mInstance;
            }
        }


        private static OhmConstants mInstance;
       

        public const string Pink = "pink";
        public const string Silver = "silver";
        public const string Gold = "gold";
        public const string Black = "black";
        public const string Brown = "brown";
        public const string Red = "red";
        public const string Orange = "orange";
        public const string Yellow = "yellow";
        public const string Green = "green";
        public const string Blue = "blue";
        public const string Violet = "violet";
        public const string Gray = "gray";
        public const string White = "white";


        public const int BlackOhmValue = 0;
        public const int BrownOhmValue = 1;
        public const int RedOhmValue = 2;
        public const int OrangeOhmValue = 3;
        public const int YellowOhmValue = 4;
        public const int GreenOhmValue = 5;
        public const int BlueOhmValue = 6;
        public const int VioletOhmValue = 7;
        public const int GrayOhmValue = 8;
        public const int WhiteOhmValue = 9;
    }
}