using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HugoLand.Acces_aux_donnees;
using HugoLand.Metiers;

namespace HugoLand
{
    class Program
    {
        static void Main(string[] args)
        {
            using (HUGOLANDEntities context = new HUGOLANDEntities())
            {
                foreach (var item in context.Monde)
                {
                    Console.WriteLine(item.Id + " " + item.Description + " " + item.LimiteX + " " + item.LimiteY );
                }


                Console.ReadLine();
                Metiers.Monde monde = new Metiers.Monde();
                monde.CreerMonde("test" , 69 ,69);
                Console.ReadLine();

            }
        }
    }
}
