using ClientTM.Reseau;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientTM.Tries.Reals
{
    public class SecondTry : ITry
    {
        int nEquipe = 0;

        public SecondTry()
        {

        }

        /// <summary>
        /// Reçoit un message du serveur et renvoie "OK"
        /// </summary>
        public void Executer()
        {
            Connexion.EnvoyerMessage("MT"); // nom équipe

            string message = Connexion.RecevoirMessage();
            Console.WriteLine(message);

            string[] temp = message.Split('|');
            nEquipe = int.Parse(temp[1]);

            Console.WriteLine(nEquipe);

        }

    }
}
