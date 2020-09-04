using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace RunHuaAdmin.Models
{
    public class OrderViewModel
    {
        /// <summary>
        /// 公司名稱
        /// </summary>
        [DisplayName("客戶(店家)")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 學生
        /// </summary>
        [DisplayName("學生姓名")]
        public string[] StudentName { get; set; }

        /// <summary>
        /// 數量
        /// </summary>
        [DisplayName("本數")]
        public string Amount { get; set; }

        /// <summary>
        /// 顏色
        /// </summary>
        [DisplayName("顏色")]
        public string[] Color { get; set; }

        /// <summary>
        /// 作業狀態
        /// </summary>
        [DisplayName("作業狀態")]
        public string Status { get; set; }

    }
}