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
            {
                using (var adapter = new SQLiteDataAdapter(cmd))
                {
                    MesDatas.DsGlobal.Tables.Clear();
                    adapter.Fill(MesDatas.DsGlobal, "Mission");
                }
            }
        }

        public static void ChargerSinistre()
        {
            using (var cmd = new SQLiteCommand("SELECT * FROM NatureSinistre", Connexion.Connec))
            {
                using (var adapter = new SQLiteDataAdapter(cmd))
                {
                    MesDatas.DsGlobal.Tables.Clear();
                    adapter.Fill(MesDatas.DsGlobal, "NatureSinistre");
                }
            }
        }

        public static void ChargerCaserne()
        {
            using (var cmd = new SQLiteCommand("SELECT * FROM Caserne", Connexion.Connec))
            {
                using (var adapter = new SQLiteDataAdapter(cmd))
                {
                    MesDatas.DsGlobal.Tables.Clear();
                    adapter.Fill(MesDatas.DsGlobal, "Caserne");
                }
            }
        }
    }
}
