using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apteka
{
    public class AptekaClass
    {
        public string Aptekaname;
        public Dictionary<string, decimal> lekva = new Dictionary<string, decimal>();
        /// <summary>
        /// Находит максимальное значение по Value из словаря. 
        /// </summary>
        /// <param name="GetMax"></param>
        /// <returns></returns>
        public KeyValuePair<string, decimal> GetMax(AptekaClass ttt)
        {
            return ttt.lekva.Aggregate((x, y) => x.Value > y.Value ? x : y);
        }
        public decimal Sum(AptekaClass ttt)
        {
            return ttt.lekva.Sum(x => x.Value);
        }
        public void Spisok(AptekaClass ttt)
        {
            foreach (var v in ttt.lekva)
            {
                Console.WriteLine(v);
            }
        }
    }
}