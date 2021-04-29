using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.InitDataGridView
{
    class  ColumnName
    {
        #region Ten cot 
        public List<String> connguoi()
        {
            List<String> ls = new List<string>()
            {
                "stt",
                "hovanten",
                "socmnd",
                "ngaysinh",
                "gioitinh",
                "nghenghiep",
                "diachi",
                "sodienthoai",
                "email",
            };
            return ls;
        }

        public List<String> nhanvien()
        {
            List<String> ls = new List<string>()
            {
                "stt",
                "hovanten",
                "socmnd",
                "ngaysinh",
                "gioitinh",
                "nghenghiep",
                "diachi",
                "sodienthoai",
                "email",
                "username",
                "password",
            };
            return ls;
        }

        public List<String> trecon()
        {
            List<String> ls = new List<string>()
            {
                "stt",
                "hovanten",
                "socmnd",
                "ngaysinh",
                "gioitinh",
                "nghenghiep",
                "diachi",
                "sodienthoai",
                "email",
                "thoigianthamkham",
                "chieucao",
                "cannang",
            };
            return ls;
        }

        public List<String> phunumangthai()
        {
            List<String> ls = new List<string>()
            {
                "stt",
                "hovanten",
                "socmnd",
                "ngaysinh",
                "gioitinh",
                "nghenghiep",
                "diachi",
                "sodienthoai",
                "email",
                "Thời gian thăm khám",
                "Cân nặng",
                "Thời gian sinh dự kiến"
            };
            return ls;
        }
        #endregion
    }
}
