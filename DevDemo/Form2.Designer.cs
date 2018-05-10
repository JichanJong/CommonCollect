namespace WindowsFormsApplication1
{
    partial class Form2
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
            DevExpress.XtraPivotGrid.PivotGridCustomTotal pivotGridCustomTotal1 = new DevExpress.XtraPivotGrid.PivotGridCustomTotal();
            DevExpress.XtraPivotGrid.PivotGridCustomTotal pivotGridCustomTotal2 = new DevExpress.XtraPivotGrid.PivotGridCustomTotal();
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup1 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup2 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            this.pivotGridField6 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField7 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField4 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField5 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.pivotGridField3 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldAvgRain = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldAvgCount = new DevExpress.XtraPivotGrid.PivotGridField();
            this.ctiysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctiysBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridField6
            // 
            this.pivotGridField6.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridField6.AreaIndex = 0;
            this.pivotGridField6.Caption = "年";
            this.pivotGridField6.FieldName = "PrecipitationTime";
            this.pivotGridField6.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.pivotGridField6.Name = "pivotGridField6";
            this.pivotGridField6.UnboundFieldName = "pivotGridField6";
            // 
            // pivotGridField7
            // 
            this.pivotGridField7.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridField7.AreaIndex = 1;
            this.pivotGridField7.Caption = "季度";
            this.pivotGridField7.FieldName = "PrecipitationTime";
            this.pivotGridField7.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
            this.pivotGridField7.Name = "pivotGridField7";
            this.pivotGridField7.UnboundFieldName = "pivotGridField7";
            // 
            // pivotGridField4
            // 
            this.pivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField4.AreaIndex = 0;
            this.pivotGridField4.Caption = "降雨量";
            pivotGridCustomTotal1.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            pivotGridCustomTotal1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average;
            this.pivotGridField4.CustomTotals.AddRange(new DevExpress.XtraPivotGrid.PivotGridCustomTotal[] {
            pivotGridCustomTotal1});
            this.pivotGridField4.FieldName = "RainfallValue";
            this.pivotGridField4.Name = "pivotGridField4";
            // 
            // pivotGridField5
            // 
            this.pivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField5.AreaIndex = 1;
            this.pivotGridField5.Caption = "次数";
            this.pivotGridField5.FieldName = "Count";
            this.pivotGridField5.Name = "pivotGridField5";
            // 
            // pivotGridField1
            // 
            this.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField1.AreaIndex = 0;
            this.pivotGridField1.Caption = "省";
            pivotGridCustomTotal2.CellFormat.FormatString = "n2";
            pivotGridCustomTotal2.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            pivotGridCustomTotal2.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average;
            this.pivotGridField1.CustomTotals.AddRange(new DevExpress.XtraPivotGrid.PivotGridCustomTotal[] {
            pivotGridCustomTotal2});
            this.pivotGridField1.FieldName = "Province";
            this.pivotGridField1.Name = "pivotGridField1";
            this.pivotGridField1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average;
            this.pivotGridField1.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.CustomTotals;
            // 
            // pivotGridField2
            // 
            this.pivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField2.AreaIndex = 1;
            this.pivotGridField2.Caption = "城市";
            this.pivotGridField2.FieldName = "CityName";
            this.pivotGridField2.Name = "pivotGridField2";
            this.pivotGridField2.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None;
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.DataSource = this.ctiysBindingSource;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.pivotGridField6,
            this.pivotGridField1,
            this.pivotGridField2,
            this.pivotGridField3,
            this.pivotGridField7,
            this.pivotGridField4,
            this.pivotGridField5,
            this.fieldAvgRain,
            this.fieldAvgCount});
            pivotGridGroup1.Caption = "Year - Quarter";
            pivotGridGroup1.Fields.Add(this.pivotGridField6);
            pivotGridGroup1.Fields.Add(this.pivotGridField7);
            pivotGridGroup1.Hierarchy = null;
            pivotGridGroup1.ShowNewValues = true;
            pivotGridGroup2.Caption = "Value - Count";
            pivotGridGroup2.Fields.Add(this.pivotGridField4);
            pivotGridGroup2.Fields.Add(this.pivotGridField5);
            pivotGridGroup2.Hierarchy = null;
            pivotGridGroup2.ShowNewValues = true;
            this.pivotGridControl1.Groups.AddRange(new DevExpress.XtraPivotGrid.PivotGridGroup[] {
            pivotGridGroup1,
            pivotGridGroup2});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsView.ShowColumnTotals = false;
            this.pivotGridControl1.OptionsView.ShowFilterHeaders = false;
            this.pivotGridControl1.Size = new System.Drawing.Size(893, 560);
            this.pivotGridControl1.TabIndex = 0;
            this.pivotGridControl1.CustomSummary += new DevExpress.XtraPivotGrid.PivotGridCustomSummaryEventHandler(this.pivotGridControl1_CustomSummary);
            // 
            // pivotGridField3
            // 
            this.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField3.AreaIndex = 2;
            this.pivotGridField3.Caption = "区";
            this.pivotGridField3.FieldName = "Area";
            this.pivotGridField3.Name = "pivotGridField3";
            // 
            // fieldAvgRain
            // 
            this.fieldAvgRain.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldAvgRain.AreaIndex = 2;
            this.fieldAvgRain.Caption = "平均降水";
            this.fieldAvgRain.CellFormat.FormatString = "n2";
            this.fieldAvgRain.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldAvgRain.FieldName = "RainfallValue";
            this.fieldAvgRain.Name = "fieldAvgRain";
            this.fieldAvgRain.Options.ShowTotals = false;
            this.fieldAvgRain.Options.ShowValues = false;
            this.fieldAvgRain.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom;
            this.fieldAvgRain.Tag = "AvgRain";
            this.fieldAvgRain.ValueFormat.FormatString = "n2";
            this.fieldAvgRain.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldAvgCount
            // 
            this.fieldAvgCount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldAvgCount.AreaIndex = 3;
            this.fieldAvgCount.Caption = "平均次数";
            this.fieldAvgCount.CellFormat.FormatString = "n2";
            this.fieldAvgCount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldAvgCount.FieldName = "Count";
            this.fieldAvgCount.Name = "fieldAvgCount";
            this.fieldAvgCount.Options.ShowTotals = false;
            this.fieldAvgCount.Options.ShowValues = false;
            this.fieldAvgCount.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom;
            this.fieldAvgCount.Tag = "AvgCount";
            // 
            // ctiysBindingSource
            // 
            this.ctiysBindingSource.DataSource = typeof(WindowsFormsApplication1.City);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 560);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctiysBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private System.Windows.Forms.BindingSource ctiysBindingSource;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField2;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField3;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField4;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField5;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField6;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField7;
        private DevExpress.XtraPivotGrid.PivotGridField fieldAvgRain;
        private DevExpress.XtraPivotGrid.PivotGridField fieldAvgCount;
    }
}