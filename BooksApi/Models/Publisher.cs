using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BooksApi.Models
{
    [Table("Publishers")]
    public class Publisher
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "* Por favor, insira o nome")]
        [MaxLength(50, ErrorMessage = "* Número máximo de caracteres: 50")]
        [Display(Name = "Nome")]
        public string Name { get; set; }
    }
}
