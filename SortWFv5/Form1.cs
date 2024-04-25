using Guna.UI2.WinForms;
using SortWFv5.Sorting_Algorithms;
using System;
using System.Diagnostics;
using System.Windows.Forms;



namespace SortWFv5
{
    public partial class Form1 : Form
    {
        bool dragging = false; //
        Point dragCursorPoint; // - for dragging form
        Point dragFormPoint;   //
        
        public static int count = 50;
        private List<int> array = new List<int>();
        Sort currentSort;

        private Bitmap bitmap;
        private Graphics g;
        private int weight = 850; //-w PictureBox
        private int height = 530; //-h PictureBox

        private int ShuffleIterate = 0;
        private Stopwatch sw = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckCurrentSort();
            Linear();
        }
        
        #region Iterations
        private void IterateSort()
        {
            labelTime.Text = $"Time: {sw.Elapsed.Seconds}:{sw.Elapsed.Milliseconds}";
            array = currentSort.Run();
            if (currentSort.hasFinished())
            {
                sw.Stop();

                Draw(-1, -1, -1);
                timer1.Stop();
                ButtonSort.Visible = true;
                ButtonStop.Visible = false;
                ButtonShuffle.Enabled = true;
                guna2ComboBoxF.Enabled = true;
                guna2ComboBoxSort.Enabled = true;
            }
            else
                Draw(currentSort.getI(), currentSort.getJ(), currentSort.getK());
        }
        private void IterateShuffle()
        {
            Random random = new Random();
            int n = array.Count - 1;
            int k = random.Next(n + 1);
            int tmp = array[k];
            array[k] = array[n];
            array[n] = tmp;
            Draw(-1, -1, -1);
            ShuffleIterate++;
            if (ShuffleIterate == 100)
            {
                timer2.Stop();
                ShuffleIterate = 0;
                ButtonSort.Enabled = true;
                ButtonStop.Enabled = true;
            }
        }
        #endregion

        #region DrawingManager
        private void Draw(int iPos, int jPos, int kPos)
        {
            UpdateDrawing();
            Brush colour;
            for (int i = 0; i < array.Count; i++)
            {
                // primary pointer
                if (i == iPos)
                    colour = Brushes.Crimson;
                // secondary pointer
                else if (i == jPos)
                    colour = Brushes.DodgerBlue;
                // tertiary pointer
                else if (i == kPos)
                    colour = Brushes.YellowGreen;
                // for other points
                else
                {
                    double proportion = (double)(array[i] - 1) / (50 - 1);

                    Color minColor = Color.DarkGray; // - color min Value
                    Color maxColor = Color.DarkSeaGreen; // - color max Value

                    int r = (int)(minColor.R + proportion * (maxColor.R - minColor.R));
                    int g = (int)(minColor.G + proportion * (maxColor.G - minColor.G));
                    int b = (int)(minColor.B + proportion * (maxColor.B - minColor.B));

                    colour = new SolidBrush(Color.FromArgb(r, g, b));
                }


                int rectWeight = weight / array.Count;
                int rectHeight = 10 + array[i] * (530 / array.Count);

                int x = i * rectWeight;
                int y = height - rectHeight;

                g.FillRectangle(colour, x, y, rectWeight, rectHeight);
                g.DrawRectangle(Pens.White, x, y, rectWeight, rectHeight);
            }
            guna2PictureBoxVisualization.Image = bitmap;
        }
        private void UpdateDrawing()
        {
            bitmap = new Bitmap(weight, height);
            g = Graphics.FromImage(bitmap);
        }
        #endregion

        #region Buttons/Controls
        private void ButtonSort_Click(object sender, EventArgs e)
        {
            sw.Restart();
            sw.Start();
            ButtonSort.Visible = false;
            ButtonStop.Visible = true;
            ButtonShuffle.Enabled = false;
            guna2ComboBoxF.Enabled = false;
            guna2ComboBoxSort.Enabled = false;
            CheckCurrentSort();
            timer1.Start();
        }

        private void ButtonShuffle_Click(object sender, EventArgs e)
        {
            timer2.Start();
            ButtonSort.Enabled = false;
            ButtonStop.Enabled = false;
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            ButtonSort.Visible = true;
            ButtonStop.Visible = false;
            ButtonShuffle.Enabled = true;
            guna2ComboBoxF.Enabled = true;
            guna2ComboBoxSort.Enabled = true;
            Draw(-1, -1, -1);
            timer1.Stop();
        }

        private void iconButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButtonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        #endregion
        
        private void guna2ComboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckCurrentSort();
        }
        private void CheckCurrentSort()
        {
            switch (guna2ComboBoxSort.SelectedIndex)
            {
                case 0:
                    currentSort = new BubbleSort(array); break;
                case 1:
                    currentSort = new InsertionSort(array); break;
                case 2:
                    currentSort = new SelectionSort(array); break;
                case 3:
                    currentSort = new MergeSort(array); break;
                case 4:
                    currentSort = new PatienceSort(array); break;
                case 5:
                    currentSort = new CocktailShakerSort(array); break;
                case 6:
                    currentSort = new DoubleSelectionSort(array); break;
                default: break;
            }
            labelSortDesc.Text = $"Sort description: \n{currentSort.sortDesc}";
        }

        private void guna2ComboBoxF_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (guna2ComboBoxF.SelectedIndex)
            {
                case 0:
                    Linear(); break;
                case 1:
                    Logarithm(); break;
                case 2:
                    Exponential(); break;
                case 3:
                    Logistical(); break;
                case 4:
                    Random(); break;
                default: break;
            }
        }

        #region Array filling functions
        private void Linear()
        {
            array.Clear();
            for (int i = 0; i < count; i++)
            {
                array.Add(i + 1);
            }
            Draw(-1, -1, -1);
        }
        private void Logarithm()
        {
            array.Clear();
            const double minValue = 1.0;
            const double maxValue = 50.0;
            const double c = 0.30;

            double scaleFactor = (maxValue - minValue) / (Math.Log(count + c) - Math.Log(1 + c));
            
            for (int i = 0; i < count; i++)
            {
                double val = Math.Log(i + c + 1) * scaleFactor;
                array.Add((int)Math.Round(val));
            }
            Draw(-1, -1, -1);
        }
        private void Random()
        {
            array.Clear();
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                array.Add(rnd.Next(1, count + 1));
            }
            Draw(-1, -1, -1);
        }
        private void Exponential()
        {
            array.Clear();
            const double minValue = 1.0;
            const double maxValue = 50.0;
            const double c = 0.5;

            for (int i = 0; i < count; i++)
            {
                double val = Math.Pow(50.0, (double)i / (count - 1)) * minValue;
                array.Add((int)Math.Round(val));
            }
            Draw(-1, -1, -1);
        }
        private void Logistical()
        {
            array.Clear();
            double a = Math.PI;  // Множник
            double b = Math.PI;  // Фазовий зсув на pi для початку від найменшого

            const double minValue = 1.0;
            const double maxValue = 50.0;

            for (int i = 0; i < count; i++)
            {
                double val = 1 + Math.Cos(a * i / count + b);
                array.Add((int)(minValue + (val / 2) * (maxValue - minValue)));
            }
            Draw(-1, -1, -1);
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            IterateSort();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            IterateShuffle();
        }
    }
}
