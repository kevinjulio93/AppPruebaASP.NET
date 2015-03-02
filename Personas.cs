using System;

public class Personas
{

        #region "Atributos"
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
        public Personas (){

            id="";
            nombre="";
            direccion="";
            telefono="";
            email="";
        }

    public Personas (String id, String nombre, String direccion, String telefono,String email  ){

            this.id=id;
            this.nombre=nombre;
            this.direccion=direccion;
            this.telefono=telefono;
            this.email=email;
        }
    
    public override string ToString(){

        return "Id: " + this.id + "nombre: " + this.nombre + "direccion: " + this.direccion + "telefono: " +this.telefono + "email: " + this.email  ;

        
    } 

    public override int GetHashCode (){   return this.ToString().GetHashCode();  }



	}
