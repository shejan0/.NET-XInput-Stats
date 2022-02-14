
namespace XInputController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OutputLabel = new System.Windows.Forms.Label();
            this.InputHertz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.BackColor = System.Drawing.Color.Transparent;
            this.OutputLabel.ForeColor = System.Drawing.Color.White;
            this.OutputLabel.Location = new System.Drawing.Point(14, 64);
            this.OutputLabel.MaximumSize = new System.Drawing.Size(500, 0);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(44, 17);
            this.OutputLabel.TabIndex = 0;
            this.OutputLabel.Text = "NULL";
            // 
            // InputHertz
            // 
            this.InputHertz.BackColor = System.Drawing.Color.Green;
            this.InputHertz.ForeColor = System.Drawing.Color.White;
            this.InputHertz.Location = new System.Drawing.Point(12, 39);
            this.InputHertz.Name = "InputHertz";
            this.InputHertz.Size = new System.Drawing.Size(100, 22);
            this.InputHertz.TabIndex = 1;
            this.InputHertz.TextChanged += new System.EventHandler(this.InputHertz_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adjust refresh hertz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(758, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Press Back or Start to oscillate motors";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::XInputController.Properties.Resources.XboxIcon;
            this.pictureBox1.Location = new System.Drawing.Point(761, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1230, 457);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputHertz);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Xbox Controller Test";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.TextBox InputHertz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

