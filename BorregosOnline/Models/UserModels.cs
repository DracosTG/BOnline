using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace BorregosOnline.Models
{
    public class UserModels
    {
          [Required]
        public int Id { get; set; }
        public int IdProductor { get; set; }
        public string Nombre { get; set; }
        public string Rancho { get; set; }
        public int CantidadDeBorregos { get; set; }
        public string Contraseña { get; set; }
        public string Telefono { get; set; }
    }
}