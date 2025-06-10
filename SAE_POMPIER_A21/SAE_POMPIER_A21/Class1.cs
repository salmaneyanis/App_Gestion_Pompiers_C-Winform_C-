using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE_POMPIER_A21
{
    public static class NavigationManager
    {
        private static readonly Dictionary<string, Form> _formulaires = new Dictionary<string, Form>();
        private static Form _formulaireActuel;

        public static void AfficherFormulaire(string nom, Func<Form> createFunc, Form parentForm)
        {
            // 1. Ne rien faire si le formulaire est déjà affiché
            if (_formulaireActuel != null && _formulaireActuel.Name == nom)
                return;

            // 2. Cacher l'ancien formulaire
            if (_formulaireActuel != null)
            {
                _formulaireActuel.Hide();
                _formulaireActuel.Owner = null; // Important pour le garbage collector
            }

            // 3. Créer ou récupérer le formulaire
            if (!_formulaires.TryGetValue(nom, out Form form) || form.IsDisposed)
            {
                form = createFunc();
                form.Name = nom;
                form.ShowInTaskbar = false; // ⚠️ Critical
                form.FormClosed += (s, e) => _formulaires.Remove(nom);
                _formulaires[nom] = form;
            }

            // 4. Afficher le nouveau formulaire
            form.Owner = parentForm;
            form.Show();
            _formulaireActuel = form;
        }
    }
}
