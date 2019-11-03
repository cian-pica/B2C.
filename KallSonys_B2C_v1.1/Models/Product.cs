using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KallSonys_B2C_v1._1.Models
{
   [Serializable]
    public class Product
    {
        public int ProductoId { get; set; }
        public string FabricanteId { get; set; }
        public string FabricanteNombre { get; set; }
        public string ProductoReferencia { get; set; }
        public string ProductoNombre { get; set; }
        public int CategoriaId { get; set; }
        public string CategoriaNombre { get; set; }
        public double ProductoValor { get; set; }
        public string ProductoImagenUrl { get; set; }
        public string UsuarioId { get; set; }
        public string UsuarioNombre { get; set; }





        









    }
}