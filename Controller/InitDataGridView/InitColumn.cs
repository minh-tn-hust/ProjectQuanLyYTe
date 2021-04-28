using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;


namespace Controller.InitDataGridView
{
    public class InitColumn 
    {
        ColumnName name = new ColumnName();
        HeaderText text = new HeaderText();
        public void connguoi(DataTable dt)
        {
            List<String> Text = text.nhanvien();
            for (int i = 0; i < dt.Columns.Count; ++i)
            {
                dt.Columns[i].ColumnName = Text[i];
            }
        }
    }
}
