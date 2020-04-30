using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KlaiduBiblioteka;

namespace _200430_p17_ExeptionHandlig
{
    class Program
    {
        //pakeitimas
        static void Main(string[] args)
        {
            try
            {
                SaiciuDarboKlase darboKlase = new SaiciuDarboKlase();

                int skaicius = darboKlase.GrandParent(2);
                Console.WriteLine(skaicius);
                int? skai = null;
                Console.WriteLine(darboKlase.GrandParent(-1));

                //Console.WriteLine(darboKlase.GrandParent(58));
                Console.WriteLine("Programa baigia darba");

            }
            catch (IndexOutOfRangeException ex)
            {

                Console.WriteLine(ex.Message);
                //Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Programa po klaidos pranesimu");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("PerduotasNull");
            }
            catch (SavoExeption ex)
            {
                Console.WriteLine(ex.KodoDalisIskvieteKlaida);
            }
            catch (Exception ex)
            {
                Console.WriteLine("nenumatyta klaida" + ex.Message);
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.StackTrace);
            }


        }

    }
}
