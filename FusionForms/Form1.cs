using DeltaQ.BsDiff;
using Microsoft.VisualBasic;    // for basic popups that support user input
using Microsoft.Win32;
using System.Diagnostics;
using System.Security.Cryptography;

namespace FusionForms
{
    public partial class Form1 : Form
    {
        public enum NationAlphabetical
        {
            None      = 0,
            Americans = 1,
            Aztecs    = 2,
            Bantu     = 3,
            British   = 4,
            Chinese   = 5,
            Dutch     = 6,
            Egyptians = 7,
            French    = 8,
            Germans   = 9,
            Greeks    = 10,
            Inca      = 11,
            Indians   = 12,
            Iroquois  = 13,
            Japanese  = 14,
            Koreans   = 15,
            Lakota    = 16,
            Maya      = 17,
            Mongols   = 18,
            Nubians   = 19,
            Persians  = 20,
            Romans    = 21,
            Russians  = 22,
            Spanish   = 23,
            Turks     = 24
        }

        public static readonly Dictionary<NationAlphabetical, byte> NationByteDict = new()
        {
            { NationAlphabetical.None,      0x79 }, // highest you can go with a triple-byte CMP instruction
            { NationAlphabetical.Aztecs,    0x0 },
            { NationAlphabetical.Maya,      0x1 },
            { NationAlphabetical.Inca,      0x2 },
            { NationAlphabetical.Bantu,     0x3 },
            { NationAlphabetical.Nubians,   0x4 },
            { NationAlphabetical.Greeks,    0x5 },
            { NationAlphabetical.Romans,    0x6 },
            { NationAlphabetical.Egyptians, 0x7 },
            { NationAlphabetical.Turks,     0x8 },
            { NationAlphabetical.Spanish,   0x9 },
            { NationAlphabetical.French,    0xA },
            { NationAlphabetical.British,   0xB },
            { NationAlphabetical.Germans,   0xC },
            { NationAlphabetical.Russians,  0xD },
            { NationAlphabetical.Chinese,   0xE },
            { NationAlphabetical.Japanese,  0xF },
            { NationAlphabetical.Koreans,   0x10 },
            { NationAlphabetical.Mongols,   0x11 },
            { NationAlphabetical.Iroquois,  0x12 },
            { NationAlphabetical.Lakota,    0x13 },
            { NationAlphabetical.Americans, 0x14 },
            { NationAlphabetical.Indians,   0x15 },
            { NationAlphabetical.Dutch,     0x16 },
            { NationAlphabetical.Persians,  0x17 },
        };

        internal static List<int> ConvertConfigToList(string config)
        {
            List<int> configList = new();
            var rows = config.Split(',');
            for (int i = 0; i < rows.Length; i++)
            {
                var rcolumns = rows[i].Split("-");
                for (int j = 0; j < rcolumns.Length; j++)
                {
                    configList.Add(int.Parse(rcolumns[j]));
                }
            }
            return configList;
        }

        internal static List<(int, int, int, int)> ConvertConfigToInternallyNumberedList(string config)
        {
            List<(int, int, int, int)> configList = new();
            var rows = config.Split(',');
            for (int i = 0; i < rows.Length; i++)
            {
                var rcolumns = rows[i].Split("-");
                (int, int, int, int) tuple;

                tuple.Item1 = NationByteDict[(NationAlphabetical)int.Parse(rcolumns[0])];
                tuple.Item2 = NationByteDict[(NationAlphabetical)int.Parse(rcolumns[1])];
                tuple.Item3 = NationByteDict[(NationAlphabetical)int.Parse(rcolumns[2])];
                tuple.Item4 = NationByteDict[(NationAlphabetical)int.Parse(rcolumns[3])];

                configList.Add(tuple);
            }
            return configList;
        }

