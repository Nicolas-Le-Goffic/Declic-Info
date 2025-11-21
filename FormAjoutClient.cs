using Declic_InfoBLL;
using Declic_InfoBO;
using Declic_InfoDAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Declic_Info
{
    public partial class FormAjoutClient : Form
    {
        public FormAjoutClient()
        {
            InitializeComponent();
            GestionCategories.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GESTION_COMMERCIALE"]);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AjoutClientBtn_Click(object sender, EventArgs e)
        {
            try 
            {
                if (NomClientTxt.Text == "")
                {
                    MessageBox.Show("Vous devez saisir un nom de client !");
                    return;
                }

                if (TelClientTxt.Text == "")
                {
                    MessageBox.Show("Vous devez saisir un numéro de téléphone !");
                    return;
                }
                if (FaxClientTxt.Text == "")
                {
                    MessageBox.Show("Vous devez saisir un numéro de Fax!");
                    return;
                }
                if (EmailClientTxt.Text == "")
                {
                    MessageBox.Show("Vous devez saisir un email !");
                    return;
                }
                if (NomVilleLivClientTxt.Text == "")
                {
                    MessageBox.Show("Vous devez saisir un nom de ville pour la livraison !");
                    return;
                }
                if (CPLivClientTxt.Text == "")
                {
                    MessageBox.Show("Vous devez saisir un code postal pour la livraison !");
                    return;
                }
                if (NumLivClientTxt.Text == "")
                {
                    MessageBox.Show("Vous devez saisir un numéro d'adresse de livraison !");
                    return;
                }
                if (RueLivClientTxt.Text == "")
                {
                    MessageBox.Show("Vous devez saisir un nom de rue de livraison !");
                    return;
                }
                if (NumFacClientTxt.Text == "")
                {
                    MessageBox.Show("Vous devez saisir un numéro d'adresse de facturation !");
                    return;
                }
                if (RueFacClientTxt.Text == "")
                {
                    MessageBox.Show("Vous devez saisir un nom de rue de facturation !");
                    return;
                }
                if (VilleFacClientTxt.Text == "")
                {
                    MessageBox.Show("Vous devez saisir un nom de ville de facturation !");
                    return;
                }
                if (CPFacClientTxt.Text == "")
                {
                    MessageBox.Show("Vous devez saisir un numéro de code postal de facturation !");
                    return;
                }

                // Récupération et conversion des valeurs
                string nomClient = NomClientTxt.Text;
                int numTelClient = int.Parse(TelClientTxt.Text);
                int numFaxClient = int.Parse(FaxClientTxt.Text);
                string emailClient = EmailClientTxt.Text;

                int numAdrFactClient = int.Parse(NumFacClientTxt.Text);
                string rueAdrFactClient = RueFacClientTxt.Text;
                string villeAdrFactClient = VilleFacClientTxt.Text;
                int cpAdrFactClient = int.Parse(CPFacClientTxt.Text);

                int numAdrLivClient = int.Parse(NumLivClientTxt.Text);
                string rueAdrLivClient = RueLivClientTxt.Text;
                string villeAdrLivClient = NomVilleLivClientTxt.Text;
                int cpAdrLivClient = int.Parse(CPLivClientTxt.Text);

                // Création de l'objet ClientBO
                ClientBO unClient = new ClientBO(
                    nomClient, numTelClient, numFaxClient, emailClient,
                    numAdrFactClient, rueAdrFactClient, villeAdrFactClient, cpAdrFactClient,
                    numAdrLivClient, rueAdrLivClient, villeAdrLivClient, cpAdrLivClient
                );

                // Appel de la BLL pour enregistrer le client
                GestionClient.CreerClient(unClient);

                MessageBox.Show("Enregistrement effectué !", "Saisie");

                // Effacer les champs
                NomClientTxt.Clear();
                TelClientTxt.Clear();
                FaxClientTxt.Clear();
                EmailClientTxt.Clear();
                NumFacClientTxt.Clear();
                RueFacClientTxt.Clear();
                VilleFacClientTxt.Clear();
                CPFacClientTxt.Clear();
                NumLivClientTxt.Clear();
                RueLivClientTxt.Clear();
                NomVilleLivClientTxt.Clear();
                CPLivClientTxt.Clear();
            }
    catch (FormatException)
            {
                MessageBox.Show("Veuillez vérifier que tous les numéros et codes postaux sont corrects !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }
    }
}
