using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q400_Performance_Calculator.Computation
{
    internal enum AltUnits
    {
        FEET,
        METERS,
    }

    internal enum PrimaryUnits
    {
        IMPERIAL,
        METRIC,
    }

    internal enum RunwayConditions
    {
        DRY,
        WET,
        ICE,
    }

    internal enum FlapsSetting
    {
        F0,
        F5,
        F10,
        F15,
        F35
    }

    internal struct TakeoffSpeedValues
    {
        public LandingSpeedValues BasicVals;

        public AltUnits AltitudeUnits;
        public RunwayConditions Conditions;
        public bool AntiIce;
        public int RunwayHdg;
        public int WindHdg;
        public int WindSpd;
        public int Elevation;

    }

    internal struct LandingSpeedValues
    {
        public PrimaryUnits Units;
        public FlapsSetting Flaps;
        public int OAT;
        public int Weight;
    }

    internal struct LandingOutput
    {
        public int VAPP;
        public int VREF;
        public int VGA;
    }

    internal struct TakeOffOutput
    {
        public int V1;
        public int VR;
        public int V2;
        public int VFRI;
        public int VCLB;
    }

    internal static class LandingSettings
    {
        private static readonly Dictionary<Tuple<int, int>, Tuple<int, int, int>> LANDING_VSPEEDS;

        public static readonly int[] WGT_NODES = new int[] { 18000, 20000, 22000, 24000, 26000, 28000, 29000 };

        internal static Tuple<int, int, int> VSPEED_LOOKUP(FlapsSetting Flaps, int Weight)
        {
            int FlapsLook = 5;
            switch(Flaps)
            {
                case FlapsSetting.F5:
                    FlapsLook = 5;
                    break;
                case FlapsSetting.F10:
                    FlapsLook = 10;
                    break;
                case FlapsSetting.F15:
                    FlapsLook = 15;
                    break;
                case FlapsSetting.F35:
                    FlapsLook = 35;
                    break;
            }

            Tuple<int, int> LookupTuple = new Tuple<int, int>(FlapsLook, Util.ClosestTo(WGT_NODES, Weight));
            LANDING_VSPEEDS.TryGetValue(LookupTuple, out Tuple<int, int, int> OutputTuple);
            return OutputTuple;
        }

        static LandingSettings()
        {
            LANDING_VSPEEDS = new Dictionary<Tuple<int, int>, Tuple<int, int, int>>();

            LANDING_VSPEEDS.Add(new Tuple<int, int>( 5, 18000), new Tuple<int, int, int>(115, 115, 109));
            LANDING_VSPEEDS.Add(new Tuple<int, int>( 5, 20000), new Tuple<int, int, int>(120, 120, 110));
            LANDING_VSPEEDS.Add(new Tuple<int, int>( 5, 22000), new Tuple<int, int, int>(126, 126, 115));
            LANDING_VSPEEDS.Add(new Tuple<int, int>( 5, 24000), new Tuple<int, int, int>(131, 131, 120));
            LANDING_VSPEEDS.Add(new Tuple<int, int>( 5, 26000), new Tuple<int, int, int>(137, 137, 125));
            LANDING_VSPEEDS.Add(new Tuple<int, int>( 5, 28000), new Tuple<int, int, int>(142, 142, 130));
            LANDING_VSPEEDS.Add(new Tuple<int, int>( 5, 29000), new Tuple<int, int, int>(146, 146, 134));

            LANDING_VSPEEDS.Add(new Tuple<int, int>(10, 18000), new Tuple<int, int, int>(109, 108, 108));
            LANDING_VSPEEDS.Add(new Tuple<int, int>(10, 20000), new Tuple<int, int, int>(112, 112, 108));
            LANDING_VSPEEDS.Add(new Tuple<int, int>(10, 22000), new Tuple<int, int, int>(117, 117, 108));
            LANDING_VSPEEDS.Add(new Tuple<int, int>(10, 24000), new Tuple<int, int, int>(122, 122, 112));
            LANDING_VSPEEDS.Add(new Tuple<int, int>(10, 26000), new Tuple<int, int, int>(127, 127, 117));
            LANDING_VSPEEDS.Add(new Tuple<int, int>(10, 28000), new Tuple<int, int, int>(132, 132, 122));
            LANDING_VSPEEDS.Add(new Tuple<int, int>(10, 29000), new Tuple<int, int, int>(136, 136, 125));

            LANDING_VSPEEDS.Add(new Tuple<int, int>(15, 18000), new Tuple<int, int, int>(106, 105, 105));
            LANDING_VSPEEDS.Add(new Tuple<int, int>(15, 20000), new Tuple<int, int, int>(106, 117, 105));
            LANDING_VSPEEDS.Add(new Tuple<int, int>(15, 22000), new Tuple<int, int, int>(112, 112, 105));
            LANDING_VSPEEDS.Add(new Tuple<int, int>(15, 24000), new Tuple<int, int, int>(117, 117, 107));
            LANDING_VSPEEDS.Add(new Tuple<int, int>(15, 26000), new Tuple<int, int, int>(122, 121, 111));
            LANDING_VSPEEDS.Add(new Tuple<int, int>(15, 28000), new Tuple<int, int, int>(126, 126, 116));
            LANDING_VSPEEDS.Add(new Tuple<int, int>(15, 29000), new Tuple<int, int, int>(129, 129, 119));

            LANDING_VSPEEDS.Add(new Tuple<int, int>(35, 18000), new Tuple<int, int, int>(101, 101, 101));
            LANDING_VSPEEDS.Add(new Tuple<int, int>(35, 20000), new Tuple<int, int, int>(102, 102, 102));
            LANDING_VSPEEDS.Add(new Tuple<int, int>(35, 22000), new Tuple<int, int, int>(107, 107, 107));
            LANDING_VSPEEDS.Add(new Tuple<int, int>(35, 24000), new Tuple<int, int, int>(112, 112, 112));
            LANDING_VSPEEDS.Add(new Tuple<int, int>(35, 26000), new Tuple<int, int, int>(116, 116, 116));
            LANDING_VSPEEDS.Add(new Tuple<int, int>(35, 28000), new Tuple<int, int, int>(120, 120, 120));
            LANDING_VSPEEDS.Add(new Tuple<int, int>(35, 29000), new Tuple<int, int, int>(123, 123, 123));
        }
    }

    internal static class TakeoffSettings
    {
        private static readonly Dictionary<Tuple<int, int, bool>, Tuple<int, int>> FLAP5_VR2_SETTINGS;
        private static readonly Dictionary<Tuple<int, int, bool>, Tuple<int, int>> FLAP10_VR2_SETTINGS;
        private static readonly Dictionary<Tuple<int, int, bool>, Tuple<int, int>> FLAP15_VR2_SETTINGS;
        private static readonly Dictionary<Tuple<int, int>, Tuple<int, int>> VFRICLB_SETTINGS;

        public static readonly int[] ALT_NODES = new int[] { 0, 2000, 4000, 6000, 8000, 10000 };
        public static readonly int[] WGT_NODES = new int[] { 18000, 20000, 22000, 24000, 26000, 28000, 29000 };

        public static Tuple<int, int> VR2_Lookup(FlapsSetting Flaps, int Weight, int Alt, int OAT)
        {
            Dictionary<Tuple<int, int, bool>, Tuple<int, int>> Settings = FLAP5_VR2_SETTINGS;
            switch(Flaps)
            {
                case FlapsSetting.F5:
                    Settings = FLAP5_VR2_SETTINGS;
                    break;
                case FlapsSetting.F10:
                    Settings = FLAP10_VR2_SETTINGS;
                    break;
                case FlapsSetting.F15:
                    Settings = FLAP15_VR2_SETTINGS;
                    break;
            }
            int ClosestWeight = Util.ClosestTo(WGT_NODES, Weight);
            int ClosestAlt = Util.ClosestTo(ALT_NODES, Alt);
            Tuple<int, int, bool> LookupTuple = new Tuple<int, int, bool>(ClosestWeight, ClosestAlt, OAT >= 20);
            Settings.TryGetValue(LookupTuple, out Tuple<int, int> VR2Settings);
            return VR2Settings;
        }

        public static Tuple<int, int> VFRICLB_Lookup(FlapsSetting Flaps, int Weight)
        {
            int ClosestWeight = Util.ClosestTo(WGT_NODES, Weight);
            int Flp = 5;
            switch (Flaps)
            {
                case FlapsSetting.F5:
                    Flp = 5;
                    break;
                case FlapsSetting.F10:
                    Flp = 10;
                    break;
                case FlapsSetting.F15:
                    Flp = 15;
                    break;
            }
            Tuple<int, int> LookupTuple = new Tuple<int, int>(ClosestWeight, Flp);
            VFRICLB_SETTINGS.TryGetValue(LookupTuple, out Tuple<int, int> VFRICLB_ADJ);
            return VFRICLB_ADJ;
        }

        static TakeoffSettings()
        {
            FLAP5_VR2_SETTINGS = new Dictionary<Tuple<int, int, bool>, Tuple<int, int>>();
            FLAP10_VR2_SETTINGS = new Dictionary<Tuple<int, int, bool>, Tuple<int, int>>();
            FLAP15_VR2_SETTINGS = new Dictionary<Tuple<int, int, bool>, Tuple<int, int>>();
            VFRICLB_SETTINGS = new Dictionary<Tuple<int, int>, Tuple<int, int>>();

            #region F5 Settings
            // Add Flaps 5 settings
            Add(FLAP5_VR2_SETTINGS, 18000, 0,    true,  102, 116);
            Add(FLAP5_VR2_SETTINGS, 18000, 2000, true,  102, 115);
            Add(FLAP5_VR2_SETTINGS, 18000, 4000, true,  102, 114);
            Add(FLAP5_VR2_SETTINGS, 18000, 6000, true,  102, 113);
            Add(FLAP5_VR2_SETTINGS, 18000, 8000, true,  102, 112);
            Add(FLAP5_VR2_SETTINGS, 18000, 10000,true,  103, 111);
            Add(FLAP5_VR2_SETTINGS, 20000, 0,    true,  105, 115);
            Add(FLAP5_VR2_SETTINGS, 20000, 2000, true,  106, 114);
            Add(FLAP5_VR2_SETTINGS, 20000, 4000, true,  107, 113);
            Add(FLAP5_VR2_SETTINGS, 20000, 6000, true,  107, 112);
            Add(FLAP5_VR2_SETTINGS, 20000, 8000, true,  108, 112);
            Add(FLAP5_VR2_SETTINGS, 20000, 10000,true,  110, 111);
            Add(FLAP5_VR2_SETTINGS, 22000, 0,    true,  112, 117);
            Add(FLAP5_VR2_SETTINGS, 22000, 2000, true,  113, 117);
            Add(FLAP5_VR2_SETTINGS, 22000, 4000, true,  113, 117);
            Add(FLAP5_VR2_SETTINGS, 22000, 6000, true,  114, 117);
            Add(FLAP5_VR2_SETTINGS, 22000, 8000, true,  115, 117);
            Add(FLAP5_VR2_SETTINGS, 22000, 10000,true,  116, 117);
            Add(FLAP5_VR2_SETTINGS, 24000, 0,    true,  118, 122);
            Add(FLAP5_VR2_SETTINGS, 24000, 2000, true,  119, 122);
            Add(FLAP5_VR2_SETTINGS, 24000, 4000, true,  120, 122);
            Add(FLAP5_VR2_SETTINGS, 24000, 6000, true,  120, 122);
            Add(FLAP5_VR2_SETTINGS, 24000, 8000, true,  121, 122);
            Add(FLAP5_VR2_SETTINGS, 24000, 10000,true,  122, 122);
            Add(FLAP5_VR2_SETTINGS, 26000, 0,    true,  124, 127);
            Add(FLAP5_VR2_SETTINGS, 26000, 2000, true,  125, 127);
            Add(FLAP5_VR2_SETTINGS, 26000, 4000, true,  126, 127);
            Add(FLAP5_VR2_SETTINGS, 26000, 6000, true,  126, 127);
            Add(FLAP5_VR2_SETTINGS, 26000, 8000, true,  127, 127);
            Add(FLAP5_VR2_SETTINGS, 26000, 10000,true,  128, 127);
            Add(FLAP5_VR2_SETTINGS, 28000, 0,    true,  130, 132);
            Add(FLAP5_VR2_SETTINGS, 28000, 2000, true,  131, 132);
            Add(FLAP5_VR2_SETTINGS, 28000, 4000, true,  131, 132);
            Add(FLAP5_VR2_SETTINGS, 28000, 6000, true,  132, 132);
            Add(FLAP5_VR2_SETTINGS, 28000, 8000, true,  133, 132);
            Add(FLAP5_VR2_SETTINGS, 28000, 10000,true,  134, 132);
            Add(FLAP5_VR2_SETTINGS, 29000, 0,    true,  133, 135);
            Add(FLAP5_VR2_SETTINGS, 29000, 2000, true,  134, 135);
            Add(FLAP5_VR2_SETTINGS, 29000, 4000, true,  135, 135);
            Add(FLAP5_VR2_SETTINGS, 29000, 6000, true,  136, 135);
            Add(FLAP5_VR2_SETTINGS, 29000, 8000, true,  137, 135);
            Add(FLAP5_VR2_SETTINGS, 29000, 10000,true,  138, 135);
            Add(FLAP5_VR2_SETTINGS, 18000, 0,    false, 102, 114);
            Add(FLAP5_VR2_SETTINGS, 18000, 2000, false, 102, 113);
            Add(FLAP5_VR2_SETTINGS, 18000, 4000, false, 102, 112);
            Add(FLAP5_VR2_SETTINGS, 18000, 6000, false, 103, 111);
            Add(FLAP5_VR2_SETTINGS, 18000, 8000, false, 103, 110);
            Add(FLAP5_VR2_SETTINGS, 18000, 10000,false, 103, 109);
            Add(FLAP5_VR2_SETTINGS, 20000, 0,    false, 105, 113);
            Add(FLAP5_VR2_SETTINGS, 20000, 2000, false, 107, 112);
            Add(FLAP5_VR2_SETTINGS, 20000, 4000, false, 108, 112);
            Add(FLAP5_VR2_SETTINGS, 20000, 6000, false, 108, 111);
            Add(FLAP5_VR2_SETTINGS, 20000, 8000, false, 110, 111);
            Add(FLAP5_VR2_SETTINGS, 20000, 10000,false, 110, 111);
            Add(FLAP5_VR2_SETTINGS, 22000, 0,    false, 112, 117);
            Add(FLAP5_VR2_SETTINGS, 22000, 2000, false, 113, 117);
            Add(FLAP5_VR2_SETTINGS, 22000, 4000, false, 114, 117);
            Add(FLAP5_VR2_SETTINGS, 22000, 6000, false, 115, 117);
            Add(FLAP5_VR2_SETTINGS, 22000, 8000, false, 116, 117);
            Add(FLAP5_VR2_SETTINGS, 22000, 10000,false, 117, 117);
            Add(FLAP5_VR2_SETTINGS, 24000, 0,    false, 118, 122);
            Add(FLAP5_VR2_SETTINGS, 24000, 2000, false, 120, 122);
            Add(FLAP5_VR2_SETTINGS, 24000, 4000, false, 120, 122);
            Add(FLAP5_VR2_SETTINGS, 24000, 6000, false, 121, 122);
            Add(FLAP5_VR2_SETTINGS, 24000, 8000, false, 122, 122);
            Add(FLAP5_VR2_SETTINGS, 24000, 10000,false, 123, 122);
            Add(FLAP5_VR2_SETTINGS, 26000, 0,    false, 124, 127);
            Add(FLAP5_VR2_SETTINGS, 26000, 2000, false, 126, 127);
            Add(FLAP5_VR2_SETTINGS, 26000, 4000, false, 127, 127);
            Add(FLAP5_VR2_SETTINGS, 26000, 6000, false, 128, 127);
            Add(FLAP5_VR2_SETTINGS, 26000, 8000, false, 129, 127);
            Add(FLAP5_VR2_SETTINGS, 26000, 10000,false, 130, 127);
            Add(FLAP5_VR2_SETTINGS, 28000, 0,    false, 131, 132);
            Add(FLAP5_VR2_SETTINGS, 28000, 2000, false, 132, 132);
            Add(FLAP5_VR2_SETTINGS, 28000, 4000, false, 133, 132);
            Add(FLAP5_VR2_SETTINGS, 28000, 6000, false, 134, 132);
            Add(FLAP5_VR2_SETTINGS, 28000, 8000, false, 135, 132);
            Add(FLAP5_VR2_SETTINGS, 28000, 10000,false, 136, 132);
            Add(FLAP5_VR2_SETTINGS, 29000, 0,    false, 135, 135);
            Add(FLAP5_VR2_SETTINGS, 29000, 2000, false, 136, 135);
            Add(FLAP5_VR2_SETTINGS, 29000, 4000, false, 137, 135);
            Add(FLAP5_VR2_SETTINGS, 29000, 6000, false, 138, 135);
            Add(FLAP5_VR2_SETTINGS, 29000, 8000, false, 138, 135);
            Add(FLAP5_VR2_SETTINGS, 29000, 10000,false, 140, 135);
            #endregion

            #region F10 Settings
            // Add Flaps 5 settings
            Add(FLAP10_VR2_SETTINGS, 18000, 0,    true,  100, 111);
            Add(FLAP10_VR2_SETTINGS, 18000, 2000, true,  100, 110);
            Add(FLAP10_VR2_SETTINGS, 18000, 4000, true,  100, 110);
            Add(FLAP10_VR2_SETTINGS, 18000, 6000, true,  100, 109);
            Add(FLAP10_VR2_SETTINGS, 18000, 8000, true,  100, 108);
            Add(FLAP10_VR2_SETTINGS, 18000, 10000,true,  100, 107);
            Add(FLAP10_VR2_SETTINGS, 20000, 0,    true,  100, 110);
            Add(FLAP10_VR2_SETTINGS, 20000, 2000, true,  100, 109);
            Add(FLAP10_VR2_SETTINGS, 20000, 4000, true,  100, 109);
            Add(FLAP10_VR2_SETTINGS, 20000, 6000, true,  100, 108);
            Add(FLAP10_VR2_SETTINGS, 20000, 8000, true,  100, 107);
            Add(FLAP10_VR2_SETTINGS, 20000, 10000,true,  101, 106);
            Add(FLAP10_VR2_SETTINGS, 22000, 0,    true,  103, 109);
            Add(FLAP10_VR2_SETTINGS, 22000, 2000, true,  105, 109);
            Add(FLAP10_VR2_SETTINGS, 22000, 4000, true,  105, 108);
            Add(FLAP10_VR2_SETTINGS, 22000, 6000, true,  105, 108);
            Add(FLAP10_VR2_SETTINGS, 22000, 8000, true,  106, 108);
            Add(FLAP10_VR2_SETTINGS, 22000, 10000,true,  108, 108);
            Add(FLAP10_VR2_SETTINGS, 24000, 0,    true,  109, 113);
            Add(FLAP10_VR2_SETTINGS, 24000, 2000, true,  110, 113);
            Add(FLAP10_VR2_SETTINGS, 24000, 4000, true,  111, 113);
            Add(FLAP10_VR2_SETTINGS, 24000, 6000, true,  111, 113);
            Add(FLAP10_VR2_SETTINGS, 24000, 8000, true,  112, 113);
            Add(FLAP10_VR2_SETTINGS, 24000, 10000,true,  113, 113);
            Add(FLAP10_VR2_SETTINGS, 26000, 0,    true,  115, 118);
            Add(FLAP10_VR2_SETTINGS, 26000, 2000, true,  116, 118);
            Add(FLAP10_VR2_SETTINGS, 26000, 4000, true,  116, 118);
            Add(FLAP10_VR2_SETTINGS, 26000, 6000, true,  117, 118);
            Add(FLAP10_VR2_SETTINGS, 26000, 8000, true,  118, 118);
            Add(FLAP10_VR2_SETTINGS, 26000, 10000,true,  119, 118);
            Add(FLAP10_VR2_SETTINGS, 28000, 0,    true,  120, 122);
            Add(FLAP10_VR2_SETTINGS, 28000, 2000, true,  121, 122);
            Add(FLAP10_VR2_SETTINGS, 28000, 4000, true,  122, 122);
            Add(FLAP10_VR2_SETTINGS, 28000, 6000, true,  122, 122);
            Add(FLAP10_VR2_SETTINGS, 28000, 8000, true,  123, 122);
            Add(FLAP10_VR2_SETTINGS, 28000, 10000,true,  124, 124);
            Add(FLAP10_VR2_SETTINGS, 29000, 0,    true,  124, 125);
            Add(FLAP10_VR2_SETTINGS, 29000, 2000, true,  125, 125);
            Add(FLAP10_VR2_SETTINGS, 29000, 4000, true,  125, 125);
            Add(FLAP10_VR2_SETTINGS, 29000, 6000, true,  126, 125);
            Add(FLAP10_VR2_SETTINGS, 29000, 8000, true,  127, 125);
            Add(FLAP10_VR2_SETTINGS, 29000, 10000,true,  128, 125);
            Add(FLAP10_VR2_SETTINGS, 18000, 0,    false, 100, 109);
            Add(FLAP10_VR2_SETTINGS, 18000, 2000, false, 100, 109);
            Add(FLAP10_VR2_SETTINGS, 18000, 4000, false, 100, 109);
            Add(FLAP10_VR2_SETTINGS, 18000, 6000, false, 100, 107);
            Add(FLAP10_VR2_SETTINGS, 18000, 8000, false, 100, 106);
            Add(FLAP10_VR2_SETTINGS, 18000, 10000,false, 100, 105);
            Add(FLAP10_VR2_SETTINGS, 20000, 0,    false, 100, 108);
            Add(FLAP10_VR2_SETTINGS, 20000, 2000, false, 100, 108);
            Add(FLAP10_VR2_SETTINGS, 20000, 4000, false, 100, 107);
            Add(FLAP10_VR2_SETTINGS, 20000, 6000, false, 100, 106);
            Add(FLAP10_VR2_SETTINGS, 20000, 8000, false, 100, 105);
            Add(FLAP10_VR2_SETTINGS, 20000, 10000,false, 100, 105);
            Add(FLAP10_VR2_SETTINGS, 22000, 0,    false, 104, 108);
            Add(FLAP10_VR2_SETTINGS, 22000, 2000, false, 106, 108);
            Add(FLAP10_VR2_SETTINGS, 22000, 4000, false, 106, 108);
            Add(FLAP10_VR2_SETTINGS, 22000, 6000, false, 106, 108);
            Add(FLAP10_VR2_SETTINGS, 22000, 8000, false, 106, 108);
            Add(FLAP10_VR2_SETTINGS, 22000, 10000,false, 106, 108);
            Add(FLAP10_VR2_SETTINGS, 24000, 0,    false, 110, 113);
            Add(FLAP10_VR2_SETTINGS, 24000, 2000, false, 111, 113);
            Add(FLAP10_VR2_SETTINGS, 24000, 4000, false, 112, 113);
            Add(FLAP10_VR2_SETTINGS, 24000, 6000, false, 112, 113);
            Add(FLAP10_VR2_SETTINGS, 24000, 8000, false, 112, 113);
            Add(FLAP10_VR2_SETTINGS, 24000, 10000,false, 112, 113);
            Add(FLAP10_VR2_SETTINGS, 26000, 0,    false, 116, 118);
            Add(FLAP10_VR2_SETTINGS, 26000, 2000, false, 117, 118);
            Add(FLAP10_VR2_SETTINGS, 26000, 4000, false, 117, 118);
            Add(FLAP10_VR2_SETTINGS, 26000, 6000, false, 118, 118);
            Add(FLAP10_VR2_SETTINGS, 26000, 8000, false, 118, 118);
            Add(FLAP10_VR2_SETTINGS, 26000, 10000,false, 118, 118);
            Add(FLAP10_VR2_SETTINGS, 28000, 0,    false, 121, 122);
            Add(FLAP10_VR2_SETTINGS, 28000, 2000, false, 122, 122);
            Add(FLAP10_VR2_SETTINGS, 28000, 4000, false, 123, 122);
            Add(FLAP10_VR2_SETTINGS, 28000, 6000, false, 123, 122);
            Add(FLAP10_VR2_SETTINGS, 28000, 8000, false, 123, 122);
            Add(FLAP10_VR2_SETTINGS, 28000, 10000,false, 123, 122);
            Add(FLAP10_VR2_SETTINGS, 29000, 0,    false, 125, 125);
            Add(FLAP10_VR2_SETTINGS, 29000, 2000, false, 125, 125);
            Add(FLAP10_VR2_SETTINGS, 29000, 4000, false, 126, 125);
            Add(FLAP10_VR2_SETTINGS, 29000, 6000, false, 127, 125);
            Add(FLAP10_VR2_SETTINGS, 29000, 8000, false, 127, 125);
            Add(FLAP10_VR2_SETTINGS, 29000, 10000,false, 127, 125);
            #endregion

            #region F15 Settings
            Add(FLAP15_VR2_SETTINGS, 18000, 0,    true,  98,  106);
            Add(FLAP15_VR2_SETTINGS, 18000, 2000, true,  98,  106);
            Add(FLAP15_VR2_SETTINGS, 18000, 4000, true,  98,  105);
            Add(FLAP15_VR2_SETTINGS, 18000, 6000, true,  98,  104);
            Add(FLAP15_VR2_SETTINGS, 18000, 8000, true,  98,  103);
            Add(FLAP15_VR2_SETTINGS, 18000, 10000,true,  98,  102);
            Add(FLAP15_VR2_SETTINGS, 20000, 0,    true,  98,  105);
            Add(FLAP15_VR2_SETTINGS, 20000, 2000, true,  98,  105);
            Add(FLAP15_VR2_SETTINGS, 20000, 4000, true,  98,  104);
            Add(FLAP15_VR2_SETTINGS, 20000, 6000, true,  98,  103);
            Add(FLAP15_VR2_SETTINGS, 20000, 8000, true,  98,  102);
            Add(FLAP15_VR2_SETTINGS, 20000, 10000,true,  98,  104);
            Add(FLAP15_VR2_SETTINGS, 22000, 0,    true,  100, 104);
            Add(FLAP15_VR2_SETTINGS, 22000, 2000, true,  101, 104);
            Add(FLAP15_VR2_SETTINGS, 22000, 4000, true,  101, 104);
            Add(FLAP15_VR2_SETTINGS, 22000, 6000, true,  102, 104);
            Add(FLAP15_VR2_SETTINGS, 22000, 8000, true,  103, 104);
            Add(FLAP15_VR2_SETTINGS, 22000, 10000,true,  104, 104);
            Add(FLAP15_VR2_SETTINGS, 24000, 0,    true,  106, 109);
            Add(FLAP15_VR2_SETTINGS, 24000, 2000, true,  106, 109);
            Add(FLAP15_VR2_SETTINGS, 24000, 4000, true,  107, 109);
            Add(FLAP15_VR2_SETTINGS, 24000, 6000, true,  108, 109);
            Add(FLAP15_VR2_SETTINGS, 24000, 8000, true,  108, 109);
            Add(FLAP15_VR2_SETTINGS, 24000, 10000,true,  109, 109);
            Add(FLAP15_VR2_SETTINGS, 26000, 0,    true,  111, 113);
            Add(FLAP15_VR2_SETTINGS, 26000, 2000, true,  112, 113);
            Add(FLAP15_VR2_SETTINGS, 26000, 4000, true,  112, 113);
            Add(FLAP15_VR2_SETTINGS, 26000, 6000, true,  113, 113);
            Add(FLAP15_VR2_SETTINGS, 26000, 8000, true,  114, 113);
            Add(FLAP15_VR2_SETTINGS, 26000, 10000,true,  114, 113);
            Add(FLAP15_VR2_SETTINGS, 28000, 0,    true,  116, 118);
            Add(FLAP15_VR2_SETTINGS, 28000, 2000, true,  117, 118);
            Add(FLAP15_VR2_SETTINGS, 28000, 4000, true,  117, 118);
            Add(FLAP15_VR2_SETTINGS, 28000, 6000, true,  118, 118);
            Add(FLAP15_VR2_SETTINGS, 28000, 8000, true,  118, 118);
            Add(FLAP15_VR2_SETTINGS, 28000, 10000,true,  119, 118);
            Add(FLAP15_VR2_SETTINGS, 29000, 0,    true,  119, 120);
            Add(FLAP15_VR2_SETTINGS, 29000, 2000, true,  120, 120);
            Add(FLAP15_VR2_SETTINGS, 29000, 4000, true,  120, 120);
            Add(FLAP15_VR2_SETTINGS, 29000, 6000, true,  121, 120);
            Add(FLAP15_VR2_SETTINGS, 29000, 8000, true,  122, 120);
            Add(FLAP15_VR2_SETTINGS, 29000, 10000,true,  122, 120);
            Add(FLAP15_VR2_SETTINGS, 18000, 0,    false, 98,  105);
            Add(FLAP15_VR2_SETTINGS, 18000, 2000, false, 98,  104);
            Add(FLAP15_VR2_SETTINGS, 18000, 4000, false, 98,  103);
            Add(FLAP15_VR2_SETTINGS, 18000, 6000, false, 98,  102);
            Add(FLAP15_VR2_SETTINGS, 18000, 8000, false, 98,  102);
            Add(FLAP15_VR2_SETTINGS, 18000, 10000,false, 98,  102);
            Add(FLAP15_VR2_SETTINGS, 20000, 0,    false, 98,  103);
            Add(FLAP15_VR2_SETTINGS, 20000, 2000, false, 98,  103);
            Add(FLAP15_VR2_SETTINGS, 20000, 4000, false, 98,  102);
            Add(FLAP15_VR2_SETTINGS, 20000, 6000, false, 98,  102);
            Add(FLAP15_VR2_SETTINGS, 20000, 8000, false, 99,  102);
            Add(FLAP15_VR2_SETTINGS, 20000, 10000,false, 99,  102);
            Add(FLAP15_VR2_SETTINGS, 22000, 0,    false, 101, 104);
            Add(FLAP15_VR2_SETTINGS, 22000, 2000, false, 102, 104);
            Add(FLAP15_VR2_SETTINGS, 22000, 4000, false, 103, 104);
            Add(FLAP15_VR2_SETTINGS, 22000, 6000, false, 104, 104);
            Add(FLAP15_VR2_SETTINGS, 22000, 8000, false, 104, 104);
            Add(FLAP15_VR2_SETTINGS, 22000, 10000,false, 104, 104);
            Add(FLAP15_VR2_SETTINGS, 24000, 0,    false, 107, 109);
            Add(FLAP15_VR2_SETTINGS, 24000, 2000, false, 108, 109);
            Add(FLAP15_VR2_SETTINGS, 24000, 4000, false, 108, 109);
            Add(FLAP15_VR2_SETTINGS, 24000, 6000, false, 109, 109);
            Add(FLAP15_VR2_SETTINGS, 24000, 8000, false, 110, 109);
            Add(FLAP15_VR2_SETTINGS, 24000, 10000,false, 110, 109);
            Add(FLAP15_VR2_SETTINGS, 26000, 0,    false, 112, 113);
            Add(FLAP15_VR2_SETTINGS, 26000, 2000, false, 113, 113);
            Add(FLAP15_VR2_SETTINGS, 26000, 4000, false, 114, 113);
            Add(FLAP15_VR2_SETTINGS, 26000, 6000, false, 114, 113);
            Add(FLAP15_VR2_SETTINGS, 26000, 8000, false, 115, 113);
            Add(FLAP15_VR2_SETTINGS, 26000, 10000,false, 115, 113);
            Add(FLAP15_VR2_SETTINGS, 28000, 0,    false, 117, 118);
            Add(FLAP15_VR2_SETTINGS, 28000, 2000, false, 118, 118);
            Add(FLAP15_VR2_SETTINGS, 28000, 4000, false, 119, 118);
            Add(FLAP15_VR2_SETTINGS, 28000, 6000, false, 119, 118);
            Add(FLAP15_VR2_SETTINGS, 28000, 8000, false, 120, 118);
            Add(FLAP15_VR2_SETTINGS, 28000, 10000,false, 120, 118);
            Add(FLAP15_VR2_SETTINGS, 29000, 0,    false, 120, 120);
            Add(FLAP15_VR2_SETTINGS, 29000, 2000, false, 121, 120);
            Add(FLAP15_VR2_SETTINGS, 29000, 4000, false, 121, 120);
            Add(FLAP15_VR2_SETTINGS, 29000, 6000, false, 122, 120);
            Add(FLAP15_VR2_SETTINGS, 29000, 8000, false, 123, 120);
            Add(FLAP15_VR2_SETTINGS, 29000, 10000,false, 123, 120);
            #endregion

            #region VFRICLB_SETTINGS
            VFRICLB_SETTINGS.Add(new Tuple<int, int>(18000, 5),  new Tuple<int, int>(116, 130));
            VFRICLB_SETTINGS.Add(new Tuple<int, int>(18000, 10), new Tuple<int, int>(110, 130));
            VFRICLB_SETTINGS.Add(new Tuple<int, int>(18000, 15), new Tuple<int, int>(107, 130));

            VFRICLB_SETTINGS.Add(new Tuple<int, int>(20000, 5),  new Tuple<int, int>(120, 131));
            VFRICLB_SETTINGS.Add(new Tuple<int, int>(20000, 10), new Tuple<int, int>(112, 131));
            VFRICLB_SETTINGS.Add(new Tuple<int, int>(20000, 15), new Tuple<int, int>(109, 131));

            VFRICLB_SETTINGS.Add(new Tuple<int, int>(22000, 5),  new Tuple<int, int>(126, 137));
            VFRICLB_SETTINGS.Add(new Tuple<int, int>(22000, 10), new Tuple<int, int>(118, 137));
            VFRICLB_SETTINGS.Add(new Tuple<int, int>(22000, 15), new Tuple<int, int>(115, 137));

            VFRICLB_SETTINGS.Add(new Tuple<int, int>(24000, 5),  new Tuple<int, int>(132, 143));
            VFRICLB_SETTINGS.Add(new Tuple<int, int>(24000, 10), new Tuple<int, int>(123, 143));
            VFRICLB_SETTINGS.Add(new Tuple<int, int>(24000, 15), new Tuple<int, int>(120, 143));

            VFRICLB_SETTINGS.Add(new Tuple<int, int>(26000, 5),  new Tuple<int, int>(137, 148));
            VFRICLB_SETTINGS.Add(new Tuple<int, int>(26000, 10), new Tuple<int, int>(128, 148));
            VFRICLB_SETTINGS.Add(new Tuple<int, int>(26000, 15), new Tuple<int, int>(125, 148));

            VFRICLB_SETTINGS.Add(new Tuple<int, int>(28000, 5),  new Tuple<int, int>(142, 154));
            VFRICLB_SETTINGS.Add(new Tuple<int, int>(28000, 10), new Tuple<int, int>(134, 154));
            VFRICLB_SETTINGS.Add(new Tuple<int, int>(28000, 15), new Tuple<int, int>(130, 154));

            VFRICLB_SETTINGS.Add(new Tuple<int, int>(29000, 5),  new Tuple<int, int>(146, 158));
            VFRICLB_SETTINGS.Add(new Tuple<int, int>(29000, 10), new Tuple<int, int>(137, 158));
            VFRICLB_SETTINGS.Add(new Tuple<int, int>(29000, 15), new Tuple<int, int>(133, 158));
            #endregion
        }

        private static void Add(Dictionary<Tuple<int, int, bool>, Tuple<int, int>> Dict, int Weight, int Alt, bool Cold, int VR, int V2)
        {
            Dict.Add(new Tuple<int, int, bool>(Weight, Alt, Cold), new Tuple<int, int>(VR, V2));
        }
    }

    internal static class Util
    {
        public static int ClosestTo(this IEnumerable<int> collection, int target)
        {
            var closest = int.MaxValue;
            var minDifference = int.MaxValue;
            foreach (var element in collection)
            {
                var difference = Math.Abs((long)element - target);
                if (minDifference > difference)
                {
                    minDifference = (int)difference;
                    closest = element;
                }
            }

            return closest;
        }
    }
}
