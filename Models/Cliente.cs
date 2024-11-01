﻿using System.ComponentModel.DataAnnotations;

namespace LojaAPI.Models
{
    public class Cliente
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public ICollection<Roupa> Roupas { get; set; } = new List<Roupa>();
    }
}
