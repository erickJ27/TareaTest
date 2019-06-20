using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTest.Entidades
{
    public class Usuario_Has_Permisos
    {
        [Key]
        public int IdUsuario { get; set; }
        public int IdPermiso { get; set; }

        public Usuario_Has_Permisos()
        {
            this.IdUsuario = 0;
            this.IdPermiso = 0;

        }
    }
}
