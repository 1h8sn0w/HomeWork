namespace Dispatcher
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.меню1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пунктToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пунктToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.меню2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dispatcherDataSet1 = new Dispatcher.DispatcherDataSet();
            this.dispatcherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dispatcherTableAdapter1 = new Dispatcher.DispatcherDataSetTableAdapters.DispatcherTableAdapter();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketTableAdapter1 = new Dispatcher.DispatcherDataSetTableAdapters.TicketTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispatcherDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispatcherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.меню1ToolStripMenuItem,
            this.меню2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(925, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // меню1ToolStripMenuItem
            // 
            this.меню1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пунктToolStripMenuItem,
            this.пунктToolStripMenuItem1});
            this.меню1ToolStripMenuItem.Name = "меню1ToolStripMenuItem";
            this.меню1ToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.меню1ToolStripMenuItem.Text = "Меню1";
            // 
            // пунктToolStripMenuItem
            // 
            this.пунктToolStripMenuItem.Name = "пунктToolStripMenuItem";
            this.пунктToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.пунктToolStripMenuItem.Text = "пункт";
            // 
            // пунктToolStripMenuItem1
            // 
            this.пунктToolStripMenuItem1.Name = "пунктToolStripMenuItem1";
            this.пунктToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.пунктToolStripMenuItem1.Text = "пункт";
            // 
            // меню2ToolStripMenuItem
            // 
            this.меню2ToolStripMenuItem.Name = "меню2ToolStripMenuItem";
            this.меню2ToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.меню2ToolStripMenuItem.Text = "Меню2";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 59);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Имя диспетчера";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.dispatcherBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Новый билет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView1.DataSource = this.ticketBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(167, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(746, 411);
            this.dataGridView1.TabIndex = 4;
            // 
            // dispatcherDataSet1
            // 
            this.dispatcherDataSet1.DataSetName = "DispatcherDataSet";
            this.dispatcherDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dispatcherBindingSource
            // 
            this.dispatcherBindingSource.DataMember = "Dispatcher";
            this.dispatcherBindingSource.DataSource = this.dispatcherDataSet1;
            // 
            // dispatcherTableAdapter1
            // 
            this.dispatcherTableAdapter1.ClearBeforeFill = true;
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataMember = "Ticket";
            this.ticketBindingSource.DataSource = this.dispatcherDataSet1;
            // 
            // ticketTableAdapter1
            // 
            this.ticketTableAdapter1.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SeatN";
            this.dataGridViewTextBoxColumn1.HeaderText = "SeatN";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cost";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cost";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Time";
            this.dataGridViewTextBoxColumn3.HeaderText = "Time";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ClientName";
            this.dataGridViewTextBoxColumn4.HeaderText = "ClientName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Passport";
            this.dataGridViewTextBoxColumn5.HeaderText = "Passport";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Privileges";
            this.dataGridViewTextBoxColumn6.HeaderText = "Privileges";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(925, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dispatcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispatcherDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispatcherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem меню1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пунктToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пунктToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem меню2ToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DispatcherDataSet dispatcherDataSet;
        private DispatcherDataSetTableAdapters.TicketTableAdapter ticketTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn privilegesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voyageIdDataGridViewTextBoxColumn;
        private DispatcherDataSetTableAdapters.DispatcherTableAdapter dispatcherTableAdapter;
        private DispatcherDataSet dispatcherDataSet1;
        private System.Windows.Forms.BindingSource dispatcherBindingSource;
        private DispatcherDataSetTableAdapters.DispatcherTableAdapter dispatcherTableAdapter1;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private DispatcherDataSetTableAdapters.TicketTableAdapter ticketTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

