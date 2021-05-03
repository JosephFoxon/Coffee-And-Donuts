
namespace Coffee_and_Donuts
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
            this.textBoxNumDonuts = new System.Windows.Forms.TextBox();
            this.textBoxNumCoffees = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNumDonuts
            // 
            this.textBoxNumDonuts.Location = new System.Drawing.Point(33, 25);
            this.textBoxNumDonuts.Name = "textBoxNumDonuts";
            this.textBoxNumDonuts.PlaceholderText = "Num Donuts";
            this.textBoxNumDonuts.Size = new System.Drawing.Size(100, 23);
            this.textBoxNumDonuts.TabIndex = 0;
            // 
            // textBoxNumCoffees
            // 
            this.textBoxNumCoffees.Location = new System.Drawing.Point(33, 76);
            this.textBoxNumCoffees.Name = "textBoxNumCoffees";
            this.textBoxNumCoffees.PlaceholderText = "Num Coffees";
            this.textBoxNumCoffees.Size = new System.Drawing.Size(100, 23);
            this.textBoxNumCoffees.TabIndex = 1;
            this.textBoxNumCoffees.TextChanged += new System.EventHandler(this.textBoxNumCoffees_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to the coffe shop, you will be alerted as soon as your order is ready ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Your coffees are ready!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Your donuts are ready!";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Submit order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNumCoffees);
            this.Controls.Add(this.textBoxNumDonuts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumDonuts;
        private System.Windows.Forms.TextBox textBoxNumCoffees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

