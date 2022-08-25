
namespace GrantCalculator
{
    partial class PricesetForm
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
            this.cementpricetextBox = new System.Windows.Forms.TextBox();
            this.limepricetextBox = new System.Windows.Forms.TextBox();
            this.sandpricetextBox = new System.Windows.Forms.TextBox();
            this.gravelpricetextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cementpricetextBox
            // 
            this.cementpricetextBox.Location = new System.Drawing.Point(28, 43);
            this.cementpricetextBox.Name = "cementpricetextBox";
            this.cementpricetextBox.Size = new System.Drawing.Size(169, 26);
            this.cementpricetextBox.TabIndex = 0;
            // 
            // limepricetextBox
            // 
            this.limepricetextBox.Location = new System.Drawing.Point(216, 43);
            this.limepricetextBox.Name = "limepricetextBox";
            this.limepricetextBox.Size = new System.Drawing.Size(169, 26);
            this.limepricetextBox.TabIndex = 1;
            // 
            // sandpricetextBox
            // 
            this.sandpricetextBox.Location = new System.Drawing.Point(407, 43);
            this.sandpricetextBox.Name = "sandpricetextBox";
            this.sandpricetextBox.Size = new System.Drawing.Size(169, 26);
            this.sandpricetextBox.TabIndex = 2;
            // 
            // gravelpricetextBox
            // 
            this.gravelpricetextBox.Location = new System.Drawing.Point(597, 43);
            this.gravelpricetextBox.Name = "gravelpricetextBox";
            this.gravelpricetextBox.Size = new System.Drawing.Size(169, 26);
            this.gravelpricetextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cement 1 lb Per";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lime 1 Cuft Per";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sand 1 Sud Per";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(621, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gravel 1 Cuft Per";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(508, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(646, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 36);
            this.button2.TabIndex = 9;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // PricesetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 123);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gravelpricetextBox);
            this.Controls.Add(this.sandpricetextBox);
            this.Controls.Add(this.limepricetextBox);
            this.Controls.Add(this.cementpricetextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PricesetForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Price Standard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cementpricetextBox;
        private System.Windows.Forms.TextBox limepricetextBox;
        private System.Windows.Forms.TextBox sandpricetextBox;
        private System.Windows.Forms.TextBox gravelpricetextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}