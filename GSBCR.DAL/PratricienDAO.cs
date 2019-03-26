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
    public static class PratricienDAO
    {
        public static PRATICIEN FindById(Int16 pranum)
        {
            //A faire : rechercher un pratricien par son numéro
            PRATICIEN pa = null;
            using (var context = new GSB_VisiteEntities())
            {
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from p in context.PRATICIEN
                          where p.PRA_NUM == pranum
                          select p;
                pa = req.SingleOrDefault<PRATICIEN>();
            }
            return pa;
        }

        public static List<PRATICIEN> FindAll()
        {
            //A faire : charger tous les praticiens
            List<PRATICIEN> prats = null;
            using (var context = new GSB_VisiteEntities())
            {
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from p in context.PRATICIEN
                          select p;
                prats = req.ToList<PRATICIEN>();
            }
            return prats;
        }

        public static List<PRATICIEN> FindByType(string code)
        {
            //A faire : charger tous les praticiens d'un type
            List<PRATICIEN> prats = null;
            using (var context = new GSB_VisiteEntities())
            {
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from p in context.PRATICIEN.Include("LeType")
                          where p.TYP_CODE == code
                          select p;
                prats = req.ToList<PRATICIEN>();
            }
            return prats;
        }
    }
}
