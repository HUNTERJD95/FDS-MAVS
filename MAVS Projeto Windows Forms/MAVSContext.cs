using MAVS_Projeto_Windows_Forms.Domain;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace MAVS_Projeto_Windows_Forms
{
    internal class MAVSContext : DbContext
    {
        public DbSet<Funcionario> Funcionarios { get; set; }

        /* public string DbPath { get; }*/

        public MAVSContext()
        {
            /* var folder = Environment.SpecialFolder.LocalApplicationData;
              var path = Environment.GetFolderPath(folder);
              DbPath = Path.Join(path, "BaseDados\\Database1.mdf");*/
        }

        /* protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer($"Data Source={DbPath}"); */

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\cs_ba\\Desktop\\FDS-MAVS\\MAVS Projeto Windows Forms\\BaseDados\\Database1.mdf\";Integrated Security=True");
    }
}
