namespace GameWinform
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
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.txtScore = new System.Windows.Forms.Label();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.txtPotion = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.buttonShow = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // txtScore
            // 
            this.txtScore.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtScore.Location = new System.Drawing.Point(451, 666);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(93, 25);
            this.txtScore.TabIndex = 1;
            this.txtScore.Text = "KILLS: 0";
            // 
            // healthBar
            // 
            this.healthBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.healthBar.Location = new System.Drawing.Point(828, 666);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(100, 25);
            this.healthBar.TabIndex = 2;
            // 
            // txtPotion
            // 
            this.txtPotion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPotion.AutoSize = true;
            this.txtPotion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPotion.Location = new System.Drawing.Point(12, 666);
            this.txtPotion.Name = "txtPotion";
            this.txtPotion.Size = new System.Drawing.Size(91, 25);
            this.txtPotion.TabIndex = 3;
            this.txtPotion.Text = "POTION";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.DimGray;
            this.panel.Controls.Add(this.buttonShow);
            this.panel.Controls.Add(this.buttonExit);
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(940, 25);
            this.panel.TabIndex = 4;
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
            // 
            // buttonShow
            // 
            this.buttonShow.BackColor = System.Drawing.Color.Transparent;
            this.buttonShow.BackgroundImage = global::GameWinform.Properties.Resources.buttonShow;
            this.buttonShow.Location = new System.Drawing.Point(890, 3);
            this.buttonShow.Margin = new System.Windows.Forms.Padding(0);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(20, 20);
            this.buttonShow.TabIndex = 1;
            this.buttonShow.TabStop = false;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.BackgroundImage = global::GameWinform.Properties.Resources.buttonExit;
            this.buttonExit.Location = new System.Drawing.Point(917, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(20, 20);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.TabStop = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImage = global::GameWinform.Properties.Resources.player;
            this.player.Location = new System.Drawing.Point(477, 466);
            this.player.Margin = new System.Windows.Forms.Padding(0);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 50);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(940, 700);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.txtPotion);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(940, 700);
            this.MinimumSize = new System.Drawing.Size(940, 700);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.ProgressBar healthBar;
        public System.Windows.Forms.Label txtPotion;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox buttonExit;
        private System.Windows.Forms.PictureBox buttonShow;
    }
}

