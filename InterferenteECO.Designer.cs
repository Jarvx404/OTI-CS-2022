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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.svBtn = new System.Windows.Forms.Button();
            this.restartBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.plaLabel = new System.Windows.Forms.Label();
            this.harLabel = new System.Windows.Forms.Label();
            this.sticleLabel = new System.Windows.Forms.Label();
            this.curBtn = new System.Windows.Forms.Button();
            this.rotBtn = new System.Windows.Forms.Button();
            this.defPb = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridCheck = new System.Windows.Forms.CheckBox();
            this.loadBtn = new System.Windows.Forms.Button();
            this.gameBox = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.stopBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::_2022.Properties.Resources.Wood1;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.stopBtn);
            this.panel1.Controls.Add(this.svBtn);
            this.panel1.Controls.Add(this.restartBtn);
            this.panel1.Controls.Add(this.startBtn);
            this.panel1.Controls.Add(this.plaLabel);
            this.panel1.Controls.Add(this.harLabel);
            this.panel1.Controls.Add(this.sticleLabel);
            this.panel1.Controls.Add(this.curBtn);
            this.panel1.Controls.Add(this.rotBtn);
            this.panel1.Controls.Add(this.defPb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.gridCheck);
            this.panel1.Controls.Add(this.loadBtn);
            this.panel1.Location = new System.Drawing.Point(1028, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 726);
            this.panel1.TabIndex = 1;
            // 
            // svBtn
            // 
            this.svBtn.Location = new System.Drawing.Point(43, 698);
            this.svBtn.Name = "svBtn";
            this.svBtn.Size = new System.Drawing.Size(161, 23);
            this.svBtn.TabIndex = 12;
            this.svBtn.Text = "Salveaza JPG";
            this.svBtn.UseVisualStyleBackColor = true;
            this.svBtn.Click += new System.EventHandler(this.svBtn_Click);
            // 
            // restartBtn
            // 
            this.restartBtn.Location = new System.Drawing.Point(43, 661);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(161, 32);
            this.restartBtn.TabIndex = 11;
            this.restartBtn.Text = "Restart";
            this.restartBtn.UseVisualStyleBackColor = true;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(43, 580);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(161, 45);
            this.startBtn.TabIndex = 10;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // plaLabel
            // 
            this.plaLabel.AutoSize = true;
            this.plaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.plaLabel.Location = new System.Drawing.Point(17, 548);
            this.plaLabel.Name = "plaLabel";
            this.plaLabel.Size = new System.Drawing.Size(81, 17);
            this.plaLabel.TabIndex = 9;
            this.plaLabel.Text = "Sticle: <ns>";
            // 
            // harLabel
            // 
            this.harLabel.AutoSize = true;
            this.harLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.harLabel.Location = new System.Drawing.Point(17, 507);
            this.harLabel.Name = "harLabel";
            this.harLabel.Size = new System.Drawing.Size(81, 17);
            this.harLabel.TabIndex = 8;
            this.harLabel.Text = "Sticle: <ns>";
            // 
            // sticleLabel
            // 
            this.sticleLabel.AutoSize = true;
            this.sticleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sticleLabel.Location = new System.Drawing.Point(17, 469);
            this.sticleLabel.Name = "sticleLabel";
            this.sticleLabel.Size = new System.Drawing.Size(81, 17);
            this.sticleLabel.TabIndex = 7;
            this.sticleLabel.Text = "Sticle: <ns>";
            // 
            // curBtn
            // 
            this.curBtn.Location = new System.Drawing.Point(43, 416);
            this.curBtn.Name = "curBtn";
            this.curBtn.Size = new System.Drawing.Size(161, 27);
            this.curBtn.TabIndex = 6;
            this.curBtn.Text = "Curata tot";
            this.curBtn.UseVisualStyleBackColor = true;
            this.curBtn.Click += new System.EventHandler(this.curBtn_Click);
            // 
            // rotBtn
            // 
            this.rotBtn.Location = new System.Drawing.Point(43, 353);
            this.rotBtn.Name = "rotBtn";
            this.rotBtn.Size = new System.Drawing.Size(161, 45);
            this.rotBtn.TabIndex = 5;
            this.rotBtn.Text = "Roteste deflector";
            this.rotBtn.UseVisualStyleBackColor = true;
            // 
            // defPb
            // 
            this.defPb.Location = new System.Drawing.Point(62, 212);
            this.defPb.Name = "defPb";
            this.defPb.Size = new System.Drawing.Size(122, 121);
            this.defPb.TabIndex = 4;
            this.defPb.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adauga deflector";
            // 
            // gridCheck
            // 
            this.gridCheck.AutoSize = true;
            this.gridCheck.CheckAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.gridCheck.Location = new System.Drawing.Point(62, 33);
            this.gridCheck.Name = "gridCheck";
            this.gridCheck.Size = new System.Drawing.Size(103, 17);
            this.gridCheck.TabIndex = 2;
            this.gridCheck.Text = "Afiseaza linii grid";
            this.gridCheck.UseVisualStyleBackColor = true;
            this.gridCheck.CheckedChanged += new System.EventHandler(this.gridCheck_CheckedChanged);
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(43, 83);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(154, 42);
            this.loadBtn.TabIndex = 1;
            this.loadBtn.Text = "Incarca Harta";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // gameBox
            // 
            this.gameBox.Location = new System.Drawing.Point(12, 12);
            this.gameBox.Name = "gameBox";
            this.gameBox.Size = new System.Drawing.Size(1000, 700);
            this.gameBox.TabIndex = 0;
            this.gameBox.TabStop = false;
            this.gameBox.Paint += new System.Windows.Forms.PaintEventHandler(this.drawGraphics);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 200;
            this.gameTimer.Tick += new System.EventHandler(this.gameTick);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(43, 631);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(161, 24);
            this.stopBtn.TabIndex = 13;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // InterferenteECO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_2022.Properties.Resources.Wood2;
            this.ClientSize = new System.Drawing.Size(1266, 726);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gameBox);
            this.Name = "InterferenteECO";
            this.Text = "InterferenteECO -";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox gameBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Label sticleLabel;
        private System.Windows.Forms.Button curBtn;
        private System.Windows.Forms.Button rotBtn;
        private System.Windows.Forms.PictureBox defPb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox gridCheck;
        private System.Windows.Forms.Button restartBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label plaLabel;
        private System.Windows.Forms.Label harLabel;
        private System.Windows.Forms.Button svBtn;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button stopBtn;
    }
}