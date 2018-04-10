using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OhmService.Models
{
    public class OhmResponse
    {
        private int resistance;
        private bool success;
        private string error;

        public int Resistance
        {
            get
            {
                return resistance;
            }

            set
            {
                resistance = value;
            }
        }

        public bool Success
        {
            get
            {
                return success;
            }

            set
            {
                success = value;
            }
        }

        public string Error
        {
            get
            {
                return error;
            }

            set
            {
                error = value;
            }
        }
    }
}