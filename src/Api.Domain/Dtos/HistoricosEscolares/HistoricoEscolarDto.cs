using System;
using Api.Domain.Interfaces;

namespace Api.Domain.Dtos.HistoricosEscolares
{
    public class HistoricoEscolarDto : IDtoBase
    {
        public string Formato { get; set; }
        
        public string Nome { get; set; }
        public int Id { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}