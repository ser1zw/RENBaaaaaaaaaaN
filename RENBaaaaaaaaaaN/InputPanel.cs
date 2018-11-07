using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace RENBaaaaaaaaaaN
{
    public partial class InputPanel : UserControl
    {
        public InputPanel()
        {
            InitializeComponent();
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            var direction = (topToBottomRadioButton.Checked) ? SequenceDirection.TopToBottom : SequenceDirection.LeftToRight;
            var startNumber = (uint)startWithUpDown.Value;
            var step = (uint)stepUpDown.Value;

            try
            {
                var sheet = Globals.ThisAddIn.Application.ActiveSheet as Excel.Worksheet;
                var shapeRange = Globals.ThisAddIn.Application.Selection.ShapeRange as Excel.ShapeRange;

                var sequentialNumberService = new SequentialNumberService();
                sequentialNumberService.SetSequentialNumber(shapeRange, startNumber, step, direction);
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
            {
                MessageBox.Show("連番を設定するオートシェイプを選択してください。", ThisAddIn.ADDIN_NAME);
            }
            catch (Exception)
            {
                MessageBox.Show("不明なエラーが発生しました。", ThisAddIn.ADDIN_NAME);
            }
        }
    }
}