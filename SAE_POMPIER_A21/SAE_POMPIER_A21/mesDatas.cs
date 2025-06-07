using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SQLite;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SAE_POMPIER_A21
{
    public class MesDatas
    {
        private static DataSet dsGlobal = new DataSet();
     
        public static DataSet DsGlobal { get {  return MesDatas.dsGlobal; } }
        public static void ChargerMissions()
        {
            using (var cmd = new SQLiteCommand("SELECT * FROM Mission", Connexion.Connec))
            using (var adapter = new SQLiteDataAdapter(cmd))
            {
                if (DsGlobal.Tables.Contains("Mission"))
                    DsGlobal.Tables["Mission"].Clear();
                else
                    DsGlobal.Tables.Add(new DataTable("Mission"));

                adapter.Fill(DsGlobal.Tables["Mission"]);
            }
        }




        public static void ChargerSinistre()
        {
            using (var cmd = new SQLiteCommand("SELECT * FROM NatureSinistre", Connexion.Connec))
            using (var adapter = new SQLiteDataAdapter(cmd))
            {
                if (DsGlobal.Tables["NatureSinistre"] != null)
                    DsGlobal.Tables["NatureSinistre"].Clear();

                adapter.Fill(DsGlobal, "NatureSinistre");
            }
        }

        public static void ChargerCaserne()
        {
            using (var cmd = new SQLiteCommand("SELECT * FROM Caserne", Connexion.Connec))
            using (var adapter = new SQLiteDataAdapter(cmd))
            {
                // Vider la table si elle existe déjà
                if (DsGlobal.Tables.Contains("Caserne"))
                    DsGlobal.Tables["Caserne"].Clear();

                // Remplir les données
                adapter.Fill(DsGlobal, "Caserne");
            }
        }

        public static void ChargerMobiliser()
        {
            using (var cmd = new SQLiteCommand("SELECT * FROM Mobiliser", Connexion.Connec))
            using (var adapter = new SQLiteDataAdapter(cmd))
            {
                if (DsGlobal.Tables.Contains("Mobiliser"))
                    DsGlobal.Tables["Mobiliser"].Clear();

                adapter.Fill(DsGlobal, "Mobiliser");
            }
        }

        public static void ChargerPompier()
        {
            using (var cmd = new SQLiteCommand("SELECT * FROM Pompier", Connexion.Connec))
            using (var adapter = new SQLiteDataAdapter(cmd))
            {
                if (DsGlobal.Tables.Contains("Pompier"))
                    DsGlobal.Tables["Pompier"].Clear();

                adapter.Fill(DsGlobal, "Pompier");
            }
        }

        public static void ChargerPartirAvec()
        {
            using (var cmd = new SQLiteCommand("SELECT * FROM PartirAvec", Connexion.Connec))
            using (var adapter = new SQLiteDataAdapter(cmd))
            {
                if (DsGlobal.Tables.Contains("PartirAvec"))
                    DsGlobal.Tables["PartirAvec"].Clear();

                adapter.Fill(DsGlobal, "PartirAvec");
            }
        }

        public static void ChargerHabilitations()
        {
            using (var cmd = new SQLiteCommand("SELECT * FROM Habilitation", Connexion.Connec))
            using (var adapter = new SQLiteDataAdapter(cmd))
            {
                if (DsGlobal.Tables["Habilitation"] != null)
                    DsGlobal.Tables["Habilitation"].Clear();

                adapter.Fill(DsGlobal, "Habilitation");
            }
        }
        public static void ChargerEngins()
        {
            using (var cmd = new SQLiteCommand("SELECT * FROM Engin", Connexion.Connec))
            using (var adapter = new SQLiteDataAdapter(cmd))
            {
                if (DsGlobal.Tables["Engin"] != null)
                    DsGlobal.Tables["Engin"].Clear();

                adapter.Fill(DsGlobal, "Engin");
            }
        }
        public static void ChargerETypeEngins()
        {
            using (var cmd = new SQLiteCommand("SELECT * FROM TypeEngin", Connexion.Connec))
            using (var adapter = new SQLiteDataAdapter(cmd))
            {
                if (DsGlobal.Tables["TypeEngin"] != null)
                    DsGlobal.Tables["TypeEngin"].Clear();

                adapter.Fill(DsGlobal, "TypeEngin");
            }
        }
    }
}
