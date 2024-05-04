

using ClientTM.Tries.Reals;

namespace ClientTM.Tries
{
    public class FabriqueTry
    {
        public static ITry Creer()
        {
            return new FirstTry();   
        }
    }
}
