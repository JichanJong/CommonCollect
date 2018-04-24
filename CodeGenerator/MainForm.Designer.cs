namespace CodeGenerator
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbConnections = new System.Windows.Forms.ComboBox();
            this.btnLoadAllTable = new System.Windows.Forms.Button();
            this.btnAddConnection = new System.Windows.Forms.Button();
            this.dgvTables = new System.Windows.Forms.DataGridView();
            this.TableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvTableInfo = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identity = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PrimaryKey = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsNullable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DefaultValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGenerateDbContext = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGenerateModel = new System.Windows.Forms.Button();
            this.btnCopyConnection = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableInfo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbConnections
            // 
            this.cbConnections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConnections.FormattingEnabled = true;
            this.cbConnections.Location = new System.Drawing.Point(4, 3);
            this.cbConnections.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbConnections.Name = "cbConnections";
            this.cbConnections.Size = new System.Drawing.Size(513, 20);
            this.cbConnections.TabIndex = 0;
            // 
            // btnLoadAllTable
            // 
            this.btnLoadAllTable.Location = new System.Drawing.Point(520, 3);
            this.btnLoadAllTable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLoadAllTable.Name = "btnLoadAllTable";
            this.btnLoadAllTable.Size = new System.Drawing.Size(76, 22);
            this.btnLoadAllTable.TabIndex = 1;
            this.btnLoadAllTable.Text = "加载所有表";
            this.btnLoadAllTable.UseVisualStyleBackColor = true;
            this.btnLoadAllTable.Click += new System.EventHandler(this.btnLoadAllTable_Click);
            // 
            // btnAddConnection
            // 
            this.btnAddConnection.Location = new System.Drawing.Point(600, 3);
            this.btnAddConnection.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddConnection.Name = "btnAddConnection";
            this.btnAddConnection.Size = new System.Drawing.Size(76, 22);
            this.btnAddConnection.TabIndex = 2;
            this.btnAddConnection.Text = "添加连接";
            this.btnAddConnection.UseVisualStyleBackColor = true;
            this.btnAddConnection.Click += new System.EventHandler(this.btnAddConnection_Click);
            // 
            // dgvTables
            // 
            this.dgvTables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTables.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TableName,
            this.Description1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTables.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTables.Location = new System.Drawing.Point(0, 0);
            this.dgvTables.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvTables.MultiSelect = false;
            this.dgvTables.Name = "dgvTables";
            this.dgvTables.ReadOnly = true;
            this.dgvTables.RowTemplate.Height = 23;
            this.dgvTables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTables.Size = new System.Drawing.Size(348, 468);
            this.dgvTables.TabIndex = 3;
            this.dgvTables.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTables_CellContentDoubleClick);
            this.dgvTables.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTables_CellDoubleClick);
            // 
            // TableName
            // 
            this.TableName.DataPropertyName = "TableName";
            this.TableName.HeaderText = "表名";
            this.TableName.Name = "TableName";
            this.TableName.ReadOnly = true;
            // 
            // Description1
            // 
            this.Description1.DataPropertyName = "Description";
            this.Description1.HeaderText = "描述";
            this.Description1.Name = "Description1";
            this.Description1.ReadOnly = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 38);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvTables);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvTableInfo);
            this.splitContainer1.Size = new System.Drawing.Size(1115, 468);
            this.splitContainer1.SplitterDistance = 348;
            this.splitContainer1.TabIndex = 4;
            // 
            // dgvTableInfo
            // 
            this.dgvTableInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTableInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTableInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.DataType,
            this.DataLength,
            this.Precision,
            this.Identity,
            this.PrimaryKey,
            this.IsNullable,
            this.DefaultValue,
            this.Description});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTableInfo.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTableInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTableInfo.Location = new System.Drawing.Point(0, 0);
            this.dgvTableInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvTableInfo.Name = "dgvTableInfo";
            this.dgvTableInfo.ReadOnly = true;
            this.dgvTableInfo.RowTemplate.Height = 23;
            this.dgvTableInfo.Size = new System.Drawing.Size(763, 468);
            this.dgvTableInfo.TabIndex = 0;
            // 
            // ColumnName
            // 
            this.ColumnName.DataPropertyName = "ColumnName";
            this.ColumnName.HeaderText = "列名";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Width = 54;
            // 
            // DataType
            // 
            this.DataType.DataPropertyName = "DataType";
            this.DataType.HeaderText = "数据类型";
            this.DataType.Name = "DataType";
            this.DataType.ReadOnly = true;
            this.DataType.Width = 78;
            // 
            // DataLength
            // 
            this.DataLength.DataPropertyName = "DataLength";
            this.DataLength.HeaderText = "数据长度";
            this.DataLength.Name = "DataLength";
            this.DataLength.ReadOnly = true;
            this.DataLength.Width = 78;
            // 
            // Precision
            // 
            this.Precision.DataPropertyName = "Precision";
            this.Precision.HeaderText = "精度";
            this.Precision.Name = "Precision";
            this.Precision.ReadOnly = true;
            this.Precision.Width = 54;
            // 
            // Identity
            // 
            this.Identity.DataPropertyName = "Identity";
            this.Identity.HeaderText = "标识";
            this.Identity.Name = "Identity";
            this.Identity.ReadOnly = true;
            this.Identity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Identity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Identity.Width = 54;
            // 
            // PrimaryKey
            // 
            this.PrimaryKey.DataPropertyName = "PrimaryKey";
            this.PrimaryKey.HeaderText = "主键";
            this.PrimaryKey.Name = "PrimaryKey";
            this.PrimaryKey.ReadOnly = true;
            this.PrimaryKey.Width = 35;
            // 
            // IsNullable
            // 
            this.IsNullable.DataPropertyName = "IsNullable";
            this.IsNullable.HeaderText = "可空";
            this.IsNullable.Name = "IsNullable";
            this.IsNullable.ReadOnly = true;
            this.IsNullable.Width = 35;
            // 
            // DefaultValue
            // 
            this.DefaultValue.DataPropertyName = "DefaultValue";
            this.DefaultValue.HeaderText = "默认值";
            this.DefaultValue.Name = "DefaultValue";
            this.DefaultValue.ReadOnly = true;
            this.DefaultValue.Width = 66;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "描述";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 54;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCopyConnection);
            this.panel1.Controls.Add(this.btnGenerateDbContext);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnGenerateModel);
            this.panel1.Controls.Add(this.cbConnections);
            this.panel1.Controls.Add(this.btnLoadAllTable);
            this.panel1.Controls.Add(this.btnAddConnection);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1115, 38);
            this.panel1.TabIndex = 5;
            // 
            // btnGenerateDbContext
            // 
            this.btnGenerateDbContext.Location = new System.Drawing.Point(853, 3);
            this.btnGenerateDbContext.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGenerateDbContext.Name = "btnGenerateDbContext";
            this.btnGenerateDbContext.Size = new System.Drawing.Size(114, 22);
            this.btnGenerateDbContext.TabIndex = 5;
            this.btnGenerateDbContext.Text = "生成DbContext";
            this.btnGenerateDbContext.UseVisualStyleBackColor = true;
            this.btnGenerateDbContext.Click += new System.EventHandler(this.btnGenerateDbContext_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(760, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 22);
            this.button1.TabIndex = 4;
            this.button1.Text = "生成Mapping";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGenerateModel
            // 
            this.btnGenerateModel.Location = new System.Drawing.Point(680, 3);
            this.btnGenerateModel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGenerateModel.Name = "btnGenerateModel";
            this.btnGenerateModel.Size = new System.Drawing.Size(76, 22);
            this.btnGenerateModel.TabIndex = 3;
            this.btnGenerateModel.Text = "生成Model";
            this.btnGenerateModel.UseVisualStyleBackColor = true;
            this.btnGenerateModel.Click += new System.EventHandler(this.btnGenerateModel_Click);
            // 
            // btnCopyConnection
            // 
            this.btnCopyConnection.Location = new System.Drawing.Point(974, 3);
            this.btnCopyConnection.Name = "btnCopyConnection";
            this.btnCopyConnection.Size = new System.Drawing.Size(111, 23);
            this.btnCopyConnection.TabIndex = 6;
            this.btnCopyConnection.Text = "复制连接字符串";
            this.btnCopyConnection.UseVisualStyleBackColor = true;
            this.btnCopyConnection.Click += new System.EventHandler(this.btnCopyConnection_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 506);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTables)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbConnections;
        private System.Windows.Forms.Button btnLoadAllTable;
        private System.Windows.Forms.Button btnAddConnection;
        private System.Windows.Forms.DataGridView dgvTables;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvTableInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precision;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Identity;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PrimaryKey;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsNullable;
        private System.Windows.Forms.DataGridViewTextBoxColumn DefaultValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.Button btnGenerateModel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGenerateDbContext;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description1;
        private System.Windows.Forms.Button btnCopyConnection;
    }
}