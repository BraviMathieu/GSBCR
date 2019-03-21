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
    public static class RegionDAO
    {
        public static REGION FindById(string code)
        {
            //A faire : rechercher une région par son nom
            return null;
        }

        public static List<REGION> FindAll()
        {
            //A faire : charger toutes les régions
            return null;
        }
    }
}
