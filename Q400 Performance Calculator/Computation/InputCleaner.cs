using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q400_Performance_Calculator.Computation
{
    internal static class InputCleaner
    {
        internal static bool CleanedLandingSpeeds(LandingSpeedValues UncleanValues, out LandingSpeedValues CleanValues)
        {
            CleanValues = UncleanValues;
            if (UncleanValues.Units == PrimaryUnits.IMPERIAL)
            {
                CleanValues.Units = PrimaryUnits.METRIC;
                CleanValues.Weight = (int)Math.Round(PoundsToKilograms(UncleanValues.Weight));
            }
            return true;
        }

        internal static bool CleanedTakeoffSpeeds(TakeoffSpeedValues UncleanValues, out TakeoffSpeedValues CleanValues)
        {
            CleanValues = UncleanValues;
            if (UncleanValues.AltitudeUnits == AltUnits.METERS)
            {
                CleanValues.AltitudeUnits = AltUnits.FEET;
                CleanValues.Elevation = (int)Math.Round(MetersToFeet(UncleanValues.Elevation));
            }
            return true;
        }

        internal static double KilogramsToPounds(double Kilograms) { return Kilograms * (1.0 / 0.45359237); }
        internal static double PoundsToKilograms(double Pounds) { return Pounds * 0.45359237; }
        internal static double FeetToMeters(double Feet) { return Feet * 0.304800609601; }
        internal static double MetersToFeet(double Meters) { return Meters * (1.0 / 0.304800609601); }
    }
}
