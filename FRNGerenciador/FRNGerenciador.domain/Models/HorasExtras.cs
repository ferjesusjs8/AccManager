using System;
using System.ComponentModel.DataAnnotations;

namespace FRNGerenciador.domain.Models
{
    public class HorasExtras
    {
        [Key]
        public int Id { get; set; }
        public int QuantidadePercentual20 { get; set; }
        public int QuantidadePercentual50 { get; set; }
        public int QuantidadePercentual75 { get; set; }
        public int QuantidadePercentual100 { get; set; }
        public int QuantidadeHorasMes { get; set; }
        public double ValorHora
        {
            get
            {
                var valor = Salario / QuantidadeHorasMes;
                return valor;
            }
        }

        public double ValorTotalPercentual20
        {
            get
            {
                var valor = ValorPercentual20 * QuantidadePercentual20;
                return Math.Round(valor, 2);
            }
        }
        public double ValorTotalPercentual50
        {
            get
            {
                var valor = ValorPercentual50 * QuantidadePercentual50;
                return Math.Round(valor, 2);
            }
        }
        public double ValorTotalPercentual75
        {
            get
            {
                var valor = ValorPercentual75 * QuantidadePercentual75;
                return Math.Round(valor, 2);
            }
        }
        public double ValorTotalPercentual100
        {
            get
            {
                var valor = ValorPercentual100 * QuantidadePercentual100;
                return Math.Round(valor, 2);
            }
        }
        public double ValorPercentual20
        {
            get
            {
                var valor = ValorHora * 1.2;
                return Math.Round(valor, 2);
            }
        }
        public double ValorPercentual50
        {
            get
            {
                var valor = ValorHora * 1.5;
                return Math.Round(valor, 2);
            }
        }
        public double ValorPercentual75
        {
            get
            {
                var valor = ValorHora * 1.75;
                return Math.Round(valor, 2);
            }
        }
        public double ValorPercentual100
        {
            get
            {
                var valor = ValorHora * 2;
                return Math.Round(valor, 2);
            }
        }
        public double Salario
        {
            get
            {
                return this.Salario;
            }
            set
            {
                this.Salario = Math.Round(value, 2);
            }
        }
        public string MesAno { get; set; }
        public bool Ativo { get; set; }
        public DateTime Criacao { get; set; }
        public DateTime Atualizacao { get; set; }
    }
}