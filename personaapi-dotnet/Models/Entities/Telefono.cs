using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace personaapi_dotnet.Models.Entities
{
    public partial class Telefono
    {
        [Key]
        public string Num { get; set; } = null!;
        public string Oper { get; set; } = null!;
        public int? Duenio { get; set; }

        public virtual Persona? DuenioNavigation { get; set; }
    }
}
