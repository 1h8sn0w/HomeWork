namespace Dispatcher
{
    partial class AddTicket
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sale = new System.Windows.Forms.CheckBox();
            this.RouteSelector = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passportId = new System.Windows.Forms.TextBox();
            this.clientName = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.seatN = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.Done = new System.Windows.Forms.Button();
            this.routeDataGridView = new System.Windows.Forms.DataGridView();
            this.dispatcherDataSet4 = new Dispatcher.DispatcherDataSet();
            this.routeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.routeTableAdapter4 = new Dispatcher.DispatcherDataSetTableAdapters.RouteTableAdapter();
            this.routeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispatcherDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sale);
            this.groupBox1.Controls.Add(this.RouteSelector);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.passportId);
            this.groupBox1.Controls.Add(this.clientName);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.seatN);
            this.groupBox1.Controls.Add(this.price);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Новый билет";
            // 
            // sale
            // 
            this.sale.AutoSize = true;
            this.sale.Location = new System.Drawing.Point(98, 204);
            this.sale.Name = "sale";
            this.sale.Size = new System.Drawing.Size(63, 17);
            this.sale.TabIndex = 8;
            this.sale.Text = "Скидка";
            this.sale.UseVisualStyleBackColor = true;
            // 
            // RouteSelector
            // 
            this.RouteSelector.DataSource = this.routeBindingSource;
            this.RouteSelector.DisplayMember = "RouteNumer";
            this.RouteSelector.FormattingEnabled = true;
            this.RouteSelector.Location = new System.Drawing.Point(98, 41);
            this.RouteSelector.Name = "RouteSelector";
            this.RouteSelector.Size = new System.Drawing.Size(121, 21);
            this.RouteSelector.TabIndex = 7;
            this.RouteSelector.ValueMember = "RouteNumer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Цена";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Скидка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Пасспорт ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Имя Клиента";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Время покупки";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Маршрут";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Номер места";
            // 
            // passportId
            // 
            this.passportId.Location = new System.Drawing.Point(98, 178);
            this.passportId.Name = "passportId";
            this.passportId.Size = new System.Drawing.Size(138, 20);
            this.passportId.TabIndex = 4;
            this.passportId.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // clientName
            // 
            this.clientName.Location = new System.Drawing.Point(98, 152);
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(138, 20);
            this.clientName.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(98, 126);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(138, 20);
            this.textBox2.TabIndex = 2;
            // 
            // seatN
            // 
            this.seatN.Location = new System.Drawing.Point(98, 74);
            this.seatN.Name = "seatN";
            this.seatN.Size = new System.Drawing.Size(138, 20);
            this.seatN.TabIndex = 1;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(98, 100);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(138, 20);
            this.price.TabIndex = 1;
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(173, 247);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // Done
            // 
            this.Done.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Done.Location = new System.Drawing.Point(27, 247);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(75, 23);
            this.Done.TabIndex = 2;
            this.Done.Text = "Готово";
            this.Done.UseVisualStyleBackColor = true;
            // 
            // routeDataGridView
            // 
            this.routeDataGridView.AllowUserToAddRows = false;
            this.routeDataGridView.AllowUserToDeleteRows = false;
            this.routeDataGridView.AutoGenerateColumns = false;
            this.routeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.routeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22});
            this.routeDataGridView.DataSource = this.routeBindingSource1;
            this.routeDataGridView.Location = new System.Drawing.Point(268, 21);
            this.routeDataGridView.Name = "routeDataGridView";
            this.routeDataGridView.ReadOnly = true;
            this.routeDataGridView.Size = new System.Drawing.Size(553, 220);
            this.routeDataGridView.TabIndex = 3;
            this.routeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.routeDataGridView_CellContentClick);
            // 
            // dispatcherDataSet4
            // 
            this.dispatcherDataSet4.DataSetName = "DispatcherDataSet";
            this.dispatcherDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // routeBindingSource
            // 
            this.routeBindingSource.DataMember = "Route";
            this.routeBindingSource.DataSource = this.dispatcherDataSet4;
            // 
            // routeTableAdapter4
            // 
            this.routeTableAdapter4.ClearBeforeFill = true;
            // 
            // routeBindingSource1
            // 
            this.routeBindingSource1.DataMember = "Route";
            this.routeBindingSource1.DataSource = this.dispatcherDataSet4;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn17.HeaderText = "Id";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "RouteNumer";
            this.dataGridViewTextBoxColumn18.HeaderText = "RouteNumer";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "From";
            this.dataGridViewTextBoxColumn19.HeaderText = "From";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "To";
            this.dataGridViewTextBoxColumn20.HeaderText = "To";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Distance";
            this.dataGridViewTextBoxColumn21.HeaderText = "Distance";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "TimeTravel";
            this.dataGridViewTextBoxColumn22.HeaderText = "TimeTravel";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // AddTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 283);
            this.Controls.Add(this.routeDataGridView);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddTicket";
            this.Text = "AddTicket";
            this.Load += new System.EventHandler(this.AddTicket_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispatcherDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button Cancel;
        public System.Windows.Forms.Button Done;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox passportId;
        public System.Windows.Forms.TextBox clientName;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox seatN;
        public System.Windows.Forms.TextBox price;
        public System.Windows.Forms.ComboBox RouteSelector;
        public System.Windows.Forms.Label label7;
        public DispatcherDataSet dispatcherDataSet;
        public DispatcherDataSetTableAdapters.RouteTableAdapter routeTableAdapter;
        public DispatcherDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.DataGridView routeDataGridView;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        public System.Windows.Forms.CheckBox sale;
        private DispatcherDataSet dispatcherDataSet1;
        private DispatcherDataSetTableAdapters.RouteTableAdapter routeTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeNumerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeTravelDataGridViewTextBoxColumn;
        private DispatcherDataSetTableAdapters.VoyageTableAdapter voyageTableAdapter;
        private DispatcherDataSet dispatcherDataSet2;
        private DispatcherDataSetTableAdapters.RouteTableAdapter routeTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DispatcherDataSet dispatcherDataSet3;
        private DispatcherDataSetTableAdapters.RouteTableAdapter routeTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DispatcherDataSetTableAdapters.VoyageTableAdapter voyageTableAdapter1;
        private DispatcherDataSet dispatcherDataSet4;
        private System.Windows.Forms.BindingSource routeBindingSource;
        private DispatcherDataSetTableAdapters.RouteTableAdapter routeTableAdapter4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.BindingSource routeBindingSource1;
    }
}