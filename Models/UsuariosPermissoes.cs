using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutenticacaoEFJwt.Models
{
    public class UsuariosPermissoes
    {
        [Key]
        public int IdUsuariosPermissoes { get; set; }

        [Required]
        public int IdUsuario { get; set; }
        
        [ForeignKey("IdUsuario")]
        public Usuario Usuario { get; set; }

        [Required]
        public int IdPermissao { get; set; }
        
        [ForeignKey("IdPermissao")]
        public Permissao Permissao { get; set; }
    }
}