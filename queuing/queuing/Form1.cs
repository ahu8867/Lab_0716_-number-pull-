using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace queuing
{
    public partial class Form1 : Form
    {
        device Device = new device();
        counter Counter = new counter();
        mainserver MainServer = new mainserver();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PullButton_Click(object sender, EventArgs e)
        {
            Device.pull();
            ShowRemainNumLabel.Text = Convert.ToString(Device.show());
            NowNum.Text = Convert.ToString(counter.callNum+1);
            MainServer.save();
            counter.callNum++;
        }

        private void ShowRemainNumLabel_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Counter1NumLabel.Text = Convert.ToString(MainServer.wait[0]);
            Counter.CallNext();
            ShowRemainNumLabel.Text = Convert.ToString(Device.show());
            MainServer.delete();
            if (counter.RemainNum==0)
            {
                Counter1Button.Enabled = false;
            }
            if (counter.RemainNum == 0)
            {
                Counter2Button.Enabled = false;
            }
        }

        private void Counter2Button_Click(object sender, EventArgs e)
        {
            Counter2NumLabel.Text = Convert.ToString(MainServer.wait[0]);
            Counter.CallNext();
            ShowRemainNumLabel.Text = Convert.ToString(Device.show());
            MainServer.delete();
            if (counter.RemainNum == 0)
            {
                Counter1Button.Enabled = false;
            }
            if (counter.RemainNum == 0)
            {
                Counter2Button.Enabled = false;
            }
        }
    }
}
