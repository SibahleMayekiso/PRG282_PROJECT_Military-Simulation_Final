namespace PRG282_PROJECT_Military_Simulations
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
            this.ammolbl = new System.Windows.Forms.Label();
            this.scorelbl = new System.Windows.Forms.Label();
            this.healthlbl = new System.Windows.Forms.Label();
            this.fuellbl = new System.Windows.Forms.Label();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.fuelBar = new System.Windows.Forms.ProgressBar();
            this.aircraftPicBox = new System.Windows.Forms.PictureBox();
            this.mainCampPicBox = new System.Windows.Forms.PictureBox();
            this.enymyCampPicBox = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.enemyHealthLabel = new System.Windows.Forms.Label();
            this.enemyCampHealth = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.aircraftPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainCampPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enymyCampPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ammolbl
            // 
            this.ammolbl.AutoSize = true;
            this.ammolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ammolbl.Location = new System.Drawing.Point(7, 12);
            this.ammolbl.Name = "ammolbl";
            this.ammolbl.Size = new System.Drawing.Size(92, 24);
            this.ammolbl.TabIndex = 0;
            this.ammolbl.Text = "Ammo - 0";
            // 
            // scorelbl
            // 
            this.scorelbl.AutoSize = true;
            this.scorelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorelbl.Location = new System.Drawing.Point(119, 12);
            this.scorelbl.Name = "scorelbl";
            this.scorelbl.Size = new System.Drawing.Size(86, 24);
            this.scorelbl.TabIndex = 1;
            this.scorelbl.Text = "Score - 0";
            // 
            // healthlbl
            // 
            this.healthlbl.AutoSize = true;
            this.healthlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthlbl.Location = new System.Drawing.Point(229, 13);
            this.healthlbl.Name = "healthlbl";
            this.healthlbl.Size = new System.Drawing.Size(69, 24);
            this.healthlbl.TabIndex = 0;
            this.healthlbl.Text = "Health:";
            // 
            // fuellbl
            // 
            this.fuellbl.AutoSize = true;
            this.fuellbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuellbl.Location = new System.Drawing.Point(467, 14);
            this.fuellbl.Name = "fuellbl";
            this.fuellbl.Size = new System.Drawing.Size(53, 24);
            this.fuellbl.TabIndex = 1;
            this.fuellbl.Text = "Fuel:";
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(311, 13);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(136, 23);
            this.healthBar.TabIndex = 2;
            this.healthBar.Value = 100;
            // 
            // fuelBar
            // 
            this.fuelBar.Location = new System.Drawing.Point(538, 14);
            this.fuelBar.Name = "fuelBar";
            this.fuelBar.Size = new System.Drawing.Size(137, 23);
            this.fuelBar.TabIndex = 2;
            this.fuelBar.Value = 100;
            // 
            // aircraftPicBox
            // 
            this.aircraftPicBox.Image = global::PRG282_PROJECT_Military_Simulations.Properties.Resources.player_front;
            this.aircraftPicBox.Location = new System.Drawing.Point(475, 462);
            this.aircraftPicBox.Name = "aircraftPicBox";
            this.aircraftPicBox.Size = new System.Drawing.Size(90, 90);
            this.aircraftPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.aircraftPicBox.TabIndex = 3;
            this.aircraftPicBox.TabStop = false;
            // 
            // mainCampPicBox
            // 
            this.mainCampPicBox.Image = global::PRG282_PROJECT_Military_Simulations.Properties.Resources.military_camp;
            this.mainCampPicBox.Location = new System.Drawing.Point(357, 462);
            this.mainCampPicBox.Name = "mainCampPicBox";
            this.mainCampPicBox.Size = new System.Drawing.Size(90, 90);
            this.mainCampPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mainCampPicBox.TabIndex = 3;
            this.mainCampPicBox.TabStop = false;
            // 
            // enymyCampPicBox
            // 
            this.enymyCampPicBox.Image = global::PRG282_PROJECT_Military_Simulations.Properties.Resources.enemy_camp;
            this.enymyCampPicBox.Location = new System.Drawing.Point(419, 55);
            this.enymyCampPicBox.Name = "enymyCampPicBox";
            this.enymyCampPicBox.Size = new System.Drawing.Size(90, 90);
            this.enymyCampPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enymyCampPicBox.TabIndex = 3;
            this.enymyCampPicBox.TabStop = false;
            this.enymyCampPicBox.Tag = "EnemyCamp";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.mainTimerEvent);
            // 
            // enemyHealthLabel
            // 
            this.enemyHealthLabel.AutoSize = true;
            this.enemyHealthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyHealthLabel.Location = new System.Drawing.Point(681, 13);
            this.enemyHealthLabel.Name = "enemyHealthLabel";
            this.enemyHealthLabel.Size = new System.Drawing.Size(125, 24);
            this.enemyHealthLabel.TabIndex = 1;
            this.enemyHealthLabel.Text = "Enemy Camp";
            // 
            // enemyCampHealth
            // 
            this.enemyCampHealth.Location = new System.Drawing.Point(806, 13);
            this.enemyCampHealth.Name = "enemyCampHealth";
            this.enemyCampHealth.Size = new System.Drawing.Size(124, 23);
            this.enemyCampHealth.TabIndex = 2;
            this.enemyCampHealth.Value = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(942, 564);
            this.Controls.Add(this.enymyCampPicBox);
            this.Controls.Add(this.mainCampPicBox);
            this.Controls.Add(this.aircraftPicBox);
            this.Controls.Add(this.enemyCampHealth);
            this.Controls.Add(this.fuelBar);
            this.Controls.Add(this.enemyHealthLabel);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.fuellbl);
            this.Controls.Add(this.healthlbl);
            this.Controls.Add(this.scorelbl);
            this.Controls.Add(this.ammolbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.aircraftPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainCampPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enymyCampPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ammolbl;
        private System.Windows.Forms.Label scorelbl;
        private System.Windows.Forms.Label healthlbl;
        private System.Windows.Forms.Label fuellbl;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.ProgressBar fuelBar;
        private System.Windows.Forms.PictureBox aircraftPicBox;
        private System.Windows.Forms.PictureBox mainCampPicBox;
        private System.Windows.Forms.PictureBox enymyCampPicBox;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label enemyHealthLabel;
        private System.Windows.Forms.ProgressBar enemyCampHealth;
    }
}

