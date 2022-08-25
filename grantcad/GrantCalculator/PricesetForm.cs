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
    public partial class PricesetForm : Form
    {
       
 
		 
		public PricesetForm()
        {
            InitializeComponent();
			cementpricetextBox.Text = DataAccess.estimator.Cement_Price.ToString();
			gravelpricetextBox.Text = DataAccess.estimator.Gravel_Price.ToString();
			limepricetextBox.Text = DataAccess.estimator.Lime_Price.ToString();
			sandpricetextBox.Text = DataAccess.estimator.Sand_Price.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
			float cp, gp, lp, sp;
			if(CheckField())
            {
				cp = (float)Convert.ToDouble(cementpricetextBox.Text.ToString());
				gp = (float)Convert.ToDouble(gravelpricetextBox.Text.ToString());
				lp = (float)Convert.ToDouble(limepricetextBox.Text.ToString());
				sp = (float)Convert.ToDouble(sandpricetextBox.Text.ToString());
				DataAccess.Update_XML_Price(cp, gp, lp, sp);
			}
			 
        }
		bool CheckField()
        {
			if (cementpricetextBox.Text.Trim() == String.Empty)
            {
				MessageBox.Show("Enter Cement Price");
				return false;
			}
			if (gravelpricetextBox.Text.Trim() == String.Empty)
			{
				MessageBox.Show("Enter Gravel Price");
				return false;
			}
			if (limepricetextBox.Text.Trim() == String.Empty)
			{
				MessageBox.Show("Enter Lime Price");
				return false;
			}
			if (sandpricetextBox.Text.Trim() == String.Empty)
			{
				MessageBox.Show("Enter Sand Price");
				return false;
			}
			return true;



		}
		 
		
	}
}
