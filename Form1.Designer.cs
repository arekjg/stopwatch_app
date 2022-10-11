
namespace stopwatch_app
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
            this.label_h = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.button_pause = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label_m = new System.Windows.Forms.Label();
            this.label_s = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_h
            // 
            this.label_h.AutoSize = true;
            this.label_h.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_h.Location = new System.Drawing.Point(38, 28);
            this.label_h.Name = "label_h";
            this.label_h.Size = new System.Drawing.Size(59, 43);
            this.label_h.TabIndex = 0;
            this.label_h.Text = "00";
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(12, 89);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 43);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "START";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_pause
            // 
            this.button_pause.Location = new System.Drawing.Point(93, 89);
            this.button_pause.Name = "button_pause";
            this.button_pause.Size = new System.Drawing.Size(75, 43);
            this.button_pause.TabIndex = 2;
            this.button_pause.Text = "PAUSE";
            this.button_pause.UseVisualStyleBackColor = true;
            this.button_pause.Click += new System.EventHandler(this.button_pause_Click);
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(174, 89);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(75, 43);
            this.button_stop.TabIndex = 3;
            this.button_stop.Text = "STOP";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label_m
            // 
            this.label_m.AutoSize = true;
            this.label_m.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_m.Location = new System.Drawing.Point(103, 28);
            this.label_m.Name = "label_m";
            this.label_m.Size = new System.Drawing.Size(59, 43);
            this.label_m.TabIndex = 4;
            this.label_m.Text = "00";
            // 
            // label_s
            // 
            this.label_s.AutoSize = true;
            this.label_s.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_s.Location = new System.Drawing.Point(168, 28);
            this.label_s.Name = "label_s";
            this.label_s.Size = new System.Drawing.Size(59, 43);
            this.label_s.TabIndex = 4;
            this.label_s.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 148);
            this.Controls.Add(this.label_s);
            this.Controls.Add(this.label_m);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_pause);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.label_h);
            this.Name = "Form1";
            this.Text = "Stopwatch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_h;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_pause;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label_m;
        private System.Windows.Forms.Label label_s;
    }
}

