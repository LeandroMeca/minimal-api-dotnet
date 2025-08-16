using Microsoft.EntityFrameworkCore;
using MinimalApi.Dominio.Entidades;

namespace MinimalApi.Infraestrutura.Db;


public class DbContexto : DbContext
{

    private readonly IConfiguration _configuracaoAppSetting;

    public DbContexto(IConfiguration configuracaoAppSetting)
    {
        _configuracaoAppSetting = configuracaoAppSetting;
    }

    public DbSet<Administrador> Administradores {get;set;} = default!;
    public DbSet<Veiculo> Veiculos {get;set;} = default!;

    protected override void OnModelCreating(ModelBuilder ModelBuilder){
        ModelBuilder.Entity<Administrador>().HasData(
            new Administrador{
                Id = 1,
                Email = "test@test.com",
                Senha = "123456",
                Perfil = "Adm"
            }
        );
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            var stringConexao = _configuracaoAppSetting.GetConnectionString("mysql")?.ToString();
            if(!string.IsNullOrEmpty(stringConexao))
            {
                optionsBuilder.UseMySql(stringConexao,ServerVersion.AutoDetect(stringConexao));
            }
        }
    } 
}