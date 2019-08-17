namespace TH17Trainer
{
    partial class Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.CloseButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.stateLabel = new System.Windows.Forms.Label();
            this.gsTimer = new System.Windows.Forms.Timer(this.components);
            this.immortalityBox = new System.Windows.Forms.CheckBox();
            this.infbombsBox = new System.Windows.Forms.CheckBox();
            this.powerBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(256, 13);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(30, 30);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.TabStop = false;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Location = new System.Drawing.Point(216, 13);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(30, 30);
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.TabStop = false;
            this.MinimizeButton.Text = "-";
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.ForeColor = System.Drawing.Color.Red;
            this.stateLabel.Location = new System.Drawing.Point(14, 19);
            this.stateLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(88, 18);
            this.stateLabel.TabIndex = 2;
            this.stateLabel.Text = "th17.exe";
            // 
            // gsTimer
            // 
            this.gsTimer.Enabled = true;
            this.gsTimer.Interval = 500;
            this.gsTimer.Tick += new System.EventHandler(this.GsTimer_Tick);
            // 
            // immortalityBox
            // 
            this.immortalityBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.immortalityBox.AutoSize = true;
            this.immortalityBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.immortalityBox.Location = new System.Drawing.Point(12, 54);
            this.immortalityBox.Name = "immortalityBox";
            this.immortalityBox.Size = new System.Drawing.Size(158, 28);
            this.immortalityBox.TabIndex = 3;
            this.immortalityBox.TabStop = false;
            this.immortalityBox.Text = "Immortality   ";
            this.immortalityBox.UseVisualStyleBackColor = true;
            this.immortalityBox.CheckedChanged += new System.EventHandler(this.ImmortalityBox_CheckedChanged);
            // 
            // infbombsBox
            // 
            this.infbombsBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.infbombsBox.AutoSize = true;
            this.infbombsBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infbombsBox.Location = new System.Drawing.Point(12, 104);
            this.infbombsBox.Name = "infbombsBox";
            this.infbombsBox.Size = new System.Drawing.Size(158, 28);
            this.infbombsBox.TabIndex = 4;
            this.infbombsBox.TabStop = false;
            this.infbombsBox.Text = "Infinite bombs";
            this.infbombsBox.UseVisualStyleBackColor = true;
            this.infbombsBox.CheckedChanged += new System.EventHandler(this.InfbombsBox_CheckedChanged);
            // 
            // powerBox
            // 
            this.powerBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.powerBox.AutoSize = true;
            this.powerBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.powerBox.Location = new System.Drawing.Point(12, 154);
            this.powerBox.Name = "powerBox";
            this.powerBox.Size = new System.Drawing.Size(158, 28);
            this.powerBox.TabIndex = 5;
            this.powerBox.TabStop = false;
            this.powerBox.Text = "Power resupply";
            this.powerBox.UseVisualStyleBackColor = true;
            this.powerBox.CheckedChanged += new System.EventHandler(this.PowerBox_CheckedChanged);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.powerBox);
            this.Controls.Add(this.infbombsBox);
            this.Controls.Add(this.immortalityBox);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.CloseButton);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Window";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Window_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Window_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Timer gsTimer;
        private System.Windows.Forms.CheckBox immortalityBox;
        private System.Windows.Forms.CheckBox infbombsBox;
        private System.Windows.Forms.CheckBox powerBox;
    }
}

