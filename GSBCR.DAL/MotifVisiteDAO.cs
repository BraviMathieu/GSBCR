using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSBCR.modele;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


namespace GSBCR.DAL
{
    public static class MotifVisiteDAO
    {
        public static MOTIF_VISITE FindById(string code)
        {
            //A faire : rechercher un motif visite par son nom
            MOTIF_VISITE mot = null;
            using (var context = new GSB_VisiteEntities())
            {
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from m in context.MOTIF_VISITE.Include("LesRapports")
                          where m.MOT_CODE == code
                          select m;
                mot = req.SingleOrDefault<MOTIF_VISITE>();
            }
            return mot;
        }

        public static List<MOTIF_VISITE> FindAll()
        {
            //A faire : charger tous les motifs visite
            List<MOTIF_VISITE> mots = null;
            using (var context = new GSB_VisiteEntities())
            {
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from f in context.MOTIF_VISITE.Include("LesRapports")
                          select f;
                mots = req.ToList<MOTIF_VISITE>();
            }
            return mots;
        }
    }
}
