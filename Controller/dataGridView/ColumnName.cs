using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.dataGridView
{
    public class ColumnName
    {
        #region Ten cot 
        public List<String> connguoi()
        {
            List<String> ls = new List<string>()
            {
                "STT",
                "Họ và tên",
                "Số CMND",
                "Ngày sinh",
                "Giới tính",
                "Nghề nghiệp",
                "Địa chỉ",
                "Số điện thoại",
                "Email",
            };
            return ls;
        }

        public List<String> nhanvien()
        {
            List<String> ls = new List<string>()
            {
                "STT",
                "Họ và tên",
                "Số CMND",
                "Ngày sinh",
                "Giới tính",
                "Nghề nghiệp",
                "Địa chỉ",
                "Số điện thoại",
                "Email",
                "Nơi làm việc",
                "Username",
                "Password",
            };
            return ls;
        }

        public List<String> trecon()
        {
            List<String> ls = new List<string>()
            {
                "STT", //0
                "Họ và tên", //1
                "Họ và tên bố", //2
                "Họ và tên mẹ", //3
                "Số CMND", //4
                "Ngày sinh", //5
                "Giới tính", //6
                "Nghề nghiệp", //7
                "Địa chỉ", //8
                "Số điện thoại", //9
                "Email", //10
                "Thời gian thăm khám", //11
                "Chiều cao", //12
                "Cân nặng", //13
            };
            return ls;
        }
        public List<String> onlytrecon()
        {
            List<String> ls = new List<string>()
            {
                "STT", //0
                "Họ và tên", //1
                "Số CMND", //4
                "Ngày sinh", //5
                "Giới tính", //6
                "Nghề nghiệp", //7
                "Địa chỉ", //8
                "Số điện thoại", //9
                "Email", //10
            };
            return ls;
        }

        public List<String> phunumangthai()
        {
            List<String> ls = new List<string>()
            {
                "STT",
                "Họ và tên",
                "Số CMND",
                "Ngày sinh",
                "Giới tính",
                "Nghề nghiệp",
                "Địa chỉ",
                "Số điện thoại",
                "Email",
                "Thời gian thăm khám",
                "Thời gian sinh dự kiến"
            };
            return ls;
        }
        //Sử dụng cho bảng thêm mới
         public List<String> vacxinThemMoi()
         {
                List<String> ls = new List<string>()
                {   "STT",
                    "Tên vắc-xin",
                    "Tên lô vắc-xin",
                    "Giá thành",
                    "Ngày sản xuất",
                    "Hạn sử dụng",
                    "Ngày nhập kho",
                    "Thời gian sử dụng lại",
                    "Số mũi tiêm cần dùng",
                    "Số lượng nhập kho",
                    "Chống chỉ định",
                    "Thông tin khác",
                };
                return ls;
         }

        public List<String> vacxin()
        {
            List<String> ls = new List<string>()
                {   "STT",
                    "Tên vắc-xin",
                    "Tên lô vắc-xin",
                    "Giá thành",
                    "Ngày sản xuất",
                    "Hạn sử dụng",
                    "Ngày nhập kho",
                    "Thời gian sử dụng lại",
                    "Số mũi tiêm cần dùng",
                    "Số lượng còn lại",
                    "Chống chỉ định",
                    "Thông tin khác",
                };
            return ls;
        }
        //Phòng Khám
        public List<String> phongkham()
        {
            List<String> ls = new List<String>()
            {
                "STT",
                "Tên phòng khám",
                "Tên người quản lý",
                "Địa chỉ",
                "Ngày bắt đầu làm việc trong tuần",
                "Ngày kết thúc làm việc trong tuần",
                "Giờ bắt đầu",
                "Giờ kết thúc",
                "Số điện thoại liên hệ",
                "Thông tin khác",
            };
            return ls;
        }
        #endregion
    public List<String> datlichkham()
            {
                List<String> ls = new List<string>()
                {
                    "STT",
                    "Họ và tên",
                    "Số CMND",
                    "Ngày sinh",
                    "Giới tính",
                    "Nghề nghiệp",
                    "Địa chỉ",
                    "Số điện thoại",
                    "Email",
                    "Thời gian hẹn khám",
                    "Lý do khám",
                    "Ghi chú",
                    "Phòng khám",
                    "Người Làm Đơn"

                };
                return ls;
            }

        public List<String> sudung()
        {
            List<String> ls = new List<String>()
            {
                "STT",
                "Họ tên",
                "Tên vắc xin",
                "Thời điểm tiêm",
                "Mũi tiêm",
                "Phòng khám"
            };
            return ls;
        }
    }
}
