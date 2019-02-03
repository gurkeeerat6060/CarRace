namespace CarRace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Track = new System.Windows.Forms.PictureBox();
            this.Car1 = new System.Windows.Forms.PictureBox();
            this.Car2 = new System.Windows.Forms.PictureBox();
            this.Car3 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRace = new System.Windows.Forms.Button();
            this.btnBet = new System.Windows.Forms.Button();
            this.nmBet = new System.Windows.Forms.NumericUpDown();
            this.cbCar = new System.Windows.Forms.ComboBox();
            this.cbPlayer = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TmCar1 = new System.Windows.Forms.Timer(this.components);
            this.tmCar2 = new System.Windows.Forms.Timer(this.components);
            this.tmCar3 = new System.Windows.Forms.Timer(this.components);
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmBet)).BeginInit();
            this.SuspendLayout();
            // 
            // Track
            // 
            this.Track.Image = ((System.Drawing.Image)(resources.GetObject("Track.Image")));
            this.Track.Location = new System.Drawing.Point(0, 0);
            this.Track.Name = "Track";
            this.Track.Size = new System.Drawing.Size(650, 206);
            this.Track.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Track.TabIndex = 0;
            this.Track.TabStop = false;
            // 
            // Car1
            // 
            this.Car1.Image = ((System.Drawing.Image)(resources.GetObject("Car1.Image")));
            this.Car1.Location = new System.Drawing.Point(8, 8);
            this.Car1.Name = "Car1";
            this.Car1.Size = new System.Drawing.Size(75, 39);
            this.Car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car1.TabIndex = 1;
            this.Car1.TabStop = false;
            // 
            // Car2
            // 
            this.Car2.Image = ((System.Drawing.Image)(resources.GetObject("Car2.Image")));
            this.Car2.Location = new System.Drawing.Point(8, 73);
            this.Car2.Name = "Car2";
            this.Car2.Size = new System.Drawing.Size(75, 39);
            this.Car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car2.TabIndex = 2;
            this.Car2.TabStop = false;
            // 
            // Car3
            // 
            this.Car3.Image = ((System.Drawing.Image)(resources.GetObject("Car3.Image")));
            this.Car3.Location = new System.Drawing.Point(8, 151);
            this.Car3.Name = "Car3";
            this.Car3.Size = new System.Drawing.Size(75, 39);
            this.Car3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car3.TabIndex = 3;
            this.Car3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRace);
            this.groupBox1.Controls.Add(this.btnBet);
            this.groupBox1.Controls.Add(this.nmBet);
            this.groupBox1.Controls.Add(this.cbCar);
            this.groupBox1.Controls.Add(this.cbPlayer);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 187);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Area of Betting";
            // 
            // btnRace
            // 
            this.btnRace.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRace.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRace.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRace.Location = new System.Drawing.Point(439, 137);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(111, 44);
            this.btnRace.TabIndex = 11;
            this.btnRace.Text = "Start Race";
            this.btnRace.UseVisualStyleBackColor = false;
            this.btnRace.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBet
            // 
            this.btnBet.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBet.Location = new System.Drawing.Point(326, 137);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(107, 44);
            this.btnBet.TabIndex = 10;
            this.btnBet.Text = "Bet";
            this.btnBet.UseVisualStyleBackColor = false;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // nmBet
            // 
            this.nmBet.Location = new System.Drawing.Point(518, 87);
            this.nmBet.Name = "nmBet";
            this.nmBet.Size = new System.Drawing.Size(114, 20);
            this.nmBet.TabIndex = 9;
            this.nmBet.ValueChanged += new System.EventHandler(this.nmBet_ValueChanged);
            // 
            // cbCar
            // 
            this.cbCar.FormattingEnabled = true;
            this.cbCar.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbCar.Location = new System.Drawing.Point(516, 54);
            this.cbCar.Name = "cbCar";
            this.cbCar.Size = new System.Drawing.Size(121, 21);
            this.cbCar.TabIndex = 8;
            // 
            // cbPlayer
            // 
            this.cbPlayer.FormattingEnabled = true;
            this.cbPlayer.Items.AddRange(new object[] {
            "Kain",
            "David",
            "Sam"});
            this.cbPlayer.Location = new System.Drawing.Point(516, 16);
            this.cbPlayer.Name = "cbPlayer";
            this.cbPlayer.Size = new System.Drawing.Size(121, 21);
            this.cbPlayer.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Red;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(326, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 26);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fill the Bet Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(359, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Choose the Car";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(346, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Select the Player";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sam has 90 dollar in his Account";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "David has 50 Dollar in his Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kain has 70 Dollar in his Account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minimum Bet Amount is $7";
            // 
            // TmCar1
            // 
            this.TmCar1.Interval = 10;
            this.TmCar1.Tick += new System.EventHandler(this.TmCar1_Tick);
            // 
            // tmCar2
            // 
            this.tmCar2.Interval = 10;
            this.tmCar2.Tick += new System.EventHandler(this.tmCar2_Tick);
            // 
            // tmCar3
            // 
            this.tmCar3.Interval = 10;
            this.tmCar3.Tick += new System.EventHandler(this.tmCar3_Tick);
            // 
            // MainTimer
            // 
            this.MainTimer.Enabled = true;
            this.MainTimer.Interval = 1;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 411);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Car3);
            this.Controls.Add(this.Car2);
            this.Controls.Add(this.Car1);
            this.Controls.Add(this.Track);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmBet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Track;
        private System.Windows.Forms.PictureBox Car1;
        private System.Windows.Forms.PictureBox Car2;
        private System.Windows.Forms.PictureBox Car3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCar;
        private System.Windows.Forms.ComboBox cbPlayer;
        private System.Windows.Forms.NumericUpDown nmBet;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.Button btnRace;
        private System.Windows.Forms.Timer TmCar1;
        private System.Windows.Forms.Timer tmCar2;
        private System.Windows.Forms.Timer tmCar3;
        private System.Windows.Forms.Timer MainTimer;
    }
}

