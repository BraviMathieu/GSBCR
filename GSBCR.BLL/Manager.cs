﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSBCR.modele;
using GSBCR.DAL;

namespace GSBCR.BLL
{
    public static class Manager
    {
         /// <summary>
        /// Permet de charger un visiteur à partir de son login et mot de passe
        /// </summary>
        /// <param name="matricule">matricule Visiteur</param>
        /// <param name="mdp">mot de passe Visiteur</param>
        /// <returns>objet VISITEUR</returns>
        public static VISITEUR ChargerVisiteur(string matricule, string mdp)
        {
            VISITEUR vis = VisiteurDAO.FindById(matricule);
            if ((vis != null) && (vis.vis_mdp == mdp))
                return vis;
            else
                return null;

        }
        /// <summary>
        /// Permet de charger la dernière affectation du visiteur
        /// et donc son profil (visiteur, délégué, responsabe secteur) et sa région
        /// </summary>
        /// <param name="matricule">matricule Visiteur</param>
        /// <returns>objet VAFFECTATION</returns>
        public static VAFFECTATION ChargerAffectationVisiteur(string matricule)
        {
            VAFFECTATION vaff = VaffectationDAO.FindByMatricule(matricule);
            return vaff;
        }
        ///<summary>
        /// Permet de charger les rapports non terminés du visiteur (état 1)
        /// </summary>
        /// <param name="m">matricule Visiteur</param>
        /// <returns>List<RAPPORT_VISITE></returns>
        public static List<RAPPORT_VISITE> ChargerRapportVisiteurEncours(String m)
        {
            List<RAPPORT_VISITE> lr;
            List<string> lm = new List<string>();
            lm.Add(m);
            List<int> le = new List<int>();
            le.Add(1);
            lr = RapportVisiteDAO.FindByEtatEtVisiteur(lm, le);
            return lr;
        }
        /// <summary>
        /// Permet de charger la liste des rapport en cours
        /// </summary>
        /// <returns></returns>
        public static List<RAPPORT_VISITE> ChargerRapportVisiteursEncours(int e)
        {
            List<RAPPORT_VISITE> lr;
            List<int> le = new List<int>();
            le.Add(1);
            lr = RapportVisiteDAO.FindByEtat(le);
            return lr;
        }
        /// Permet de charger un rapport de visite
        /// </summary>
        /// <param name="m">matricule Visiteur</param>
        /// <param name="n">numéro rapport</param>
        /// <returns>RAPPORT_VISITE</returns>
        public static RAPPORT_VISITE ChargerRapportVisite(string m, int n)
        {
            RAPPORT_VISITE r = RapportVisiteDAO.FindById(m, n);
            return r;
        }
        /// Permet de charger les rapports terminés du visiteur (état 2 et 3) 
        /// </summary>
        /// <param name="m">matricule Visiteur</param>
        /// <returns>List<RAPPORT_VISITE>/returns>
        public static List<RAPPORT_VISITE> ChargerRapportVisiteurFinis(String m)
        {
            List<RAPPORT_VISITE> lr;
            List<string> lm = new List<string>();
            lm.Add(m);
            List<int> le = new List<int>();
            le.Add(2);
            le.Add(3);
            lr = RapportVisiteDAO.FindByEtatEtVisiteur(lm, le);
            return lr;
        }
        /// <summary>
        /// Permet de retourner une liste de visiteurs pour une région à partir de vaffectation
        /// </summary>
        /// <param name="regionCode">code région</param>
        /// <returns>List<VISITEUR></returns>
        public static List<VISITEUR> ChargerVisiteurByRegion(string regionCode)
        {
            List<VISITEUR> lv = new List<VISITEUR>();
            VISITEUR vis;
            List<VAFFECTATION> lvaff = VaffectationDAO.FindByRegion(regionCode);
            foreach (VAFFECTATION vaff in lvaff)
            {
                vis = VisiteurDAO.FindById(vaff.VIS_MATRICULE);
                lv.Add(vis);
            }
            return lv;
        }

