using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsReFactory.Model;

namespace WindowsFormsReFactory.Business
{
    public class FactoryRepository
    {
        /// <summary>
        /// 將ILogistics的instance，交給工廠來決定
        /// </summary>
        /// <param name="company"></param>
        /// <param name="product"></param>
        /// <returns></returns>
        public static ILogistics GetILogistics(string company, Product product)
        {
            if (company == "1")
            {
                return new BlackCat() { ShipProduct = product };
            }
            else if (company == "2")
            {
                return new Hsinchu() { ShipProduct = product };
            }
            else if (company == "3")
            {
                return new PostOffice() { ShipProduct = product };
            }
            else
            {
                return null;
            }
        }
    }
}
