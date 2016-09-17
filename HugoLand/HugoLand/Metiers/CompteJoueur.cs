using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HugoLand.Acces_aux_donnees;


namespace HugoLand.Metiers
{
    class CompteJoueur
    {
        void CreerJoueur()
        {
            using (HUGOLANDEntities context = new HUGOLANDEntities())
            {
                Acces_aux_donnees.CompteJoueur joueur = new Acces_aux_donnees.CompteJoueur();
                context.CompteJoueur.Add(joueur);

                //context.SaveChanges();
            }
        }

        void SupprimerJoueur(int id)
        {
            using (HUGOLANDEntities context = new HUGOLANDEntities())
            {
               context.CompteJoueur.Remove((Acces_aux_donnees.CompteJoueur)context.CompteJoueur.Where(j=> j.Id == id));
                //context.SaveChanges();
            }
        }

        void ModifierParametres()
        {
            using (HUGOLANDEntities context = new HUGOLANDEntities())
            {

                //context.SaveChanges();
            }
        }

        void VerifierConnexionJoueur()
        {
            using (HUGOLANDEntities context = new HUGOLANDEntities())
            {

                //context.SaveChanges();
            }
        }
    }
}
