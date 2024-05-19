using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accord.Math.Wavelets;
using FontAwesome.Sharp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Watermarking
{
    public partial class Form1 : Form
    {
        private Bitmap mainImage;
        private Bitmap watermarkImage;
        private Bitmap watermarkedImage;

        //field
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        public Form1()
        {
            InitializeComponent();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 95);
            panelMenu.Controls.Add(leftBorderBtn);
            //menghilangkan control box form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private struct RGBcolors
        {
            public static System.Drawing.Color color1 = System.Drawing.Color.FromArgb(206, 187, 249);
            public static System.Drawing.Color color2 = System.Drawing.Color.FromArgb(249, 118, 176);
            public static System.Drawing.Color color3 = System.Drawing.Color.FromArgb(253, 138, 114);
            public static System.Drawing.Color color4 = System.Drawing.Color.FromArgb(95, 77, 221);
            public static System.Drawing.Color color5 = System.Drawing.Color.FromArgb(249, 88, 155);
            public static System.Drawing.Color color6 = System.Drawing.Color.FromArgb(24, 161, 251);
        }

        private void ActivateButton(object senderBtn, System.Drawing.Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = System.Drawing.Color.FromArgb(70, 49, 93);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextAboveImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleCenter;
                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = System.Drawing.Color.FromArgb(151, 57, 241);
                currentBtn.ForeColor = System.Drawing.Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = System.Drawing.Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageAboveText;
                currentBtn.ImageAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            if (lblLoading.Text == "Processing...")
            {
                MessageBox.Show("Silahkan tunggu sampai proses nya selesai");
                return;
            }
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    mainImage = new Bitmap(openFileDialog.FileName);
                    pictureBoxMain.Image = mainImage;
                }
            }
        }

        private void btnUploadWatermark_Click(object sender, EventArgs e)
        {
            if (lblLoading.Text == "Processing...")
            {
                MessageBox.Show("Silahkan tunggu sampai proses nya selesai");
                return;
            }
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    watermarkImage = new Bitmap(openFileDialog.FileName);
                    pictureBoxWatermark.Image = watermarkImage;
                }
            }
        }

        private async void btnInsertWatermark_Click(object sender, EventArgs e)
        {
            if (lblLoading.Text == "Processing...")
            {
                MessageBox.Show("Silahkan tunggu sampai proses nya selesai");
                return;
            }
            if (mainImage == null || watermarkImage == null)
            {
                MessageBox.Show("Please upload both the image and the watermark.");
                return;
            }

            lblLoading.Visible = true;
            lblLoading.Text = "Processing...";

            progressBar1.Value = 0;
            watermarkedImage = await Task.Run(() => InsertWatermarkDWT(mainImage, watermarkImage));
            pictureBoxInserted.Image = watermarkedImage;
        }

        private Bitmap InsertWatermarkDWT(Bitmap image, Bitmap watermark)
        {
            // Resize watermark to match the size of the main image
            Bitmap resizedWatermark = new Bitmap(image.Width, image.Height, PixelFormat.Format24bppRgb);
            using (Graphics g = Graphics.FromImage(resizedWatermark))
            {
                g.DrawImage(watermark, new Rectangle(0, 0, image.Width, image.Height));
            }

            double alpha = 0.009;
            Bitmap watermarkedImage = new Bitmap(image.Width, image.Height);

            for (int channel = 0; channel < 3; channel++) // For each color channel (R, G, B)
            {
                double[,] imageChannel = ConvertToChannel(image, channel);
                double[,] watermarkChannel = ConvertToChannel(resizedWatermark, channel);

                double[] flattenedImageChannel = FlattenArray(imageChannel);
                double[] flattenedWatermarkChannel = FlattenArray(watermarkChannel);

                Haar.FWT(flattenedImageChannel);
                Haar.FWT(flattenedWatermarkChannel);

                for (int i = 0; i < flattenedImageChannel.Length; i++)
                {
                    flattenedImageChannel[i] += alpha * flattenedWatermarkChannel[i];
                }

                Haar.IWT(flattenedImageChannel);

                double[,] watermarkedChannel = ReshapeArray(flattenedImageChannel, image.Width, image.Height);
                ApplyChannelToBitmap(watermarkedImage, watermarkedChannel, channel);

                Invoke(new Action(() => progressBar1.Value += 33)); // Update progress
            }
            
            if (watermarkedImage != null)
            {
                progressBar1.Value = 0;
                lblLoading.Text = "Complete...";
            }
            return watermarkedImage;
        }

        private double[,] ConvertToChannel(Bitmap bitmap, int channel)
        {
            int width = bitmap.Width;
            int height = bitmap.Height;
            double[,] channelValues = new double[width, height];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixel = bitmap.GetPixel(x, y);
                    if (channel == 0)
                    {
                        channelValues[x, y] = pixel.R;
                    }
                    else if (channel == 1)
                    {
                        channelValues[x, y] = pixel.G;
                    }
                    else
                    {
                        channelValues[x, y] = pixel.B;
                    }
                }
            }

            return channelValues;
        }

        private void ApplyChannelToBitmap(Bitmap bitmap, double[,] channel, int channelIndex)
        {
            int width = bitmap.Width;
            int height = bitmap.Height;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixel = bitmap.GetPixel(x, y);
                    int value = (int)Math.Max(0, Math.Min(255, channel[x, y]));
                    if (channelIndex == 0)
                    {
                        bitmap.SetPixel(x, y, Color.FromArgb(value, pixel.G, pixel.B));
                    }
                    else if (channelIndex == 1)
                    {
                        bitmap.SetPixel(x, y, Color.FromArgb(pixel.R, value, pixel.B));
                    }
                    else
                    {
                        bitmap.SetPixel(x, y, Color.FromArgb(pixel.R, pixel.G, value));
                    }
                }
            }
        }

        private double[] FlattenArray(double[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            double[] flattenedArray = new double[rows * cols];
            int index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    flattenedArray[index++] = array[i, j];
                }
            }
            return flattenedArray;
        }

        private double[,] ReshapeArray(double[] array, int rows, int cols)
        {
            double[,] reshapedArray = new double[rows, cols];
            int index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    reshapedArray[i, j] = array[index++];
                }
            }
            return reshapedArray;
        }

        private async void btnExtractWatermark_Click(object sender, EventArgs e)
        {
            if (lblLoading.Text == "Processing...")
            {
                MessageBox.Show("Silahkan tunggu sampai proses nya selesai");
                return;
            }
            if (watermarkedImage == null)
            {
                MessageBox.Show("Please upload the watermarked image.");
                return;
            }

            if (mainImage == null)
            {
                MessageBox.Show("Please upload the original image.");
                return;
            }
            lblLoading.Visible = true;
            lblLoading.Text = "Processing...";
            progressBar1.Value = 0;
            Bitmap extractedWatermark = await Task.Run(() => ExtractWatermarkDWT(watermarkedImage, mainImage));
            pictureBoxExtractedWM.Image = extractedWatermark;
        }

        private Bitmap ExtractWatermarkDWT(Bitmap watermarkedImage, Bitmap originalImage)
        {
            int width = watermarkedImage.Width;
            int height = watermarkedImage.Height;
            Bitmap extractedWatermark = new Bitmap(width, height);

            double alpha = 0.010;

            for (int channel = 0; channel < 3; channel++) // For each color channel (R, G, B)
            {
                double[,] lumaWatermarked = ConvertToChannel(watermarkedImage, channel);
                double[,] lumaOriginal = ConvertToChannel(originalImage, channel);

                double[] flattenedLumaWatermarked = FlattenArray(lumaWatermarked);
                double[] flattenedLumaOriginal = FlattenArray(lumaOriginal);

                Haar.FWT(flattenedLumaWatermarked);
                Haar.FWT(flattenedLumaOriginal);

                double[] extractedCoefficients = new double[flattenedLumaWatermarked.Length];
                for (int i = 0; i < flattenedLumaWatermarked.Length; i++)
                {
                    extractedCoefficients[i] = (flattenedLumaWatermarked[i] - flattenedLumaOriginal[i]) / alpha;
                }

                Haar.IWT(extractedCoefficients);

                double[,] extractedLuma = ReshapeArray(extractedCoefficients, width, height);
                ApplyChannelToBitmap(extractedWatermark, extractedLuma, channel);

                Invoke(new Action(() => progressBar1.Value += 33)); // Update progress
                
            }
            if (extractedWatermark != null)
            {
                progressBar1.Value = 0;
                lblLoading.Text = "Complete...";
            }

            return extractedWatermark;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lblLoading.Text == "Processing...")
            {
                MessageBox.Show("Silahkan tunggu sampai proses nya selesai");
                return;
            }
            if (watermarkedImage == null)
            {
                MessageBox.Show("Please insert the watermark first.");
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Image Files|*.jpg;*.jpeg";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    watermarkedImage.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                }
            }
        }

        private void UploadWatermarked_Click(object sender, EventArgs e)
        {
            if (lblLoading.Text == "Processing...")
            {
                MessageBox.Show("Silahkan tunggu sampai proses nya selesai");
                return;
            }
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    watermarkedImage = new Bitmap(openFileDialog.FileName);
                    pictureBoxWatermarked.Image = watermarkedImage;
                }
            }
        }

        

        private void btnSaveExtractedWM_Click(object sender, EventArgs e)
        {
            if (lblLoading.Text == "Processing...")
            {
                MessageBox.Show("Silahkan tunggu sampai proses nya selesai");
                return;
            }
            if (pictureBoxExtractedWM.Image == null)
            {
                MessageBox.Show("No extracted watermark to save.");
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxExtractedWM.Image.Save(saveFileDialog.FileName, ImageFormat.Png);
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (lblLoading.Text == "Processing...")
            {
                MessageBox.Show("Silahkan tunggu sampai proses nya selesai");
                return;
            }
            ActivateButton(sender, RGBcolors.color1);
            panelHome.BringToFront();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            if (lblLoading.Text == "Processing...")
            {
                MessageBox.Show("Silahkan tunggu sampai proses nya selesai");
                return;
            }
            ActivateButton(sender, RGBcolors.color1);
            panelAbout.BringToFront();
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            if (lblLoading.Text == "Processing...")
            {
                MessageBox.Show("Silahkan tunggu sampai proses nya selesai");
                return;
            }
            ActivateButton(sender, RGBcolors.color1);
            pictureBoxMain.Visible = true;
            pictureBoxWatermark.Visible = true;
            pictureBoxInserted.Visible = true;
            btnUploadImage.Visible = true;
            btnUploadWatermark.Visible = true;
            btnInsertWatermark.Visible = true;
            btnSave.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
           

            pictureBoxWatermarked.Visible = false;
            pictureBoxExtractedWM.Visible = false;
            UploadWatermarked.Visible = false;
            btnExtractWatermark.Visible = false;
            btnSaveExtractedWM.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            mainPanel.BringToFront();
            

        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            if (lblLoading.Text == "Processing...")
            {
                MessageBox.Show("Silahkan tunggu sampai proses nya selesai");
                return;
            }
            ActivateButton(sender, RGBcolors.color1);

            pictureBoxMain.Visible = true;
            pictureBoxWatermark.Visible = false;
            pictureBoxInserted.Visible = false;
            btnUploadImage.Visible = true;
            btnUploadWatermark.Visible = false;
            btnInsertWatermark.Visible = false;
            btnSave.Visible = false;
            label2.Visible = false;
            label3.Visible = false;


            pictureBoxWatermarked.Visible = true;
            pictureBoxExtractedWM.Visible = true;
            UploadWatermarked.Visible = true;
            btnExtractWatermark.Visible = true;
            btnSaveExtractedWM.Visible = true;
            label4.Visible = true;
            label5.Visible = true;

            mainPanel.BringToFront();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelHome.BringToFront();
        }
    }
}
