using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyTipsFix.Models
{
    public class IconItem
    {
        public string imagePath { get; set; }

        public IconItem(string path)
        {
            imagePath = path;
        }
    }
}
