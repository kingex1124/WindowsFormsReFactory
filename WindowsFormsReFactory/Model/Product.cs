using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsReFactory.Model
{
    public class Product
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        
        public Size Size { get; set; }

        public bool IsNeedCool { get; set; }


    }
    public class Size
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public double Height { get; set; }
    }
}
