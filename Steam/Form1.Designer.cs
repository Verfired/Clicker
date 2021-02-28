
namespace Steam
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
            this.gunaTrackBar1 = new Guna.UI.WinForms.GunaTrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cps = new System.Windows.Forms.Timer(this.components);
            this.gunaCheckBox1 = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.Clicker = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.gunaCheckBox2 = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaCheckBox3 = new Guna.UI.WinForms.GunaCheckBox();
            this.OnlyMc = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // gunaTrackBar1
            // 
            this.gunaTrackBar1.Location = new System.Drawing.Point(12, 48);
            this.gunaTrackBar1.Maximum = 20;
            this.gunaTrackBar1.Name = "gunaTrackBar1";
            this.gunaTrackBar1.Size = new System.Drawing.Size(316, 23);
            this.gunaTrackBar1.TabIndex = 0;
            this.gunaTrackBar1.TrackColor = System.Drawing.Color.DimGray;
            this.gunaTrackBar1.TrackHoverColor = System.Drawing.Color.Gray;
            this.gunaTrackBar1.TrackIdleColor = System.Drawing.Color.Silver;
            this.gunaTrackBar1.TrackPressedColor = System.Drawing.Color.Black;
            this.gunaTrackBar1.Value = 2;
            this.gunaTrackBar1.Visible = false;
            this.gunaTrackBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.gunaTrackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(132, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cps :";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(186, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "2";
            this.label2.Visible = false;
            // 
            // Cps
            // 
            this.Cps.Enabled = true;
            this.Cps.Tick += new System.EventHandler(this.Cps_Tick);
            // 
            // gunaCheckBox1
            // 
            this.gunaCheckBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCheckBox1.CheckedOffColor = System.Drawing.Color.Gray;
            this.gunaCheckBox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaCheckBox1.FillColor = System.Drawing.Color.White;
            this.gunaCheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaCheckBox1.ForeColor = System.Drawing.Color.White;
            this.gunaCheckBox1.Location = new System.Drawing.Point(12, 29);
            this.gunaCheckBox1.Name = "gunaCheckBox1";
            this.gunaCheckBox1.Size = new System.Drawing.Size(84, 22);
            this.gunaCheckBox1.TabIndex = 3;
            this.gunaCheckBox1.Text = "Clicker";
            this.gunaCheckBox1.CheckedChanged += new System.EventHandler(this.gunaCheckBox1_CheckedChanged);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // Clicker
            // 
            this.Clicker.Tick += new System.EventHandler(this.Clicker_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(157, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Toggle [ON]";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gunaCheckBox2
            // 
            this.gunaCheckBox2.BaseColor = System.Drawing.Color.White;
            this.gunaCheckBox2.CheckedOffColor = System.Drawing.Color.Gray;
            this.gunaCheckBox2.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaCheckBox2.FillColor = System.Drawing.Color.White;
            this.gunaCheckBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaCheckBox2.ForeColor = System.Drawing.Color.White;
            this.gunaCheckBox2.Location = new System.Drawing.Point(12, 78);
            this.gunaCheckBox2.Name = "gunaCheckBox2";
            this.gunaCheckBox2.Size = new System.Drawing.Size(122, 22);
            this.gunaCheckBox2.TabIndex = 5;
            this.gunaCheckBox2.Text = "Blatant Mod";
            this.gunaCheckBox2.Visible = false;
            this.gunaCheckBox2.CheckedChanged += new System.EventHandler(this.gunaCheckBox2_CheckedChanged);
            // 
            // gunaCheckBox3
            // 
            this.gunaCheckBox3.BaseColor = System.Drawing.Color.White;
            this.gunaCheckBox3.CheckedOffColor = System.Drawing.Color.Gray;
            this.gunaCheckBox3.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaCheckBox3.FillColor = System.Drawing.Color.White;
            this.gunaCheckBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaCheckBox3.ForeColor = System.Drawing.Color.White;
            this.gunaCheckBox3.Location = new System.Drawing.Point(12, 106);
            this.gunaCheckBox3.Name = "gunaCheckBox3";
            this.gunaCheckBox3.Size = new System.Drawing.Size(142, 22);
            this.gunaCheckBox3.TabIndex = 6;
            this.gunaCheckBox3.Text = "Only Minecraft";
            this.gunaCheckBox3.Visible = false;
            this.gunaCheckBox3.CheckedChanged += new System.EventHandler(this.gunaCheckBox3_CheckedChanged);
            // 
            // OnlyMc
            // 
            this.OnlyMc.Tick += new System.EventHandler(this.OnlyMc_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(594, 382);
            this.Controls.Add(this.gunaCheckBox3);
            this.Controls.Add(this.gunaCheckBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gunaCheckBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaTrackBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Toggle [OFF]";
            this.Load += new System.EventHandler(this.F_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaTrackBar gunaTrackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer Cps;
        private Guna.UI.WinForms.GunaCheckBox gunaCheckBox1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private System.Windows.Forms.Timer Clicker;
        private System.Windows.Forms.Button button1;
        private Guna.UI.WinForms.GunaCheckBox gunaCheckBox2;
        private Guna.UI.WinForms.GunaCheckBox gunaCheckBox3;
        private System.Windows.Forms.Timer OnlyMc;
    }
}

