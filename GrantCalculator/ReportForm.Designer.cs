
namespace GrantCalculator
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewreport = new System.Windows.Forms.DataGridView();
            this.Nocolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Particularcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RatioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labeltotalestimate = new System.Windows.Forms.Label();
            this.buttonexcelexport = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewreport)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewreport
            // 
            this.dataGridViewreport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewreport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewreport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nocolumn,
            this.Particularcolumn,
            this.RatioColumn,
            this.UnitColumn,
            this.RateColumn,
            this.AmountColumn});
            this.dataGridViewreport.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewreport.Name = "dataGridViewreport";
            this.dataGridViewreport.RowHeadersWidth = 62;
            this.dataGridViewreport.RowTemplate.Height = 28;
            this.dataGridViewreport.Size = new System.Drawing.Size(1161, 529);
            this.dataGridViewreport.TabIndex = 0;
            // 
            // Nocolumn
            // 
            this.Nocolumn.HeaderText = "No";
            this.Nocolumn.MinimumWidth = 8;
            this.Nocolumn.Name = "Nocolumn";
            this.Nocolumn.ReadOnly = true;
            this.Nocolumn.Width = 150;
            // 
            // Particularcolumn
            // 
            this.Particularcolumn.HeaderText = "Particular";
            this.Particularcolumn.MinimumWidth = 8;
            this.Particularcolumn.Name = "Particularcolumn";
            this.Particularcolumn.ReadOnly = true;
            this.Particularcolumn.Width = 150;
            // 
            // RatioColumn
            // 
            this.RatioColumn.HeaderText = "Ratio";
            this.RatioColumn.MinimumWidth = 8;
            this.RatioColumn.Name = "RatioColumn";
            this.RatioColumn.ReadOnly = true;
            this.RatioColumn.Width = 150;
            // 
            // UnitColumn
            // 
            this.UnitColumn.HeaderText = "Unit";
            this.UnitColumn.MinimumWidth = 8;
            this.UnitColumn.Name = "UnitColumn";
            this.UnitColumn.ReadOnly = true;
            this.UnitColumn.Width = 150;
            // 
            // RateColumn
            // 
            this.RateColumn.HeaderText = "Rate";
            this.RateColumn.MinimumWidth = 8;
            this.RateColumn.Name = "RateColumn";
            this.RateColumn.ReadOnly = true;
            this.RateColumn.Width = 150;
            // 
            // AmountColumn
            // 
            this.AmountColumn.HeaderText = "Amount";
            this.AmountColumn.MinimumWidth = 8;
            this.AmountColumn.Name = "AmountColumn";
            this.AmountColumn.ReadOnly = true;
            this.AmountColumn.Width = 150;
            // 
            // labeltotalestimate
            // 
            this.labeltotalestimate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labeltotalestimate.AutoSize = true;
            this.labeltotalestimate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltotalestimate.Location = new System.Drawing.Point(13, 559);
            this.labeltotalestimate.Name = "labeltotalestimate";
            this.labeltotalestimate.Size = new System.Drawing.Size(163, 25);
            this.labeltotalestimate.TabIndex = 1;
            this.labeltotalestimate.Text = "Total Estimate :";
            // 
            // buttonexcelexport
            // 
            this.buttonexcelexport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonexcelexport.Location = new System.Drawing.Point(1010, 549);
            this.buttonexcelexport.Name = "buttonexcelexport";
            this.buttonexcelexport.Size = new System.Drawing.Size(164, 35);
            this.buttonexcelexport.TabIndex = 2;
            this.buttonexcelexport.Text = "Excel Export";
            this.buttonexcelexport.UseVisualStyleBackColor = true;
            this.buttonexcelexport.Click += new System.EventHandler(this.buttonexcelexport_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 610);
            this.Controls.Add(this.buttonexcelexport);
            this.Controls.Add(this.labeltotalestimate);
            this.Controls.Add(this.dataGridViewreport);
            this.Name = "ReportForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Grant Report";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewreport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewreport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nocolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Particularcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RatioColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
        private System.Windows.Forms.Label labeltotalestimate;
        private System.Windows.Forms.Button buttonexcelexport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}