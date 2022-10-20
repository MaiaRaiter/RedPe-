using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

namespace RedPe.Models
{
 
    public class Eventos
    {
        private int _idEvento;
        private string _nombre;
         private string _foto;
        
        

        public Eventos( int pIdEvento, string pNombre, string pFoto)
        {
         
            _idEvento = pIdEvento;
            _nombre = pNombre;
            _foto=pFoto;
            
        }

        public Eventos()
        {
            _idEvento = 0;
            _nombre = "";
            _foto="";
           
        }



        public int pIdEvento
        {
        
          get {return _idEvento;}
          set {_idEvento=value;}

        }
        public string Nombre
        {
        
          get {return _nombre;}
          set {_nombre=value;}

        }
         public string Foto
        {
        
          get {return _foto;}
          set {_foto=value;}

        }
        


        
    }
}