namespace Weather_Station_sql
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.connectionStatusStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonKyiv = new System.Windows.Forms.Button();
            this.buttonLviv = new System.Windows.Forms.Button();
            this.buttonBerlin = new System.Windows.Forms.Button();
            this.buttonSelo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.connectionStatusStrip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(147, 17);
            this.toolStripStatusLabel1.Text = "Connection to SQL data base";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel2.Text = "Status:";
            // 
            // connectionStatusStrip
            // 
            this.connectionStatusStrip.Name = "connectionStatusStrip";
            this.connectionStatusStrip.Size = new System.Drawing.Size(39, 17);
            this.connectionStatusStrip.Text = "Closed";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(709, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "SQL Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // buttonKyiv
            // 
            this.buttonKyiv.Location = new System.Drawing.Point(13, 13);
            this.buttonKyiv.Name = "buttonKyiv";
            this.buttonKyiv.Size = new System.Drawing.Size(75, 23);
            this.buttonKyiv.TabIndex = 2;
            this.buttonKyiv.Text = "Kyiv";
            this.buttonKyiv.UseVisualStyleBackColor = true;
            this.buttonKyiv.Click += new System.EventHandler(this.buttonKyiv_Click);
            // 
            // buttonLviv
            // 
            this.buttonLviv.Location = new System.Drawing.Point(13, 43);
            this.buttonLviv.Name = "buttonLviv";
            this.buttonLviv.Size = new System.Drawing.Size(75, 23);
            this.buttonLviv.TabIndex = 3;
            this.buttonLviv.Text = "Lviv";
            this.buttonLviv.UseVisualStyleBackColor = true;
            this.buttonLviv.Click += new System.EventHandler(this.buttonLviv_Click);
            // 
            // buttonBerlin
            // 
            this.buttonBerlin.Location = new System.Drawing.Point(13, 73);
            this.buttonBerlin.Name = "buttonBerlin";
            this.buttonBerlin.Size = new System.Drawing.Size(75, 23);
            this.buttonBerlin.TabIndex = 4;
            this.buttonBerlin.Text = "Berlin";
            this.buttonBerlin.UseVisualStyleBackColor = true;
            this.buttonBerlin.Click += new System.EventHandler(this.buttonBerlin_Click);
            // 
            // buttonSelo
            // 
            this.buttonSelo.Location = new System.Drawing.Point(13, 103);
            this.buttonSelo.Name = "buttonSelo";
            this.buttonSelo.Size = new System.Drawing.Size(75, 23);
            this.buttonSelo.TabIndex = 5;
            this.buttonSelo.Text = "Selo";
            this.buttonSelo.UseVisualStyleBackColor = true;
            this.buttonSelo.Click += new System.EventHandler(this.buttonSelo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSelo);
            this.Controls.Add(this.buttonBerlin);
            this.Controls.Add(this.buttonLviv);
            this.Controls.Add(this.buttonKyiv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        public System.Windows.Forms.ToolStripStatusLabel connectionStatusStrip;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonKyiv;
        private System.Windows.Forms.Button buttonLviv;
        private System.Windows.Forms.Button buttonBerlin;
        private System.Windows.Forms.Button buttonSelo;
        public System.Windows.Forms.Label label1;
    }
}

