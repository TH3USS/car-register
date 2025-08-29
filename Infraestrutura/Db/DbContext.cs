using Microsoft.EntityFrameworkCore;
using MinhaApi.Dominio.Entidades;

namespace MinhaApi.Infraestrutura.Db;

public class DbContext : DbContext
{
    public DbContext(IConfiguration configuracaoAppSettings)
    {
        _configuracaoAppSettings = configuracaoAppSettings;
    }

    public DbSet<Administrador> Administradores { get; set; } = default;

    protected override void OnModelCreating(ModeBuild modeBuilder)
    {
        modeBuilder.Entity<Administrador>().HasData(
            new Administrador {
                Id= 1,
                Email = "administrador@teste.com",
                Senha = "123456",
                Perfil = "Adm"
            }
        );
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
    {
        if(!optionBuilder.IsConfigured)
        {
            var stringConexao = _configuracao.GetConnectionString("mysql")?.ToString();
        if(!string.IsNullOrEmpty(stringConexao))
        {
            optionBuilder.UseMySql{
            stringConexao,
            ServerVersion.AutoDetect(stringConexao)
        };
        
        };
        }
        
    }
}