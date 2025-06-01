using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VehiculeNeufOccasion
{
    public static class LogiqueAchats
    {
        public static bool updateVehicule()
        {
            bool valeurRetour = false;

            Globales.vehiculeEditionValide = false;
            frmEditVehicule frm = new frmEditVehicule();
            frm.editTitre("Modifier un véhicule");
            frm.ShowDialog();
            if (Globales.vehiculeEditionValide == false)
                return valeurRetour;

            // insérer le nouveau Vehicule
            string requete = "UPDATE concession.VEHICULE SET annee = @annee, " +
                "kilometrage = @kilometrage, prix = @prix, puissance = @puissance, " +
                "couleur = @couleur, id_etat = @id_etat, id_carburant = @id_carburant, " +
                "id_modele = @id_modele, id_personnePossession = @id_personnePossession " +
                "WHERE id = @id;";
            using (SqlCommand commande = new SqlCommand(requete))
            {
                commande.Parameters.AddWithValue("@annee", Globales.vehiculeEdition.Annee);
                commande.Parameters.AddWithValue("@kilometrage", Globales.vehiculeEdition.Kilometrage);
                commande.Parameters.AddWithValue("@prix", Globales.vehiculeEdition.Prix);
                commande.Parameters.AddWithValue("@puissance", Globales.vehiculeEdition.Puissance);
                commande.Parameters.AddWithValue("@couleur", Globales.vehiculeEdition.Couleur);
                commande.Parameters.AddWithValue("@id_etat", Globales.vehiculeEdition.IdEtat);
                commande.Parameters.AddWithValue("@id_carburant", Globales.vehiculeEdition.IdCarburant);
                commande.Parameters.AddWithValue("@id_modele", Globales.vehiculeEdition.IdModele);
                commande.Parameters.AddWithValue("@id_personnePossession", Globales.vehiculeEdition.IdPersonnePossession);
                commande.Parameters.AddWithValue("@id", Globales.vehiculeEdition.Id);

                int result = 0;
                try
                {
                    result = Bdd.insert(commande);
                    if (result != 0)
                        MessageBox.Show("Voiture modifiée dans la base de données.");
                    else
                    {
                        MessageBox.Show("La mise à jour n'a pas fonctionné.");
                        return valeurRetour;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return valeurRetour;
                }
            }
            return true;
        }

        public static bool ajouterVehicule()
        {
            bool valeurRetour = false;

            Globales.vehiculeEditionValide = false;
            frmEditVehicule frm = new frmEditVehicule();
            frm.ShowDialog();
            if (Globales.vehiculeEditionValide == false)
                return valeurRetour;

            // insérer le nouveau Vehicule
            string requete = "INSERT INTO concession.VEHICULE(annee, kilometrage, prix, puissance, couleur," +
                " id_etat, id_carburant, id_modele, id_personnePossession)" +
                "VALUES(@annee, @kilometrage, @prix, @puissance, @couleur, " +
                "@id_etat, @id_carburant, @id_modele, @id_personnePossession)";
            using (SqlCommand commande = new SqlCommand(requete))
            {
                commande.Parameters.AddWithValue("@annee", Globales.vehiculeEdition.Annee);
                commande.Parameters.AddWithValue("@kilometrage", Globales.vehiculeEdition.Kilometrage);
                commande.Parameters.AddWithValue("@prix", Globales.vehiculeEdition.Prix);
                commande.Parameters.AddWithValue("@puissance", Globales.vehiculeEdition.Puissance);
                commande.Parameters.AddWithValue("@couleur", Globales.vehiculeEdition.Couleur);
                commande.Parameters.AddWithValue("@id_etat", Globales.vehiculeEdition.IdEtat);
                commande.Parameters.AddWithValue("@id_carburant", Globales.vehiculeEdition.IdCarburant);
                commande.Parameters.AddWithValue("@id_modele", Globales.vehiculeEdition.IdModele);
                commande.Parameters.AddWithValue("@id_personnePossession", Globales.vehiculeEdition.IdPersonnePossession);

                int result = 0;
                try
                {
                    result = Bdd.insert(commande);
                    if (result != 0)
                        MessageBox.Show("Voiture ajoutée dans la base de données.");
                    else
                    {
                        MessageBox.Show("L'ajout n'a pas fonctionné.");
                        return valeurRetour;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return valeurRetour;
                }
            }
            return true;
        }
    }
}
