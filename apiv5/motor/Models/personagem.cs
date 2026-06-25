using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace motor.Models
{
    public class Personagem
    {
        [Key]
        public int Id {get; set;}
        [Required(ErrorMessage = "Nome é um campo obrigatório!")]
        [MaxLength(50, ErrorMessage = "Nome precisa ser menor que 50 caracteres!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Nome é um campo obrigatório!")]
        [MaxLength(50, ErrorMessage = "Nome precisa ser menor que 50 caracteres!")]
        public string Tipo { get; set; }
    }
}