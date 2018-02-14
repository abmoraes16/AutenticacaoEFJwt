using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AutenticacaoEFJwt.Models
{
    public class Usuario
    {
            [Key]
            public int IdUsuario { get; set; } 

            [Required]
            [StringLength(100,MinimumLength=3)]
            public string Nome { get; set; }

            [Required]
            [StringLength(100)]
            [DataType(DataType.EmailAddress)]
            public string Email { get; set; }

            [Required]
            [StringLength(20,MinimumLength=8)]
            [DataType(DataType.Password)]
            public string Senha { get; set; }

            [Required]
            [DataType(DataType.Date)]
            public DateTime DataNascimento { get; set; }

            public ICollection<UsuariosPermissoes> UsuariosPermissoes { get; set; }
    }
}