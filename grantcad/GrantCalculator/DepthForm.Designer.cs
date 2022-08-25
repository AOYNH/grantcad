
namespace GrantCalculator
{
    partial class DepthForm
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
            this.numericUpDownZDepth = new System.Windows.Forms.NumericUpDown();
            this.buttonsetdept = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZDepth)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownZDepth
            // 
            this.numericUpDownZDepth.Location = new System.Drawing.Point(12, 12);
            this.numericUpDownZDepth.Name = "numericUpDownZDepth";
            this.numericUpDownZDepth.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownZDepth.TabIndex = 0;
            // 
            // buttonsetdept
            // 
            this.buttonsetdept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonsetdept.Location = new System.Drawing.Point(12, 45);
            this.buttonsetdept.Name = "buttonsetdept";
            this.buttonsetdept.Size = new System.Drawing.Size(116, 44);
            this.buttonsetdept.TabIndex = 1;
            this.buttonsetdept.Text = "SET";
            this.buttonsetdept.UseVisualStyleBackColor = true;
            // 
            // DepthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(141, 101);
            this.Controls.Add(this.buttonsetdept);
            this.Controls.Add(this.numericUpDownZDepth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DepthForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Above";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZDepth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonsetdept;
        public System.Windows.Forms.NumericUpDown numericUpDownZDepth;
    }
}