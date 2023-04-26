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
    public partial class PanelOne : UserControl
    {
        public PanelOne()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            var firstInput = this.inputOneField.Text;
            var secondInput = this.inputTwoField.Text;

            var parent = this.Parent as UCPActivityForm;

            parent.inputOneText = firstInput;
            parent.inputTwoText = secondInput;
        }

    }
}
