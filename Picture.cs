using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 期末0507
{
    internal class Picture
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Mood { get; set; }
        public string Weather { get; set; }
        public string Content { get; set; }
        public byte[] Photo { get; set; } // 存儲圖片的二進制數據
    }
}
