using MAVS_Projeto_Windows_Forms.Dominio;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace MAVS_Projeto_Windows_Forms
{
   internal class MAVSContext : DbContext
    {
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<ProdutoDigital> ProdutosDigitais { get; set; }
        public DbSet<ProdutoFisico> ProdutosFisicos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .ToTable("Produtos")
                .HasDiscriminator<string>("Discriminator") // Qual a coluna da tabela de produtos que vai descriminar se o produto é digital ou físico
                .HasValue<ProdutoDigital>(ProductType.Digital.ToString()) // para ser digital o valor tem que ser igual à string "Digital", feito no enumerador
                .HasValue<ProdutoFisico>(ProductType.Fisico.ToString()); // para ser fisico o valor tem que ser igual à string "Fisico", feito no enumerador
        }

        // Comando para conectar ao servidor SQL
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\cs_ba\\Desktop\\FDS-MAVS\\MAVS Projeto Windows Forms\\BaseDados\\Database1.mdf\";Integrated Security=True");
   }
}
