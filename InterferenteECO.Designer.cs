namespace _2022
{
    partial class InterferenteECO
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
            this.gameBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gameBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::_2022.Properties.Resources.Wood1;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(1028, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 726);
            this.panel1.TabIndex = 1;
            // 
            // gameBox
            // 
            this.gameBox.Location = new System.Drawing.Point(0, 0);
            this.gameBox.Name = "gameBox";
            this.gameBox.Size = new System.Drawing.Size(1022, 726);
            this.gameBox.TabIndex = 0;
            this.gameBox.TabStop = false;
            // 
            // InterferenteECO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 726);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gameBox);
            this.Name = "InterferenteECO";
            this.Text = "InterferenteECO -";
            ((System.ComponentModel.ISupportInitialize)(this.gameBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox gameBox;
        private System.Windows.Forms.Panel panel1;
    }
}