using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitTest3
{
    public partial class presidentForm : Form
    {
        public presidentForm()
        {
            InitializeComponent();
            

            this.timer1.Tick += new EventHandler(Timer__Tick);
        }

        private void Timer__Tick(object sender, EventArgs e)
        {
            

            if (this.toolStripProgressBar1.Value == 0)
            {
                this.timer1.Stop();
            }
        }



        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            benjaminHarrisonRadioButton.Visible = true;
            georgeWBushRadioButton.Visible = true;
            williamMcKinleyRadioButton.Visible = true;
            ronaldReaganRadioButton.Visible = true;
            dwightDEisenhowerRadioButton.Visible = true;
            georgeWashingtonRadioButton.Visible = true;
            johnAdamsRadioButton.Visible = true;
            theodoreRoodeveltRadioButton.Visible = true;
            thomasJefferesonRadioButton.Visible = true;
            franklinDRooseveltRadioButton.Visible = true;
            williamJClintonRadioButton.Visible = true;
            jamesBuchananRadioButton.Visible = true;
            franklinPierceRadioButton.Visible = true;
            barackObamaRadioButton.Visible = true;
            johnFKennedyRadioButton.Visible = true;
            martinVanBuerenRadioButton.Visible = true;
        }

        private void benjaminHarrisonRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Width = pictureBox1.Width * 2;
            pictureBox1.Height = pictureBox1.Height * 2;
            this.Cursor = Cursors.WaitCursor;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Width = pictureBox1.Width / 2;
            pictureBox1.Height = pictureBox1.Height / 2;
            this.Cursor = Cursors.Default;
        }

        private void benjaminHarrisonRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.BenjaminHarrison;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            webBrowser1.Navigate("https://en.wikipedia.org/wiki/Benjamin_Harrison");

        }

        private void franklinDRooseveltRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.FranklinDRoosevelt;
            webBrowser1.Navigate("https://en.wikipedia.org/wiki/Franklin_D._Roosevelt");
        }

        private void williamJClintonRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.WilliamJClinton;
            webBrowser1.Navigate("https://en.wikipedia.org/wiki/William_J_Clinton");

        }

        private void jamesBuchananRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.JamesBuchanan;
            webBrowser1.Navigate("https://en.wikipedia.org/wiki/James_Buchanan");

        }

        private void franklinPierceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.FranklinPierce;
            webBrowser1.Navigate("https://en.wikipedia.org/wiki/Franklin_Pierce");

        }

        private void georgeWBushRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.GeorgeWBush;
            webBrowser1.Navigate("https://en.wikipedia.org/wiki/George_W_Bush");

        }

        private void barackObamaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.BarackObama;
            webBrowser1.Navigate("https://en.wikipedia.org/wiki/Barrack_Obama");

        }

        private void johnFKennedyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.JohnFKennedy;
            webBrowser1.Navigate("https://en.wikipedia.org/wiki/John_F_Kennedy");

        }

        private void williamMcKinleyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.WilliamMcKinley;
            webBrowser1.Navigate("https://en.wikipedia.org/wiki/William_McKinley");

        }

        private void ronaldReaganRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.RonaldReagan;
            webBrowser1.Navigate("https://en.wikipedia.org/wiki/Ronal_Reagan");

        }

        private void dwightDEisenhower_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.DwightDEisenhower;
            webBrowser1.Navigate("https://en.wikipedia.org/wiki/Dwight_D_Eisenhower");

        }

        private void martinVanBuerenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.MartinVanBuren;
            webBrowser1.Navigate("https://en.wikipedia.org/wiki/Martin_Van_Buren");

        }

        private void georgeWashingtonRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.GeorgeWashington;
            webBrowser1.Navigate("https://en.wikipedia.org/wiki/George_Washington");

        }

        private void johnAdamsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.JohnAdams;
            webBrowser1.Navigate("https://en.wikipedia.org/wiki/John_Adams");

        }

        private void theodoreRoodeveltRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.TheodoreRoosevelt;
            webBrowser1.Navigate("https://en.wikipedia.org/wiki/Theodore_Roosevelt");

        }

        private void thomasJefferesonRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.ThomasJefferson;
            webBrowser1.Navigate("https://en.wikipedia.org/wiki/Thomas_Jeffereson");

        }

        private void democratRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            benjaminHarrisonRadioButton.Visible = false;
            georgeWBushRadioButton.Visible = false;
            williamMcKinleyRadioButton.Visible = false;
            ronaldReaganRadioButton.Visible = false;
            dwightDEisenhowerRadioButton.Visible = false;
            georgeWashingtonRadioButton.Visible = false;
            johnAdamsRadioButton.Visible = false;
            theodoreRoodeveltRadioButton.Visible = false;
            thomasJefferesonRadioButton.Visible = false;
            franklinDRooseveltRadioButton.Visible = true;
            williamJClintonRadioButton.Visible = true;
            jamesBuchananRadioButton.Visible = true;
            franklinPierceRadioButton.Visible = true;
            barackObamaRadioButton.Visible = true;
            johnFKennedyRadioButton.Visible = true;
            martinVanBuerenRadioButton.Visible = true;
        }

        private void republicanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
           franklinDRooseveltRadioButton.Visible = false;
           williamJClintonRadioButton.Visible = false;
           jamesBuchananRadioButton.Visible = false;
           franklinPierceRadioButton.Visible = false;
           barackObamaRadioButton.Visible = false;
           johnFKennedyRadioButton.Visible = false;
           martinVanBuerenRadioButton.Visible = false;
           georgeWashingtonRadioButton.Visible = false;
           johnAdamsRadioButton.Visible = false;
           thomasJefferesonRadioButton.Visible = false;
            benjaminHarrisonRadioButton.Visible = true;
            georgeWBushRadioButton.Visible = true;
            williamMcKinleyRadioButton.Visible = true;
            ronaldReaganRadioButton.Visible = true;
            dwightDEisenhowerRadioButton.Visible = true;    
            theodoreRoodeveltRadioButton.Visible = true;
        }

        private void democraticRepublicanRadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            franklinDRooseveltRadioButton.Visible = false;
            williamJClintonRadioButton.Visible = false;
            jamesBuchananRadioButton.Visible = false;
            franklinPierceRadioButton.Visible = false;
            barackObamaRadioButton.Visible = false;
            johnFKennedyRadioButton.Visible = false;
            martinVanBuerenRadioButton.Visible = false;
            georgeWashingtonRadioButton.Visible = false;
            johnAdamsRadioButton.Visible = false;
            thomasJefferesonRadioButton.Visible = true;
            benjaminHarrisonRadioButton.Visible = false;
            georgeWBushRadioButton.Visible = false;
            williamMcKinleyRadioButton.Visible = false;
            ronaldReaganRadioButton.Visible = false;
            dwightDEisenhowerRadioButton.Visible = false;
            theodoreRoodeveltRadioButton.Visible = false;
        }

        private void federalistRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            franklinDRooseveltRadioButton.Visible = false;
            williamJClintonRadioButton.Visible = false;
            jamesBuchananRadioButton.Visible = false;
            franklinPierceRadioButton.Visible = false;
            barackObamaRadioButton.Visible = false;
            johnFKennedyRadioButton.Visible = false;
            martinVanBuerenRadioButton.Visible = false;
            georgeWashingtonRadioButton.Visible = true;
            johnAdamsRadioButton.Visible = true;
            thomasJefferesonRadioButton.Visible = false;
            benjaminHarrisonRadioButton.Visible = false;
            georgeWBushRadioButton.Visible = false;
            williamMcKinleyRadioButton.Visible = false;
            ronaldReaganRadioButton.Visible = false;
            dwightDEisenhowerRadioButton.Visible = false;
            theodoreRoodeveltRadioButton.Visible = false;
        }
    }
}
