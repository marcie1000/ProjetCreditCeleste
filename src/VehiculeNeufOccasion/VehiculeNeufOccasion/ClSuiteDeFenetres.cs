using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehiculeNeufOccasion
{
    /// <summary>
    /// Permet de définir une suite de fenêtre où on peut faire suivant - précédent.
    /// Par exemple, on veut afficher frmVendre d'abord, puis frmChoisirClient pour sélectionner le
    /// bon client, puis frmCredit pour proposer le crédit, etc. Donc quand on clique sur valider / suivant
    /// dans une fenêtre, on a besoin de savoir quelle fenêtre afficher ensuite.
    /// </summary>
    class ClSuiteDeFenetres
    {
        private List<Form> _listeFenetres = new List<Form>();
        private int _indexFenetreActive = -1;
        public List<Form> listeFenetres
        {
            get => _listeFenetres;
            //set => _listeFenetres = value;
        }

        public void resetSuiteFenetres(Panel panel, frmAccueil fenAccueil)
        {
            // supprimer l'ancienne fenêtre du conteneur
            if(panel.Controls.Count > 0)
                panel.Controls.Clear();

            // fermer l'ancienne fenêtre
            for (int i = 0; i < _listeFenetres.Count; i++)
            {
                _listeFenetres.Last().Close();
            }

            if(_listeFenetres.Count > 0)
                _listeFenetres.Clear();
            
            _indexFenetreActive = -1;

            fenAccueil.Text = "Crédit Céleste";
        }

        /// <summary>
        /// Ajouter fenêtre à la fin de la liste
        /// </summary>
        public void ajouterFenetre(Panel panel, frmAccueil fenAccueil, Form fenetre)
        {
            if(_listeFenetres.Count > 0)
                _listeFenetres.Last().Hide();
            // enregistrer dans Globales
            _listeFenetres.Add(fenetre);

            // afficher dans le conteneur

            fenetre.Parent = fenAccueil;
            //panel.Controls.Clear();
            //panel.Controls.Add(fenetre);
            //fenetre.Show();
            //fenAccueil.Text = "Crédit Céleste - " + fenetre.Text;
        }

        public void supprimerDerniereFenetre(Panel panel, frmAccueil fenAccueil)
        {
            if(panel.Controls.Count > 0)
                panel.Controls.Clear();
            
            if(_listeFenetres.Count > 0)
            {
                _listeFenetres.Last().Close();
                _listeFenetres.RemoveAt(_listeFenetres.Count - 1);
            }

            if(_indexFenetreActive > -1)
                _indexFenetreActive--;
            
            
            if(_listeFenetres.Count > 0)
            {
                Form fenetre = _listeFenetres.Last();

                panel.Controls.Add(fenetre);
                fenetre.Show();
                fenAccueil.Text = "Crédit Céleste - " + fenetre.Text;
            }
            else
            {
                fenAccueil.Text = "Crédit Céleste";
            }
        }

        /// <summary>
        /// Changer de fenêtre active dans la liste, depuis le numéro d'index.
        /// </summary>
        /// <param name="index"></param>
        public void changerFenetreActive(int index, Panel panel, frmAccueil fenAccueil)
        {
            if(index < _listeFenetres.Count && index >= 0)
            {
                if(panel.Controls.Count > 0)
                    panel.Controls.Clear();

                if (_indexFenetreActive >= 0)
                {
                    _listeFenetres[_indexFenetreActive].Hide();
                }
                
                _listeFenetres[index].Show();
                panel.Controls.Add(listeFenetres[index]);
                _indexFenetreActive = index;
            }
            else if(index == -1)
            {
                panel.Controls.Clear();
                _listeFenetres[_indexFenetreActive].Hide();
                _indexFenetreActive = index;
            }
            else
            {
                throw new Exception("La valeur d'index indiquée est invalide.");
            }
        }

        public void afficherFenetreSuivante(Panel panel, frmAccueil fenAccueil)
        {
            if (_indexFenetreActive < _listeFenetres.Count - 1)
                changerFenetreActive(_indexFenetreActive + 1, panel, fenAccueil);
            else
                throw new Exception("Impossible d'afficher la fenêtre suivante (fin de la liste).");
        }

        public void afficherFenetrePrecedente(Panel panel, frmAccueil fenAccueil)
        {
            if (_indexFenetreActive >= 0)
                changerFenetreActive(_indexFenetreActive - 1, panel, fenAccueil);
            else
                throw new Exception("Impossible d'afficher la fenêtre précédente (début de la liste).");
        }

        public int getIndexFenetreActuelle()
        {
            return _indexFenetreActive;
        }
    }
}
