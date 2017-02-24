namespace GUI_with_WinForms
{
    partial class AboutMessageBoxForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutMessageBoxForm));
            this.labelAboutMessageBoxForm = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelVersionOfProgram = new System.Windows.Forms.Label();
            this.labelDevlopedBy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAboutMessageBoxForm
            // 
            this.labelAboutMessageBoxForm.AutoSize = true;
            this.labelAboutMessageBoxForm.Location = new System.Drawing.Point(47, 9);
            this.labelAboutMessageBoxForm.Name = "labelAboutMessageBoxForm";
            this.labelAboutMessageBoxForm.Size = new System.Drawing.Size(596, 39);
            this.labelAboutMessageBoxForm.TabIndex = 0;
            this.labelAboutMessageBoxForm.Text = resources.GetString("labelAboutMessageBoxForm.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(231, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelVersionOfProgram
            // 
            this.labelVersionOfProgram.AutoSize = true;
            this.labelVersionOfProgram.Location = new System.Drawing.Point(291, 123);
            this.labelVersionOfProgram.Name = "labelVersionOfProgram";
            this.labelVersionOfProgram.Size = new System.Drawing.Size(141, 13);
            this.labelVersionOfProgram.TabIndex = 2;
            this.labelVersionOfProgram.Text = "Version of Program: v1.0.0.0";
            // 
            // labelDevlopedBy
            // 
            this.labelDevlopedBy.AutoSize = true;
            this.labelDevlopedBy.Location = new System.Drawing.Point(280, 171);
            this.labelDevlopedBy.Name = "labelDevlopedBy";
            this.labelDevlopedBy.Size = new System.Drawing.Size(163, 13);
            this.labelDevlopedBy.TabIndex = 3;
            this.labelDevlopedBy.Text = "Developed By: Robert Humphres";
            // 
            // AboutMessageBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 253);
            this.Controls.Add(this.labelDevlopedBy);
            this.Controls.Add(this.labelVersionOfProgram);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelAboutMessageBoxForm);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutMessageBoxForm";
            this.ShowIcon = false;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAboutMessageBoxForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelVersionOfProgram;
        private System.Windows.Forms.Label labelDevlopedBy;
    }
}