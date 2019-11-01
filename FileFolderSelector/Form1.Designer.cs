namespace FileFolderSelector
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
            this.choof_Click = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.direc_Click = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.run_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // choof_Click
            // 
            this.choof_Click.Location = new System.Drawing.Point(151, 89);
            this.choof_Click.Name = "choof_Click";
            this.choof_Click.Size = new System.Drawing.Size(75, 23);
            this.choof_Click.TabIndex = 0;
            this.choof_Click.Text = "Select File";
            this.choof_Click.UseVisualStyleBackColor = true;
            this.choof_Click.Click += new System.EventHandler(this.Choof_Click_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(351, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 20);
            this.textBox1.TabIndex = 1;
            // 
            // direc_Click
            // 
            this.direc_Click.Location = new System.Drawing.Point(151, 180);
            this.direc_Click.Name = "direc_Click";
            this.direc_Click.Size = new System.Drawing.Size(175, 23);
            this.direc_Click.TabIndex = 2;
            this.direc_Click.Text = "Select the Folder to Save Files";
            this.direc_Click.UseVisualStyleBackColor = true;
            this.direc_Click.Click += new System.EventHandler(this.Direc_Click_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(351, 182);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(236, 20);
            this.textBox2.TabIndex = 3;
            // 
            // run_Click
            // 
            this.run_Click.Location = new System.Drawing.Point(151, 294);
            this.run_Click.Name = "run_Click";
            this.run_Click.Size = new System.Drawing.Size(75, 23);
            this.run_Click.TabIndex = 4;
            this.run_Click.Text = "Go!";
            this.run_Click.UseVisualStyleBackColor = true;
            this.run_Click.Click += new System.EventHandler(this.Run_Click_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.run_Click);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.direc_Click);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.choof_Click);
            this.Name = "Form1";
            this.Text = "DPD Scan File Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button choof_Click;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button direc_Click;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button run_Click;
    }
}

