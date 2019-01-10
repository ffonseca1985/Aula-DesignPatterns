namespace Singleton
{
    public class Connection
    {
        private static Connection _conection;
        private static readonly object mutex = new object();

        private Connection() {}

        public static Connection GetInstance()
        {
            //Loca o bloco
            lock (mutex)
            {
                //Sem locar este método quando usado com thread
                //não funcionara. 
                //Poderá criar duas instancias mesmo com o if abaixo
                if (_conection == null)
                    return _conection = new Connection();
            }

            return _conection;
        }
    }
}
