using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrantCalculator
{
    public partial class DepthForm : Form
    {
        public DepthForm(float abovedepth)
        {
            InitializeComponent();
            numericUpDownZDepth.Value = (decimal)abovedepth;
        }
    }
}
