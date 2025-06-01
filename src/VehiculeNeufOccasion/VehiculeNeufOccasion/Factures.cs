using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;
using System.Windows.Forms;

namespace VehiculeNeufOccasion
{
    public static class Factures
    {
        public static void generer()
        {
            var wordApp = new Word.Application();
            wordApp.Visible = false;

            var doc = wordApp.Documents.Add();

            Word.Paragraph para1 = doc.Paragraphs.Add();
            para1.Range.Text = Globales.LeGarage.RaisonSociale + "\n" + Globales.LeGarage.LocRue + " " + 
                Globales.LeGarage.NomRue + "\n" + Globales.LeGarage.CodePostal + " " + Globales.LeGarage.Ville + "\n";
            para1.Range.Font.Bold = 0;
            para1.Range.Font.Size = 12;
            para1.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            para1.Range.InsertParagraphAfter();

            Word.Paragraph para3 = doc.Paragraphs.Add();
            para3.Range.Text = Globales.clientSelectionne.Nom + " " + Globales.clientSelectionne.Prenom;
            para3.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
            para3.Range.InsertParagraphAfter();
            para3 = doc.Paragraphs.Add();

            para3.Range.Text = Globales.clientSelectionne.NumRue + " " + Globales.clientSelectionne.Rue;
            para3.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
            para3.Range.InsertParagraphAfter();
            para3 = doc.Paragraphs.Add();

            para3.Range.Text = Globales.clientSelectionne.Cp + " " + Globales.clientSelectionne.Ville;
            para3.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
            para3.Range.InsertParagraphAfter();
            para3 = doc.Paragraphs.Add();

            Word.Paragraph para2 = doc.Paragraphs.Add();
            para2.Range.Text = "FACTURE";
            para2.Range.Font.Bold = 1;
            para2.Range.Font.Size = 18;
            para2.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            para2.Range.InsertParagraphAfter();


            Word.Paragraph para4 = doc.Paragraphs.Add();
            para4.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            para4.Range.Font.Bold = 0;
            para4.Range.Font.Size = 10;
            para4.Range.InsertParagraphAfter();

            para4 = doc.Paragraphs.Add();
            para4.Range.Font.Size = 10;
            para4.Range.Font.Bold = 0;
            para4.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            para4.Range.InsertParagraphAfter();

            // Ajout du tableau
            Word.Table table = doc.Tables.Add(para4.Range, 3, 10);
            table.Range.Font.Size = 8;
            table.Range.Font.Bold = 0;
            table.Borders.Enable = 1;

            string[] headers = {
                "", "Marque", "Modèle", "Carburant", "Puissance", "Couleur",
                "Kilométrage", "État", "Prix HT", "TVA"
            };

            for (int i = 0; i < headers.Length; i++)
            {
                table.Cell(1, i + 1).Range.Text = headers[i];
                table.Cell(1, i + 1).Range.Bold = 1;
                table.Cell(1, i + 1).Shading.BackgroundPatternColor = Word.WdColor.wdColorGray20;
            }

            //// Ligne de données vide (ligne 2)
            //for (int i = 1; i <= 9; i++)
            //{
            //    table.Cell(2, i).Range.Text = "";
            //}

            table.Cell(2, 1).Range.Text = "V. Vendu";
            table.Cell(2, 2).Range.Text = Globales.vehiculeSelectionneVente.IdModeleNavigation.IdMarqueNavigation.Nom;
            table.Cell(2, 3).Range.Text = Globales.vehiculeSelectionneVente.IdModeleNavigation.Nom;
            table.Cell(2, 4).Range.Text = Globales.vehiculeSelectionneVente.IdCarburantNavigation.Designation;
            table.Cell(2, 5).Range.Text = Globales.vehiculeSelectionneVente.Puissance.ToString();
            table.Cell(2, 6).Range.Text = Globales.vehiculeSelectionneVente.Couleur;
            table.Cell(2, 7).Range.Text = Globales.vehiculeSelectionneVente.Kilometrage.ToString();
            table.Cell(2, 8).Range.Text = Globales.vehiculeSelectionneVente.IdEtatNavigation.Designation;
            table.Cell(2, 9).Range.Text = Globales.vehiculeSelectionneVente.Prix.ToString();

            if(Globales.vehiculeSelectionneRachat != null)
            {
                table.Cell(3, 1).Range.Text = "- V. Reprise";
                table.Cell(3, 2).Range.Text = Globales.vehiculeSelectionneRachat.IdModeleNavigation.IdMarqueNavigation.Nom;
                table.Cell(3, 3).Range.Text = Globales.vehiculeSelectionneRachat.IdModeleNavigation.Nom;
                table.Cell(3, 4).Range.Text = Globales.vehiculeSelectionneRachat.IdCarburantNavigation.Designation;
                table.Cell(3, 5).Range.Text = Globales.vehiculeSelectionneRachat.Puissance.ToString();
                table.Cell(3, 6).Range.Text = Globales.vehiculeSelectionneRachat.Couleur;
                table.Cell(3, 7).Range.Text = Globales.vehiculeSelectionneRachat.Kilometrage.ToString();
                table.Cell(3, 8).Range.Text = Globales.vehiculeSelectionneRachat.IdEtatNavigation.Designation;
                table.Cell(3, 9).Range.Text = Globales.vehiculeSelectionneRachat.Prix.ToString();
            }


            // Total
            Word.Paragraph totalPara = doc.Paragraphs.Add();
            totalPara.Range.Text = "\nTOTAL : " + Globales.prixTotalAFinancer;
            totalPara.Range.Font.Bold = 1;
            totalPara.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;

            foreach (Word.Paragraph p in doc.Paragraphs)
            {
                p.Format.LineSpacingRule = Word.WdLineSpacing.wdLineSpaceSingle;
                p.Format.SpaceBefore = 0;
                p.Format.SpaceAfter = 0;
            }

            // Enregistrement
            object filename = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Facture.docx";
            doc.SaveAs2(ref filename);
            doc.Close();
            wordApp.Quit();

            MessageBox.Show("Document généré : " + filename);
        }
    }
}
