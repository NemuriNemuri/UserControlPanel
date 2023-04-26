using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class UCPActivityForm : Form
    {
        public UCPActivityForm()
        {
            InitializeComponent();
        }

        public string inputOneText
        {
            set 
            {
                inputOneField.Text = value;
            }
        }

        public string inputTwoText
        {
            set
            {
                inputTwoField.Text = value;
            }
        }

        private void UCPActivityForm_Load(object sender, EventArgs e)
        {
            panelOne.Hide();
            panelTwo.Hide();
        }

        private void panelOneButton_Click(object sender, EventArgs e)
        {
            emptyAllInputs();

            panelOne.Show();
            panelOne.BringToFront();

            panelTwo.Hide();
            panelTwo.InputOneField.Text = string.Empty;
            panelTwo.InputTwoField.Text = string.Empty;
        }

        private void panelTwoButton_Click(object sender, EventArgs e)
        {
            emptyAllInputs();

            panelTwo.Show();
            panelTwo.BringToFront();

            panelOne.Hide();
            panelOne.InputOneField.Text = string.Empty;
            panelOne.InputTwoField.Text = string.Empty;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            emptyAllInputs();
            panelOne.InputOneField.Text = string.Empty;
            panelOne.InputTwoField.Text = string.Empty;
            panelTwo.InputOneField.Text = string.Empty;
            panelTwo.InputTwoField.Text = string.Empty;
            this.UCPActivityForm_Load(sender, e);
        }

        private void emptyAllInputs()
        {
            inputOneField.Text = string.Empty;
            inputTwoField.Text = string.Empty;
        }
    }
}
