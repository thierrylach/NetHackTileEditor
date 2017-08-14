using System;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace NetHackTileEditor
{
    public partial class Form1 : Form
    {
        #region Constants
        private const int X_SIZE = 16;
        private const int Y_SIZE = 16;
        private const int NUM_COLORS = 17;
        #endregion

        #region Properties
        private RadioButton[] colorButtons = new RadioButton[NUM_COLORS];

        private Button[,] imageButtons = new Button[X_SIZE, Y_SIZE];

        private Color selectedColor = Color.FromArgb(71, 108, 108 );
        private string selectedColorCode = ".";
        #endregion

        #region Constructors
        public Form1()
        {
            InitializeComponent();

            CreateColorButtons();

            CreateImageButtons();

            SetButtonColors();

            SetSelectedColor(colorButtons[0]);

            GenerateOutput();
        }
        #endregion

        #region Callbacks
        #region Form Callbacks
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void form1_OnPaint(object sender, PaintEventArgs e)
        {
        }
        #endregion

        #region ColorButton callbacks
        private void colorSelected_CheckedChanged(object sender, EventArgs e)
        {
            SetSelectedColor((RadioButton)sender);

            GenerateOutput();
        }
        private void colorSelected_MouseHover(object sender, EventArgs e)
        {

       }
        #endregion

        #region ImageButton Callbacks
        private void imageButton_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Tag = selectedColorCode;
            button.BackColor = selectedColor;
            GenerateOutput();
        }
        #endregion

        #region Action button callbacks
        private void buttonClear_Click(object sender, EventArgs e)
        {
            SetSelectedColor(colorButtons[0]);

            for (int y = 0; y < Y_SIZE; y++)
            {
                for (int x = 0; x < X_SIZE; x++)
                {
                    imageButtons[x, y].BackColor = selectedColor;
                    imageButtons[x, y].Tag = selectedColorCode;
                }
            }
            GenerateOutput();
        }
        #endregion

        #region Background selection callbacks
        private void normalBackgroundCheckbox_Changed(object sender, EventArgs e)
        {
            colorButtons[0].BackColor = normalBackgroundCheckbox.Checked ? Color.FromArgb(71, 108, 108) : Color.Silver;

            #region Scan the image buttons and change any that have the background color
            for(int y = 0; y < Y_SIZE; y++)
            {
                for (int x = 0; x < X_SIZE; x++)
                {
                    if (imageButtons[x, y].Tag.Equals(colorButtons[0].Tag))
                    {
                        imageButtons[x, y].BackColor = colorButtons[0].BackColor;
                        imageButtons[x, y].Invalidate();
                    }
                }
            }
            SetSelectedColor(colorButtons[0]);
            #endregion

            GenerateOutput();
        }
        #endregion

        #region Lock callback
        private void lockedCheckbox_CheckChanged(object sender, EventArgs e)
        {
            buttonImport.Enabled = !lockedCheckbox.Checked;
            textOutput.ReadOnly = lockedCheckbox.Checked;
            for (int y = 0; y < Y_SIZE; y++)
            {
                for(int x = 0; x < X_SIZE; x++)
                {
                    imageButtons[x, y].Enabled = lockedCheckbox.Checked;
                }
            }
        }
        #endregion

        #region Text area callbacks
        private void textOutput_KeyDown(object sender, KeyEventArgs e)
        {
            SetControlStatus();
        }

        private void textOutput_KeyPress(object sender, KeyPressEventArgs e)
        {
            SetControlStatus();
        }

        private void textOutput_KeyUp(object sender, KeyEventArgs e)
        {
            SetControlStatus();
        }

        private void textOutput_TextChanged(object sender, EventArgs e)
        {
            SetControlStatus();
        }
        #endregion

        #region Import callbacks
        private void buttonImport_Clicked(object sender, EventArgs e)
        {
            if (IsTextAreaValid())
            {
                ImportTextArea();
            }
        }
        #endregion

        #endregion

        #region Initialization routines
        private void CreateImageButtons()
        {
            for (int y = 0; y < Y_SIZE; y++)
            {
                for (int x = 0; x < X_SIZE; x++)
                {
                    Button button = new Button();
                    button.BackColor = Color.FromArgb(71, 108, 108);
                    button.Tag = ".";
                    button.Location = new Point(x * 20, y * 20);
                    button.Margin = new Padding(0);
                    button.MaximumSize = new Size(20, 20);
                    button.MinimumSize = new Size(20, 20);
                    button.Name = string.Format("imageButton_{0}_{1}", x, y);
                    button.Size = new Size(20, 20);
                    button.TabIndex = 0;
                    button.TabStop = false;
                    button.UseVisualStyleBackColor = false;
                    button.Click += imageButton_Clicked;
                    imageButtons[x, y] = button;
                    this.panel1.Controls.Add(button);
                }
            }
        }

        private void CreateColorButtons()
        {
            int pos = 0;
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 6; x++)
                {
                    if (pos < NUM_COLORS)
                    {
                        RadioButton button = new RadioButton();
                        button.Appearance = System.Windows.Forms.Appearance.Button;
                        button.AutoSize = true;
                        button.BackColor = Color.FromArgb(0, 0, 0);
                        button.Location = new Point(10 + (x * 32), 20 + (y * 32));
                        button.MaximumSize = new Size(32, 32);
                        button.MinimumSize = new Size(32, 32);
                        button.Name = string.Format("colorSelected_{0}_{1}", x, y);
                        button.Size = new Size(32, 32);
                        button.TabIndex = 0;
                        button.Text = "";
                        button.Tag = ".";
                        button.UseVisualStyleBackColor = false;
                        button.CheckedChanged += new EventHandler(this.colorSelected_CheckedChanged);
                        button.MouseHover += new EventHandler(this.colorSelected_MouseHover);
                        colorButtons[pos++] = button;
                        colorGroup.Controls.Add(button);
                    }
                }
            }
        }
        private void SetButtonColors()
        {
            SetButtonColor(0, ".", 71, 108, 108);
            SetButtonColor(1, "A", 0, 0, 0);
            SetButtonColor(2, "B", 0, 182, 255);
            SetButtonColor(3, "C", 255, 108, 0);
            SetButtonColor(4, "D", 255, 0, 0);
            SetButtonColor(5, "E", 0, 0, 255);
            SetButtonColor(6, "F", 0, 145, 0);
            SetButtonColor(7, "G", 108, 255, 0);
            SetButtonColor(8, "H", 255, 255, 0);
            SetButtonColor(9, "I", 255, 0, 255);
            SetButtonColor(10, "J", 145, 71, 0);
            SetButtonColor(11, "K", 204, 79, 0);
            SetButtonColor(12, "L", 255, 182, 145);
            SetButtonColor(13, "M", 237, 237, 237);
            SetButtonColor(14, "N", 255, 255, 255);
            SetButtonColor(15, "O", 215, 215, 215);
            SetButtonColor(16, "P", 108, 145, 182);
            //SetButtonColor(17, "Q", 18, 18, 18);
            //SetButtonColor(18, "R", 54, 54, 54);
            //SetButtonColor(19, "S", 73, 73, 73);
            //SetButtonColor(20, "T", 82, 82, 82);
            //SetButtonColor(21, "U", 205, 205, 205);
            //SetButtonColor(22, "V", 104, 104, 104);
            //SetButtonColor(23, "W", 131, 131, 131);
            //SetButtonColor(24, "X", 140, 140, 140);
            //SetButtonColor(25, "Y", 149, 149, 149);
            //SetButtonColor(26, "Z", 195, 195, 195);
            //SetButtonColor(27, "0", 100, 100, 100);
            //SetButtonColor(28, "1", 72, 108, 108);

        }

        private void SetSelectedColor(RadioButton button)
        {
            selectedColor = button.BackColor;
            selectedColorCode = (string)button.Tag;
        }
        #endregion

        #region Helper routines
        private void SetButtonColor(int number, string text, int r, int g, int b)
        {
            colorButtons[number].Tag = text;
            colorButtons[number].Text = "";
            colorButtons[number].BackColor = Color.FromArgb(r,g,b);
        }
        #endregion

        #region Output routines
        private void GenerateOutput()
        {
            FillText();
            DrawThumbnails();
            PopulateStatusBar();
            SetControlStatus();
        }

        private void FillText()
        {
            string s = "";
            for (int y = 0; y < Y_SIZE; y++)
            {
                s += "  ";
                for (int x = 0; x < X_SIZE; x++)
                {
                    s += imageButtons[x, y].Tag;
                }
                if (y < 15)
                {
                    s += "\r\n";
                }
            }
            textOutput.Text = s;
        }

        private void PopulateStatusBar()
        {
            string name = "";

            #region Find name if possible
            var predefined = typeof(Color).GetProperties(BindingFlags.Public | BindingFlags.Static);
            var match = (from p in predefined where ((Color)p.GetValue(null, null)).ToArgb() == selectedColor.ToArgb() select (Color)p.GetValue(null, null));
            if (match.Any())
            {
                name = match.First().Name;
            }
            #endregion

            toolStripStatusLabel1.Text = string.Format("RGB({0},{1},{2}) {3}",
                selectedColor.R, selectedColor.G, selectedColor.B, name);
        }

        private void DrawThumbnails()
        {
            DrawThumbnail1();
            DrawThumbnail2();
        }

        private void DrawThumbnail1()
        {
            Bitmap bitmap = new Bitmap(thumbnail.Width, thumbnail.Height);
            Rectangle rectangle = thumbnail.DisplayRectangle;

            using (Graphics graphics = thumbnail.CreateGraphics())
            {
                for (int y = 0; y < Y_SIZE; y++)
                {
                    for (int x = 0; x < X_SIZE; x++)
                    {
                        bitmap.SetPixel(x, y, imageButtons[x, y].BackColor);
                    }
                }
            }
            thumbnail.BackgroundImage = bitmap;
        }

        private void DrawThumbnail2()
        {
            Bitmap bitmap = new Bitmap(thumbnail2.Width, thumbnail2.Height);
            Rectangle rectangle = thumbnail2.DisplayRectangle;

            using (Graphics graphics = thumbnail2.CreateGraphics())
            {
                for (int y = 0; y < Y_SIZE; y++)
                {
                    for (int x = 0; x < X_SIZE; x++)
                    {
                        bitmap.SetPixel(x * 2, y * 2, imageButtons[x, y].BackColor);
                        bitmap.SetPixel(x * 2, (y * 2) + 1, imageButtons[x, y].BackColor);
                        bitmap.SetPixel((x * 2) + 1, y * 2, imageButtons[x, y].BackColor);
                        bitmap.SetPixel((x * 2) + 1, (y * 2) + 1, imageButtons[x, y].BackColor);
                    }
                }
            }
            thumbnail2.BackgroundImage = bitmap;

        }
        #endregion

        #region Text area support
        private void SetControlStatus()
        {
            if (IsTextAreaValid())
            {
                buttonImport.Enabled = true;
                lockedCheckbox.Enabled = true;
            }
            else
            {
                buttonImport.Enabled = false;
                lockedCheckbox.Enabled = false;
            }
        }

        private bool IsTextAreaValid()
        {
            // Must have exactly 16 lines
            if (textOutput.Lines.Length != Y_SIZE)
            {
                return false;
            }

            // Check each line
            for (int y = 0; y < Y_SIZE; y++)
            {
                string line = textOutput.Lines[y].Trim();
                // must have 16 non-space characters
                if (line.Trim().Length != X_SIZE)
                {
                    return false;
                }

                // Each character must be a valid color code
                for (int x = 0; x < X_SIZE; x++)
                {
                    string chr = line.Substring(x, 1);
                    bool found = false;
                    for (int i = 0; i < NUM_COLORS; i++)
                    {
                        //Debug.WriteLine(string.Format("[{0},{1}] {2}: {3}", x, y, chr, colorButtons[i].Tag));
                        if (chr.Equals(colorButtons[i].Tag))
                        {
                            found = true;
                        }
                        else if ("QRSTUVWXYZ01".Contains(chr))
                        {
                            // Handle initial mis-mapping
                            found = true;
                        }
                    }
                    if (!found)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        #endregion

        #region Import functionality
        private void ImportTextArea()
        {
            if (IsTextAreaValid())
            {
                for (int y = 0; y < Y_SIZE; y++)
                {
                    string line = textOutput.Lines[y].Trim();
                    for (int x = 0; x < X_SIZE; x++)
                    {
                        string tag = line.Substring(x, 1);
                        Button imageButton = imageButtons[x, y];
                        imageButton.Tag = tag;
                        for (int i = 0; i < NUM_COLORS; i++)
                        {
                            if (tag.Equals(colorButtons[i].Tag))
                            {
                                imageButton.BackColor = colorButtons[i].BackColor;
                            }
                            else if ("QRSTUVWXYZ01".Contains(tag))
                            {
                                // Handle initial mis-mapping
                                imageButton.BackColor = colorButtons[0].BackColor;
                            }
                        }
                    }
                }
            }
            GenerateOutput();
        }
        #endregion
    }
}
