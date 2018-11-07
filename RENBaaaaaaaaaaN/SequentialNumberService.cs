using System;
using Excel = Microsoft.Office.Interop.Excel;

namespace RENBaaaaaaaaaaN
{
    enum SequenceDirection
    {
        TopToBottom, LeftToRight
    }

    class SequentialNumberService
    {
        public void SetSequentialNumber(Excel.ShapeRange shapeRange, uint startNumber, uint step, SequenceDirection direction)
        {
            var testFunc = GetTestFunc(direction);
            var sortedShapes = Sort(shapeRange, testFunc);
            for (int i = 0; i < sortedShapes.Length; i++)
            {
                sortedShapes[i].TextFrame2.TextRange.Text = string.Format("{0}", startNumber + (step * i));
            }
        }

        private Func<Excel.Shape, Excel.Shape, float> GetTestFunc(SequenceDirection direction)
        {
            if (direction == SequenceDirection.TopToBottom)
            {
                return (shape1, shape2) => { return shape1.Top - shape2.Top; };
            }
            else
            {
                return (shape1, shape2) => { return shape1.Left - shape2.Left; };
            }
        }

        private Excel.Shape[] Sort(Excel.ShapeRange shapeRange, Func<Excel.Shape, Excel.Shape, float> testFunc)
        {
            var sorted = new Excel.Shape[shapeRange.Count];
            for (int i = 0; i < sorted.Length; i++)
            {
                sorted[i] = shapeRange.Item(i + 1);
            }

            // FIXME: GroupByで一発でソートする
            bool swapped = true;
            while (swapped)
            {
                swapped = false;
                for (int i = 0, length = sorted.Length; i < length - 1; i++)
                {
                    if (testFunc(sorted[i], sorted[i + 1]) > 0)
                    {
                        var tmp = sorted[i + 1];
                        sorted[i + 1] = sorted[i];
                        sorted[i] = tmp;
                        swapped = true;
                    }
                }
            }

            return sorted;
        }
    }
}
