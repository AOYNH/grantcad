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
    public partial class Estimationform : Form
    {
        Control showCost;
        Shape shape;
         
        public Estimationform(Shape shape)
        {
            InitializeComponent();
            this.shape = shape;
            ShowResult();
        }
        public void ShowResult()
        {
            labelarea.Text = "Area: " + shape.Area.ToString();
            showCost = new Cost(shape);
            this.Controls.Add(showCost);
            showCost.Dock = DockStyle.Fill;
            showCost.Visible = true;
        }

        private void buttonestimateEdit_Click(object sender, EventArgs e)
        {
            this.Close();
            EditCostForm editCostForm = new EditCostForm(this.shape);
            editCostForm.ShowDialog();
        }
    }
   
}
