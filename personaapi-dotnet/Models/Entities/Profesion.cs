using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace personaapi_dotnet.Models.Entities
{
    public partial class Profesion
    {
        public Profesion()
        {
            Estudios = new HashSet<Estudio>();
        }

        [Key]
        public int Id { get; set; }
        public string? Nom { get; set; }
        public string? Des { get; set; }

        public virtual ICollection<Estudio> Estudios { get; set; }
    }
}
