using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AutenticacaoEFJwt.Models
{
    public class Permissao
    {
        [Key]
        public int IdPermissao { get; set; }

        [Required]
        [StringLength(100,MinimumLength=5)]
        public string Nome { get; set; }

        public ICollection<UsuariosPermissoes> UsuariosPermissoes { get; set; }
    }
}