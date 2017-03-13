namespace WindowsFormsApplication4
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "Form1";
            this.Size = new System.Drawing.Size(500, 400);

            //new
            this.btnStyle1 = new System.Windows.Forms.Button();
            this.btnStyle2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();

            this.btnStyle1.Location = new System.Drawing.Point(50,30);
            this.btnStyle1.Name = "Style 1";
            this.btnStyle1.Text = "Style 1";
            this.btnStyle1.Size = new System.Drawing.Size(70, 25);
            this.btnStyle1.Click += new System.EventHandler(this.btnStyle1_Click);

            this.btnStyle2.Location = new System.Drawing.Point(200, 30);
            this.btnStyle2.Name = "Style 2";
            this.btnStyle2.Text = "Style 2";
            this.btnStyle2.Size = new System.Drawing.Size(70, 25);
            this.btnStyle2.Click += new System.EventHandler(this.btnStyle2_Click);

            this.label1.Text = "Title Text";
            //this.label1.Font = new System.Drawing.Font(新細明體, 18, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(50, 100);
            this.label1.Size = new System.Drawing.Size(130, 30);

            this.label2.Text = "Subtitle Text";
            //this.label1.Font = new System.Drawing.Font(新細明體, 18, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(50, 150);
            this.label2.Size = new System.Drawing.Size(132, 50);

            this.textBox1.Location = new System.Drawing.Point(50, 200);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Content Text";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            this.button3.Location = new System.Drawing.Point(50, 250);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 25);
            this.button3.TabIndex = 4;
            this.button3.Text = "Button";
            this.button3.UseVisualStyleBackColor = true;

            this.pictureBox1.Location = new System.Drawing.Point(230, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 180);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;

            //add
            this.Controls.Add(this.btnStyle1);
            this.Controls.Add(this.btnStyle2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);



        }

        #endregion
        //declare
        private System.Windows.Forms.Button btnStyle1;
        private System.Windows.Forms.Button btnStyle2;
        private System.Windows.Forms. Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
    
}

