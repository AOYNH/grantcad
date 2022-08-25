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
    public partial class Cost : UserControl
    {
		private Shape shape;
		 
		//DataAccess MDA;

		private float cementprice;

		private float limeprice;

		private float gravelprice;

		private float sandprice;

		private int ratio;

		private float cuft;

		private float cement;

		private float gravel;

		private float sand;

		private float Lime;
		public Cost(Shape shape)
        {
            InitializeComponent();
			//MDA = mda;
			this.shape = shape;
			RefreshList();
        }
		void RefreshList()
        {

			 ratio = Calculate.ShapeRatio(shape);// shape.Cement + shape.Lime + shape.Gravel + shape.Sand;
			    cuft = Calculate.CubicFeet(shape.Area, shape.Depth);// shape.Area * shape.Depth;
			    cement = Calculate.AverageCubic(shape.Cement, ratio, cuft);// (cuft / ratio) * shape.Cement;
			    gravel = Calculate.AverageCubic(shape.Gravel, ratio, cuft);// (cuft / ratio) * shape.Gravel;
			    sand = Calculate.AverageCubic(shape.Sand, ratio, cuft);// (cuft / ratio) * shape.Sand;
			    Lime = Calculate.AverageCubic(shape.Lime, ratio, cuft);// (cuft / ratio) * shape.Lime;
			    cementprice = Calculate.MaterialPrice(cement, DataAccess.estimator.Cement_Price);// cement * DataAccess.estimator.Cement_Price;// PSF.ReadCP();
			    sandprice = Calculate.MaterialPrice(sand, DataAccess.estimator.Sand_Price);// sand * DataAccess.estimator.Sand_Price;// PSF.ReadSP();
			    gravelprice = Calculate.MaterialPrice(gravel, DataAccess.estimator.Gravel_Price);// gravel * DataAccess.estimator.Gravel_Price;// PSF.ReadGP();
			limeprice = Calculate.MaterialPrice(Lime, DataAccess.estimator.Lime_Price);// Lime * DataAccess.estimator.Lime_Price;// PSF.ReadLP();
			float totalestimate = cementprice + sandprice + gravelprice + limeprice;
			shape.price = totalestimate;
			costview.SuspendLayout();
			costview.Items.Clear();
			ListViewItem listViewItem = new ListViewItem();
			listViewItem = this.costview.Items.Add(shape.Name);
			listViewItem.SubItems.Add(this.cement.ToString().TrimEnd('0') + " lb");
			listViewItem.SubItems.Add(this.gravel.ToString().TrimEnd('0') + " Cuft");
			listViewItem.SubItems.Add(this.sand.ToString().TrimEnd('0') + " Sud");
			listViewItem.SubItems.Add(this.Lime.ToString().TrimEnd('0') + " Cuft");
			listViewItem.SubItems.Add(this.cuft.ToString());
			listViewItem.SubItems.Add(this.shape.Cement.ToString() + " : " + this.shape.Gravel.ToString() + " : " + this.shape.Sand.ToString() + " : " + shape.Lime.ToString());
			listViewItem.SubItems.Add(totalestimate.ToString());
			costview.ResumeLayout();
			 
		}
    }
}
