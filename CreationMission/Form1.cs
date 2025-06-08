using SAE_POMPIER_A21;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CreationMission
{
    public partial class Form1 : Form
    {

        private BindingSource bsMissions = new BindingSource();
        private DataTable dtMissions = new DataTable();
        private BindingSource bsCasernes = new BindingSource();
        private DataTable dtCasernes = new DataTable();
        private BindingSource bsSinistres = new BindingSource();
        private DataTable dtSinistres = new DataTable();
        private SQLiteConnection cx = Connexion.Connec;
        private DataSet ds = MesDatas.DsGlobal;

        string motif;
        string rue;
        string code_postal;
        string ville;

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;


            try
            {
                this.cx = new SQLiteConnection(Connexion.Connec);
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

            LoadMissions();
            LoadCasernes();
            LoadSinistres();
            UpdateNextMissionId();

            DateTime dateLancement = DateTime.Now;
            label4.Text = dateLancement.ToString("dd/MM/yyyy HH:mm:ss");
        }

       

        private void LoadMissions()
        {
            try
            {
                string query = "SELECT * FROM Mission";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, cx);
                dtMissions.Clear();
                adapter.Fill(dtMissions);
                bsMissions.DataSource = dtMissions;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des missions : " + ex.Message);
            }
        }

        private void LoadCasernes()
        {
            try
            {
                string sql = "SELECT id, nom FROM Caserne";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, cx);
                dtCasernes.Clear();
                adapter.Fill(dtCasernes);

                DataRow newRow = dtCasernes.NewRow();
                newRow["id"] = 0;
                newRow["nom"] = "Choisir caserne";
                dtCasernes.Rows.InsertAt(newRow, 0);

                bsCasernes.DataSource = dtCasernes;
                cboCaserne.DataSource = bsCasernes;
                cboCaserne.DisplayMember = "nom";
                cboCaserne.ValueMember = "id";
                cboCaserne.SelectedIndex = 0;
            }
            catch (SQLiteException err)
            {
                MessageBox.Show("Erreur lors du chargement des casernes : " + err.Message);
            }
        }

        private void LoadSinistres()
        {
            try
            {
                string sql = "SELECT id, libelle FROM NatureSinistre";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, cx);
                dtSinistres.Clear();
                adapter.Fill(dtSinistres);

                DataRow newRow = dtSinistres.NewRow();
                newRow["id"] = 0;
                newRow["libelle"] = "Choisir Sinistre";
                dtSinistres.Rows.InsertAt(newRow, 0);

                bsSinistres.DataSource = dtSinistres;
                cboSinistre.DataSource = bsSinistres;
                cboSinistre.DisplayMember = "libelle";
                cboSinistre.ValueMember = "id";
                cboSinistre.SelectedIndex = 0;
            }
            catch (SQLiteException err)
            {
                MessageBox.Show("Erreur lors du chargement des sinistres : " + err.Message);
            }
        }

        private void UpdateNextMissionId()
        {
            try
            {
                string sql = "SELECT MAX(id) FROM Mission";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, cx))
                {
                    object result = cmd.ExecuteScalar();
                    int maxId = (result != DBNull.Value) ? Convert.ToInt32(result) : 0;
                    label2.Text = (maxId + 1).ToString();
                }
            }
            catch (SQLiteException err)
            {
                MessageBox.Show("Erreur lors du calcul du prochain ID mission : " + err.Message);
                label2.Text = "1";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) => motif = textBox1.Text;
        private void textBox2_TextChanged(object sender, EventArgs e) => rue = textBox2.Text;
        private void textBox3_TextChanged(object sender, EventArgs e) => code_postal = textBox3.Text;
        private void textBox4_TextChanged(object sender, EventArgs e) => ville = textBox4.Text;

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine("Début de la création de mission...");

            if (!TousLesChampsRemplis(groupBox1) || !TousLesChampsRemplis(groupBox2))
            {
                Console.WriteLine("Échec: Tous les champs ne sont pas remplis.");
                MessageBox.Show("Veuillez remplir tous les champs requis.");
                return;
            }

            // Création du GroupBox pour afficher les détails de la mission
            GroupBox groupBoxDetailsMission = new GroupBox
            {
                Text = "Détails de la mission",
                Location = new Point(51, 537),
                Size = new Size(855, 143),
                Name = "groupBoxDetailsMission"
            };

            // Création des labels pour afficher les informations
            Label labelPompiers = new Label
            {
                Text = "Pompiers affectés: ",
                Location = new Point(10, 20),
                AutoSize = true,
                Name = "labelPompiersAffectes",
                Font = new Font("Arial", 9, FontStyle.Bold)
            };

            Label labelEngins = new Label
            {
                Text = "Engins utilisés: ",
                Location = new Point(10, 50),
                AutoSize = true,
                Name = "labelEnginsUtilises",
                Font = new Font("Arial", 9, FontStyle.Bold)
            };

            // Ajout des contrôles au GroupBox
            groupBoxDetailsMission.Controls.Add(labelPompiers);
            groupBoxDetailsMission.Controls.Add(labelEngins);

            // Ajout du GroupBox au formulaire
            this.Controls.Add(groupBoxDetailsMission);
            groupBoxDetailsMission.BringToFront();

            try
            {
                Console.WriteLine("Début de la transaction...");
                using (SQLiteTransaction transaction = cx.BeginTransaction())
                {
                    try
                    {
                        int missionId = int.Parse(label2.Text);
                        int idNatureSinistre = Convert.ToInt32(cboSinistre.SelectedValue);
                        int idCaserne = Convert.ToInt32(cboCaserne.SelectedValue);

                        Console.WriteLine($"Création mission ID: {missionId}, Sinistre: {idNatureSinistre}, Caserne: {idCaserne}");

                        // Listes pour stocker les informations à afficher
                        List<string> pompiersAffectesList = new List<string>();
                        List<string> enginsUtilisesList = new List<string>();

                        // 1. Insertion de la mission
                        Console.WriteLine("Insertion de la mission dans la table Mission...");
                        string sqlInsertMission = @"
                    INSERT INTO Mission (id, motifAppel, adresse, cp, ville, idCaserne, idNatureSinistre, dateHeureDepart, terminee)
                    VALUES (@id, @motifAppel, @adresse, @cp, @ville, @idCaserne, @idNatureSinistre, @dateHeureDepart, 0)";

                        using (SQLiteCommand cmd = new SQLiteCommand(sqlInsertMission, cx, transaction))
                        {
                            cmd.Parameters.AddWithValue("@id", missionId);
                            cmd.Parameters.AddWithValue("@motifAppel", motif);
                            cmd.Parameters.AddWithValue("@adresse", rue);
                            cmd.Parameters.AddWithValue("@cp", code_postal);
                            cmd.Parameters.AddWithValue("@ville", ville);
                            cmd.Parameters.AddWithValue("@idCaserne", idCaserne);
                            cmd.Parameters.AddWithValue("@idNatureSinistre", idNatureSinistre);
                            cmd.Parameters.AddWithValue("@dateHeureDepart", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                            cmd.ExecuteNonQuery();
                        }
                        Console.WriteLine("Mission insérée avec succès.");

                        // 2. Récupérer les types d'engins nécessaires pour ce sinistre
                        Console.WriteLine("Récupération des types d'engins nécessaires...");
                        List<string> typesEnginsNecessaires = new List<string>();
                        string sqlTypesEngins = "SELECT codeTypeEngin FROM Necessiter WHERE idNatureSinistre = @idNatureSinistre";
                        using (SQLiteCommand cmd = new SQLiteCommand(sqlTypesEngins, cx, transaction))
                        {
                            cmd.Parameters.AddWithValue("@idNatureSinistre", idNatureSinistre);
                            using (SQLiteDataReader rdr = cmd.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    typesEnginsNecessaires.Add(rdr["codeTypeEngin"].ToString());
                                    Console.WriteLine($"Engin nécessaire trouvé: {rdr["codeTypeEngin"]}");
                                }
                            }
                        }

                        if (typesEnginsNecessaires.Count == 0)
                        {
                            Console.WriteLine("Aucun engin requis pour ce type de sinistre.");
                            throw new Exception("Aucun engin requis pour ce type de sinistre.");
                        }

                        // 3. Pour chaque type d'engin, trouver un engin disponible et affecter les pompiers
                        Console.WriteLine($"Début de l'affectation des engins ({typesEnginsNecessaires.Count} types)");
                        foreach (string typeEngin in typesEnginsNecessaires)
                        {
                            Console.WriteLine($"Traitement de l'engin de type: {typeEngin}");

                            // Trouver un engin disponible
                            Console.WriteLine("Recherche d'un engin disponible...");
                            string sqlEnginDisponible = @"
                        SELECT idCaserne, codeTypeEngin, numero 
                        FROM Engin 
                        WHERE codeTypeEngin = @typeEngin 
                        AND idCaserne = @idCaserne
                        AND enMission = 0 
                        AND enPanne = 0
                        LIMIT 1";

                            using (SQLiteCommand cmd = new SQLiteCommand(sqlEnginDisponible, cx, transaction))
                            {
                                cmd.Parameters.AddWithValue("@typeEngin", typeEngin);
                                cmd.Parameters.AddWithValue("@idCaserne", idCaserne);
                                using (SQLiteDataReader rdr = cmd.ExecuteReader())
                                {
                                    if (!rdr.Read())
                                    {
                                        Console.WriteLine($"Aucun engin de type {typeEngin} disponible.");
                                        throw new Exception($"Aucun engin de type {typeEngin} disponible dans la caserne.");
                                    }

                                    Console.WriteLine($"Engin trouvé: {rdr["codeTypeEngin"]}-{rdr["numero"]}");

                                    // Récupérer le nom complet de l'engin
                                    string nomEngin = GetNomEngin(typeEngin, cx, transaction);
                                    enginsUtilisesList.Add($"{nomEngin} #{rdr["numero"]}");

                                    // Marquer l'engin comme en mission
                                    Console.WriteLine("Marquage de l'engin comme en mission...");
                                    string sqlUpdateEngin = @"
                                UPDATE Engin 
                                SET enMission = 1 
                                WHERE codeTypeEngin = @codeTypeEngin 
                                AND idCaserne = @idCaserne 
                                AND numero = @numero";

                                    using (SQLiteCommand updateCmd = new SQLiteCommand(sqlUpdateEngin, cx, transaction))
                                    {
                                        updateCmd.Parameters.AddWithValue("@codeTypeEngin", rdr["codeTypeEngin"]);
                                        updateCmd.Parameters.AddWithValue("@idCaserne", rdr["idCaserne"]);
                                        updateCmd.Parameters.AddWithValue("@numero", rdr["numero"]);
                                        updateCmd.ExecuteNonQuery();
                                    }

                                    // Enregistrer l'engin dans la mission
                                    Console.WriteLine("Enregistrement de l'engin dans la mission...");
                                    string sqlInsertEnginMission = @"
                                INSERT INTO PartirAvec (idMission, idCaserne, codeTypeEngin, numeroEngin, reparationsEventuelles)
                                VALUES (@idMission, @idCaserne, @codeTypeEngin, @numero, @reparation)";

                                    using (SQLiteCommand insertCmd = new SQLiteCommand(sqlInsertEnginMission, cx, transaction))
                                    {
                                        insertCmd.Parameters.AddWithValue("@idMission", missionId);
                                        insertCmd.Parameters.AddWithValue("@idCaserne", rdr["idCaserne"]);
                                        insertCmd.Parameters.AddWithValue("@codeTypeEngin", rdr["codeTypeEngin"]);
                                        insertCmd.Parameters.AddWithValue("@numero", rdr["numero"]);
                                        insertCmd.Parameters.AddWithValue("@reparation", DBNull.Value);
                                        insertCmd.ExecuteNonQuery();
                                    }
                                }
                            }

                            // 4. Trouver les habilitations requises pour cet engin
                            Console.WriteLine("Recherche des habilitations requises...");
                            List<int> habilitationsRequises = new List<int>();
                            string sqlHabilitations = "SELECT idHabilitation FROM Embarquer WHERE codeTypeEngin = @codeTypeEngin";
                            using (SQLiteCommand cmd = new SQLiteCommand(sqlHabilitations, cx, transaction))
                            {
                                cmd.Parameters.AddWithValue("@codeTypeEngin", typeEngin);
                                using (SQLiteDataReader rdr = cmd.ExecuteReader())
                                {
                                    while (rdr.Read())
                                    {
                                        habilitationsRequises.Add(Convert.ToInt32(rdr["idHabilitation"]));
                                        Console.WriteLine($"Habilitation requise: {rdr["idHabilitation"]}");
                                    }
                                }
                            }

                            // 5. Trouver le nombre de pompiers nécessaires pour cet engin
                            Console.WriteLine("Détermination de l'équipage nécessaire...");
                            int equipageNecessaire = 0;
                            string sqlEquipage = "SELECT equipage FROM TypeEngin WHERE code = @code";
                            using (SQLiteCommand cmd = new SQLiteCommand(sqlEquipage, cx, transaction))
                            {
                                cmd.Parameters.AddWithValue("@code", typeEngin);
                                equipageNecessaire = Convert.ToInt32(cmd.ExecuteScalar());
                            }
                            Console.WriteLine($"Équipage nécessaire: {equipageNecessaire} pompiers");

                            // 6. Trouver les pompiers disponibles avec les bonnes habilitations
                            Console.WriteLine("Recherche des pompiers disponibles...");
                            string sqlPompiersDisponibles = @"
                        SELECT DISTINCT P.matricule, P.nom, P.prenom, G.libelle as grade
                        FROM Pompier P
                        JOIN Affectation A ON P.matricule = A.matriculePompier
                        JOIN Passer Pa ON P.matricule = Pa.matriculePompier
                        JOIN Grade G ON P.codeGrade = G.code
                        WHERE A.idCaserne = @idCaserne
                        AND (A.dateFin IS NULL OR A.dateFin > DATE('now'))
                        AND P.enMission = 0
                        AND P.enConge = 0
                        AND Pa.idHabilitation IN (" + string.Join(",", habilitationsRequises) + @")
                        ORDER BY P.codeGrade DESC
                        LIMIT @limit";

                            List<int> pompiersAffectes = new List<int>();
                            using (SQLiteCommand cmd = new SQLiteCommand(sqlPompiersDisponibles, cx, transaction))
                            {
                                cmd.Parameters.AddWithValue("@idCaserne", idCaserne);
                                cmd.Parameters.AddWithValue("@limit", equipageNecessaire);
                                using (SQLiteDataReader rdr = cmd.ExecuteReader())
                                {
                                    while (rdr.Read())
                                    {
                                        pompiersAffectes.Add(Convert.ToInt32(rdr["matricule"]));
                                        pompiersAffectesList.Add($"{rdr["prenom"]} {rdr["nom"]} ({rdr["grade"]})");
                                        Console.WriteLine($"Pompier sélectionné: {rdr["matricule"]}");
                                    }
                                }
                            }

                            if (pompiersAffectes.Count < equipageNecessaire)
                            {
                                Console.WriteLine($"Erreur: Pompiers insuffisants (nécessaire: {equipageNecessaire}, trouvés: {pompiersAffectes.Count})");
                                throw new Exception($"Pas assez de pompiers disponibles pour l'engin {typeEngin} (nécessaire: {equipageNecessaire}, disponibles: {pompiersAffectes.Count})");
                            }

                            // 7. Affecter les pompiers à la mission
                            Console.WriteLine($"Affectation de {pompiersAffectes.Count} pompiers à la mission...");
                            foreach (int matricule in pompiersAffectes)
                            {
                                Console.WriteLine($"Traitement du pompier {matricule}");

                                // Mise à jour du pompier : enMission = 1
                                Console.WriteLine("Marquage du pompier comme en mission...");
                                string sqlUpdatePompier = "UPDATE Pompier SET enMission = 1 WHERE matricule = @matricule";
                                using (SQLiteCommand cmd = new SQLiteCommand(sqlUpdatePompier, cx, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@matricule", matricule);
                                    cmd.ExecuteNonQuery();
                                }

                                // Insertion dans Mobiliser
                                Console.WriteLine("Insertion dans la table Mobiliser...");
                                string sqlInsertMobiliser = @"
                            INSERT INTO Mobiliser (matriculePompier, idMission, idHabilitation)
                            SELECT @matricule, @idMission, idHabilitation 
                            FROM Passer 
                            WHERE matriculePompier = @matricule
                            LIMIT 1";
                                using (SQLiteCommand cmd = new SQLiteCommand(sqlInsertMobiliser, cx, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@matricule", matricule);
                                    cmd.Parameters.AddWithValue("@idMission", missionId);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }

                        // Mise à jour des labels avec les informations récupérées
                        labelPompiers.Text = "Pompiers affectés: " + string.Join(", ", pompiersAffectesList.Distinct());
                        labelEngins.Text = "Engins utilisés: " + string.Join(", ", enginsUtilisesList);

                        transaction.Commit();
                        Console.WriteLine("Transaction commitée avec succès.");
                        MessageBox.Show($"Mission #{missionId} créée avec succès avec les engins et pompiers nécessaires.");

                        LoadMissions();
                        UpdateNextMissionId();
                        ResetChamps();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erreur dans la transaction: {ex.Message}");
                        transaction.Rollback();
                        this.Controls.Remove(groupBoxDetailsMission);
                        groupBoxDetailsMission.Dispose();
                        MessageBox.Show("Erreur lors de la création de la mission : " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur globale: {ex.Message}");
                this.Controls.Remove(groupBoxDetailsMission);
                groupBoxDetailsMission.Dispose();
                MessageBox.Show("Erreur : " + ex.Message);
            }

            Console.WriteLine("Fin du processus de création de mission.");
        }

        private string GetNomEngin(string codeEngin, SQLiteConnection cx, SQLiteTransaction transaction)
        {
            string sql = "SELECT nom FROM TypeEngin WHERE code = @code";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, cx, transaction))
            {
                cmd.Parameters.AddWithValue("@code", codeEngin);
                return cmd.ExecuteScalar()?.ToString() ?? codeEngin;
            }
        }

        private void ResetChamps()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            cboCaserne.SelectedIndex = 0;
            cboSinistre.SelectedIndex = 0;
        }




        private bool TousLesChampsRemplis(GroupBox groupBox)
        {
            foreach (Control ctrl in groupBox.Controls)
            {
                if (ctrl is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
                    return false;

                if (ctrl is ComboBox comboBox && comboBox.SelectedIndex == -1)
                    return false;

                if (ctrl is DateTimePicker dateTimePicker && dateTimePicker.Value == default)
                    return false;
            }

            return true;
        }
    }
}
