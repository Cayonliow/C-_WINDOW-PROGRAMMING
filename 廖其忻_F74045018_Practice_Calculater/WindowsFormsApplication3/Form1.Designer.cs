namespace WindowsFormsApplication3
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
            this.txtPW = new System.Windows.Forms.TextBox();
            this.txtPW2 = new System.Windows.Forms.TextBox();
            this.txtPW3 = new System.Windows.Forms.TextBox();
            //this.txtPW4 = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblShow = new System.Windows.Forms.Label();


            this.txtPW.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPW.Location = new System.Drawing.Point(80, 50);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(150, 25);
            this.txtPW.TabIndex = 10;
            this.Controls.Add(this.txtPW);

            this.txtPW3.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPW3.Location = new System.Drawing.Point(80, 100);
            this.txtPW3.Name = "txtPW";
            this.txtPW3.Size = new System.Drawing.Size(150, 25);
            this.txtPW3.TabIndex = 10;
            this.Controls.Add(this.txtPW3);

            this.btnCancel.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Location = new System.Drawing.Point(80, 150);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 25);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "計算";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.Controls.Add(this.btnCancel);

            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(10, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "除數：";
            this.Controls.Add(this.label3);

            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(10, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "被除數：";
            this.Controls.Add(this.label4);



            //this.lblShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShow.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblShow.Location = new System.Drawing.Point(15, 200);
            //this.lblShow.BackColor = System.Drawing.Color(ye)
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(252, 50);
            this.lblShow.TabIndex = 7;
            this.Controls.Add(this.lblShow);

        }
        #endregion
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.TextBox txtPW2;
        private System.Windows.Forms.TextBox txtPW3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblShow;

    }
}

