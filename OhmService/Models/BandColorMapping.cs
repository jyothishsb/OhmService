using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OhmService.Models
{
    public class BandColorMapping
    {
        public  Dictionary<string, int> significantValue;
        public  Dictionary<string, double> multiplierValue;
        public  Dictionary<string, double> toleranceValue;

        public BandColorMapping()
        {
            significantValue = new Dictionary<string, int>();
            multiplierValue = new Dictionary<string, double>();
            toleranceValue = new Dictionary<string, double>();
            significantValue.Add( OhmConstants.Black, OhmConstants.BlackOhmValue);
            significantValue.Add( OhmConstants.Brown, OhmConstants.BrownOhmValue);
            significantValue.Add( OhmConstants.Red, OhmConstants.RedOhmValue);
            significantValue.Add( OhmConstants.Orange, OhmConstants.OrangeOhmValue);
            significantValue.Add( OhmConstants.Yellow, OhmConstants.YellowOhmValue);
            significantValue.Add( OhmConstants.Green, OhmConstants.GreenOhmValue);
            significantValue.Add( OhmConstants.Blue, OhmConstants.BlueOhmValue);
            significantValue.Add( OhmConstants.Violet, OhmConstants.VioletOhmValue);
            significantValue.Add( OhmConstants.Gray, OhmConstants.GrayOhmValue);
            significantValue.Add( OhmConstants.White, OhmConstants.WhiteOhmValue);

            multiplierValue.Add( OhmConstants.Pink, 0.001);
            multiplierValue.Add( OhmConstants.Silver, 0.01);
            multiplierValue.Add( OhmConstants.Gold, 0.1);
            multiplierValue.Add( OhmConstants.Black, 1);
            multiplierValue.Add( OhmConstants.Brown, 10);
            multiplierValue.Add( OhmConstants.Red, 100);
            multiplierValue.Add( OhmConstants.Orange, 1000);
            multiplierValue.Add( OhmConstants.Yellow, 10000);
            multiplierValue.Add( OhmConstants.Green, 100000);
            multiplierValue.Add( OhmConstants.Blue, 1000000);
            multiplierValue.Add( OhmConstants.Violet, 10000000);
            multiplierValue.Add( OhmConstants.Gray, 100000000);
            multiplierValue.Add( OhmConstants.White, 1000000000);

            toleranceValue.Add( OhmConstants.Silver, 0.1);
            toleranceValue.Add( OhmConstants.Gold, 0.05);
            toleranceValue.Add( OhmConstants.Brown, 0.01);
            toleranceValue.Add( OhmConstants.Red, 0.02);
            toleranceValue.Add( OhmConstants.Yellow, 0.05);
            toleranceValue.Add( OhmConstants.Green, 0.0005);
            toleranceValue.Add( OhmConstants.Blue, 0.0025);
            toleranceValue.Add( OhmConstants.Violet, 0.001);
            toleranceValue.Add( OhmConstants.Gray, 0.0005);
        }
    }
}