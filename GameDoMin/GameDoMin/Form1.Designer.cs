namespace GameDoMin
{
    partial class FormDoMin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoMin));
            this.pnlBoardGame = new System.Windows.Forms.Panel();
            this.btBeginer = new System.Windows.Forms.Button();
            this.btIntermediate = new System.Windows.Forms.Button();
            this.btExpert = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.picReset = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btFlagging = new System.Windows.Forms.Button();
            this.prgCountTime = new System.Windows.Forms.ProgressBar();
            this.timerCountTime = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBoardGame
            // 
            this.pnlBoardGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnlBoardGame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBoardGame.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlBoardGame.Location = new System.Drawing.Point(326, 86);
            this.pnlBoardGame.Name = "pnlBoardGame";
            this.pnlBoardGame.Size = new System.Drawing.Size(915, 315);
            this.pnlBoardGame.TabIndex = 0;
            // 
            // btBeginer
            // 
            this.btBeginer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btBeginer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBeginer.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBeginer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBeginer.Location = new System.Drawing.Point(64, 69);
            this.btBeginer.Name = "btBeginer";
            this.btBeginer.Size = new System.Drawing.Size(131, 37);
            this.btBeginer.TabIndex = 0;
            this.btBeginer.Text = "Beginer";
            this.btBeginer.UseVisualStyleBackColor = false;
            this.btBeginer.Click += new System.EventHandler(this.btBeginer_Click);
            // 
            // btIntermediate
            // 
            this.btIntermediate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btIntermediate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIntermediate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btIntermediate.Location = new System.Drawing.Point(64, 128);
            this.btIntermediate.Name = "btIntermediate";
            this.btIntermediate.Size = new System.Drawing.Size(131, 37);
            this.btIntermediate.TabIndex = 0;
            this.btIntermediate.Text = "Intermediate";
            this.btIntermediate.UseVisualStyleBackColor = false;
            this.btIntermediate.Click += new System.EventHandler(this.btIntermediate_Click);
            // 
            // btExpert
            // 
            this.btExpert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btExpert.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExpert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btExpert.Location = new System.Drawing.Point(64, 182);
            this.btExpert.Name = "btExpert";
            this.btExpert.Size = new System.Drawing.Size(131, 37);
            this.btExpert.TabIndex = 0;
            this.btExpert.Text = "Expert";
            this.btExpert.UseVisualStyleBackColor = false;
            this.btExpert.Click += new System.EventHandler(this.btExpert_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btBeginer);
            this.panel1.Controls.Add(this.btIntermediate);
            this.panel1.Controls.Add(this.btExpert);
            this.panel1.Location = new System.Drawing.Point(24, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 240);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "GAME DÒ MÌN";
            // 
            // picReset
            // 
            this.picReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.picReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picReset.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picReset.Image = global::GameDoMin.Properties.Resources.happy;
            this.picReset.Location = new System.Drawing.Point(326, 21);
            this.picReset.Name = "picReset";
            this.picReset.Size = new System.Drawing.Size(55, 47);
            this.picReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picReset.TabIndex = 3;
            this.picReset.TabStop = false;
            this.picReset.Click += new System.EventHandler(this.picReset_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GameDoMin.Properties.Resources.maxresdefault;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btFlagging
            // 
            this.btFlagging.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFlagging.ForeColor = System.Drawing.Color.Red;
            this.btFlagging.Location = new System.Drawing.Point(1170, 21);
            this.btFlagging.Name = "btFlagging";
            this.btFlagging.Size = new System.Drawing.Size(71, 47);
            this.btFlagging.TabIndex = 4;
            this.btFlagging.Text = "250";
            this.btFlagging.UseVisualStyleBackColor = true;
            // 
            // prgCountTime
            // 
            this.prgCountTime.Location = new System.Drawing.Point(697, 32);
            this.prgCountTime.Maximum = 150;
            this.prgCountTime.Name = "prgCountTime";
            this.prgCountTime.Size = new System.Drawing.Size(173, 27);
            this.prgCountTime.TabIndex = 5;
            // 
            // timerCountTime
            // 
            this.timerCountTime.Interval = 1000;
            this.timerCountTime.Tick += new System.EventHandler(this.timerCountTime_Tick);
            // 
            // FormDoMin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 419);
            this.Controls.Add(this.prgCountTime);
            this.Controls.Add(this.btFlagging);
            this.Controls.Add(this.picReset);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlBoardGame);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MaximizeBox = false;
            this.Name = "FormDoMin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DoMin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDoMin_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBoardGame;
        private System.Windows.Forms.Button btBeginer;
        private System.Windows.Forms.Button btIntermediate;
        private System.Windows.Forms.Button btExpert;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picReset;
        private System.Windows.Forms.Button btFlagging;
        private System.Windows.Forms.ProgressBar prgCountTime;
        private System.Windows.Forms.Timer timerCountTime;
    }
}

