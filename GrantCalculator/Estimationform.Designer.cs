
namespace GrantCalculator
{
    partial class Estimationform
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
            this.buttonestimateEdit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelarea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonestimateEdit
            // 
            this.buttonestimateEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonestimateEdit.Location = new System.Drawing.Point(676, 151);
            this.buttonestimateEdit.Name = "buttonestimateEdit";
            this.buttonestimateEdit.Size = new System.Drawing.Size(139, 35);
            this.buttonestimateEdit.TabIndex = 0;
            this.buttonestimateEdit.Text = "EDIT";
            this.buttonestimateEdit.UseVisualStyleBackColor = true;
            this.buttonestimateEdit.Click += new System.EventHandler(this.buttonestimateEdit_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(830, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelarea
            // 
            this.labelarea.AutoSize = true;
            this.labelarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelarea.Location = new System.Drawing.Point(12, 140);
            this.labelarea.Name = "labelarea";
            this.labelarea.Size = new System.Drawing.Size(108, 46);
            this.labelarea.TabIndex = 2;
            this.labelarea.Text = "Area";
            // 
            // Estimationform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 198);
            this.Controls.Add(this.labelarea);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonestimateEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Estimationform";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estimate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonestimateEdit;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label labelarea;
    }
}