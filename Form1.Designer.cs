namespace notetaker
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.canbut = new System.Windows.Forms.Button();
            this.savebut = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.newnote = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.canbut);
            this.panel1.Controls.Add(this.savebut);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(12, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 409);
            this.panel1.TabIndex = 0;
            // 
            // canbut
            // 
            this.canbut.Location = new System.Drawing.Point(274, 328);
            this.canbut.Name = "canbut";
            this.canbut.Size = new System.Drawing.Size(79, 23);
            this.canbut.TabIndex = 2;
            this.canbut.Text = "cancel";
            this.canbut.UseVisualStyleBackColor = true;
            this.canbut.Click += new System.EventHandler(this.canbut_Click);
            // 
            // savebut
            // 
            this.savebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebut.Location = new System.Drawing.Point(97, 328);
            this.savebut.Name = "savebut";
            this.savebut.Size = new System.Drawing.Size(79, 23);
            this.savebut.TabIndex = 1;
            this.savebut.Text = "Save";
            this.savebut.UseVisualStyleBackColor = true;
            this.savebut.Click += new System.EventHandler(this.savebut_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(455, 288);
            this.textBox1.TabIndex = 0;
            // 
            // newnote
            // 
            this.newnote.Location = new System.Drawing.Point(594, 68);
            this.newnote.Name = "newnote";
            this.newnote.Size = new System.Drawing.Size(108, 26);
            this.newnote.TabIndex = 1;
            this.newnote.Text = "New Note";
            this.newnote.UseVisualStyleBackColor = true;
            this.newnote.Click += new System.EventHandler(this.newnote_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 442);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.newnote);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button canbut;
        private System.Windows.Forms.Button savebut;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button newnote;
        private System.Windows.Forms.Panel panel2;
    }
}