        public Form1()
        {
            InitializeComponent();

            string version = Application.ProductVersion;
            this.Text += $" v{version}";

            // Try to pre-fill the user's RoN path
            string defaultExePath = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Rise of Nations\\riseofnations.exe";
            if (!IsRonExeAtPath(defaultExePath) && !IsRonAtRegistryPath())
            {
                MessageBox.Show("Unable to automatically locate RoN game exe. Please input paths manually using the \"...\" button.");
            }
            // [on second thought, I don't want to handle a lot of the flow-on logic from fully handling this - this is supposed to be quick-and-dirty]
            //else
            //{
            //    // Check if a Fusion exe has already been generated 
            //    string ronFolder = Path.GetDirectoryName(RoNPathTextBox.Text);
            //    string newExePath = Path.Combine(ronFolder, "riseofnations_fusion.exe");

            //    if (Path.Exists(newExePath))
            //    {
            //        LoadBaselineButton.Enabled = true;
            //        LoadSPConfigButton.Enabled = true;
            //        ImportButton.Enabled = true;
            //        ExportButton.Enabled = true;

            //        ApplyButton.Enabled = true;

            //        LoadingText.Visible = false;
            //        LabelBaseNation.Visible = true;
            //        LabelNationPowers.Visible = true;
            //        NationsFlowLayoutPanel.Enabled = true;
            //    }
            //}
        }

        private async Task InitializeComboGroupsAsync()
        {
            int nations = 24;
            for (int groupIndex = 0; groupIndex < nations; groupIndex++)
            {
                var panel = await CreateComboGroupAsync(groupIndex); // runs async, but returns Panel on UI thread
                NationsFlowLayoutPanel.Controls.Add(panel);
            }
        }

        // weak attempt at improving performance, but doesn't help much because you have to clone it anyway
        private NationAlphabetical[]? _cachedNations;
        private async Task<NationAlphabetical[]> GetNationsAsync()
        {
            if (_cachedNations is not null)
            {
                return _cachedNations;
            }
            return _cachedNations = await Task.Run(() => (NationAlphabetical[])Enum.GetValues(typeof(NationAlphabetical)));
        }

        // another attempt at optimization-by-caching
        private List<ComboBox>? _cachedComboBoxes;
        private List<ComboBox> GetNationComboBoxes()
        {
            if (_cachedComboBoxes is not null)
            {
                return _cachedComboBoxes;
            }

            List<ComboBox> cBoxes = new();
            foreach (Control child in this.Controls.Find("NationPowersPanel", true))
            {
                foreach (Control grandchild in child.Controls)
                {
                    foreach (ComboBox comboBox in grandchild.Controls)
                    {
                        cBoxes.Add(comboBox);
                    }
                }
            }

            return _cachedComboBoxes = cBoxes;
        }

        private async Task<Panel> CreateComboGroupAsync(int groupIndex)
        {
            // Slightly unnecessary outer panel
            var groupPanel = new Panel
            {
                Width = 640,
                Height = 29,
                Margin = new Padding(3, 2, 1, 2),
                BackColor = Color.FromArgb(252, 252, 252),
                BorderStyle = BorderStyle.FixedSingle,
                Name = "NationPowersPanel"
            };

            // Horizontal container for the 4 comboboxes
            var row = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                Padding = new Padding(2),
                AutoSize = false,
                Name = "FlowLayoutPanelRow" + groupIndex
            };
            groupPanel.Controls.Add(row);

            // Faster reimplementation: give the illusion that we've populated the dropdowns, but we actually only do one, then do the full thing on-click
            // Although individually the speed wasn't too bad, when fully populating 100 boxes it was a wait time of 5+ seconds
            row.SuspendLayout();
            var fullNations = await GetNationsAsync();  // I timed this before (but not after lol) and it wasn't that heavy in absolute terms, but it probably doesn't hurt

