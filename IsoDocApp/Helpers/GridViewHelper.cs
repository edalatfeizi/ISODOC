using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoDocApp.Helpers
{
    public static class GridViewHelper
    {
        public static object GetGridViewCellValue(DevExpress.XtraGrid.Views.Grid.GridView gridView, string columnName)
        {
            int rowHandle = gridView.FocusedRowHandle;

            if (rowHandle >= 0)
            {
                var value = gridView.GetRowCellValue(rowHandle, columnName);
                return value;
            }
            return null;
        }
    }
}
