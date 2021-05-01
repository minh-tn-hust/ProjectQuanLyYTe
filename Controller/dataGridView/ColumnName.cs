﻿using System;
using YTeModel;
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
                "Username",
                "Password",
            };
            return ls;
        }

        public List<String> trecon()
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
                "Chiều cao",
                "Cân nặng",
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
                "Cân nặng",
                "Thời gian sinh dự kiến"
            };
            return ls;
        }

         public List<String> vacxin()
                {
                    List<String> ls = new List<string>()
                    {
                        "Tên vắc-xin",
                        "Tên lo vắc-xin",
                        "Giá thành",
                        "Ngày sản xuất",
                        "Hạn sử dụng",
                        "Ngày nhập kho",
                        "Thời gian sử dụng lại",
                        "Số mũi cần tiêm",
                        "Số lượng còn lại",
                        "Chống chỉ định",
                        "Thông tin khác",
                    };
                    return ls;
                }


        #endregion
    }
}