﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace dominio
{
    public class Articulos
    {
        [DisplayName("Código")]
        public string Codigo { get; set; }
        public string Nombre { get; set; }

        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        
        [DisplayName("Imagen Url")]
        public string ImagenUrl { get; set; }
       
        [DisplayName("Categoría")]
        public Categoria Categoria { get; set; }
        public Marca Marca { get; set; }

        public decimal Precio { get; set; }
        public int Id { get; set; }
    }
}
