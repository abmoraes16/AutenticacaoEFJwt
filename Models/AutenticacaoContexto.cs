using Microsoft.EntityFrameworkCore;

namespace AutenticacaoEFJwt.Models
{
    public class AutenticacaoContexto:DbContext
    {
        public AutenticacaoContexto(DbContextOptions<AutenticacaoContexto> options):base(options){}

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Permissao> Permissao { get; set; }
        public DbSet<UsuariosPermissoes> UsuariosPermissoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Permissao>().ToTable("Permissao");
            modelBuilder.Entity<UsuariosPermissoes>().ToTable("UsuariosPermissoes");

            base.OnModelCreating(modelBuilder);
        }
    }
}