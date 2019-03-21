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
            return null;
        }

        public static List<FAMILLE> FindAll()
        {
            //A faire : charger toutes les familles de médicaments
            return null;
        }

    }
}
