using PrimerTarea_Majo_Victor_23CV.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerTarea_Majo_Victor_23CV.Services
{
    public class ClienteServices
    {

       public  Cliente Agregar()
        {
            try
            {
                Cliente clienteCompra = new Cliente()
                {
                    Nombre = "Victor",
                    Telefono = "9983304505",
                    Correo = "victor.vu583@gmail.com"
                   
                };
                return clienteCompra;
            }
            catch(Exception ex)
            {
                throw new Exception("Sucedio un error" + ex.Message);
            }
        }

        public void ImprimirDatos(Cliente request)
        {
            try
            {
                Console.WriteLine("El nombre es: " + request.Nombre);
                Console.WriteLine("El apellido es: " + request.Telefono);
                Console.WriteLine("El dia de ingreso  es: " + request.Correo);
                
            }
            catch (Exception ex)
            {

                throw new Exception("Succedio un error " + ex.Message);
               
            }
        }
        




    }
}
