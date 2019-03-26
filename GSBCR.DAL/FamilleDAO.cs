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
    public static class FamilleDAO
    {
        public static FAMILLE FindById(string code)
        {
            //A faire : rechercher une famille de médicaments par son nom
            FAMILLE med = null;
            using (var context = new GSB_VisiteEntities())
            {
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from f in context.FAMILLE
                          where f.FAM_CODE == code
                          select f;
                med = req.SingleOrDefault<FAMILLE>();
            }
            return med;
        }

        public static List<FAMILLE> FindAll()
        {
            //A faire : charger toutes les familles de médicaments
            List<FAMILLE> fams = null;
            using (var context = new GSB_VisiteEntities())
            {
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from f in context.FAMILLE
                          select f;
                fams = req.ToList<FAMILLE>();
            }
            return fams;
        }

    }
}
