using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaAndPerimeter
{
    public partial class AreaAndPerimeter : Form
    {
        public AreaAndPerimeter()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            decimal length = Convert.ToDecimal(LengthTextBox.Text);
            decimal width = Convert.ToDecimal(WidthTextBox.Text);
            decimal area = length * width;
            decimal perimeter = length * 2 + width * 2;
            AreaTextBox.Text = area.ToString();
            PerimeterTextBox.Text = perimeter.ToString();
        }
    }
}
