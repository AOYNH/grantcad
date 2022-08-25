using System;
 
using System.Data;
 
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GrantCalculator
{
    public partial class ReportForm : Form
    {
        ShapesCollection shapes;
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
        public ReportForm(ShapesCollection shapes)
        {
            InitializeComponent();
            this.shapes = shapes;
            Bind_GrantReport();
        }
        void Bind_GrantReport()
        {
            int no = 0;
           
            foreach(Shape sh in shapes)
            {
                no++;
                ratio = Calculate.ShapeRatio(sh); 
                cuft = Calculate.CubicFeet(sh.Area, sh.Depth); 
                cement = Calculate.AverageCubic(sh.Cement, ratio, cuft); 
                gravel = Calculate.AverageCubic(sh.Gravel, ratio, cuft); 
                sand = Calculate.AverageCubic(sh.Sand, ratio, cuft);//  
                Lime = Calculate.AverageCubic(sh.Lime, ratio, cuft);// 
                cementprice = Calculate.MaterialPrice(cement, DataAccess.estimator.Cement_Price);//  
                sandprice = Calculate.MaterialPrice(sand, DataAccess.estimator.Sand_Price);//  
                gravelprice = Calculate.MaterialPrice(gravel, DataAccess.estimator.Gravel_Price);//  
                limeprice = Calculate.MaterialPrice(Lime, DataAccess.estimator.Lime_Price);// 
                float totalestimate = cementprice + sandprice + gravelprice + limeprice;
                sh.price = totalestimate;
                DataGridViewRow row = (DataGridViewRow)dataGridViewreport.Rows[0].Clone();
                row.Cells[0].Value = no.ToString();
                row.Cells[1].Value = sh.Name;
                row.Cells[2].Value = sh.Cement + ":" + sh.Gravel + ":" + sh.Sand + ":" + sh.Lime;
                row.Cells[3].Value = "Cubic";
                row.Cells[4].Value = "All";
                row.Cells[5].Value = sh.Price;
                dataGridViewreport.Rows.Add(row);
                DataGridViewRow row1 = (DataGridViewRow)dataGridViewreport.Rows[1].Clone();
                row1.Cells[1].Value = "Cement";
                row1.Cells[2].Value = sh.Cement;
                row1.Cells[3].Value = "lb";
                row1.Cells[4].Value = "Per Set";
                row1.Cells[5].Value = cementprice;
                dataGridViewreport.Rows.Add(row1);
                DataGridViewRow row2 = (DataGridViewRow)dataGridViewreport.Rows[2].Clone();
                row2.Cells[1].Value = "Gravel";
                row2.Cells[2].Value = sh.Gravel;
                row2.Cells[3].Value = "Cuft";
                row2.Cells[4].Value = "Per Set";
                row2.Cells[5].Value = limeprice;
                dataGridViewreport.Rows.Add(row2);
                DataGridViewRow row3 = (DataGridViewRow)dataGridViewreport.Rows[3].Clone();
                row3.Cells[1].Value = "Sand";
                row3.Cells[2].Value = sh.Sand;
                row3.Cells[3].Value = "Sud";
                row3.Cells[4].Value = "Per Set";
                row3.Cells[5].Value = sandprice;
                dataGridViewreport.Rows.Add(row3);
                DataGridViewRow row4 = (DataGridViewRow)dataGridViewreport.Rows[4].Clone();
                row4.Cells[1].Value = "Lime";
                row4.Cells[2].Value = sh.Lime;
                row4.Cells[3].Value = "Cuft";
                row4.Cells[4].Value = "Per Set";
                row4.Cells[5].Value = limeprice;
                dataGridViewreport.Rows.Add(row4);
                
            }
            float allestimate = 0;
            foreach (Shape sh in shapes)
            {

                allestimate += sh.price;
            }
            labeltotalestimate.Text = "Total Estimate : " + allestimate.ToString();
        }

        private void buttonexcelexport_Click(object sender, EventArgs e)
        {
            if (dataGridViewreport.Rows.Count > 0)
            {
                saveFileDialog.Filter = "Excel file (*.csv)|*.csv|All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter csv = new StreamWriter(saveFileDialog.FileName, false))
                        {
                            int totalcolms = dataGridViewreport.ColumnCount;
                            foreach (DataGridViewColumn colm in dataGridViewreport.Columns) csv.Write(colm.HeaderText + ',');
                            csv.Write('\n');
                            string data = "";
                            foreach (DataGridViewRow row in dataGridViewreport.Rows)
                            {
                                if (row.IsNewRow) continue;
                                data = "";
                                for (int i = 0; i < totalcolms; i++)
                                {
                                    data += (row.Cells[i].Value ?? "").ToString() + ',';
                                }
                                if (data != string.Empty) csv.WriteLine(data);
                            }
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Error while saving. " + err.Message);
                    }
                }
              
            }
        }
    }
}
