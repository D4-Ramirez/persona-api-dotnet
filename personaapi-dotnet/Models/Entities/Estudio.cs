using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace personaapi_dotnet.Models.Entities
{
    public partial class Estudio
    {
        public int IdProf { get; set; }
        [Key]
        public int CcPer { get; set; }
        public DateTime Fecha { get; set; }
        public string Univer { get; set; } = null!;

        public virtual Persona CcPerNavigation { get; set; } = null!;
        public virtual Profesion IdProfNavigation { get; set; } = null!;
    }
}
