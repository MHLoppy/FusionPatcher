namespace FusionForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            InstallButton = new Button();
            ApplyButton = new Button();
            TopDivider = new Label();
            LoadSPConfigButton = new Button();
            LoadBaselineButton = new Button();
            LabelBaseNation = new Label();
            LabelNationPowers = new Label();
            ImportButton = new Button();
            ExportButton = new Button();
            BottomDivider = new Label();
            LaunchButton = new Button();
            NationsFlowLayoutPanel = new FlowLayoutPanel();
            LoadingText = new Label();
            FusionPathTextBox = new TextBox();
            FusionPathLabel = new Label();
            FusionPathButton = new Button();
            RoNPathButton = new Button();
            RoNPathLabel = new Label();
            RoNPathTextBox = new TextBox();
            PresetsLabel = new Label();
            ThirdRandomButton = new Button();
            LoadMayaButton = new Button();
            FirstRandomButton = new Button();
            SecondRandomButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // InstallButton
            // 
            InstallButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InstallButton.Location = new Point(65, 127);
            InstallButton.Name = "InstallButton";
            InstallButton.Size = new Size(180, 60);
            InstallButton.TabIndex = 0;
            InstallButton.Text = "Generate patchable game exe";
            InstallButton.UseVisualStyleBackColor = true;
            InstallButton.Click += InstallButton_Click;
            // 
            // ApplyButton
            // 
            ApplyButton.Enabled = false;
            ApplyButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ApplyButton.Location = new Point(85, 493);
            ApplyButton.Name = "ApplyButton";
            ApplyButton.Size = new Size(140, 60);
            ApplyButton.TabIndex = 2;
            ApplyButton.Text = "Apply current configuration";
            ApplyButton.UseVisualStyleBackColor = true;
            ApplyButton.Click += ApplyButton_Click;
            // 
            // TopDivider
            // 
            TopDivider.BorderStyle = BorderStyle.Fixed3D;
            TopDivider.Location = new Point(40, 216);
            TopDivider.Name = "TopDivider";
            TopDivider.Size = new Size(230, 2);
            TopDivider.TabIndex = 3;
            // 
            // LoadSPConfigButton
            // 
            LoadSPConfigButton.Enabled = false;
            LoadSPConfigButton.Font = new Font("Segoe UI", 12F);
            LoadSPConfigButton.Location = new Point(115, 247);
            LoadSPConfigButton.Name = "LoadSPConfigButton";
            LoadSPConfigButton.Size = new Size(80, 50);
            LoadSPConfigButton.TabIndex = 4;
            LoadSPConfigButton.Text = "Stack Pointer";
            LoadSPConfigButton.UseVisualStyleBackColor = true;
            LoadSPConfigButton.Click += LoadSPConfigButton_Click;
            // 
            // LoadBaselineButton
            // 
            LoadBaselineButton.Enabled = false;
            LoadBaselineButton.Font = new Font("Segoe UI", 12F);
            LoadBaselineButton.Location = new Point(27, 247);
            LoadBaselineButton.Name = "LoadBaselineButton";
            LoadBaselineButton.Size = new Size(80, 50);
            LoadBaselineButton.TabIndex = 5;
            LoadBaselineButton.Text = "Baseline";
            LoadBaselineButton.UseVisualStyleBackColor = true;
            LoadBaselineButton.Click += LoadBaselineButton_Click;
            // 
            // LabelBaseNation
            // 
            LabelBaseNation.AutoSize = true;
            LabelBaseNation.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelBaseNation.ForeColor = Color.DimGray;
            LabelBaseNation.Location = new Point(310, 19);
            LabelBaseNation.Name = "LabelBaseNation";
            LabelBaseNation.Size = new Size(116, 20);
            LabelBaseNation.TabIndex = 6;
            LabelBaseNation.Text = "When playing...";
            LabelBaseNation.Visible = false;
            // 
            // LabelNationPowers
            // 
            LabelNationPowers.AutoSize = true;
            LabelNationPowers.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelNationPowers.ForeColor = Color.DimGray;
            LabelNationPowers.Location = new Point(570, 19);
            LabelNationPowers.Name = "LabelNationPowers";
            LabelNationPowers.Size = new Size(296, 20);
            LabelNationPowers.TabIndex = 7;
            LabelNationPowers.Text = "Get the nation powers normally given to...";
            LabelNationPowers.Visible = false;
            // 
            // ImportButton
            // 
            ImportButton.Enabled = false;
            ImportButton.Font = new Font("Segoe UI", 12F);
            ImportButton.Location = new Point(71, 320);
            ImportButton.Name = "ImportButton";
            ImportButton.Size = new Size(80, 40);
            ImportButton.TabIndex = 8;
            ImportButton.Text = "Import...";
            ImportButton.UseVisualStyleBackColor = true;
            ImportButton.Click += ImportButton_Click;
            // 
            // ExportButton
            // 
            ExportButton.Enabled = false;
            ExportButton.Font = new Font("Segoe UI", 12F);
            ExportButton.Location = new Point(159, 320);
            ExportButton.Name = "ExportButton";
            ExportButton.Size = new Size(80, 40);
            ExportButton.TabIndex = 9;
            ExportButton.Text = "Export...";
            ExportButton.UseVisualStyleBackColor = true;
            ExportButton.Click += ExportButton_Click;
            // 
            // BottomDivider
            // 
            BottomDivider.BorderStyle = BorderStyle.Fixed3D;
            BottomDivider.Location = new Point(105, 462);
            BottomDivider.Name = "BottomDivider";
            BottomDivider.Size = new Size(100, 2);
            BottomDivider.TabIndex = 10;
            // 
            // LaunchButton
            // 
            LaunchButton.Enabled = false;
            LaunchButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LaunchButton.Location = new Point(85, 566);
            LaunchButton.Name = "LaunchButton";
            LaunchButton.Size = new Size(140, 60);
            LaunchButton.TabIndex = 11;
            LaunchButton.Text = "Launch patched game exe";
            LaunchButton.UseVisualStyleBackColor = true;
            LaunchButton.Click += LaunchButton_Click;
            // 
            // NationsFlowLayoutPanel
            // 
            NationsFlowLayoutPanel.AutoScroll = true;
            NationsFlowLayoutPanel.BackColor = Color.White;
            NationsFlowLayoutPanel.Enabled = false;
            NationsFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            NationsFlowLayoutPanel.Location = new Point(310, 42);
            NationsFlowLayoutPanel.Name = "NationsFlowLayoutPanel";
            NationsFlowLayoutPanel.Size = new Size(662, 607);
            NationsFlowLayoutPanel.TabIndex = 12;
            NationsFlowLayoutPanel.WrapContents = false;
            // 
            // LoadingText
            // 
            LoadingText.AutoSize = true;
            LoadingText.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoadingText.ForeColor = Color.DimGray;
            LoadingText.Location = new Point(570, 19);
            LoadingText.Name = "LoadingText";
            LoadingText.Size = new Size(76, 20);
            LoadingText.TabIndex = 13;
            LoadingText.Text = "Loading...";
            LoadingText.Visible = false;
            // 
            // FusionPathTextBox
            // 
            FusionPathTextBox.Location = new Point(26, 90);
            FusionPathTextBox.Name = "FusionPathTextBox";
            FusionPathTextBox.ReadOnly = true;
            FusionPathTextBox.RightToLeft = RightToLeft.No;
            FusionPathTextBox.Size = new Size(224, 23);
            FusionPathTextBox.TabIndex = 14;
            // 
            // FusionPathLabel
            // 
            FusionPathLabel.AutoSize = true;
            FusionPathLabel.Location = new Point(26, 72);
            FusionPathLabel.Name = "FusionPathLabel";
            FusionPathLabel.Size = new Size(93, 15);
            FusionPathLabel.TabIndex = 15;
            FusionPathLabel.Text = "Fusion exe path:";
            // 
            // FusionPathButton
            // 
            FusionPathButton.Location = new Point(256, 89);
            FusionPathButton.Name = "FusionPathButton";
            FusionPathButton.Size = new Size(29, 25);
            FusionPathButton.TabIndex = 16;
            FusionPathButton.Text = "...";
            FusionPathButton.UseVisualStyleBackColor = true;
            FusionPathButton.Visible = false;
            FusionPathButton.Click += FusionPathButton_Click;
            // 
            // RoNPathButton
            // 
            RoNPathButton.Location = new Point(256, 45);
            RoNPathButton.Name = "RoNPathButton";
            RoNPathButton.Size = new Size(29, 25);
            RoNPathButton.TabIndex = 19;
            RoNPathButton.Text = "...";
            RoNPathButton.UseVisualStyleBackColor = true;
            RoNPathButton.Click += RoNPathButton_Click;
            // 
            // RoNPathLabel
            // 
            RoNPathLabel.AutoSize = true;
            RoNPathLabel.Location = new Point(26, 28);
            RoNPathLabel.Name = "RoNPathLabel";
            RoNPathLabel.Size = new Size(81, 15);
            RoNPathLabel.TabIndex = 18;
            RoNPathLabel.Text = "RoN exe path:";
            // 
            // RoNPathTextBox
            // 
            RoNPathTextBox.Location = new Point(26, 46);
            RoNPathTextBox.Name = "RoNPathTextBox";
            RoNPathTextBox.ReadOnly = true;
            RoNPathTextBox.RightToLeft = RightToLeft.No;
            RoNPathTextBox.Size = new Size(224, 23);
            RoNPathTextBox.TabIndex = 17;
            // 
            // PresetsLabel
            // 
            PresetsLabel.AutoSize = true;
            PresetsLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PresetsLabel.Location = new Point(126, 227);
            PresetsLabel.Name = "PresetsLabel";
            PresetsLabel.Size = new Size(59, 17);
            PresetsLabel.TabIndex = 20;
            PresetsLabel.Text = "PRESETS";
            PresetsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ThirdRandomButton
            // 
            ThirdRandomButton.Enabled = false;
            ThirdRandomButton.Font = new Font("Segoe UI", 12F);
            ThirdRandomButton.Location = new Point(203, 383);
            ThirdRandomButton.Name = "ThirdRandomButton";
            ThirdRandomButton.Size = new Size(80, 50);
            ThirdRandomButton.TabIndex = 21;
            ThirdRandomButton.Text = "Third power";
            ThirdRandomButton.UseVisualStyleBackColor = true;
            ThirdRandomButton.Click += ThreeRandomButton_Click;
            // 
            // LoadMayaButton
            // 
            LoadMayaButton.Cursor = Cursors.No;
            LoadMayaButton.Enabled = false;
            LoadMayaButton.Font = new Font("Segoe UI", 12F);
            LoadMayaButton.Location = new Point(203, 247);
            LoadMayaButton.Name = "LoadMayaButton";
            LoadMayaButton.Size = new Size(80, 50);
            LoadMayaButton.TabIndex = 22;
            LoadMayaButton.Text = "Rise of Maya";
            LoadMayaButton.UseVisualStyleBackColor = true;
            LoadMayaButton.Click += LoadMayaButton_Click;
            // 
            // FirstRandomButton
            // 
            FirstRandomButton.Enabled = false;
            FirstRandomButton.Font = new Font("Segoe UI", 12F);
            FirstRandomButton.Location = new Point(27, 383);
            FirstRandomButton.Name = "FirstRandomButton";
            FirstRandomButton.Size = new Size(80, 50);
            FirstRandomButton.TabIndex = 23;
            FirstRandomButton.Text = "First power";
            FirstRandomButton.UseVisualStyleBackColor = true;
            FirstRandomButton.Click += OneRandomButton_Click;
            // 
            // SecondRandomButton
            // 
            SecondRandomButton.Enabled = false;
            SecondRandomButton.Font = new Font("Segoe UI", 12F);
            SecondRandomButton.Location = new Point(115, 383);
            SecondRandomButton.Name = "SecondRandomButton";
            SecondRandomButton.Size = new Size(80, 50);
            SecondRandomButton.TabIndex = 24;
            SecondRandomButton.Text = "Second power";
            SecondRandomButton.UseVisualStyleBackColor = true;
            SecondRandomButton.Click += TwoRandomButton_Clickk;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(113, 435);
            label1.Name = "label1";
            label1.Size = new Size(85, 17);
            label1.TabIndex = 25;
            label1.Text = "RANDOMIZE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 661);
            Controls.Add(label1);
            Controls.Add(SecondRandomButton);
            Controls.Add(FirstRandomButton);
            Controls.Add(LoadMayaButton);
            Controls.Add(ThirdRandomButton);
            Controls.Add(PresetsLabel);
            Controls.Add(RoNPathButton);
            Controls.Add(RoNPathLabel);
            Controls.Add(RoNPathTextBox);
            Controls.Add(FusionPathButton);
            Controls.Add(FusionPathLabel);
            Controls.Add(FusionPathTextBox);
            Controls.Add(LoadingText);
            Controls.Add(NationsFlowLayoutPanel);
            Controls.Add(LaunchButton);
            Controls.Add(BottomDivider);
            Controls.Add(ExportButton);
            Controls.Add(ImportButton);
            Controls.Add(LabelNationPowers);
            Controls.Add(LabelBaseNation);
            Controls.Add(LoadBaselineButton);
            Controls.Add(LoadSPConfigButton);
            Controls.Add(TopDivider);
            Controls.Add(ApplyButton);
            Controls.Add(InstallButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1000, 700);
            MinimumSize = new Size(1000, 700);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fusion Patcher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button InstallButton;
        private Button ApplyButton;
        private Label TopDivider;
        private Button LoadSPConfigButton;
        private Button LoadBaselineButton;
        private Label LabelBaseNation;
        private Label LabelNationPowers;
        private Button ImportButton;
        private Button ExportButton;
        private Label BottomDivider;
        private Button LaunchButton;
        private FlowLayoutPanel NationsFlowLayoutPanel;
        private Label LoadingText;
        private TextBox FusionPathTextBox;
        private Label FusionPathLabel;
        private Button FusionPathButton;
        private Button RoNPathButton;
        private Label RoNPathLabel;
        private TextBox RoNPathTextBox;
        private Label PresetsLabel;
        private Button ThirdRandomButton;
        private Button LoadMayaButton;
        private Button FirstRandomButton;
        private Button SecondRandomButton;
        private Label label1;
    }
}
