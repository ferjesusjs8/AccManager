using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FRNGerenciador.domain.Models
{
    public class Empregado
    {
        [Key]
        public int Id { get; set; }
        public Salario Salario { get; set; }
        public Cargo Cargo { get; set; }
        public string Nome { get; set; }
        public string Empresa { get; set; }
        public string Setor { get; set; }
        public int IdRegimeContratacao { get; set; }
        public RegimeContratacao RegimeContratacao { get; set; }
        public List<Desconto> Descontos { get; set; }
        public double ValorHora
        {
            get
            {
                var valor = Salario.Valor / (int)RegimeContratacao.CargaHoraria;
                return valor;
            }
        }
        public List<Ferias> Ferias { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataContratacao { get; set; }
        public DateTime Criacao { get; set; }
        public DateTime Atualizacao { get; set; }
    }
}