        /// <summary>
        /// Permet de retourner une liste de visiteurs (pas responsable actuel) pour un secteur
        /// </summary>
        /// <param name="secteurCode">code secteur</param>
        /// <returns>List<VISITEUR></returns>
        public static List<VISITEUR> ChargerVisiteurBySecteur(string respon, string secteurCode)
        {
            List<VISITEUR> lv = new List<VISITEUR>();
            lv = VisiteurDAO.FindBySecteur(respon,secteurCode);
            return lv;
        }

        /// Permet de charger les rapports non consultés (état 2) des visiteurs d'une région  
        /// </summary>
        /// <param name="code">code région</param>
        /// <returns>List<RAPPORT_VISITE>/returns>
        public static List<RAPPORT_VISITE> ChargerRapportRegionNonLus(String code)
        {
            //A faire : charger les rapports terminés et non lus (état = 2 ) des visiteurs d'une région
            List<VISITEUR> rv = new List<VISITEUR>();
            List<RAPPORT_VISITE> lr;
            List<String> str = new List<String>();
            rv = ChargerVisiteurByRegion(code);
            List<int> le = new List<int>();
            le.Add(2);
            foreach (VISITEUR visi in rv)
            {
                str.Add(visi.VIS_MATRICULE);
            }
            lr = RapportVisiteDAO.FindByEtatEtVisiteur(str, le);
            return lr;
        }
        /// Permet de charger les rapports terminés et consultés (état 3) des visiteurs d'une région 
        /// </summary>
        /// <param name="r">code région</param>
        /// <returns>List<RAPPORT_VISITE>/returns>
        public static List<RAPPORT_VISITE> ChargerRapportRegionLus(String r)
        {
            //A faire : charger les rapports terminés (état = 3) des visiteurs d'une région
            List<VISITEUR> rv = new List<VISITEUR>();
            List<RAPPORT_VISITE> lr;
            List<String> str = new List<String>();
            rv = ChargerVisiteurByRegion(r);
            List<int> le = new List<int>();
            le.Add(3);
            foreach(VISITEUR visi in rv)
            {
                str.Add(visi.VIS_MATRICULE);
            }
            lr = RapportVisiteDAO.FindByEtatEtVisiteur(str, le);
            return lr;
        }


        /// Permet de charger les rapports terminés et consultés (état 3) d'un visiteur
        /// </summary>
        /// <param name="r">code région</param>
        /// /// <param name="code">code visiteur</param>
        /// <returns>List<RAPPORT_VISITE>/returns>
        public static List<RAPPORT_VISITE> ChargerRapportRegionLusVisiteur(String r, string code)
        {
            //A faire : charger les rapports terminés (état = 3) des visiteurs d'une région
            List<RAPPORT_VISITE> lr;
            List<string> codes = new List<String>();
            List<int> le = new List<int>();
            le.Add(3);
            codes.Add(code);
            lr = RapportVisiteDAO.FindByEtatEtVisiteur(codes, le);
            return lr;
        }

        /// <summary>
        /// Permet de créer un rapport dans la base de données 
        /// </summary>
        /// <param name="r">objet rapport de visite</param>
        public static void CreateRapport(RAPPORT_VISITE r)
        {
            RapportVisiteDAO.insert(r);
        }

