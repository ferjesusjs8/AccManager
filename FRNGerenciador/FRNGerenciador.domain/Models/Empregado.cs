using FRNGerenciador.domain.Enums;
using System;
using System.Collections.Generic;

namespace FRNGerenciador.domain.Models
{
    public class Empregado
    {
        public int Id { get; set; }
        public double Salario { get; set; }
        public string Cargo { get; set; }
        public string Nome { get; set; }
        public string Empresa { get; set; }
        public string Setor { get; set; }
        public ERegimeContratacao RegimeContratacao { get; set; }
        public List<Desconto> Descontos { get; set; }
        public EEscala Escala { get; set; }
        public double ValorHora
        {
            get
            {
                var valor = Salario / (int)Escala;
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