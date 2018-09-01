using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q400_Performance_Calculator.Computation
{

    internal class LandingComputation
    {
        public bool Failed { get; private set; }
        public LandingOutput Output { get; private set; }

        private readonly LandingSpeedValues Values;

        internal LandingComputation(LandingSpeedValues Values)
        {
            this.Values = Values;
            this.Output = Adjust(Compute());
        }

        private LandingOutput Compute()
        {
            LandingOutput Output = new LandingOutput();
            Tuple<int, int, int> VSpeeds = LandingSettings.VSPEED_LOOKUP(Values.Flaps, Values.Weight);
            int Vapp = VSpeeds.Item1;
            int Vref = VSpeeds.Item2;
            int Vga = VSpeeds.Item3;
            Output.VAPP = Vapp;
            Output.VREF = Vref;
            Output.VGA = Vga;
            return Output;
        }

        private LandingOutput Adjust(LandingOutput CurrOutput)
        {
            LandingOutput NewOutput = CurrOutput;
            if (Values.OAT < 0)
            {
                NewOutput.VAPP += 20;
                NewOutput.VREF += 20;
                NewOutput.VGA += 20;
            }
            return NewOutput;
        }
    }

    internal class TakeoffComputation
    {
        public bool Failed { get; private set; }
        public TakeOffOutput Output { get; private set; }

        private readonly TakeoffSpeedValues Values;

        internal TakeoffComputation(TakeoffSpeedValues Values)
        {
            this.Values = Values;
            this.Output = Adjust(Compute());
        }

        private TakeOffOutput Compute()
        {
            if (Values.BasicVals.Flaps == FlapsSetting.F35)
            {
                Failed = true;
                return new TakeOffOutput()
                {
                    VR = 0,
                    V2 = 0,
                    VFRI = 0,
                    VCLB = 0
                };
            }
            Tuple<int, int> VR2 = TakeoffSettings.VR2_Lookup(Values.BasicVals.Flaps, Values.BasicVals.Weight, Values.Elevation, Values.BasicVals.OAT);
            Tuple<int, int> VFRICLB = TakeoffSettings.VFRICLB_Lookup(Values.BasicVals.Flaps, Values.BasicVals.Weight);
            int VR = VR2.Item1;
            int V2 = VR2.Item2;
            int VFRI = VFRICLB.Item1;
            int VCLB = VFRICLB.Item2;
            return new TakeOffOutput()
            {
                V1 = VR,
                VR = VR,
                V2 = V2,
                VFRI = VFRI,
                VCLB = VCLB
            };
        }

        private TakeOffOutput Adjust(TakeOffOutput CurrOutput)
        {
            if (Values.BasicVals.Flaps == FlapsSetting.F35) { Failed = true; return new TakeOffOutput(); }
            TakeOffOutput NewOutput = CurrOutput;
            if (CurrOutput.VR > CurrOutput.V2) { NewOutput.V2 = CurrOutput.VR; }
            if (Values.AntiIce) { NewOutput.V2 += 20; }
            if (Values.Conditions == RunwayConditions.WET || Values.Conditions == RunwayConditions.ICE)
            {
                NewOutput.V1 -= 8;
                double HeadwindComponent = 0.0;
                double Angle = Values.RunwayHdg + 90 - Values.WindHdg;
                int Multiplier = Angle >= 0 ? -1 : 1;
                double SinAngle = Math.Sin(Math.Abs(Angle) * (Math.PI / 180.0));
                if (SinAngle == 0) { HeadwindComponent = 0.0; }
                else { HeadwindComponent = (this.Values.WindSpd * Multiplier) / SinAngle; }
                if (HeadwindComponent < 0) { NewOutput.V1 += (int)Math.Round(0.3 * Math.Round(HeadwindComponent)); }
                else { NewOutput.V1 += (int)Math.Round(0.1 * Math.Round(HeadwindComponent)); }
                if (Values.Conditions == RunwayConditions.ICE)
                {
                    NewOutput.VFRI += 20;
                    NewOutput.VCLB += 20;
                }
            }
            switch (Values.BasicVals.Flaps)
            {
                case FlapsSetting.F5:
                    if (NewOutput.VR < 108) { NewOutput.VR = 108; }
                    if (NewOutput.V1 < 97) { NewOutput.V1 = 97; }
                    break;
                case FlapsSetting.F10:
                    if (NewOutput.VR < 104) { NewOutput.VR = 104; }
                    if (NewOutput.V1 < 96) { NewOutput.V1 = 96; }
                    break;
                case FlapsSetting.F15:
                    if (NewOutput.VR < 100) { NewOutput.VR = 100; }
                    if (NewOutput.V1 < 96) { NewOutput.V1 = 96; }
                    break;
            }
            return NewOutput;
        }
    }

}
