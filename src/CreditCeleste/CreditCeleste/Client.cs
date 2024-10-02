using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste
{
    public class Client
    {
        private int numeroClient;
        private string nomClient;
        private string prenomClient;
        private string civClient;

        public Client()
        {

        }

        public Client(int numCli)
        {
            numeroClient = numCli;
        }

        public Client(int numCli, string civCli, string nomCli, string prenomCli)
        {
            numeroClient = numCli;
            civClient = civCli;
            nomClient = nomCli;
            prenomClient = prenomCli;
        }

        public int getNumeroClient()
        {
            return numeroClient;
        }

        public void setNumeroClient(int numCli)
        {
            numeroClient = numCli;
        }

        public string getNomClient()
        {
            return nomClient;
        }

        public void setNomClient(string nomCli)
        {
            nomClient = nomCli;
        }

        public string getPrenomClient()
        {
            return prenomClient;
        }

        public void setPrenomClient(string prenomCli)
        {
            prenomClient = prenomCli;
        }

        public string getCiviliteClient()
        {
            return civClient;
        }

        public void setCiviliteClient(string civCli)
        {
            civClient = civCli;
        }

    }

}
