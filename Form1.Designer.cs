namespace NNPG2_2024_Uloha_06_Bajer_Lukas
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SpawnNext = new System.Windows.Forms.Button();
            this.UseDoubleBuffering = new System.Windows.Forms.CheckBox();
            this.useHQInterpolation = new System.Windows.Forms.CheckBox();
            this.CleanDead = new System.Windows.Forms.Button();
            this.DeadLabel = new System.Windows.Forms.Label();
            this.AliveLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.SpawnHundered = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(947, 530);
            this.splitContainer1.SplitterDistance = 489;
            this.splitContainer1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.SpawnNext);
            this.flowLayoutPanel1.Controls.Add(this.SpawnHundered);
            this.flowLayoutPanel1.Controls.Add(this.UseDoubleBuffering);
            this.flowLayoutPanel1.Controls.Add(this.useHQInterpolation);
            this.flowLayoutPanel1.Controls.Add(this.CleanDead);
            this.flowLayoutPanel1.Controls.Add(this.AliveLabel);
            this.flowLayoutPanel1.Controls.Add(this.DeadLabel);
            this.flowLayoutPanel1.Controls.Add(this.TimerLabel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(947, 37);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // SpawnNext
            // 
            this.SpawnNext.Location = new System.Drawing.Point(3, 3);
            this.SpawnNext.Name = "SpawnNext";
            this.SpawnNext.Size = new System.Drawing.Size(75, 23);
            this.SpawnNext.TabIndex = 0;
            this.SpawnNext.Text = "Další komár";
            this.SpawnNext.UseVisualStyleBackColor = true;
            this.SpawnNext.Click += new System.EventHandler(this.SpawnNext_Click);
            // 
            // UseDoubleBuffering
            // 
            this.UseDoubleBuffering.AutoSize = true;
            this.UseDoubleBuffering.Location = new System.Drawing.Point(165, 3);
            this.UseDoubleBuffering.Name = "UseDoubleBuffering";
            this.UseDoubleBuffering.Size = new System.Drawing.Size(105, 17);
            this.UseDoubleBuffering.TabIndex = 1;
            this.UseDoubleBuffering.Text = "Double Buffering";
            this.UseDoubleBuffering.UseVisualStyleBackColor = true;
            this.UseDoubleBuffering.CheckedChanged += new System.EventHandler(this.UseDoubleBuffering_CheckedChanged);
            // 
            // useHQInterpolation
            // 
            this.useHQInterpolation.AutoSize = true;
            this.useHQInterpolation.Location = new System.Drawing.Point(276, 3);
            this.useHQInterpolation.Name = "useHQInterpolation";
            this.useHQInterpolation.Size = new System.Drawing.Size(103, 17);
            this.useHQInterpolation.TabIndex = 2;
            this.useHQInterpolation.Text = "HQ Interpolation";
            this.useHQInterpolation.UseVisualStyleBackColor = true;
            this.useHQInterpolation.CheckedChanged += new System.EventHandler(this.useHQInterpolation_CheckedChanged);
            // 
            // CleanDead
            // 
            this.CleanDead.Location = new System.Drawing.Point(385, 3);
            this.CleanDead.Name = "CleanDead";
            this.CleanDead.Size = new System.Drawing.Size(75, 23);
            this.CleanDead.TabIndex = 3;
            this.CleanDead.Text = "Uklidit mrtvoly";
            this.CleanDead.UseVisualStyleBackColor = true;
            this.CleanDead.Click += new System.EventHandler(this.CleanDead_Click);
            // 
            // DeadLabel
            // 
            this.DeadLabel.AutoSize = true;
            this.DeadLabel.Location = new System.Drawing.Point(553, 0);
            this.DeadLabel.Name = "DeadLabel";
            this.DeadLabel.Size = new System.Drawing.Size(85, 13);
            this.DeadLabel.TabIndex = 4;
            this.DeadLabel.Text = "Celkem mrtvých:";
            // 
            // AliveLabel
            // 
            this.AliveLabel.AutoSize = true;
            this.AliveLabel.Location = new System.Drawing.Point(466, 0);
            this.AliveLabel.Name = "AliveLabel";
            this.AliveLabel.Size = new System.Drawing.Size(81, 13);
            this.AliveLabel.TabIndex = 5;
            this.AliveLabel.Text = "Celkem živých: ";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 489);
            this.panel1.TabIndex = 0;
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Location = new System.Drawing.Point(644, 0);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(118, 13);
            this.TimerLabel.TabIndex = 6;
            this.TimerLabel.Text = "Čas vykreslení snímku:";
            // 
            // SpawnHundered
            // 
            this.SpawnHundered.Location = new System.Drawing.Point(84, 3);
            this.SpawnHundered.Name = "SpawnHundered";
            this.SpawnHundered.Size = new System.Drawing.Size(75, 23);
            this.SpawnHundered.TabIndex = 7;
            this.SpawnHundered.Text = "Dalších 100";
            this.SpawnHundered.UseVisualStyleBackColor = true;
            this.SpawnHundered.Click += new System.EventHandler(this.SpawnHundered_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 530);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button SpawnNext;
        private System.Windows.Forms.CheckBox UseDoubleBuffering;
        private System.Windows.Forms.CheckBox useHQInterpolation;
        private System.Windows.Forms.Button CleanDead;
        private System.Windows.Forms.Label AliveLabel;
        private System.Windows.Forms.Label DeadLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Button SpawnHundered;
    }
}

