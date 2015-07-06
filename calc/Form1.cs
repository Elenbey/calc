using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        public double ValOne;
        public double ValTwo;
        public double Result;

        
        public Form1()
        {
            InitializeComponent();
        }

        private void InputLable_Click(object sender, EventArgs e)
        {

        }

        private void InpValOne_TextChanged(object sender, EventArgs e)
        {
            string input = InpValOne.Text;
            if (input.Length == 0)
                this.ValOne = 0;
            else
                this.ValOne =  Convert.ToDouble(input);
        }

        private void InpValTwo_TextChanged(object sender, EventArgs e)
        {
            string input = InpValTwo.Text;
            if (input.Length == 0)
                this.ValTwo = 0;
            else
                this.ValTwo = Convert.ToDouble(input);
        }

        private void Output_TextChanged(object sender, EventArgs e)
        {
            //Output.Text=
        }

        private void ButtMltp_Click(object sender, EventArgs e)
        {
            this.Result = this.ValOne * this.ValTwo;
            Output.Text = this.Result.ToString();
            this.Reset();

        }

        private void ButtDiv_Click(object sender, EventArgs e)
        {
            this.Result = this.ValOne  / this.ValTwo;
            Output.Text = this.Result.ToString();
            this.Reset();

        }

        private void ButtAdd_Click(object sender, EventArgs e)
        {
            this.Result = this.ValOne + this.ValTwo;
            Output.Text = this.Result.ToString();
            this.Reset();

        }

        private void ButtSubr_Click(object sender, EventArgs e)
        {
            this.Result = this.ValOne - this.ValTwo;
            Output.Text = this.Result.ToString();
            this.Reset();
        }

        public void Reset()
        {
            InpValOne.Text = "";
            InpValTwo.Text = "";
        }

       
    }
}
