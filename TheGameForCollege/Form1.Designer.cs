namespace TheGameForCollege
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.plFinish = new System.Windows.Forms.Panel();
            this.timerForMove = new System.Windows.Forms.Timer(this.components);
            this.timerForTraLie = new System.Windows.Forms.Timer(this.components);
            this.pbFinish = new System.Windows.Forms.PictureBox();
            this.pbTrafficLights = new System.Windows.Forms.PictureBox();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pbRoad2 = new System.Windows.Forms.PictureBox();
            this.pbPC = new System.Windows.Forms.PictureBox();
            this.pbRoad1 = new System.Windows.Forms.PictureBox();
            this.lblTrafficLights = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFinish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrafficLights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoad2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoad1)).BeginInit();
            this.SuspendLayout();
            // 
            // plFinish
            // 
            this.plFinish.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.plFinish.Location = new System.Drawing.Point(12, 180);
            this.plFinish.Name = "plFinish";
            this.plFinish.Size = new System.Drawing.Size(10, 385);
            this.plFinish.TabIndex = 7;
            this.plFinish.Visible = false;
            // 
            // timerForMove
            // 
            this.timerForMove.Tick += new System.EventHandler(this.timerForMove_Tick);
            // 
            // timerForTraLie
            // 
            this.timerForTraLie.Interval = 500;
            this.timerForTraLie.Tick += new System.EventHandler(this.timerForTraLie_Tick);
            // 
            // pbFinish
            // 
            this.pbFinish.Image = global::TheGameForCollege.Properties.Resources.Screenshot_5;
            this.pbFinish.Location = new System.Drawing.Point(0, 12);
            this.pbFinish.Name = "pbFinish";
            this.pbFinish.Size = new System.Drawing.Size(130, 171);
            this.pbFinish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFinish.TabIndex = 8;
            this.pbFinish.TabStop = false;
            this.pbFinish.Visible = false;
            // 
            // pbTrafficLights
            // 
            this.pbTrafficLights.Image = global::TheGameForCollege.Properties.Resources.Screenshot_4;
            this.pbTrafficLights.Location = new System.Drawing.Point(403, 12);
            this.pbTrafficLights.Name = "pbTrafficLights";
            this.pbTrafficLights.Size = new System.Drawing.Size(146, 157);
            this.pbTrafficLights.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTrafficLights.TabIndex = 6;
            this.pbTrafficLights.TabStop = false;
            this.pbTrafficLights.Visible = false;
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackgroundImage = global::TheGameForCollege.Properties.Resources.BackRoad;
            this.pbPlayer.Image = global::TheGameForCollege.Properties.Resources.user_car;
            this.pbPlayer.Location = new System.Drawing.Point(1126, 412);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(100, 100);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer.TabIndex = 0;
            this.pbPlayer.TabStop = false;
            this.pbPlayer.Visible = false;
            // 
            // pbRoad2
            // 
            this.pbRoad2.Image = global::TheGameForCollege.Properties.Resources.road;
            this.pbRoad2.Location = new System.Drawing.Point(0, 354);
            this.pbRoad2.Name = "pbRoad2";
            this.pbRoad2.Size = new System.Drawing.Size(1264, 217);
            this.pbRoad2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRoad2.TabIndex = 5;
            this.pbRoad2.TabStop = false;
            this.pbRoad2.Visible = false;
            // 
            // pbPC
            // 
            this.pbPC.BackgroundImage = global::TheGameForCollege.Properties.Resources.BackRoad;
            this.pbPC.Image = global::TheGameForCollege.Properties.Resources.PC_car;
            this.pbPC.Location = new System.Drawing.Point(1126, 238);
            this.pbPC.Name = "pbPC";
            this.pbPC.Size = new System.Drawing.Size(100, 100);
            this.pbPC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPC.TabIndex = 1;
            this.pbPC.TabStop = false;
            this.pbPC.Visible = false;
            // 
            // pbRoad1
            // 
            this.pbRoad1.Image = global::TheGameForCollege.Properties.Resources.road;
            this.pbRoad1.Location = new System.Drawing.Point(0, 180);
            this.pbRoad1.Name = "pbRoad1";
            this.pbRoad1.Size = new System.Drawing.Size(1264, 217);
            this.pbRoad1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRoad1.TabIndex = 2;
            this.pbRoad1.TabStop = false;
            this.pbRoad1.Visible = false;
            // 
            // lblTrafficLights
            // 
            this.lblTrafficLights.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTrafficLights.ForeColor = System.Drawing.Color.Black;
            this.lblTrafficLights.Location = new System.Drawing.Point(590, 58);
            this.lblTrafficLights.Name = "lblTrafficLights";
            this.lblTrafficLights.Size = new System.Drawing.Size(596, 111);
            this.lblTrafficLights.TabIndex = 9;
            this.lblTrafficLights.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(421, 215);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(452, 221);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Начать Игру";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnMove
            // 
            this.btnMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMove.Location = new System.Drawing.Point(207, 532);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(864, 137);
            this.btnMove.TabIndex = 12;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Visible = false;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResult.Location = new System.Drawing.Point(145, 35);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(975, 610);
            this.lblResult.TabIndex = 14;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResult.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.plFinish);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTrafficLights);
            this.Controls.Add(this.pbFinish);
            this.Controls.Add(this.pbTrafficLights);
            this.Controls.Add(this.pbRoad2);
            this.Controls.Add(this.pbPC);
            this.Controls.Add(this.pbRoad1);
            this.Controls.Add(this.lblResult);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbFinish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrafficLights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoad2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoad1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.PictureBox pbPC;
        private System.Windows.Forms.PictureBox pbRoad1;
        private System.Windows.Forms.PictureBox pbRoad2;
        private System.Windows.Forms.PictureBox pbTrafficLights;
        private System.Windows.Forms.Panel plFinish;
        private System.Windows.Forms.Timer timerForMove;
        private System.Windows.Forms.Timer timerForTraLie;
        private System.Windows.Forms.PictureBox pbFinish;
        private System.Windows.Forms.Label lblTrafficLights;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Label lblResult;
    }
}

