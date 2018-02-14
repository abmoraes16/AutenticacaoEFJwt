using System;
using System.Linq;
using AutenticacaoEFJwt.Models;

namespace AutenticacaoEFJwt.Dados
{
    public class CodeFirstBanco
    {
        public static void Inicializar(AutenticacaoContexto contexto){
            
            if(contexto.Usuario.Any()) return;

            Usuario usuario = new Usuario(){
                Nome = "Amanda B Moraes",
                Email = "ab@mail.com",
                Senha = "123456",
                DataNascimento = DateTime.Parse("16/10/1993")
            };
            
            contexto.Usuario.Add(usuario);

            Permissao permissao = new Permissao(){
                Nome = "Administracao"
            };

            contexto.Permissao.Add(permissao);

            UsuariosPermissoes usuariosPermissoes = new UsuariosPermissoes(){
                IdUsuario = usuario.IdUsuario,
                IdPermissao = permissao.IdPermissao
            };

            contexto.UsuariosPermissoes.Add(usuariosPermissoes); 
        }
    }
}