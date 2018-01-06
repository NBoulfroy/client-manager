using System;
using System.Net;

namespace ClassLibrary
{
    [Serializable]
    public class Support
    {
        private string application;
        private string type;
        private string message;

        public Support(string application, string type)
        {
            this.application = application;
            this.type = type;
        }

        #region Accessor

        public string GetApplication() { return application; }
        public string GetType() { return type; }
        public string GetMessage() { return message; }

        #endregion

        #region Property

        public string Message { get { return message; } }

        #endregion

        #region Method

        public string Post(string method) // , Exception exception
        {

            // Si connection impossible, créer un fichier qui contient le / les rapports d'erreur
            // en cas d'impossibilité de se connecter au serveur.
            // Lors d'un envoie, si le fichier existe, le lire et rajouter les rapports d'erreur
            // à celui qui va être envoyé.
            // return message = method + ": " + exception.Message.ToString();

            string error = method + ": surprise!"; // + exception.Message.ToString();

            using (WebClient client = new WebClient())
            {
                /*return message = client.DownloadString(
                    "http://localhost/site/customer-manager/support.php?application=" 
                    + application + "&type=" + type + "&error" + error);*/
                return message = client.DownloadString("http://localhost/site/customer-manager/support.php?application=" + application + "&type=" + type + "&error=" + error);
            }

        }

        #endregion
    }
}
