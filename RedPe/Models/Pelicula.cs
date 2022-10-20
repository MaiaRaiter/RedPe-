using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

namespace RedPe.Models
{
 
    public class Pelicula
    {
        private int _idCategoria;
        private string _nombre;
         private string _foto;
        private string _director;
        private int _idReseña;
    
        private string _sintesis;
          private string _trailer;
        

        public Pelicula( int pIdCategoria, string pNombre, string pFoto,string pDirector,int pIdReseña,string pSintesis,string pTrailer)
        {
         
            _idCategoria = pIdCategoria;
            _nombre = pNombre;
            _foto=pFoto;
            _director=pDirector;
            _idReseña=pIdReseña;
            _sintesis=pSintesis;
            _trailer=pTrailer;
        }

        public Pelicula()
        {
            _idCategoria = 0;
            _nombre = "";
            _foto="";
            _director="";
            _idReseña=0;
            _sintesis="";
            _trailer="";
        }



        public int IdCategoria
        {
        
          get {return _idCategoria;}
          set {_idCategoria=value;}

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
        public string Director
        {
        
          get {return _director;}
          set {_director=value;}

        }
          public int IdReseña
        {
        
          get {return _idReseña;}
          set {_idReseña=value;}

        }
        public string Sintesis
        {
        
          get {return _sintesis;}
          set {_sintesis=value;}

        }
        public string Trailer
        {
        
          get {return _trailer;}
          set {_trailer=value;}

        }
       
    }
}