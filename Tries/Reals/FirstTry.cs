using ClientTM.Reseau;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientTM.Tries.Reals
{
    public class FirstTry: ITry
    {
        public FirstTry()
        {

        }

        /// <summary>
        /// Reçoit un message du serveur et renvoie "OK"
        /// </summary>
        public void Executer()
        {
            Connexion.EnvoyerMessage("OK"); // okay 👌
        }

    }
}
