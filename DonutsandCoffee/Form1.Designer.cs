
namespace DonutsandCoffee
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nuCoffee = new System.Windows.Forms.NumericUpDown();
            this.nuDonuts = new System.Windows.Forms.NumericUpDown();
            this.btnOrder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nuCoffee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDonuts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number Of Coffee :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number Of Donuts :";
            // 
            // nuCoffee
            // 
            this.nuCoffee.Location = new System.Drawing.Point(440, 105);
            this.nuCoffee.Name = "nuCoffee";
            this.nuCoffee.Size = new System.Drawing.Size(67, 23);
            this.nuCoffee.TabIndex = 2;
            // 
            // nuDonuts
            // 
            this.nuDonuts.Location = new System.Drawing.Point(440, 163);
            this.nuDonuts.Name = "nuDonuts";
            this.nuDonuts.Size = new System.Drawing.Size(66, 23);
            this.nuDonuts.TabIndex = 3;
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOrder.Location = new System.Drawing.Point(269, 249);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(109, 23);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Welcome! Please place your order";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(657, 339);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.nuDonuts);
            this.Controls.Add(this.nuCoffee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Coffee Shop";
            ((System.ComponentModel.ISupportInitialize)(this.nuCoffee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDonuts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nuCoffee;
        private System.Windows.Forms.NumericUpDown nuDonuts;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label label3;
    }
}

