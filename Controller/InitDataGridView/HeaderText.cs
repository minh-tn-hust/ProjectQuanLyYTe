using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    class HeaderText 
    {
        #region Ten cot 
        public List<String> htconnguoi()
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

        public List<String> htnhanVien()
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

        public List<String> httrecon()
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

        public List<String> htphunumangthai()
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
