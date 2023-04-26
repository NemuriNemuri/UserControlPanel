using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class PanelTwo : UserControl
    {
        

        public PanelTwo()
        {
            InitializeComponent();
        }

        private void inputOneField_TextChanged(object sender, EventArgs e)
        {
            var input = inputOneField.Text;

            var parent = this.Parent as UCPActivityForm;

            parent.inputOneText = input;
        }

        private void inputTwoField_TextChanged(object sender, EventArgs e)
        {
            var input = inputTwoField.Text;

            var parent = this.Parent as UCPActivityForm;

            parent.inputTwoText = input;
        }
    }
}
