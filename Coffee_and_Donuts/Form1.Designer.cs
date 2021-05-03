
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
            this.labelCoffeeReady = new System.Windows.Forms.Label();
            this.labelDonutReady = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCoffee = new System.Windows.Forms.Button();
            this.buttonDonut = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelCoffeeWait = new System.Windows.Forms.Label();
            this.labelDonutsWaiting = new System.Windows.Forms.Label();
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
            // labelCoffeeReady
            // 
            this.labelCoffeeReady.AutoSize = true;
            this.labelCoffeeReady.Location = new System.Drawing.Point(129, 247);
            this.labelCoffeeReady.Name = "labelCoffeeReady";
            this.labelCoffeeReady.Size = new System.Drawing.Size(126, 15);
            this.labelCoffeeReady.TabIndex = 3;
            this.labelCoffeeReady.Text = "Your coffees are ready!";
            // 
            // labelDonutReady
            // 
            this.labelDonutReady.AutoSize = true;
            this.labelDonutReady.Location = new System.Drawing.Point(129, 288);
            this.labelDonutReady.Name = "labelDonutReady";
            this.labelDonutReady.Size = new System.Drawing.Size(125, 15);
            this.labelDonutReady.TabIndex = 4;
            this.labelDonutReady.Text = "Your donuts are ready!";
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
            // buttonCoffee
            // 
            this.buttonCoffee.Location = new System.Drawing.Point(541, 76);
            this.buttonCoffee.Name = "buttonCoffee";
            this.buttonCoffee.Size = new System.Drawing.Size(144, 23);
            this.buttonCoffee.TabIndex = 6;
            this.buttonCoffee.Text = "Make coffee x1";
            this.buttonCoffee.UseVisualStyleBackColor = true;
            // 
            // buttonDonut
            // 
            this.buttonDonut.Location = new System.Drawing.Point(541, 122);
            this.buttonDonut.Name = "buttonDonut";
            this.buttonDonut.Size = new System.Drawing.Size(144, 23);
            this.buttonDonut.TabIndex = 7;
            this.buttonDonut.Text = "Make donut x1";
            this.buttonDonut.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(287, 199);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(125, 23);
            this.buttonUpdate.TabIndex = 8;
            this.buttonUpdate.Text = "Update Status";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // labelCoffeeWait
            // 
            this.labelCoffeeWait.AutoSize = true;
            this.labelCoffeeWait.Location = new System.Drawing.Point(433, 247);
            this.labelCoffeeWait.Name = "labelCoffeeWait";
            this.labelCoffeeWait.Size = new System.Drawing.Size(161, 15);
            this.labelCoffeeWait.TabIndex = 9;
            this.labelCoffeeWait.Text = "You have coffee outstanding!";
            // 
            // labelDonutsWaiting
            // 
            this.labelDonutsWaiting.AutoSize = true;
            this.labelDonutsWaiting.Location = new System.Drawing.Point(433, 290);
            this.labelDonutsWaiting.Name = "labelDonutsWaiting";
            this.labelDonutsWaiting.Size = new System.Drawing.Size(165, 15);
            this.labelDonutsWaiting.TabIndex = 10;
            this.labelDonutsWaiting.Text = "You have donuts outstanding!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDonutsWaiting);
            this.Controls.Add(this.labelCoffeeWait);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDonut);
            this.Controls.Add(this.buttonCoffee);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelDonutReady);
            this.Controls.Add(this.labelCoffeeReady);
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
        private System.Windows.Forms.Label labelCoffeeReady;
        private System.Windows.Forms.Label labelDonutReady;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCoffee;
        private System.Windows.Forms.Button buttonDonut;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelCoffeeWait;
        private System.Windows.Forms.Label labelDonutsWaiting;
    }
}

