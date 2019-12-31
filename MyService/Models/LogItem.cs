using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyService.Models
{
    public class LogItem
    {
        public int Id { get; set; }
        public DateTime LogDate { get; set; }
        public string Message { get; set; }
    }
}
