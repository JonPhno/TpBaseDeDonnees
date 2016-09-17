using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HugoLand.Acces_aux_donnees;

namespace HugoLand.Metiers
{
    class Monstre
    {
        private Random _rnd = new Random();
        void CreerMonstreAleatoire(Acces_aux_donnees.Monde monde, string nom)
        {
            using (HUGOLANDEntities context = new HUGOLANDEntities())
            {
                Acces_aux_donnees.Monstre monstre = new Acces_aux_donnees.Monstre()
                {
                    ImageId = _rnd.Next(0, 5),//??nombre de idImage??
                    Monde = monde,
                    MondeId = monde.Id,
                    Niveau = _rnd.Next(1, 101),
                    Nom = nom,
                    StatDmgMin = _rnd.Next(1, 101),
                    StatPV = _rnd.Next(1,101),
                    x = _rnd.Next(0,monde.LimiteX),
                    y = _rnd.Next(0, monde.LimiteY)//manque rowVersion et id
                };
                int degatMax;
                do
                {
                    degatMax = _rnd.Next(2, 101);
                } while (monstre.StatDmgMax > degatMax);
                monstre.StatDmgMax = degatMax;

                //context.SaveChanges();
            }
        }

        void SupprimerMonstre(int id)
        {
            using (HUGOLANDEntities context = new HUGOLANDEntities())
            {
                context.Monstre.Remove((Acces_aux_donnees.Monstre)context.Monstre.Where(m => m.Id == id));
                //context.SaveChanges();
            }
        }

        void ModifierInfos(int id , Acces_aux_donnees.Monde monde , int imageId , int niveau, string nom, int dmgMax ,int dmgMin , int pv , int x , int y)
        {
            using (HUGOLANDEntities context = new HUGOLANDEntities())
            {
                Acces_aux_donnees.Monstre monstre = (Acces_aux_donnees.Monstre)context.Monstre.Where(m => m.Id == id);
                monstre.Id = id;
                monstre.ImageId = imageId;
                monstre.Monde = monde;
                monstre.MondeId = monde.Id;
                monstre.Niveau = niveau;
                monstre.Nom = nom;
                monstre.StatDmgMax = dmgMax;
                monstre.StatDmgMin = dmgMin;
                monstre.StatPV = pv;
                monstre.x = x;
                monstre.y = y;

                //context.SaveChanges();
            }
        }
    }
}