            for (int i = 0; i < 4; i++)
            {
                await Task.Yield();

                var margin = new Padding(4, 0, 4, 0);
                if (i == 0)
                {
                    margin.Right = 44;
                }

                var cb = new ComboBox
                {
                    Width = 140,
                    DropDownStyle = ComboBoxStyle.DropDownList,
                    Margin = margin,
                    Name = "cb" + groupIndex + "-" + i
                };
                cb.BindingContext = this.BindingContext;    // a few hours of my life I will never get back https://stackoverflow.com/a/36053452 (might've been a threading issue)
                cb.MouseWheel += new MouseEventHandler(Dummy_MouseWheel);
                cb.Tag = false;

                cb.DropDown += async (s, e) =>
                {
                    var box = (ComboBox)s;
                    int tagValue = (int)box.Tag;
                    if (tagValue == -1) return;

                    box.DataSource = (NationAlphabetical[])fullNations.Clone();    // whoops, was accidentally sharing data sources without the cloning
                    box.SelectedIndex = tagValue;
                    box.Tag = -1;
                };

                // Delay full population of ALL combobox columns for speed reasons
                if (i == 0)
                {
                    cb.Enabled = false; // Probably best to lock these from being edited [Rise of Maya doesn't actually work with this assembly implementation]
                    cb.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }
                if (i <= 1)
                {
                    cb.DataSource = new NationAlphabetical[] { (NationAlphabetical)(groupIndex + 1) };
                    cb.Tag = groupIndex + 1; // dual purpose: true/false tag for delayed load + prefill selection after dropdown re-population
                }
                else
                {
                    cb.DataSource = new NationAlphabetical[] { NationAlphabetical.None };
                    cb.Tag = 0;              // dual purpose: true/false tag for delayed load + prefill selection after dropdown re-population
                }

                row.Controls.Add(cb);
            }

            row.ResumeLayout();
            return groupPanel;
        }

        private void SetFusionPath(string ronPath)
        {
            string fusionPath = Path.Combine(Path.GetDirectoryName(ronPath), "riseofnations_fusion.exe");
            FusionPathTextBox.Text = fusionPath;
        }

