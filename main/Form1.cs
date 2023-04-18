namespace main
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Image = bmp;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            bmp.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureBox1.Image = bmp;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            bmp.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureBox1.Image = bmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);

            //get image dimension
            int width = bmp.Width;
            int height = bmp.Height;

            Bitmap gbmp = new Bitmap(bmp);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color p = bmp.GetPixel(x, y);

                    if (p.G > p.R && p.G > p.B)
                    {
                        gbmp.SetPixel(x, y, p);
                    }
                    else
                    {
                        gbmp.SetPixel(x, y, Color.Black);
                    }

                }
            }

            pictureBox1.Image = gbmp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);

            //get image dimension
            int width = bmp.Width;
            int height = bmp.Height;

            Bitmap gbmp = new Bitmap(bmp);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color p = bmp.GetPixel(x, y);

                    int a = p.A;
                    int b = 255 - p.B;
                    int c = 255 - p.R;
                    int d = 255 - p.G;

                    gbmp.SetPixel(x, y, Color.FromArgb(a, c, d, b));

                }
            }

            pictureBox1.Image = gbmp;
        }
    }
}