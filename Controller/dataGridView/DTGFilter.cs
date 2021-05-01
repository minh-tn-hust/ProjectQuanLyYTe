using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using YTeDB;
using System.Windows.Forms;

namespace Controller.dataGridView
{
    public class DTGFilter
    {
        public DataTable searchRow(DataGridView dgv, String nameColumn, String value)
        {
            DataTable dt = dgv.DataSource as DataTable;
            return (dt.AsEnumerable()
                        .Where(row => row.Field<String>(nameColumn) == value)
                        .OrderByDescending(row => row.Field<String>(nameColumn))
                        .CopyToDataTable());
        }
    }
}
