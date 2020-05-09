using FRNGerenciador.domain.Models;
using Microsoft.EntityFrameworkCore;

namespace FRNGerenciador.data.Connection
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Bandeira> Bandeiras { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Cartao> Cartoes { get; set; }
        public DbSet<Conta> Contas { get; set; }
        public DbSet<Debito> Debitos { get; set; }
        public DbSet<Desconto> Descontos { get; set; }
        public DbSet<Empregado> Empregados { get; set; }
        public DbSet<EquivalenciaHoras> EquivalenciaHoras { get; set; }
        public DbSet<Fatura> Faturas { get; set; }
        public DbSet<Ferias> Ferias { get; set; }
        public DbSet<Hierarquia> Hierarquias { get; set; }
        public DbSet<HorasExtras> HorasExtras { get; set; }
        public DbSet<Pessoa> Owners { get; set; }
        public DbSet<Parcela> Parcelas { get; set; }
        public DbSet<RegimeContratacao> RegimesContratacoes { get; set; }
        public DbSet<Salario> Salarios { get; set; }
        public DbSet<Saldo> Saldos { get; set; }
    }
}