using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace pryEtapa1Ambordt
{
    public partial class Form1 : Form
    {

        private Point previousPoint;
        private Bitmap firmaBitmap = new Bitmap(400, 200);

        public Form1()
        {
            InitializeComponent();
            pctFirma.MouseDown += pctFirma_MouseDown;
            pctFirma.MouseMove += pctFirma_MouseMove;
            btnGuardar.Click += btnGuardar_Click;
        }

        

        private void pctFirma_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                using (Graphics g = Graphics.FromImage(firmaBitmap))
                {
                    g.DrawLine(new Pen(Color.Black, 2), previousPoint, e.Location);
                }
                pctFirma.Image = firmaBitmap;
                previousPoint = e.Location;
            }
        }

        private void pctFirma_MouseDown(object sender, MouseEventArgs e)
        {
            previousPoint = e.Location;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            pctFirma.Image = new Bitmap(pctFirma.Width, pctFirma.Height);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (pctFirma.Image != null)
            {
                string folderName = "FIRMAS";
                string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, folderName);

                // Verificar si la carpeta existe, si no, la crea
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string fileName = $"{DateTime.Now.ToString("yyyy.MM.dd.HH.mm")}.png";
                string filePath = Path.Combine(folderPath, fileName);
                pctFirma.Image.Save(filePath, ImageFormat.Png);

                MessageBox.Show("Firma guardada correctamente en: " + filePath, "Guardar Firma", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No hay una firma para guardar.", "Guardar Firma", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            
            Bitmap blankImage = new Bitmap(pctFirma.Width, pctFirma.Height);

            
            pctFirma.Image = blankImage;
        }
    }
}
