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
    public static class VaffectationDAO
    {
        /// <summary>
        /// Permet de retrouver la dernière affectation d'un visiteur à partir de son matricule
        /// en utilisant la vue vaffectation
        /// </summary>
        /// <param name="matricule">matricule Visiteur</param>
        /// <returns>VAFFECTATION</returns>
        public static VAFFECTATION FindByMatricule(string matricule)
        {
            VAFFECTATION v = null;
            using (var context = new GSB_VisiteEntities())
            {
                var req = from vaff in context.VAFFECTATION
                          where vaff.VIS_MATRICULE == matricule
                          select vaff;
                v = req.SingleOrDefault();
            }
            return v;
        }
        /// <summary>
        /// Permet de retourner une liste d'affectations pour un région en utilisant la vue VAFFECTATION
        /// </summary>
        /// <param name="regionCode">code région</param>
        /// <returns>List<VAFFECTATION></returns>
        public static List<VAFFECTATION> FindByRegion(string regionCode)
        {
            List<VAFFECTATION> lv = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from vaff in context.VAFFECTATION
                          where vaff.REG_CODE == regionCode && vaff.TRA_ROLE == "Visiteur"
                          select vaff;
                lv = req.ToList();
            }
            return lv;
        }
    }
}
