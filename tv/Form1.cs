using Microsoft.VisualBasic.ApplicationServices;
using System.Threading.Channels;
using televisiors;

namespace tv
{
    public partial class Form1 : Form
    {
        Tv tv1 = new Tv();
        Tv tv2 = new Tv();

        public Form1()
        {
            InitializeComponent();

            tv1.channel = 5;
            tv1.volume = 3;

            channelValue.Text = tv1.channel.ToString();
            volumeValue.Text = tv1.volume.ToString();

            tv2.channel = 10;
            tv2.volume = 10;

            tv2_chValue.Text = tv2.channel.ToString();
            tv2_volValue.Text = tv2.volume.ToString();
        }

        private void nextChannel_Click(object sender, EventArgs e)
        {
            tv1.nextChan();
            channelValue.Text = tv1.channel.ToString();
            if (tv1.channel == 5)
            {
                tv1Screen.Image = Image.FromFile("C:/Users/gahia/source/repos/tv/channel5.jpg");
            }
            if (tv1.channel != 5)
            {
                tv1Screen.Image = null;
            }
        }

        private void tv1_on_Click(object sender, EventArgs e)
        {
            tv1.tv_on();

            if (tv1.channel == 5)
            {
                tv1Screen.Image = Image.FromFile("C:\\Users\\gahia\\source\\repos\\tv\\channel5.jpg");
            }
        }

        private void tv1_off_Click(object sender, EventArgs e)
        {
            tv1Screen.Image = null;
        }

        private void prevChannel_Click(object sender, EventArgs e)
        {
            if (tv1.channel >= 0)
            {
                tv1.prevChan();
                channelValue.Text = tv1.channel.ToString();
                if (tv1.channel == 5)
                {
                    tv1Screen.Image = Image.FromFile("C:/Users/gahia/source/repos/tv/channel5.jpg");
                }
                if (tv1.channel != 5)
                {
                    tv1Screen.Image = null;
                }
            }
        }

        private void volUp_Click(object sender, EventArgs e)
        {
            tv1.vol_up();
            volumeValue.Text = tv1.volume.ToString();
        }

        private void volDown_Click(object sender, EventArgs e)
        {
            if (tv1.volume >= 1)
            {
                tv1.vol_down();
                volumeValue.Text = tv1.volume.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tv2.nextChan();
            tv2_chValue.Text = tv2.channel.ToString();
            if (tv2.channel == 10)
            {
                tv2Screen.Image = Image.FromFile("C:\\Users\\gahia\\source\\repos\\tv\\channel10.jpg");
            }
            if (tv2.channel != 10)
            {
                tv2Screen.Image = null;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tv2.vol_up();
            tv2_volValue.Text = tv2.volume.ToString();
        }

        private void tv2_prevCh_Click(object sender, EventArgs e)
        {
            if (tv2.channel >= 0)
            {
                tv2.prevChan();
                tv2_chValue.Text = tv2.channel.ToString();
                if (tv2.channel == 10)
                {
                    tv2Screen.Image = Image.FromFile("C:\\Users\\gahia\\source\\repos\\tv\\channel10.jpg");
                }
                if (tv2.channel != 10)
                {
                    tv2Screen.Image = null;
                }
            }
        }

        private void tv2_volDown_Click(object sender, EventArgs e)
        {
            if (tv2.volume >= 1)
            {
                tv2.vol_down();
                tv2_volValue.Text = tv2.volume.ToString();
            }
        }

        private void tv2_on_Click(object sender, EventArgs e)
        {
            tv2.tv_on();

            if (tv2.channel == 10)
            {
                tv2Screen.Image = Image.FromFile("C:\\Users\\gahia\\source\\repos\\tv\\channel10.jpg");
            }
        }

        private void tv2_off_Click(object sender, EventArgs e)
        {
            tv2Screen.Image = null;
        }
    }
}