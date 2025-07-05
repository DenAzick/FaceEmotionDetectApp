using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceEmotionDetectApp.Forms
{
    public partial class UserInfoForm : Form
    {
        public UserInfoForm(Image ptz, Image panorama)
        {
            InitializeComponent();

            pictureBox_PTZ_Live_Info.Image = ptz != null ? (Image)ptz.Clone() : null;
            pictureBox_Panorama_Live_Info.Image = panorama != null ? (Image)panorama.Clone() : null;

            pictureBox_PTZ.Image =  ptz != null ? (Image)ptz.Clone() : null;

            pictureBox_Panorama.Image = panorama != null ? (Image)panorama.Clone() : null;

            pictureBox_PTZ_Live_Info.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox_Panorama_Live_Info.SizeMode = PictureBoxSizeMode.CenterImage;

        }

        
    }
}
