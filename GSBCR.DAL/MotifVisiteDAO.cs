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
            return null;
        }

        public static List<MOTIF_VISITE> FindAll()
        {
            //A faire : charger tous les motifs visite
            return null;
        }
    }
}
