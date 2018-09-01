using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Q400_Performance_Calculator.Computation;

namespace Q400_Performance_Calculator
{
    public partial class MainWindow : Form
    {
        private AltUnits CurrentAltUnits;
        private PrimaryUnits CurrentUnits;

        public MainWindow()
        {
            InitializeComponent();
            CurrentAltUnits = AltUnits.FEET;
            CurrentUnits = PrimaryUnits.METRIC;
            this.AltUnitsChoice.SelectedIndex = 0;
            this.WeightUnitsChoice.SelectedIndex = 0;
            this.RwyCondSel.SelectedIndex = 0;
            this.FlapsSettingSel.SelectedIndex = 0;
        }

        private void WeightUnitsChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetFailure();
            ComboBox Selector = (ComboBox)sender;
            PrimaryUnits NewUnits = DecideUnits((string)Selector.SelectedItem);
            try
            {
                if (NewUnits == CurrentUnits) { return; }
                if (!WeightInput.Text.Equals(string.Empty))
                {
                    double CurrWeight = double.Parse(WeightInput.Text);
                    if (CurrentUnits == PrimaryUnits.METRIC)
                    {
                        WeightInput.Text = Math.Round(InputCleaner.KilogramsToPounds(CurrWeight)).ToString();
                    }
                    else
                    {
                        WeightInput.Text = Math.Round(InputCleaner.PoundsToKilograms(CurrWeight)).ToString();
                    }
                }
            } catch { FailedUnitsConversion(); }
            CurrentUnits = NewUnits;
        }

