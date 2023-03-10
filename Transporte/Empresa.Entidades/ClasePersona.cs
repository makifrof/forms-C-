using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Entidades
{
    public class ClasePersona
    {
        //Atributos
        private int _idE;
        private string _nombre;
        private string _apellidoP;
        private string _apellidoS;
        private int _cedula;
        private int _salario;
        private string _email;
        private int _celular;
        private int _seguro;

        //Constructores
        public ClasePersona()
        {
        }

        public ClasePersona(int idE, string nombre, string apellidoP, string apellidoS, int cedula, int salario, string email, int celular, int seguro)
        {
            IdE = idE;
            Nombre = nombre;
            ApellidoP = apellidoP;
            Modelo_del_vehiculo = apellidoS;
            Marca = cedula;
            Año = salario;
            Email = email;
            Celular = celular;
            Seguro = seguro;
        }

        //GET y SET
        public int IdE { get => _idE; set => _idE = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string ApellidoP { get => _apellidoP; set => _apellidoP = value; }
        public string Modelo_del_vehiculo { get => _apellidoS; set => _apellidoS = value; }
        public int Marca { get => _cedula; set => _cedula = value; }
        public int Año { get => _salario; set => _salario = value; }
        public int Celular { get => _celular; set => _celular = value; }
        public string Email { get => _email; set => _email = value; }

        public int Seguro { get => _seguro; set => _seguro = value; }
        //método nombreCompleto que se sobreescribirá con EmpleadoTurno
        public virtual string DetalleCompleto()
        {
            return string.Format("IdE: " + _idE + "Nombre: " + _nombre + " ApellidoP " + _apellidoP + " Modelo del vehiculo:  " +
                _apellidoS + " Marca: " + _cedula + "Año: " + _salario + "Email: " + _email + "Celular: " + _celular + "Seguro: "+ _seguro);
        }
    }
}
