using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Entidades
{
    public class VespertinoE : ClasePersona
    {
        // Atributos 
        private string _turno;

        //Constructores
        public VespertinoE()
        {
        }

        public VespertinoE(string turno)
        {
            Turno = turno;
        }

        
        public VespertinoE(string turno, int idE, string nombre, string apellidoP, string apellidoS, int cedula, int salario, string email, int celular, int seguro)
            : base(idE, nombre, apellidoP, apellidoS, cedula, salario, email, celular, seguro)
        {
            Turno = turno;
        }

        //GET y SET
        public string Turno { get => _turno; set => _turno = value; }

        // Override del método nombreCompleto de clasePersona para Vespertino
        public override string DetalleCompleto()
        {
            return string.Format("IdE: {0} + Nombre: {1} + ApellidoP:  {2} + ApellidoS: {3} + Cedula: {4} + Salario: {5} + Correo: {6} + Celular: {7} + Seguro: {8} + Turno: {9}",
               IdE, Nombre, ApellidoP, Modelo_del_vehiculo, Marca, Año, Email, Celular, Seguro, Turno);
        }
    }
}
