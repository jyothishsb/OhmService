using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OhmService.Models
{
    public class OhmValueCalculator
    {
        public OhmResponse getOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor)
        {
            OhmResponse response = new OhmResponse();
            int resistance = 0;
            bool success =false;
            string error = "";
            try
            {
                resistance = CalculateOhmValue(bandAColor, bandBColor, bandCColor, bandDColor);
                if (resistance < 0)
                {
                    success = false;
                    error = "Error in calculating the resistance";
                }
                else
                {
                    success = true;
                    error = null;

                }
            }
            catch (Exception e)
            {
                error = e.Message;
                success = false;
                resistance = -1;
            }
            finally
            {
                response.Resistance = resistance;
                response.Success = success;
                response.Error = error;
            }
            return response;
        }
            


        public int CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor)
        {
            
            int ohmValue = 0;
            BandColorMapping bandMapping = new BandColorMapping();
            if (!string.IsNullOrEmpty(bandAColor) && bandMapping.significantValue.ContainsKey(bandAColor.ToLower()))
            {
                ohmValue = ohmValue + 10 * bandMapping.significantValue[bandAColor.ToLower()];
            }
            else
            {
                throw (new ArgumentException(String.Format("{0} is not valid band color", bandAColor),"bandAColor"));
            }
            if (!string.IsNullOrEmpty(bandBColor) && bandMapping.significantValue.ContainsKey(bandBColor.ToLower()))
            {
                ohmValue = ohmValue + bandMapping.significantValue[bandBColor.ToLower()];
            }
            else
            {
                throw (new ArgumentException(String.Format("{0} is not valid band color", bandBColor), "bandBColor"));
            }
            if (!string.IsNullOrEmpty(bandCColor) && bandMapping.multiplierValue.ContainsKey(bandCColor.ToLower()) )
            {
                ohmValue = Convert.ToInt32(ohmValue * bandMapping.multiplierValue[bandCColor.ToLower()]);
            }
            else
            {
                throw (new ArgumentException(String.Format("{0} is not valid band color", bandCColor), "bandCColor"));
            }
            if (!string.IsNullOrEmpty(bandDColor) && bandMapping.toleranceValue.ContainsKey(bandDColor.ToLower()))
            {
                //considering the higher limit for tolerance.
                ohmValue = Convert.ToInt32(ohmValue * (1 + bandMapping.toleranceValue[bandDColor.ToLower()]));
            }
            else
            {
                ohmValue = Convert.ToInt32(ohmValue * (1.20d));
            }

            return ohmValue;
        }
    }
}