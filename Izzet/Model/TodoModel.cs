using Izzet.Core.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izzet.Model
{
    internal class TodoModel:Base
    {
        public string OwnName { get; set; }
        public string OwnNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerNumber { get; set; }
        public int Kod { get; set; }
        public string HomeLandKod { get; set; } = Guid.NewGuid().ToString("N").Substring(0, 10);
        public DateTime AddTime { get; set; }= DateTime.Now;
        public int DeletedId { get; set; } = 0;
        public int HomePrice { get; set; }
        public double OwnPrice { get; set; }
        public double CustomerPrice { get; set; }

    
    }
}
