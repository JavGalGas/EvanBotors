using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Client
    {
        private string _name;
        private int _id;
        private string _direccion;
        private int _edad;

        private List<Account> _cuentas = new List<Account>();

        public Client(string name, int id, string direccion, int edad)
        {
            _name = name;
            _id = id;
            _direccion = direccion;
            _edad = edad;
        }

        public void CreateCuenta(long id)
        {
            Account cuenta = new Account();
            _cuentas.Add(cuenta);
        }
        public static Client CargarCliente(string name)
        {
            Client c=new Client();
            //...
            return c;
        }

    }
}
