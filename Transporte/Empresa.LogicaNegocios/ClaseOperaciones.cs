using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.LogicaNegocios
{
    public class ClaseOperaciones
    {
        // Declarar listas
        List<Entidade.DiurnoE> listaEmpleadoDiurno = new List<Entidade.DiurnoE>();
        List<Entidades.NocturnoE> listaEmpleadoNocturno = new List<Entidades.NocturnoE>();
        List<Entidades.VespertinoE> listaEmpleadoVespertino = new List<Entidades.VespertinoE>();
     


        // inserta nuevo empleadoDiurno en listaEmpleadoDiurno
        public void InsertarEmpleadoDiurno(Entidade.DiurnoE empleadoDiurno)
        {
            listaEmpleadoDiurno.Add(empleadoDiurno);
        }

        // inserta nuevo empleadoNocturno en listaEmpleadoNocturno
        public void InsertarEmpleadoNocturno(Entidades.NocturnoE empleadoNocturno)
        {
            listaEmpleadoNocturno.Add(empleadoNocturno);
        }
        // inserta nuevo empleadoVespertino en listaEmpleadoVespertino
        public void InsertarEmpleadoVespertino(Entidades.VespertinoE empleadoVespertino)
        {
            listaEmpleadoVespertino.Add(empleadoVespertino);
        }

        // inserta nuevo empleadoTemporal en listaEmpleadoTemporal
 



        //retorna listaEmpleadoDiurno
        public List<Entidade.DiurnoE> RetornarEmpleadosDiurno()
        {
            return listaEmpleadoDiurno;
        }

        //retorna listaEmpleadoNocturno
        public List<Entidades.NocturnoE> RetornarEmpleadosNocturno()
        {
            return listaEmpleadoNocturno;
        }

        //retorna listaEmpleadoVespertino
        public List<Entidades.VespertinoE> RetornarEmpleadosVespertino()
        {
            return listaEmpleadoVespertino;
        }


        // Declarar lista // instancia de lista de clasePersona
        List<Entidades.ClasePersona> listaPersonas = new List<Entidades.ClasePersona>();

        // Agregar personas a lista
        public void InsertarPersona(Entidades.ClasePersona persona)
        {
            listaPersonas.Add(persona);
        }

        // Imprimir lista
        public void ImprimirPersonas()
        {
            foreach (Entidades.ClasePersona persona in listaPersonas)
            {
                Console.WriteLine("\n" + persona.DetalleCompleto());
            }
        }

        // EliminarEmpleadoDiurno
        public void EliminarEmpleadoDiurno(Entidade.DiurnoE empDBuscar)
        {
            foreach (Entidade.DiurnoE empD in listaEmpleadoDiurno)
            {
                if (empDBuscar.IdE == empD.IdE)
                {
                    listaEmpleadoDiurno.Remove(empD);
                    break;
                }
            }
        }

        //EliminarEmpleadoNocturno
        public void EliminarEmpleadoNocturno(Entidades.NocturnoE empNBuscar)
        {
            foreach (Entidades.NocturnoE empN in listaEmpleadoNocturno)
            {
                if (empNBuscar.IdE == empN.IdE)
                {
                    listaEmpleadoNocturno.Remove(empN);
                    break;
                }
            }
        }

        //EliminarEmpleadoNocturno
        public void EliminarEmpleadoVespertino(Entidades.VespertinoE empVBuscar)
        {
            foreach (Entidades.VespertinoE empV in listaEmpleadoVespertino)
            {
                if (empVBuscar.IdE == empV.IdE)
                {
                    listaEmpleadoVespertino.Remove(empV);
                    break;
                }
            }
        }
    }
}
