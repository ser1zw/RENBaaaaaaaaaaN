namespace RENBaaaaaaaaaaN
{
    partial class Ribbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.RenBaaaaaaaaaNGroup = this.Factory.CreateRibbonGroup();
            this.openInputPanelButton = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.RenBaaaaaaaaaNGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.RenBaaaaaaaaaNGroup);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // RenBaaaaaaaaaNGroup
            // 
            this.RenBaaaaaaaaaNGroup.Items.Add(this.openInputPanelButton);
            this.RenBaaaaaaaaaNGroup.Label = "RenBaaaaaaaaaN";
            this.RenBaaaaaaaaaNGroup.Name = "RenBaaaaaaaaaNGroup";
            // 
            // openInputPanelButton
            // 
            this.openInputPanelButton.Label = "連番を設定";
            this.openInputPanelButton.Name = "openInputPanelButton";
            this.openInputPanelButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.openInputPanelButton_Click);
            // 
            // Ribbon
            // 
            this.Name = "Ribbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.RenBaaaaaaaaaNGroup.ResumeLayout(false);
            this.RenBaaaaaaaaaNGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup RenBaaaaaaaaaNGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton openInputPanelButton;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon Ribbon
        {
            get { return this.GetRibbon<Ribbon>(); }
        }
    }
}
