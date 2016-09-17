using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HugoLand.Acces_aux_donnees;

namespace HugoLand.Metiers
{
    class ObjetMonde
    {
        void CreerObjet(string description, int id, Acces_aux_donnees.Monde monde, int mondeId,int typeObjet, int x, int y )
        {
            using (HUGOLANDEntities context = new HUGOLANDEntities())
            {
                Acces_aux_donnees.ObjetMonde objet = new Acces_aux_donnees.ObjetMonde()
                {
                    Id = id,
                    Monde = monde,
                    MondeId = mondeId,
                    Description = description,
                    TypeObjet = typeObjet,
                    x = x,
                    y = y
                };
                context.ObjetMonde.Add(objet);
                //context.SaveChanges();
            }
        }

        void SupprimerObjet(int id,Acces_aux_donnees.Monde monde)
        {
            using (HUGOLANDEntities context = new HUGOLANDEntities())
            {
                context.ObjetMonde.Remove((Acces_aux_donnees.ObjetMonde)context.ObjetMonde.Where(o => o.Id == id && o.Monde == monde));
                //context.SaveChanges();
            }
        }

        void ModifierDescriptionObjet(int id, Acces_aux_donnees.Monde monde, string description)
        {
            using (HUGOLANDEntities context = new HUGOLANDEntities())
            {
                Acces_aux_donnees.ObjetMonde objet = (Acces_aux_donnees.ObjetMonde)context.ObjetMonde.Where(o => o.Id == id && o.Monde == monde);
                objet.Description = description;
                //context.SaveChanges();
            }
        }
    }
}
