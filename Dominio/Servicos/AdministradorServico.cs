namespace MinimalApi.Dominio.Servico;

public class AdministradorServico : IAdministradorServico
{
    private readonly DbContext _context;

    public AdministradorServico(DbContexto context)
    {
        _context = context;
    }

    public Administrador? Login(LoginDTO loginDTO)
    {
        var adm = _context.Administradores.Where(a => a.Email == loginDTO.Email && a.Senha == loginDTO.Senha).FirstOrDefault();
        return adm;
    }
}