        private bool IsRonExeAtPath(string exePath)
        {
            if (Path.Exists(exePath))
            {
                RoNPathTextBox.Text = exePath;
                SetFusionPath(exePath);

                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsRonAtRegistryPath()
        {
            RegistryKey regPath;
            if (Environment.Is64BitOperatingSystem)
            {
                regPath = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            }
            else
            {
                regPath = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);
            }

            RegistryKey ronReg = regPath.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Steam App 287450");
            if (ronReg is not null)
            {
                string ronPath = ronReg.ToString();
                RoNPathTextBox.Text = ronPath;
                SetFusionPath(ronPath);

                return true;
            }
            else
            {
                return false;
            }
        }

        // TODO Ideally we'd also have a function checking relative local paths to find the RoN exe (with an assumption that it's run as a Workshop download),
        //   but at that point we can just graphically offload the programming burden to the user.

        private bool RonExeHashMatches(bool laa)
        {
            // riseofnations.exe version 00.2024.06.2000 SHA256 hashes
            string ronHash = "30478a44b577cb11ebcbbbf53d3e93ba02fd2aacf3bdefa6552c9b6449625079";
            string laaHash = "75d9b49109d5eefe8ab9d73dc53f44f0e193c445b63c5b2e8e11ed9b90a6ef41";
            string thisHash;
            string expectedHash;
            if (laa)
            {
                expectedHash = laaHash;
            }
            else
            {
                expectedHash = ronHash;
            }

            // https://makolyte.com/csharp-get-a-files-checksum-using-any-hashing-algorithm-md5-sha256/
            using (SHA256 sha256 = SHA256.Create())
            {
                using (var stream = File.OpenRead(RoNPathTextBox.Text))
                {
                    var hash = sha256.ComputeHash(stream);
                    thisHash = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant(); // hash is separated by dashes + capitalized by default

                    Debug.WriteLine(thisHash);
                }
            }

            return (thisHash == expectedHash);
        }

        private async Task<bool> CreateFusionExe(bool laa)  // not properly async
        {
            if (File.Exists(FusionPathTextBox.Text))
            {
                string title = "Overwrite file?";
                string message = "Fusion exe already exists at the specified path, so continuing will overwrite it (resetting whatever configuration that was previously patched onto it).";
                DialogResult response = MessageBox.Show(message, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (response is not DialogResult.OK)
                {
                    return false;
                }
            }

            var baseData = File.ReadAllBytes(RoNPathTextBox.Text);
            var fusionDelta = File.ReadAllBytes("riseofnations_fusion.delta");
            if (laa)
            {
                //int offsetFromEnd = 4;
                //int insertPos = FusionPathTextBox.Text.Length - offsetFromEnd;
                //FusionPathTextBox.Text = FusionPathTextBox.Text.Insert(insertPos, "_LAA");

                fusionDelta = File.ReadAllBytes("riseofnations_fusion_laa.delta");
            }
            using var outStream = File.Create(FusionPathTextBox.Text);
            Patch.Apply(baseData, fusionDelta, outStream);

            return true;
        }

        private async Task SetFusionConfig(string config)   // not properly async
        {
            SetCursorBusy();
            Application.DoEvents();
            List<ComboBox> cBoxes = GetNationComboBoxes();
            List<int> indexes = ConvertConfigToList(config);
            var nations = await GetNationsAsync();

            for (int i = 0; i < cBoxes.Count; i++)
            {
                cBoxes[i].Parent.SuspendLayout();

                cBoxes[i].DataSource = (NationAlphabetical[])nations.Clone(); // have to clone to avoid referencing same data
                cBoxes[i].SelectedIndex = indexes[i];
                cBoxes[i].Tag = -1;   // otherwise e.g., export can have problems due to mismatch between tag and state

                cBoxes[i].Parent.ResumeLayout();
                Application.DoEvents();
            }
            SetCursorNotBusy();
        }

        // This implementation is a little messy and could be cleaned up, but the performance is still okay because it's read not write
        private string GetFusionConfig()
        {
            SetCursorBusy();
            Application.DoEvents();
            string config = "";
            int i = 0;

            foreach (Control child in this.Controls.Find("NationPowersPanel", true))
            {
                foreach (Control grandchild in child.Controls)
                {
                    int j = 0;
                    foreach (ComboBox comboBox in grandchild.Controls)
                    {
                        int num;
                        // combobox datasource might not be fully populated yet if the user hasn't interacted with it
                        if ((int)comboBox.Tag < 0)
                        {
                            num = comboBox.SelectedIndex;
                        }
                        else
                        {
                            num = (int)comboBox.Tag;
                        }

                        config += num.ToString("D2");    // pad to 2 digits (D = decimal i.e., base10)
                        if (j < 3)
                        {
                            config += "-";
                        }
                        j++;
                    }
                    if (i < 23)
                    {
                        config += ", ";
                    }
                    i++;
                }
            }

            SetCursorNotBusy();
            return config;
        }

        private async Task SetColumnsToRandom(int numCols, int startAt)  // not properly async
        {
            SetCursorBusy();
            Application.DoEvents();
            List<ComboBox> cBoxes = GetNationComboBoxes();
            var nations = await GetNationsAsync();
            Random rngEngine = new();

            // Can't use the original because the assembly doesn't *actually* support rise-of-maya style multi-row assignments
            //int startAt = 3;
            for (int i = 0; i < numCols; i++)
            {
                for (int j = startAt; j < cBoxes.Count; j += 4)
                {
                    cBoxes[j].Parent.SuspendLayout();

                    cBoxes[j].DataSource = (NationAlphabetical[])nations.Clone(); // have to clone to avoid referencing same data
                    cBoxes[j].SelectedIndex = rngEngine.Next(1, 25);
                    cBoxes[j].Tag = -1;   // otherwise e.g., export can have problems due to mismatch between tag and state

                    cBoxes[j].Parent.ResumeLayout();
                    Application.DoEvents();
                }
                //startAt--;
                startAt++;
            }

            SetCursorNotBusy();
        }

        private async Task PatchConfigIntoFusionExe()   // not properly async
        {
            SetCursorBusy();
            Application.DoEvents();

            int initialStart = 0xA97206;
            int initialSpan = 0xB;
            int intialTripleJump = 0x10B;
            //int tripleStart = 0xA97311;
            int tripleIntraSpan = 9;
            //int tripleInterSpan = 14;
            int greeksOffset = 3;   // I accidentally used a sextuple byte CMP instead of a triple for Greeks' third CMP, and since they're early it's tedious to correct

            // Because the user inputs in alphabetical order (not internally numbered order) we have to do some conversions
            string rawConfig = GetFusionConfig();
            List<(int, int, int, int)> nationRows = ConvertConfigToInternallyNumberedList(rawConfig);
            nationRows.Sort((x, y) => x.Item1.CompareTo(y.Item1));  // https://makolyte.com/csharp-using-a-list-of-tuples/

            using (var stream = File.Open(FusionPathTextBox.Text, FileMode.Open, FileAccess.ReadWrite)) // https://stackoverflow.com/a/6525687
            {
                /// it turns out there's no point patching the first column lol - the assembly isn't set up for it
                for (int i = 0; i < nationRows.Count; i++)
                {
                    stream.Position = initialStart + (i * initialSpan);
                    stream.WriteByte((byte)nationRows[i].Item1);

                    if (i > 5) stream.Position += greeksOffset;    // Greeks fix
                    stream.Position += (intialTripleJump - 1 + (i * 21));  // the TripleJump distance changes between pairs of initial-triple because the length of initial instruction groups differs from triple groups
                    stream.WriteByte((byte)nationRows[i].Item2);

                    stream.Position += (tripleIntraSpan - 1);
                    stream.WriteByte((byte)nationRows[i].Item3);

                    stream.Position += (tripleIntraSpan - 1);
                    stream.WriteByte((byte)nationRows[i].Item4);
                }
            }

            SetCursorNotBusy();
        }

        private void RoNPathButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new();
            DialogResult result = openFileDialog.ShowDialog();

            // No validation
            if (result == DialogResult.OK)
            {
                RoNPathTextBox.Text = openFileDialog.FileName;
                SetFusionPath(RoNPathTextBox.Text);
            }
        }

        private void FusionPathButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new();
            DialogResult result = openFileDialog.ShowDialog();

            // No validation
            if (result == DialogResult.OK)
            {
                FusionPathTextBox.Text = openFileDialog.FileName;
            }
        }

