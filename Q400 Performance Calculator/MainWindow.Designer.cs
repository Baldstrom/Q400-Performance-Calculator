namespace Q400_Performance_Calculator
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.PrimaryLayout = new System.Windows.Forms.TableLayoutPanel();
            this.IconCredit = new System.Windows.Forms.Label();
            this.MainUnitsLabel = new System.Windows.Forms.Label();
            this.WeightUnitsChoice = new System.Windows.Forms.ComboBox();
            this.AltUnitsChoice = new System.Windows.Forms.ComboBox();
            this.AltUnitsMenu = new System.Windows.Forms.Label();
            this.VRotOutputLabel = new System.Windows.Forms.Label();
            this.VRotOutput = new System.Windows.Forms.TextBox();
            this.SafeClimbOutputLabel = new System.Windows.Forms.Label();
            this.SafeClimbOutput = new System.Windows.Forms.TextBox();
            this.FlapRetractOutput = new System.Windows.Forms.TextBox();
            this.FlapRetractSpeedLabel = new System.Windows.Forms.Label();
            this.ClimbSpeedOutputLabel = new System.Windows.Forms.Label();
            this.ClimbOutput = new System.Windows.Forms.TextBox();
            this.ApproachSpeedOutputLabel = new System.Windows.Forms.Label();
            this.ApproachSpeedOutput = new System.Windows.Forms.TextBox();
            this.LandingRefLabel = new System.Windows.Forms.Label();
            this.LandingReferenceSpeedOutput = new System.Windows.Forms.TextBox();
            this.GoAroundSpeedOutput = new System.Windows.Forms.TextBox();
            this.GoAroundSpdLabel = new System.Windows.Forms.Label();
            this.DeIceOnCheckbox = new System.Windows.Forms.CheckBox();
            this.RunwayCondLabel = new System.Windows.Forms.Label();
            this.RwyCondSel = new System.Windows.Forms.ComboBox();
            this.RunwayHeadingLabel = new System.Windows.Forms.Label();
            this.RwyHdgInput = new System.Windows.Forms.TextBox();
            this.RwyWindInput = new System.Windows.Forms.TextBox();
            this.RwyWindLabel = new System.Windows.Forms.Label();
            this.RunwayElevationLabel = new System.Windows.Forms.Label();
            this.RwyElevationInput = new System.Windows.Forms.TextBox();
            this.ComputeBtn = new System.Windows.Forms.Button();
            this.UnitsClarification = new System.Windows.Forms.Label();
            this.FailureOutput = new System.Windows.Forms.Label();
            this.FlapsSettingLabel = new System.Windows.Forms.Label();
            this.FlapsSettingSel = new System.Windows.Forms.ComboBox();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.WeightInput = new System.Windows.Forms.TextBox();
            this.OATInput = new System.Windows.Forms.TextBox();
            this.CelciusLabel = new System.Windows.Forms.Label();
            this.OATLabel = new System.Windows.Forms.Label();
            this.V1Label = new System.Windows.Forms.Label();
            this.V1Output = new System.Windows.Forms.TextBox();
            this.PrimaryLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrimaryLayout
            // 
            this.PrimaryLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrimaryLayout.AutoSize = true;
            this.PrimaryLayout.ColumnCount = 16;
            this.PrimaryLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.PrimaryLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.PrimaryLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.PrimaryLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.PrimaryLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.PrimaryLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.PrimaryLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.PrimaryLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.PrimaryLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.PrimaryLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.PrimaryLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.PrimaryLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.PrimaryLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.PrimaryLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.PrimaryLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.PrimaryLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.PrimaryLayout.Controls.Add(this.IconCredit, 6, 15);
            this.PrimaryLayout.Controls.Add(this.MainUnitsLabel, 0, 1);
            this.PrimaryLayout.Controls.Add(this.WeightUnitsChoice, 3, 1);
            this.PrimaryLayout.Controls.Add(this.AltUnitsChoice, 3, 2);
            this.PrimaryLayout.Controls.Add(this.AltUnitsMenu, 0, 2);
            this.PrimaryLayout.Controls.Add(this.DeIceOnCheckbox, 0, 4);
            this.PrimaryLayout.Controls.Add(this.RunwayCondLabel, 3, 4);
            this.PrimaryLayout.Controls.Add(this.RwyCondSel, 6, 4);
            this.PrimaryLayout.Controls.Add(this.RunwayHeadingLabel, 0, 5);
            this.PrimaryLayout.Controls.Add(this.RwyHdgInput, 3, 5);
            this.PrimaryLayout.Controls.Add(this.RwyWindInput, 3, 6);
            this.PrimaryLayout.Controls.Add(this.RwyWindLabel, 0, 6);
            this.PrimaryLayout.Controls.Add(this.RunwayElevationLabel, 0, 7);
            this.PrimaryLayout.Controls.Add(this.RwyElevationInput, 3, 7);
            this.PrimaryLayout.Controls.Add(this.UnitsClarification, 6, 1);
            this.PrimaryLayout.Controls.Add(this.FlapsSettingLabel, 0, 8);
            this.PrimaryLayout.Controls.Add(this.FlapsSettingSel, 3, 8);
            this.PrimaryLayout.Controls.Add(this.WeightLabel, 0, 11);
            this.PrimaryLayout.Controls.Add(this.WeightInput, 4, 11);
            this.PrimaryLayout.Controls.Add(this.OATInput, 4, 10);
            this.PrimaryLayout.Controls.Add(this.CelciusLabel, 6, 10);
            this.PrimaryLayout.Controls.Add(this.OATLabel, 0, 10);
            this.PrimaryLayout.Controls.Add(this.FailureOutput, 10, 13);
            this.PrimaryLayout.Controls.Add(this.ComputeBtn, 10, 11);
            this.PrimaryLayout.Controls.Add(this.GoAroundSpeedOutput, 13, 9);
            this.PrimaryLayout.Controls.Add(this.GoAroundSpdLabel, 9, 9);
            this.PrimaryLayout.Controls.Add(this.LandingRefLabel, 9, 8);
            this.PrimaryLayout.Controls.Add(this.ApproachSpeedOutputLabel, 9, 7);
            this.PrimaryLayout.Controls.Add(this.LandingReferenceSpeedOutput, 13, 8);
            this.PrimaryLayout.Controls.Add(this.ApproachSpeedOutput, 13, 7);
            this.PrimaryLayout.Controls.Add(this.ClimbOutput, 13, 5);
            this.PrimaryLayout.Controls.Add(this.ClimbSpeedOutputLabel, 9, 5);
            this.PrimaryLayout.Controls.Add(this.FlapRetractSpeedLabel, 9, 4);
            this.PrimaryLayout.Controls.Add(this.SafeClimbOutputLabel, 10, 3);
            this.PrimaryLayout.Controls.Add(this.VRotOutputLabel, 10, 2);
            this.PrimaryLayout.Controls.Add(this.FlapRetractOutput, 13, 4);
            this.PrimaryLayout.Controls.Add(this.SafeClimbOutput, 13, 3);
            this.PrimaryLayout.Controls.Add(this.VRotOutput, 13, 2);
            this.PrimaryLayout.Controls.Add(this.V1Label, 10, 1);
            this.PrimaryLayout.Controls.Add(this.V1Output, 13, 1);
            this.PrimaryLayout.Location = new System.Drawing.Point(1, 3);
            this.PrimaryLayout.Name = "PrimaryLayout";
            this.PrimaryLayout.RowCount = 16;
            this.PrimaryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.PrimaryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.PrimaryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.PrimaryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.PrimaryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.PrimaryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.PrimaryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.PrimaryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.PrimaryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.PrimaryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.PrimaryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.PrimaryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.PrimaryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.PrimaryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.PrimaryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.PrimaryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.PrimaryLayout.Size = new System.Drawing.Size(582, 428);
            this.PrimaryLayout.TabIndex = 0;
            // 
            // IconCredit
            // 
            this.IconCredit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.IconCredit.AutoSize = true;
            this.PrimaryLayout.SetColumnSpan(this.IconCredit, 10);
            this.IconCredit.Location = new System.Drawing.Point(232, 405);
            this.IconCredit.Name = "IconCredit";
            this.IconCredit.Padding = new System.Windows.Forms.Padding(5);
            this.IconCredit.Size = new System.Drawing.Size(347, 23);
            this.IconCredit.TabIndex = 0;
            this.IconCredit.Text = "Icon made by Pixel Buddha on flaticon.com via Creative Commons 3.0";
            // 
            // MainUnitsLabel
            // 
            this.MainUnitsLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MainUnitsLabel.AutoSize = true;
            this.PrimaryLayout.SetColumnSpan(this.MainUnitsLabel, 3);
            this.MainUnitsLabel.Location = new System.Drawing.Point(74, 32);
            this.MainUnitsLabel.Name = "MainUnitsLabel";
            this.MainUnitsLabel.Size = new System.Drawing.Size(31, 13);
            this.MainUnitsLabel.TabIndex = 3;
            this.MainUnitsLabel.Text = "Units";
            // 
            // WeightUnitsChoice
            // 
            this.WeightUnitsChoice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrimaryLayout.SetColumnSpan(this.WeightUnitsChoice, 3);
            this.WeightUnitsChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WeightUnitsChoice.FormattingEnabled = true;
            this.WeightUnitsChoice.Items.AddRange(new object[] {
            "METRIC",
            "IMPERIAL"});
            this.WeightUnitsChoice.Location = new System.Drawing.Point(111, 29);
            this.WeightUnitsChoice.Name = "WeightUnitsChoice";
            this.WeightUnitsChoice.Size = new System.Drawing.Size(102, 21);
            this.WeightUnitsChoice.TabIndex = 2;
            this.WeightUnitsChoice.SelectedIndexChanged += new System.EventHandler(this.WeightUnitsChoice_SelectedIndexChanged);
            // 
            // AltUnitsChoice
            // 
            this.AltUnitsChoice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrimaryLayout.SetColumnSpan(this.AltUnitsChoice, 3);
            this.AltUnitsChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AltUnitsChoice.FormattingEnabled = true;
            this.AltUnitsChoice.Items.AddRange(new object[] {
            "FEET",
            "METERS"});
            this.AltUnitsChoice.Location = new System.Drawing.Point(111, 55);
            this.AltUnitsChoice.Name = "AltUnitsChoice";
            this.AltUnitsChoice.Size = new System.Drawing.Size(102, 21);
            this.AltUnitsChoice.TabIndex = 4;
            this.AltUnitsChoice.SelectedIndexChanged += new System.EventHandler(this.AltUnitsChoice_SelectedIndexChanged);
            // 
            // AltUnitsMenu
            // 
            this.AltUnitsMenu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AltUnitsMenu.AutoSize = true;
            this.PrimaryLayout.SetColumnSpan(this.AltUnitsMenu, 3);
            this.AltUnitsMenu.Location = new System.Drawing.Point(27, 58);
            this.AltUnitsMenu.Name = "AltUnitsMenu";
            this.AltUnitsMenu.Size = new System.Drawing.Size(78, 13);
            this.AltUnitsMenu.TabIndex = 5;
            this.AltUnitsMenu.Text = "Elevation Units";
            // 
            // VRotOutputLabel
            // 
            this.VRotOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.VRotOutputLabel.AutoSize = true;
            this.PrimaryLayout.SetColumnSpan(this.VRotOutputLabel, 3);
            this.VRotOutputLabel.Location = new System.Drawing.Point(363, 58);
            this.VRotOutputLabel.Name = "VRotOutputLabel";
            this.VRotOutputLabel.Size = new System.Drawing.Size(102, 13);
            this.VRotOutputLabel.TabIndex = 7;
            this.VRotOutputLabel.Text = "Rotation (VR)";
            this.VRotOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VRotOutput
            // 
            this.VRotOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrimaryLayout.SetColumnSpan(this.VRotOutput, 2);
            this.VRotOutput.Location = new System.Drawing.Point(471, 55);
            this.VRotOutput.Name = "VRotOutput";
            this.VRotOutput.ReadOnly = true;
            this.VRotOutput.Size = new System.Drawing.Size(66, 20);
            this.VRotOutput.TabIndex = 8;
            this.VRotOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SafeClimbOutputLabel
            // 
            this.SafeClimbOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SafeClimbOutputLabel.AutoSize = true;
            this.PrimaryLayout.SetColumnSpan(this.SafeClimbOutputLabel, 3);
            this.SafeClimbOutputLabel.Location = new System.Drawing.Point(363, 84);
            this.SafeClimbOutputLabel.Name = "SafeClimbOutputLabel";
            this.SafeClimbOutputLabel.Size = new System.Drawing.Size(102, 13);
            this.SafeClimbOutputLabel.TabIndex = 9;
            this.SafeClimbOutputLabel.Text = "Safe Climb (V2)";
            this.SafeClimbOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SafeClimbOutput
            // 
            this.SafeClimbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrimaryLayout.SetColumnSpan(this.SafeClimbOutput, 2);
            this.SafeClimbOutput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SafeClimbOutput.Location = new System.Drawing.Point(471, 81);
            this.SafeClimbOutput.Name = "SafeClimbOutput";
            this.SafeClimbOutput.ReadOnly = true;
            this.SafeClimbOutput.Size = new System.Drawing.Size(66, 20);
            this.SafeClimbOutput.TabIndex = 10;
            this.SafeClimbOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FlapRetractOutput
            // 
            this.FlapRetractOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrimaryLayout.SetColumnSpan(this.FlapRetractOutput, 2);
            this.FlapRetractOutput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FlapRetractOutput.Location = new System.Drawing.Point(471, 107);
            this.FlapRetractOutput.Name = "FlapRetractOutput";
            this.FlapRetractOutput.ReadOnly = true;
            this.FlapRetractOutput.Size = new System.Drawing.Size(66, 20);
            this.FlapRetractOutput.TabIndex = 12;
            this.FlapRetractOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FlapRetractSpeedLabel
            // 
            this.FlapRetractSpeedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FlapRetractSpeedLabel.AutoSize = true;
            this.PrimaryLayout.SetColumnSpan(this.FlapRetractSpeedLabel, 4);
            this.FlapRetractSpeedLabel.Location = new System.Drawing.Point(327, 110);
            this.FlapRetractSpeedLabel.Name = "FlapRetractSpeedLabel";
            this.FlapRetractSpeedLabel.Size = new System.Drawing.Size(138, 13);
            this.FlapRetractSpeedLabel.TabIndex = 11;
            this.FlapRetractSpeedLabel.Text = "Flap Retract Init (VFRI)";
            this.FlapRetractSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ClimbSpeedOutputLabel
            // 
            this.ClimbSpeedOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ClimbSpeedOutputLabel.AutoSize = true;
            this.PrimaryLayout.SetColumnSpan(this.ClimbSpeedOutputLabel, 4);
            this.ClimbSpeedOutputLabel.Location = new System.Drawing.Point(327, 136);
            this.ClimbSpeedOutputLabel.Name = "ClimbSpeedOutputLabel";
            this.ClimbSpeedOutputLabel.Size = new System.Drawing.Size(138, 13);
            this.ClimbSpeedOutputLabel.TabIndex = 13;
            this.ClimbSpeedOutputLabel.Text = "Climb (VCLB)";
            this.ClimbSpeedOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ClimbOutput
            // 
            this.ClimbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrimaryLayout.SetColumnSpan(this.ClimbOutput, 2);
            this.ClimbOutput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ClimbOutput.Location = new System.Drawing.Point(471, 133);
            this.ClimbOutput.Name = "ClimbOutput";
            this.ClimbOutput.ReadOnly = true;
            this.ClimbOutput.Size = new System.Drawing.Size(66, 20);
            this.ClimbOutput.TabIndex = 14;
            this.ClimbOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ApproachSpeedOutputLabel
            // 
            this.ApproachSpeedOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ApproachSpeedOutputLabel.AutoSize = true;
            this.PrimaryLayout.SetColumnSpan(this.ApproachSpeedOutputLabel, 4);
            this.ApproachSpeedOutputLabel.Location = new System.Drawing.Point(327, 188);
            this.ApproachSpeedOutputLabel.Name = "ApproachSpeedOutputLabel";
            this.ApproachSpeedOutputLabel.Size = new System.Drawing.Size(138, 13);
            this.ApproachSpeedOutputLabel.TabIndex = 15;
            this.ApproachSpeedOutputLabel.Text = "Approach (VAPP)";
            this.ApproachSpeedOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ApproachSpeedOutput
            // 
            this.ApproachSpeedOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrimaryLayout.SetColumnSpan(this.ApproachSpeedOutput, 2);
            this.ApproachSpeedOutput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ApproachSpeedOutput.Location = new System.Drawing.Point(471, 185);
            this.ApproachSpeedOutput.Name = "ApproachSpeedOutput";
            this.ApproachSpeedOutput.ReadOnly = true;
            this.ApproachSpeedOutput.Size = new System.Drawing.Size(66, 20);
            this.ApproachSpeedOutput.TabIndex = 16;
            this.ApproachSpeedOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LandingRefLabel
            // 
            this.LandingRefLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LandingRefLabel.AutoSize = true;
            this.PrimaryLayout.SetColumnSpan(this.LandingRefLabel, 4);
            this.LandingRefLabel.Location = new System.Drawing.Point(327, 214);
            this.LandingRefLabel.Name = "LandingRefLabel";
            this.LandingRefLabel.Size = new System.Drawing.Size(138, 13);
            this.LandingRefLabel.TabIndex = 17;
            this.LandingRefLabel.Text = "Landing Reference (VREF)";
            this.LandingRefLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LandingReferenceSpeedOutput
            // 
            this.LandingReferenceSpeedOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrimaryLayout.SetColumnSpan(this.LandingReferenceSpeedOutput, 2);
            this.LandingReferenceSpeedOutput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LandingReferenceSpeedOutput.Location = new System.Drawing.Point(471, 211);
            this.LandingReferenceSpeedOutput.Name = "LandingReferenceSpeedOutput";
            this.LandingReferenceSpeedOutput.ReadOnly = true;
            this.LandingReferenceSpeedOutput.Size = new System.Drawing.Size(66, 20);
            this.LandingReferenceSpeedOutput.TabIndex = 18;
            this.LandingReferenceSpeedOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GoAroundSpeedOutput
            // 
            this.GoAroundSpeedOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrimaryLayout.SetColumnSpan(this.GoAroundSpeedOutput, 2);
            this.GoAroundSpeedOutput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GoAroundSpeedOutput.Location = new System.Drawing.Point(471, 237);
            this.GoAroundSpeedOutput.Name = "GoAroundSpeedOutput";
            this.GoAroundSpeedOutput.ReadOnly = true;
            this.GoAroundSpeedOutput.Size = new System.Drawing.Size(66, 20);
            this.GoAroundSpeedOutput.TabIndex = 19;
            this.GoAroundSpeedOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GoAroundSpdLabel
            // 
            this.GoAroundSpdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GoAroundSpdLabel.AutoSize = true;
            this.PrimaryLayout.SetColumnSpan(this.GoAroundSpdLabel, 4);
            this.GoAroundSpdLabel.Location = new System.Drawing.Point(327, 240);
            this.GoAroundSpdLabel.Name = "GoAroundSpdLabel";
            this.GoAroundSpdLabel.Size = new System.Drawing.Size(138, 13);
            this.GoAroundSpdLabel.TabIndex = 20;
            this.GoAroundSpdLabel.Text = "Go Around (VGA)";
            this.GoAroundSpdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DeIceOnCheckbox
            // 
            this.DeIceOnCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeIceOnCheckbox.AutoSize = true;
            this.DeIceOnCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PrimaryLayout.SetColumnSpan(this.DeIceOnCheckbox, 3);
            this.DeIceOnCheckbox.Location = new System.Drawing.Point(3, 107);
            this.DeIceOnCheckbox.Name = "DeIceOnCheckbox";
            this.DeIceOnCheckbox.Size = new System.Drawing.Size(102, 20);
            this.DeIceOnCheckbox.TabIndex = 22;
            this.DeIceOnCheckbox.Text = "ANTI-ICE";
            this.DeIceOnCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeIceOnCheckbox.UseVisualStyleBackColor = true;
            // 
            // RunwayCondLabel
            // 
            this.RunwayCondLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RunwayCondLabel.AutoSize = true;
            this.PrimaryLayout.SetColumnSpan(this.RunwayCondLabel, 3);
            this.RunwayCondLabel.Location = new System.Drawing.Point(111, 104);
            this.RunwayCondLabel.Name = "RunwayCondLabel";
            this.RunwayCondLabel.Size = new System.Drawing.Size(102, 26);
            this.RunwayCondLabel.TabIndex = 23;
            this.RunwayCondLabel.Text = "Runway Conditions";
            this.RunwayCondLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RwyCondSel
            // 
            this.PrimaryLayout.SetColumnSpan(this.RwyCondSel, 3);
            this.RwyCondSel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RwyCondSel.FormattingEnabled = true;
            this.RwyCondSel.Items.AddRange(new object[] {
            "DRY",
            "WET",
            "ICE"});
            this.RwyCondSel.Location = new System.Drawing.Point(219, 107);
            this.RwyCondSel.Name = "RwyCondSel";
            this.RwyCondSel.Size = new System.Drawing.Size(102, 21);
            this.RwyCondSel.TabIndex = 24;
            // 
            // RunwayHeadingLabel
            // 
            this.RunwayHeadingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RunwayHeadingLabel.AutoSize = true;
            this.PrimaryLayout.SetColumnSpan(this.RunwayHeadingLabel, 3);
            this.RunwayHeadingLabel.Location = new System.Drawing.Point(3, 130);
            this.RunwayHeadingLabel.Name = "RunwayHeadingLabel";
            this.RunwayHeadingLabel.Size = new System.Drawing.Size(102, 26);
            this.RunwayHeadingLabel.TabIndex = 25;
            this.RunwayHeadingLabel.Text = "Runway Heading";
            this.RunwayHeadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RwyHdgInput
            // 
            this.PrimaryLayout.SetColumnSpan(this.RwyHdgInput, 2);
            this.RwyHdgInput.Location = new System.Drawing.Point(111, 133);
            this.RwyHdgInput.Name = "RwyHdgInput";
            this.RwyHdgInput.Size = new System.Drawing.Size(66, 20);
            this.RwyHdgInput.TabIndex = 26;
            // 
            // RwyWindInput
            // 
            this.PrimaryLayout.SetColumnSpan(this.RwyWindInput, 2);
            this.RwyWindInput.Location = new System.Drawing.Point(111, 159);
            this.RwyWindInput.Name = "RwyWindInput";
            this.RwyWindInput.Size = new System.Drawing.Size(66, 20);
            this.RwyWindInput.TabIndex = 27;
            this.RwyWindInput.Text = "000/00";
            // 
            // RwyWindLabel
            // 
            this.RwyWindLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RwyWindLabel.AutoSize = true;
            this.PrimaryLayout.SetColumnSpan(this.RwyWindLabel, 3);
            this.RwyWindLabel.Location = new System.Drawing.Point(3, 156);
            this.RwyWindLabel.Name = "RwyWindLabel";
            this.RwyWindLabel.Size = new System.Drawing.Size(102, 26);
            this.RwyWindLabel.TabIndex = 28;
            this.RwyWindLabel.Text = "Runway Wind";
            this.RwyWindLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RunwayElevationLabel
            // 
            this.RunwayElevationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RunwayElevationLabel.AutoSize = true;
            this.PrimaryLayout.SetColumnSpan(this.RunwayElevationLabel, 3);
            this.RunwayElevationLabel.Location = new System.Drawing.Point(3, 182);
            this.RunwayElevationLabel.Name = "RunwayElevationLabel";
            this.RunwayElevationLabel.Size = new System.Drawing.Size(102, 26);
            this.RunwayElevationLabel.TabIndex = 29;
            this.RunwayElevationLabel.Text = "Runway Elevation";
            this.RunwayElevationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RwyElevationInput
            // 
            this.PrimaryLayout.SetColumnSpan(this.RwyElevationInput, 2);
            this.RwyElevationInput.Location = new System.Drawing.Point(111, 185);
            this.RwyElevationInput.Name = "RwyElevationInput";
            this.RwyElevationInput.Size = new System.Drawing.Size(66, 20);
            this.RwyElevationInput.TabIndex = 30;
            // 
            // ComputeBtn
            // 
            this.ComputeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrimaryLayout.SetColumnSpan(this.ComputeBtn, 5);
            this.ComputeBtn.Location = new System.Drawing.Point(363, 289);
            this.ComputeBtn.Name = "ComputeBtn";
            this.PrimaryLayout.SetRowSpan(this.ComputeBtn, 2);
            this.ComputeBtn.Size = new System.Drawing.Size(174, 46);
            this.ComputeBtn.TabIndex = 36;
            this.ComputeBtn.Text = "Compute";
            this.ComputeBtn.UseVisualStyleBackColor = true;
            this.ComputeBtn.Click += new System.EventHandler(this.ComputeBtn_Click);
            // 
            // UnitsClarification
            // 
            this.UnitsClarification.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnitsClarification.AutoSize = true;
            this.PrimaryLayout.SetColumnSpan(this.UnitsClarification, 4);
            this.UnitsClarification.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitsClarification.Location = new System.Drawing.Point(219, 26);
            this.UnitsClarification.Name = "UnitsClarification";
            this.UnitsClarification.Size = new System.Drawing.Size(138, 26);
            this.UnitsClarification.TabIndex = 37;
            this.UnitsClarification.Text = "(For Weights)";
            this.UnitsClarification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FailureOutput
            // 
            this.FailureOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FailureOutput.AutoSize = true;
            this.PrimaryLayout.SetColumnSpan(this.FailureOutput, 5);
            this.FailureOutput.ForeColor = System.Drawing.Color.DarkRed;
            this.FailureOutput.Location = new System.Drawing.Point(363, 338);
            this.FailureOutput.Name = "FailureOutput";
            this.FailureOutput.Size = new System.Drawing.Size(174, 26);
            this.FailureOutput.TabIndex = 38;
            this.FailureOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FlapsSettingLabel
            // 
            this.FlapsSettingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlapsSettingLabel.AutoSize = true;
            this.PrimaryLayout.SetColumnSpan(this.FlapsSettingLabel, 3);
            this.FlapsSettingLabel.Location = new System.Drawing.Point(3, 208);
            this.FlapsSettingLabel.Name = "FlapsSettingLabel";
            this.FlapsSettingLabel.Size = new System.Drawing.Size(102, 26);
            this.FlapsSettingLabel.TabIndex = 39;
            this.FlapsSettingLabel.Text = "Flaps Setting";
            this.FlapsSettingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FlapsSettingSel
            // 
            this.PrimaryLayout.SetColumnSpan(this.FlapsSettingSel, 2);
            this.FlapsSettingSel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FlapsSettingSel.FormattingEnabled = true;
            this.FlapsSettingSel.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "35"});
            this.FlapsSettingSel.Location = new System.Drawing.Point(111, 211);
            this.FlapsSettingSel.Name = "FlapsSettingSel";
            this.FlapsSettingSel.Size = new System.Drawing.Size(66, 21);
            this.FlapsSettingSel.TabIndex = 40;
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightLabel.AutoSize = true;
            this.PrimaryLayout.SetColumnSpan(this.WeightLabel, 4);
            this.WeightLabel.Location = new System.Drawing.Point(3, 286);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(138, 26);
            this.WeightLabel.TabIndex = 34;
            this.WeightLabel.Text = "Takeoff or Landing Weight";
            this.WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WeightInput
            // 
            this.WeightInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrimaryLayout.SetColumnSpan(this.WeightInput, 3);
            this.WeightInput.Location = new System.Drawing.Point(147, 289);
            this.WeightInput.Name = "WeightInput";
            this.WeightInput.Size = new System.Drawing.Size(102, 20);
            this.WeightInput.TabIndex = 35;
            // 
            // OATInput
            // 
            this.PrimaryLayout.SetColumnSpan(this.OATInput, 2);
            this.OATInput.Location = new System.Drawing.Point(147, 263);
            this.OATInput.Name = "OATInput";
            this.OATInput.Size = new System.Drawing.Size(66, 20);
            this.OATInput.TabIndex = 32;
            // 
            // CelciusLabel
            // 
            this.CelciusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CelciusLabel.AutoSize = true;
            this.CelciusLabel.Location = new System.Drawing.Point(219, 260);
            this.CelciusLabel.Name = "CelciusLabel";
            this.CelciusLabel.Size = new System.Drawing.Size(30, 26);
            this.CelciusLabel.TabIndex = 33;
            this.CelciusLabel.Text = "°C";
            this.CelciusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OATLabel
            // 
            this.OATLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OATLabel.AutoSize = true;
            this.PrimaryLayout.SetColumnSpan(this.OATLabel, 4);
            this.OATLabel.Location = new System.Drawing.Point(3, 260);
            this.OATLabel.Name = "OATLabel";
            this.OATLabel.Size = new System.Drawing.Size(138, 26);
            this.OATLabel.TabIndex = 31;
            this.OATLabel.Text = "Outside Air Temp (OAT)";
            this.OATLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // V1Label
            // 
            this.V1Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.V1Label.AutoSize = true;
            this.PrimaryLayout.SetColumnSpan(this.V1Label, 3);
            this.V1Label.Location = new System.Drawing.Point(363, 26);
            this.V1Label.Name = "V1Label";
            this.V1Label.Size = new System.Drawing.Size(102, 26);
            this.V1Label.TabIndex = 41;
            this.V1Label.Text = "Commit to Fly (V1)";
            this.V1Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // V1Output
            // 
            this.V1Output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrimaryLayout.SetColumnSpan(this.V1Output, 2);
            this.V1Output.Location = new System.Drawing.Point(471, 29);
            this.V1Output.Name = "V1Output";
            this.V1Output.ReadOnly = true;
            this.V1Output.Size = new System.Drawing.Size(66, 20);
            this.V1Output.TabIndex = 42;
            this.V1Output.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 431);
            this.Controls.Add(this.PrimaryLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Q400 Performance Calculator";
            this.PrimaryLayout.ResumeLayout(false);
            this.PrimaryLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PrimaryLayout;
        private System.Windows.Forms.Label IconCredit;
        private System.Windows.Forms.ComboBox WeightUnitsChoice;
        private System.Windows.Forms.Label MainUnitsLabel;
        private System.Windows.Forms.ComboBox AltUnitsChoice;
        private System.Windows.Forms.Label AltUnitsMenu;
        private System.Windows.Forms.Label VRotOutputLabel;
        private System.Windows.Forms.TextBox VRotOutput;
        private System.Windows.Forms.Label SafeClimbOutputLabel;
        private System.Windows.Forms.TextBox SafeClimbOutput;
        private System.Windows.Forms.TextBox FlapRetractOutput;
        private System.Windows.Forms.Label FlapRetractSpeedLabel;
        private System.Windows.Forms.Label ClimbSpeedOutputLabel;
        private System.Windows.Forms.TextBox ClimbOutput;
        private System.Windows.Forms.Label ApproachSpeedOutputLabel;
        private System.Windows.Forms.TextBox ApproachSpeedOutput;
        private System.Windows.Forms.Label LandingRefLabel;
        private System.Windows.Forms.TextBox LandingReferenceSpeedOutput;
        private System.Windows.Forms.TextBox GoAroundSpeedOutput;
        private System.Windows.Forms.Label GoAroundSpdLabel;
        private System.Windows.Forms.CheckBox DeIceOnCheckbox;
        private System.Windows.Forms.Label RunwayCondLabel;
        private System.Windows.Forms.ComboBox RwyCondSel;
        private System.Windows.Forms.Label RunwayHeadingLabel;
        private System.Windows.Forms.TextBox RwyHdgInput;
        private System.Windows.Forms.TextBox RwyWindInput;
        private System.Windows.Forms.Label RwyWindLabel;
        private System.Windows.Forms.Label RunwayElevationLabel;
        private System.Windows.Forms.TextBox RwyElevationInput;
        private System.Windows.Forms.Label OATLabel;
        private System.Windows.Forms.TextBox OATInput;
        private System.Windows.Forms.Label CelciusLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TextBox WeightInput;
        private System.Windows.Forms.Button ComputeBtn;
        private System.Windows.Forms.Label UnitsClarification;
        private System.Windows.Forms.Label FailureOutput;
        private System.Windows.Forms.Label FlapsSettingLabel;
        private System.Windows.Forms.ComboBox FlapsSettingSel;
        private System.Windows.Forms.Label V1Label;
        private System.Windows.Forms.TextBox V1Output;
    }
}

