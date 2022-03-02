using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace GifConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Image img;
        ImageList img_list = new ImageList();

        private void btn_Import_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "GIF(*.gif) |" + "*.gif";
            string img_path;
            if (ofd.ShowDialog()==DialogResult.OK)
            {
                img_path = ofd.FileName;
                pic_Display.Image = new Bitmap(img_path);
            }
        }

        private void btn_Retrive_Click(object sender, EventArgs e)
        {
            img = pic_Display.Image;
            FrameDimension dim = new FrameDimension(img.FrameDimensionsList[0]);
            int frame_count = img.GetFrameCount(dim);
            lbl_Frames.Text = "Frames: " + frame_count.ToString();
            for(int i = 0; i< frame_count; i++)
            {
                img.SelectActiveFrame(new FrameDimension(img.FrameDimensionsList[0]), i);
                img_list.ImageSize = new Size(100, 100);
                listView1.LargeImageList = img_list;
                ListViewItem item = new ListViewItem();
                listView1.Items.Add(item);
            }
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult dr = fbd.ShowDialog();

            if(dr == DialogResult.OK)
            {
                string fp = fbd.SelectedPath;
                int index=1;
                foreach (Image frm in img_list.Images)
                {
                    string path = Path.Combine(fp,string.Format("Sprite-{0}.png", index));
                    frm.Save(path);
                    index++;
                }
                MessageBox.Show("Exportado com sucesso!");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (0<listView1.SelectedItems.Count)
            {
                var item = listView1.SelectedItems[0];
                Image img = img_list.Images[item.ImageIndex];
                pic_Frame.Image = img;
            }
        }
    }
}
