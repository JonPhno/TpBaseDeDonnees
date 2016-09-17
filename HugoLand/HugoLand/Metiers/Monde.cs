using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HugoLand.Acces_aux_donnees;

namespace HugoLand.Metiers
{
    class Monde
    {
        //public int Id { get; set; }
        //public string Description { get; set; }
        //public int LimiteX { get; set; }
        //public int LimiteY { get; set; }



        public void CreerMonde(string sDescription, int x, int y)
        {
            using (HUGOLANDEntities context = new HUGOLANDEntities())
            {
                Acces_aux_donnees.Monde monde = new Acces_aux_donnees.Monde()
                {
                    Description = sDescription,
                    LimiteX = x,
                    LimiteY = y
                };
                context.Monde.Add(monde);
                //context.SaveChanges();
            }
        }

        void SupprimerMonde(int id)
        {
            using (HUGOLANDEntities context = new HUGOLANDEntities())
            {
                var monde = (Acces_aux_donnees.Monde)context.Monde.Where(m => m.Id == id);
                context.Monde.Remove(monde);
                //context.SaveChanges();
            }
        }

        void SetLimitesMondes(int id, int x, int y)
        {
            using (HUGOLANDEntities context = new HUGOLANDEntities())
            {
                var monde = (Acces_aux_donnees.Monde)context.Monde.Where(m => m.Id == id);
                monde.LimiteX = x;
                monde.LimiteY = y;
                //context.SaveChanges();
            }
        }

        List<Acces_aux_donnees.Monde> RetourListeMonde()
        {
            using (HUGOLANDEntities context = new HUGOLANDEntities())
            {
                return context.Monde.ToList();
            }
        }
    }
}
