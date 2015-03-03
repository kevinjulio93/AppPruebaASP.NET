using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Modelo
{
    public class Personas
    {


        #region "Atributos kevin julio"
        private string id;
        private string nombre;
        private string direccion;
        private string telefono;
        private string email;
        #endregion

        #region "Propiedades"
        public String Id { get; set; }
        public String Nombre { get; set; }
        public String Direccion { get; set; }
        public String Telefono { get; set; }
        public String Email { get; set; }
        #endregion
            
        #region "constructores"
        public Personas()
        {

            id = "1111";
            nombre = "kevin";
            direccion = "asdasdv w34 wsdqd";
            telefono = "66666666";
            email = "sdfs@sdfs.com";
        }

        public Personas(String id, String nombre, String direccion, String telefono, String email)
        {

            this.id = id;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;
        }
        #endregion

        #region "ToString"
        public override string ToString()
        {

            return "Id: " + this.id + "\nnombre: " + this.nombre + "\ndireccion: " + this.direccion + "\ntelefono: " + this.telefono + "\nemail: " + this.email;


        }

        public override int GetHashCode() { return this.ToString().GetHashCode(); }
        #endregion





    }
}