        private void AltUnitsChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetFailure();
            ComboBox Selector = (ComboBox)sender;
            AltUnits NewUnits = DecideAltUnits((string)Selector.SelectedItem);
            try
            {
                if (CurrentAltUnits == NewUnits) { return; }
                if (!RwyElevationInput.Text.Equals(string.Empty))
                {
                    double CurrElev = double.Parse(RwyElevationInput.Text);
                    if (CurrentAltUnits == AltUnits.FEET)
                    {
                        RwyElevationInput.Text = Math.Round(InputCleaner.FeetToMeters(CurrElev)).ToString();
                    }
                    else
                    {
                        RwyElevationInput.Text = Math.Round(InputCleaner.MetersToFeet(CurrElev)).ToString();
                    }
                }
            } catch { FailedUnitsConversion(); }
            CurrentAltUnits = NewUnits;
        }

        private void ComputeBtn_Click(object sender, EventArgs e)
        {
            ResetFailure();
            ResetOutput();
            PrimaryUnits Units = DecideUnits((string)WeightUnitsChoice.SelectedValue);
            AltUnits AltitudeUnits = DecideAltUnits((string)AltUnitsChoice.SelectedValue);
            FlapsSetting Flaps = DecideFlapsSetting((string)FlapsSettingSel.SelectedValue);
            LandingSpeedValues BaseValues = new LandingSpeedValues { Units = Units, Flaps = Flaps, };
            bool ConvertSuccess = double.TryParse(OATInput.Text, out double OAT);
            ConvertSuccess &= double.TryParse(WeightInput.Text, out double WeightDouble);
            if (!ConvertSuccess) { FailedToClean(); return; }
            BaseValues.OAT = (int)Math.Round(OAT);
            BaseValues.Weight = (int)Math.Round(WeightDouble);

            // Compute Landing
            bool CleanSuccess = InputCleaner.CleanedLandingSpeeds(BaseValues, out LandingSpeedValues CleanedLandingVals);
            if (!CleanSuccess) { FailedToClean(); return; }
            LandingComputation LandingComp = new LandingComputation(CleanedLandingVals);
            if (LandingComp.Failed) { FailedToCompute(); return; }

            // Display landing data
            DisplayLandingData(LandingComp.Output);

            TakeoffSpeedValues TakeOffValues = new TakeoffSpeedValues();
            // ALT Units, AntiIce, Runway HDG, Wind HFG, Wind Speed, Elevation, RWY Conditions
            TakeOffValues.BasicVals = CleanedLandingVals;
            bool ConvertValsSuccess = double.TryParse(RwyElevationInput.Text, out double RwyElev);
            ConvertValsSuccess &= double.TryParse(RwyHdgInput.Text, out double RwyHdg);
            double WindHdg = 0;
            double WindSpd = 0;
            try
            {
                string[] WindInfo = RwyWindInput.Text.Split('/');
                ConvertValsSuccess &= double.TryParse(WindInfo[0], out WindHdg);
                ConvertValsSuccess &= double.TryParse(WindInfo[1], out WindSpd);
            }
            catch { FailedToCleanTO(); return; }
            if (!ConvertValsSuccess) { FailedToCleanTO(); return; }
            TakeOffValues.Elevation = (int)Math.Round(RwyElev);
            TakeOffValues.RunwayHdg = (int)Math.Round(RwyHdg);
            TakeOffValues.WindHdg = (int)Math.Round(WindHdg);
            TakeOffValues.WindSpd = (int)Math.Round(WindSpd);
            TakeOffValues.Conditions = DecideRunwayConditions((string)RwyCondSel.SelectedItem);
            TakeOffValues.AntiIce = DeIceOnCheckbox.Checked;

            CleanSuccess = InputCleaner.CleanedTakeoffSpeeds(TakeOffValues, out TakeoffSpeedValues CleanedTakeOffVals);
            if (!CleanSuccess) { FailedTakeoffComputation(); return; }

            TakeoffComputation TakeoffComp = new TakeoffComputation(CleanedTakeOffVals);
            if (TakeoffComp.Failed) { FailedTakeoffComputation(); return; }

            // Display Takeoff Data
            DisplayTakeoffData(TakeoffComp.Output);
            Success();
        }

        private RunwayConditions DecideRunwayConditions(string Input)
        {
            if (Input == null) { return RunwayConditions.DRY; }
            switch (Input)
            {
                case "DRY":
                default:
                    return RunwayConditions.DRY;
                case "WET":
                    return RunwayConditions.WET;
                case "ICE":
                    return RunwayConditions.ICE;
            }
        }

        private PrimaryUnits DecideUnits(string Input)
        {
            if (Input != null && Input.Equals("IMPERIAL")) { return PrimaryUnits.IMPERIAL; }
            else { return PrimaryUnits.METRIC; }
        }

        private AltUnits DecideAltUnits(string Input)
        {
            if (Input != null && Input.Equals("METERS")) { return AltUnits.METERS; }
            else { return AltUnits.FEET; }
        }

        private FlapsSetting DecideFlapsSetting(string Input)
        {
            if (Input != null)
            {
                switch(Input)
                {
                    default:
                    case "5":
                        return FlapsSetting.F5;
                    case "10":
                        return FlapsSetting.F10;
                    case "15":
                        return FlapsSetting.F15;
                    case "35":
                        return FlapsSetting.F35;
                }
            } else { return FlapsSetting.F5; }
        }

        private void DisplayLandingData(LandingOutput Output)
        {
            ApproachSpeedOutput.Text = Output.VAPP.ToString();
            LandingReferenceSpeedOutput.Text = Output.VREF.ToString();
            GoAroundSpeedOutput.Text = Output.VGA.ToString();
        }

        private void DisplayTakeoffData(TakeOffOutput Output)
        {
            V1Output.Text = Output.V1.ToString();
            VRotOutput.Text = Output.VR.ToString();
            SafeClimbOutput.Text = Output.V2.ToString();
            FlapRetractOutput.Text = Output.VFRI.ToString();
            ClimbOutput.Text = Output.VCLB.ToString();
        }

        private void ResetFailure() { FailureOutput.ForeColor = Color.DarkRed; FailureOutput.Text = ""; }
        private void FailedToClean() { FailureOutput.Text = "Failed to process input"; }
        private void FailedToCleanTO() { FailureOutput.Text = "Failed to process input for takeoff performance"; }
        private void FailedToCompute() { FailureOutput.Text = "Failed to Compute Performance"; }
        private void FailedTakeoffComputation() { FailureOutput.Text = "Failed to Takeoff Performance"; }
        private void FailedUnitsConversion() { FailureOutput.Text = "Failed to Convert units"; }
        private void Success() { FailureOutput.ForeColor = Color.Green; FailureOutput.Text = "Completed!"; }
        private void CustomError(string Err) { FailureOutput.Text = Err; }

        private void ResetOutput()
        {
            ApproachSpeedOutput.Text = "";
            LandingReferenceSpeedOutput.Text = "";
            GoAroundSpeedOutput.Text = "";
            V1Output.Text = "";
            VRotOutput.Text = "";
            SafeClimbOutput.Text = "";
            FlapRetractOutput.Text = "";
            ClimbOutput.Text = "";
        }

    }
}
