using AutenticacaoEFJwt.Models;

namespace AutenticacaoEFJwt.Dados
{
    public class IniciarBanco
    {
        public static void Inicializar(AutenticacaoContexto contexto){
            contexto.Database.EnsureCreated(); //Cria banco, caso ainda não exista.
        }   
    }
}