        private async void InstallButton_Click(object sender, EventArgs e)  // not properly async
        {
            // Check that we have source and destination paths (this doesn't validate them!)
            if (string.IsNullOrEmpty(RoNPathTextBox.Text) || string.IsNullOrEmpty(FusionPathTextBox.Text))
            {
                string title = "File paths missing";
                string msg = "File path for the RoN game .exe is required. The file path for the generated Fusion exe will also be based on this path."
                    + "\n\nThis path can be selected by using the \"...\" button.";
                MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            LoadingText.Visible = true;
            InstallButton.Text = "Please wait...";
            InstallButton.Enabled = false;
            SetCursorBusy();
            Application.DoEvents();

            // Handle non-LAA and LAA RoN exes
            bool ronHashMatches = RonExeHashMatches(false);
            bool laaHashMatches = RonExeHashMatches(true);
            if (!ronHashMatches && !laaHashMatches)
            {
                MessageBox.Show("Incompatible riseofnations.exe file. Only unmodified 00.2024.06.2000 (June 2024) is supported (LAA / \"4GB patch\" is okay).");

                LoadingText.Visible = false;
                InstallButton.Text = "Generate patchable game exe";
                Cursor.Current = Cursors.Default;
                return;
            }

            if (await CreateFusionExe(laaHashMatches))
            {
                await InitializeComboGroupsAsync();

                EnableMiddleButtons();
                ApplyButton.Enabled = true;
                LoadingText.Visible = false;
                LabelBaseNation.Visible = true;
                LabelNationPowers.Visible = true;
                NationsFlowLayoutPanel.Enabled = true;
            }
            else
            {
                LoadingText.Visible = false;
                InstallButton.Enabled = true;
            }

            InstallButton.Text = "Generate patchable game exe";
            SetCursorNotBusy();
        }

        private void LoadBaselineButton_Click(object sender, EventArgs e)
        {
            string baseline = "01-01-00-00, 02-02-00-00, 03-03-00-00, 04-04-00-00, 05-05-00-00, 06-06-00-00,"
                            + "07-07-00-00, 08-08-00-00, 09-09-00-00, 10-10-00-00, 11-11-00-00, 12-12-00-00,"
                            + "13-13-00-00, 14-14-00-00, 15-15-00-00, 16-16-00-00, 17-17-00-00, 18-18-00-00,"
                            + "19-19-00-00, 20-20-00-00, 21-21-00-00, 22-22-00-00, 23-23-00-00, 24-24-00-00";
            SetFusionConfig(baseline);
        }

        private void LoadSPConfigButton_Click(object sender, EventArgs e)
        {
            string spConfig = "01-01-18-12, 02-02-07-11, 03-03-15-09, 04-04-17-13, 05-05-09-03, 06-06-13-04,"
                            + "07-07-02-20, 08-08-22-14, 09-09-05-15, 10-10-12-01, 11-11-20-07, 12-12-10-18,"
                            + "13-13-06-17, 14-14-19-22, 15-15-03-05, 16-16-24-23, 17-17-04-06, 18-18-01-10,"
                            + "19-19-14-08, 20-20-14-08, 21-21-23-16, 22-22-08-19, 23-23-21-24, 24-24-16-21";
            SetFusionConfig(spConfig);
        }

        private void LoadMayaButton_Click(object sender, EventArgs e)
        {
            string baseline = "17-01-02-03, 17-04-05-06, 17-07-08-09, 17-10-11-12, 17-13-14-15, 17-16-17-18,"
                            + "17-19-20-21, 17-22-23-24, 00-00-00-00, 00-00-00-00, 00-00-00-00, 00-00-00-00,"
                            + "00-00-00-00, 00-00-00-00, 00-00-00-00, 00-00-00-00, 00-00-00-00, 00-00-00-00,"
                            + "00-00-00-00, 00-00-00-00, 00-00-00-00, 00-00-00-00, 00-00-00-00, 00-00-00-00";
            SetFusionConfig(baseline);
        }

        private void MayaButton_Hover(object sender, EventArgs e)
        {
            Cursor current = Cursor.Current;
            Cursor.Current = Cursors.No;
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            string title = "Input config";
            string msg = "To load an exported config here, paste it in then press OK. To cancel, clear the input (if any) and press cancel.";
            string userConfig = Interaction.InputBox(msg, title);

            if (!string.IsNullOrEmpty(userConfig))
            {
                SetFusionConfig(userConfig);
            }
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            string title = "Config export";
            string msg = "The exported config shown below has been copied to your clipboard!"
                       + "\n\n";
            string config = GetFusionConfig();

            MessageBox.Show(msg + config, title, MessageBoxButtons.OK);
            Clipboard.SetText(config);
        }

        private void OneRandomButton_Click(object sender, EventArgs e)
        {
            //SetColumnsToRandom(4);
            SetColumnsToRandom(1, 1);
        }

        private void TwoRandomButton_Clickk(object sender, EventArgs e)
        {
            //SetColumnsToRandom(3);
            SetColumnsToRandom(1, 2);
        }

        private void ThreeRandomButton_Click(object sender, EventArgs e)
        {
            //SetColumnsToRandom(2);
            SetColumnsToRandom(1, 3);
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            PatchConfigIntoFusionExe();

            LaunchButton.Enabled = true;
        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new(FusionPathTextBox.Text)
            {
                WorkingDirectory = Path.GetDirectoryName(FusionPathTextBox.Text)
            };
            Process.Start(startInfo);

            Application.Exit();
        }

        // Dummy handler to block accidental scroll-on-hover for the comboboxes https://stackoverflow.com/a/1883072
        void Dummy_MouseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }

        private void EnableMiddleButtons()
        {
            LoadBaselineButton.Enabled = true;
            LoadSPConfigButton.Enabled = true;
            //LoadMayaButton.Enabled = true;

            ImportButton.Enabled = true;
            ExportButton.Enabled = true;

            FirstRandomButton.Enabled = true;
            SecondRandomButton.Enabled = true;
            ThirdRandomButton.Enabled = true;
        }

        private void DisableMiddleButtons()
        {
            LoadBaselineButton.Enabled = false;
            LoadSPConfigButton.Enabled = false;
            //LoadMayaButton.Enabled = false;

            ImportButton.Enabled = false;
            ExportButton.Enabled = false;

            FirstRandomButton.Enabled = false;
            SecondRandomButton.Enabled = false;
            ThirdRandomButton.Enabled = false;
        }

        // Somehow half the buttons only work with one, and half only work with the other
        //   (even for the buttons that do basically the same thing!?!)
        private void SetCursorBusy()
        {
            Cursor.Current = Cursors.WaitCursor;
            Application.UseWaitCursor = true;
        }

        private void SetCursorNotBusy()
        {
            Cursor.Current = Cursors.Default;
            Application.UseWaitCursor = false;
        }
    }
}
