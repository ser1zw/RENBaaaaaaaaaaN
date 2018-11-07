namespace RENBaaaaaaaaaaN
{
    public partial class ThisAddIn
    {
        public const string ADDIN_NAME = "RENBaaaaaaaaaaN";
        public Microsoft.Office.Tools.CustomTaskPane InputPanelPane { get; private set; }

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            var inputPanel = new InputPanel();
            InputPanelPane = this.CustomTaskPanes.Add(inputPanel, ADDIN_NAME);
            InputPanelPane.Visible = false;
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO で生成されたコード

        /// <summary>
        /// デザイナーのサポートに必要なメソッドです。
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
