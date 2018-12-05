using System.Collections.Generic;

namespace RENBaaaaaaaaaaN
{
    public partial class ThisAddIn
    {
        public const string ADDIN_NAME = "RENBaaaaaaaaaaN";
        private Dictionary<int, Microsoft.Office.Tools.CustomTaskPane> inputPanels;

        public void ShowInputPanel()
        {
            var activeWindow = Globals.ThisAddIn.Application.ActiveWindow;
            Microsoft.Office.Tools.CustomTaskPane inputPanelPane;

            var found = inputPanels.TryGetValue(activeWindow.Hwnd, out inputPanelPane);
            if (!found)
            {
                var inputPanel = new InputPanel();
                inputPanelPane = this.CustomTaskPanes.Add(inputPanel, ADDIN_NAME, activeWindow);
                inputPanels.Add(activeWindow.Hwnd, inputPanelPane);
            }
            inputPanelPane.Visible = true;
        }

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            inputPanels = new Dictionary<int, Microsoft.Office.Tools.CustomTaskPane>();
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
