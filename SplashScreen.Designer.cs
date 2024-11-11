namespace LiftSimGame
{
    partial class SplashScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            splash_loading_bar = new ProgressBar();
            splash_progressbar_timer = new System.Windows.Forms.Timer(components);
            loading_label = new Label();
            SuspendLayout();
            // 
            // splash_loading_bar
            // 
            splash_loading_bar.Anchor = AnchorStyles.Bottom;
            splash_loading_bar.BackColor = Color.FromArgb(255, 128, 128);
            splash_loading_bar.ForeColor = Color.DarkTurquoise;
            splash_loading_bar.Location = new Point(89, 693);
            splash_loading_bar.MarqueeAnimationSpeed = 10000;
            splash_loading_bar.Name = "splash_loading_bar";
            splash_loading_bar.Size = new Size(997, 24);
            splash_loading_bar.Step = 5;
            splash_loading_bar.Style = ProgressBarStyle.Continuous;
            splash_loading_bar.TabIndex = 0;
            splash_loading_bar.Value = 70;
            // 
            // splash_progressbar_timer
            // 
            splash_progressbar_timer.Enabled = true;
            splash_progressbar_timer.Tick += splash_progressbar_timer_Tick;
            // 
            // loading_label
            // 
            loading_label.AutoSize = true;
            loading_label.BackColor = Color.Transparent;
            loading_label.FlatStyle = FlatStyle.Flat;
            loading_label.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loading_label.ForeColor = Color.White;
            loading_label.Location = new Point(509, 645);
            loading_label.Name = "loading_label";
            loading_label.Size = new Size(177, 45);
            loading_label.TabIndex = 1;
            loading_label.Text = "Loading...";
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1174, 729);
            Controls.Add(loading_label);
            Controls.Add(splash_loading_bar);
            MaximizeBox = false;
            MaximumSize = new Size(1200, 800);
            MinimizeBox = false;
            MinimumSize = new Size(1200, 800);
            Name = "SplashScreen";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loading...";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar splash_loading_bar;
        private System.Windows.Forms.Timer splash_progressbar_timer;
        private Label loading_label;
    }
}
    