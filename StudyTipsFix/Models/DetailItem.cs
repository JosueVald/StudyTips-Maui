using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyTipsFix.Models
{
    public class DetailItem
    {
        public string index { get; set; }
        public int id { get; set; }
        public int parentID { get; set; }
        public string caption { get; set; }
        public string description { get; set; }
        public bool favorite { get; set; }

        public DetailItem()
        {

        }

        public DetailItem(string idx, string desc)
        {
            index = idx;
            description = desc;
        }
    }
}
