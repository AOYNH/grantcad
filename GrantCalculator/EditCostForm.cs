using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrantCalculator
{
    public partial class EditCostForm : Form
    {
        Shape shape;
        public EditCostForm(Shape sh)
        {
            InitializeComponent();
            shape = sh;
            textBoxeditarea.Text = sh.Area.ToString();
            textBoxeditname.Text = sh.Name.ToString();
            textBoxeditprice.Text = sh.price.ToString();
            comboBoxeditcement.Text = sh.Cement.ToString();
            comboBoxeditgravel.Text = sh.Gravel.ToString();
            comboBoxeditsand.Text = sh.Sand.ToString();
            comboBoxeditlime.Text = sh.Lime.ToString();
             
        }
		public void FixData()
		{
            if (textBoxeditarea.Text.Trim() != String.Empty)
                shape.Area = (float)Convert.ToDouble(textBoxeditarea.Text.ToString());
            if (textBoxeditname.Text.Trim() != String.Empty)
                shape.Name = textBoxeditname.Text.ToString();
            shape.Cement = Convert.ToInt32(comboBoxeditcement.Text.ToString());
            shape.Gravel = Convert.ToInt32(comboBoxeditgravel.Text.ToString());
            shape.Sand = Convert.ToInt32(comboBoxeditsand.Text.ToString());
            shape.Lime = Convert.ToInt32(comboBoxeditlime.Text.ToString());
            DataAccess.Update_XML_Ratio(shape.Cement, shape.Gravel, shape.Lime, shape.Sand);
        }
         
           
       
        private void buttoneditsave_Click(object sender, EventArgs e)
        {
            FixData();
          
        }

        private void textBoxeditarea_KeyPress(object sender, KeyPressEventArgs e)
        {
             if(!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar)&&e.KeyChar!='.')
            {
                e.Handled = true;
            }
        }
    }
}
