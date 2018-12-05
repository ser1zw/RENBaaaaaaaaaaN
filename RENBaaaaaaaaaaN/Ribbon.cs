using Microsoft.Office.Tools.Ribbon;

namespace RENBaaaaaaaaaaN
{
    public partial class Ribbon
    {
        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {
        }

        private void openInputPanelButton_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.ShowInputPanel();
        }
    }
}
