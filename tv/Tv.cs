using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace televisiors
{
    internal class Tv
    {
        public bool state = false;
        public int channel = 0;
        public int volume = 0;
        public int[,] resolution = { { }, { } };
        public string model = "";
        public void tv_on()
        {
            state = true;
        }
        public void tv_off()
        {
            state = false;
        }
        public void vol_up()
        {
            volume += 1;
        }
        public void vol_down()
        {
            volume -= 1;
        }
        public void nextChan()
        {
            channel += 1;
        }
        public void prevChan()
        {
            channel -= 1;
        }
    }
}