using FRNGerenciador.domain.Enums;
using System;

namespace FRNGerenciador.domain.Models
{
    public class HorasExtras
    {
        public int Id { get; set; }
        public double ValorHora
        {
            get
            {
                var valor = Salario / 160;
                return valor;
            }
        }
        public int QuantidadePercentual20 { get; set; }
        public int QuantidadePercentual50 { get; set; }
        public int QuantidadePercentual75 { get; set; }
        public int QuantidadePercentual100 { get; set; }
        public double ValorTotalPercentual20
        {
            get
            {
                var valor = ValorHora * 0.2;
                return Math.Round(valor, 2);
            }
        }
        public decimal ValorTotalPercentual50 { get; set; }
        public decimal ValorTotalPercentual75 { get; set; }
        public decimal ValorTotalPercentual100 { get; set; }
        public decimal ValorPercentual20 { get; set; }
        public decimal ValorPercentual50 { get; set; }
        public decimal ValorPercentual75 { get; set; }
        public decimal ValorPercentual100 { get; set; }
        public double Salario { get; set; }
        public string MesAno { get; set; }
        public EEquivalenciaHoras EquivalenciaHoras { get; set; }
        public DateTime Criacao { get; set; }
        public DateTime Atualizacao { get; set; }
    }
}