        /// <summary>
        /// Permet de mettre à jour un rapport dans la base de données 
        /// </summary>
        /// <param name="r">objet rapport de visite</param>
        public static void MajRapport(RAPPORT_VISITE r)
        {
            RapportVisiteDAO.update(r);
        }
        /// <summary>
        /// Permet de charger un médicament à partir de son nom de dépot légal
        /// </summary>
        /// <param name="depot">chaine caractères</param>
        public static MEDICAMENT ChargerLeMedicament(string depot)
        {
            MEDICAMENT l = MedicamentDAO.FindById(depot);
            return l;
        }
        /// <summary>
        /// Permet de charger tous les médicaments
        /// </summary>
        public static List<MEDICAMENT> ChargerMedicaments()
        {
            List<MEDICAMENT> lm = MedicamentDAO.FindAll();
            return lm;
        }
        /// <summary>
        /// Permet de charger tous les motifs visite
        /// </summary>
        public static List<MOTIF_VISITE> ChargerMotifVisites()
        {
            List<MOTIF_VISITE> mv = MotifVisiteDAO.FindAll();
            return mv;
        }
        /// <summary>
        /// Permet de charger tous les praticiens
        /// </summary>
        public static List<PRATICIEN> ChargerPraticiens()
        {
            List<PRATICIEN> pr = PratricienDAO.FindAll();
            return pr;
        }
        /// <summary>
        /// Permet de charger un praticien à partir de son numéro
        /// <param name="pranum">entier</param>
        /// </summary>
        public static PRATICIEN ChargerLePraticien(Int16 pranum)
        {
            PRATICIEN pr = PratricienDAO.FindById(pranum);
            return pr;
        }
        /// <summary>
        /// Permet de charger les rapports d'un visiteur pour un praticien donné
        /// <param name="visiteurcode">chaine de caracteres</param>
        /// <param name="praticiencode">entier</param>
        /// </summary>
        public static List<RAPPORT_VISITE> ChargerSiRapportsExistent(string visiteurcode, Int16 praticiencode)
        {
            List<RAPPORT_VISITE> pr = RapportVisiteDAO.FindRapportExiste(visiteurcode, praticiencode);
            return pr;
        }

        /// <summary>
        /// Permet de charger le visiteur pour un id donné
        /// <param name="id">chaine de caracteres</param>
        /// </summary>
        public static VISITEUR ChargerVisiteurById(string id)
        {
            VISITEUR vis = null;
            using (var context = new GSB_VisiteEntities())
            {
                var req = from v in context.VISITEUR
                          where v.VIS_MATRICULE == id
                          select v;
                vis = req.SingleOrDefault();
            }
            return vis;
        }

        /// <summary>
        /// Permet de charger le type praticien a partir du code
        /// <param name="code">chaine de caracteres</param>
        /// </summary>
        public static TYPE_PRATICIEN ChargerTypeParticien(string code)
        {
            TYPE_PRATICIEN tr = TypePraticienDAO.FindById(code);
            return tr;
        }

        /// <summary>
        /// Permet de mettre à jour le visiteur dans la base de données
        /// <param name="mat">(matricule visiteur,</param>
        /// <param name="adr">ancienne adresse visiteur,</param>
        /// <param name="CP">ancien code postal visiteur,</param>
        /// <param name="ville">ancienne ville visiteur,</param>
        /// <param name="nadr">nouvelle adresse visiteur,</param>
        /// <param name="nCP">nouveau code postal visiteur,</param>
        /// <param name="nville">nouvelle ville visiteur)</param>
        /// </summary>
        public static void UpdateVisiteur(string mat, string adr, string CP, string ville, string nadr, string nCP, string nville)
        {
            using (var context = new GSB_VisiteEntities())
            {
                var req = context.VISITEUR.Where(m => m.VIS_MATRICULE == mat).Where(a => a.VIS_ADRESSE == adr).First();
                req.VIS_ADRESSE = nadr;
                context.SaveChanges();

                req = context.VISITEUR.Where(m => m.VIS_MATRICULE == mat).Where(c => c.VIS_CP == CP).First();
                req.VIS_CP = nCP;
                context.SaveChanges();

                req = context.VISITEUR.Where(m => m.VIS_MATRICULE == mat).Where(v => v.VIS_VILLE == ville).First();
                req.VIS_VILLE = nville;
                context.SaveChanges();
            }
        }
    }
}