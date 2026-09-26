using Microsoft.EntityFrameworkCore;
using cadastro_emprestimo.Models;

namespace cadastro_emprestimo.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<EmprestimoModel> Emprestimos { get; set; }
}
