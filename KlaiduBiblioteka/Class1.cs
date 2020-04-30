using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlaiduBiblioteka
{
    public class SavoExeption : Exception
    {
        public String KodoDalisIskvieteKlaida { get; set; }

        public override string Message => "mano Klaida";
        
    }

    public class SaiciuDarboKlase
    {
        public int GrandParent(int kelintas)
        {
            return Parent(kelintas);
        }
        public int Parent(int kelintas)
        {
            return GautiSkaiciu(kelintas);
        }

        private int GautiSkaiciu(int kelintas)
        {
            int[] skaiciai = { 1, 2, 3, 4, 5, 6 };
            if (kelintas<0)
            {
                throw new SavoExeption();
            }
            return skaiciai[kelintas];
        }
    }
}
