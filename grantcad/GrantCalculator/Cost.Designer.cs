
namespace GrantCalculator
{
    partial class Cost
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.costview = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCement = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGravel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columncubic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnratio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // costview
            // 
            this.costview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.costview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnCement,
            this.columnGravel,
            this.columnSand,
            this.columnLime,
            this.columncubic,
            this.columnratio,
            this.columnPrice});
            this.costview.HideSelection = false;
            this.costview.Location = new System.Drawing.Point(11, 12);
            this.costview.MultiSelect = false;
            this.costview.Name = "costview";
            this.costview.Size = new System.Drawing.Size(680, 120);
            this.costview.TabIndex = 6;
            this.costview.UseCompatibleStateImageBehavior = false;
            this.costview.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            // 
            // columnCement
            // 
            this.columnCement.Text = "Cement";
            this.columnCement.Width = 80;
            // 
            // columnGravel
            // 
            this.columnGravel.Text = "Gravel";
            this.columnGravel.Width = 76;
            // 
            // columnSand
            // 
            this.columnSand.Text = "Sand";
            this.columnSand.Width = 80;
            // 
            // columnLime
            // 
            this.columnLime.Text = "Lime";
            this.columnLime.Width = 72;
            // 
            // columncubic
            // 
            this.columncubic.Text = "Cubic";
            this.columncubic.Width = 92;
            // 
            // columnratio
            // 
            this.columnratio.Text = "Ratio";
            this.columnratio.Width = 86;
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "Price";
            this.columnPrice.Width = 86;
            // 
            // Cost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.costview);
            this.Name = "Cost";
            this.Size = new System.Drawing.Size(705, 146);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView costview;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnCement;
        private System.Windows.Forms.ColumnHeader columnGravel;
        private System.Windows.Forms.ColumnHeader columnSand;
        private System.Windows.Forms.ColumnHeader columnLime;
        private System.Windows.Forms.ColumnHeader columncubic;
        private System.Windows.Forms.ColumnHeader columnratio;
        private System.Windows.Forms.ColumnHeader columnPrice;
    }
}
