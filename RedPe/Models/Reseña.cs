using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

namespace RedPe.Models
{
 
    public class Reseña
    {
        private int _idReseña;
        private string _nombreDelUsuario;
         private string _titulo;
        private int _cantLikes;
        private string _contenido;
        

        public Reseña( int pIdReseña, string pNombreDelUsuario, string pTitulo, int pCantLikes ,string pContenido)
        {
         
            _idReseña = pIdReseña;
            _nombreDelUsuario = pNombreDelUsuario;
            _titulo=pTitulo;
            _cantLikes=pCantLikes;
            _contenido=pContenido;
        }

        public Reseña()
        {
            _idReseña = 0;
            _nombreDelUsuario = "";
            _titulo="";
            _cantLikes=0;
            _contenido="";

        }



        public int IdReseña
        {
        
          get {return _idReseña;}
          set {_idReseña=value;}

        }
        public string NombreDelUsuario
        {
        
          get {return _nombreDelUsuario;}
          set {_nombreDelUsuario=value;}

        }
         public string Titulo
        {
        
          get {return _titulo;}
          set {_titulo=value;}

        }
        public int CantLikes
        {
        
          get {return _cantLikes;}
          set {_cantLikes=value;}

        }
          public string Contenido
        {
        
          get {return _contenido;}
          set {_contenido=value;}

        }
       
    }
}