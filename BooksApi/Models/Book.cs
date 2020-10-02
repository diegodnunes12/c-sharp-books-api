using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BooksApi.Models
{
    [Table("Books")]
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "* Por favor, insira o título")]
        [MaxLength(50, ErrorMessage = "* Número máximo de caracteres: 50")]
        [Display(Name = "Título")]
        public string Title { get; set; }

        [Display(Name = "Descrição")]
        [MaxLength(500, ErrorMessage = "* Número máximo de caracteres: 500")]
        public string Description { get; set; }

        [Required(ErrorMessage = "* Por favor, selecione a editora")]
        [Display(Name = "Editora")]
        public int PublisherId { get; set; }

        [ForeignKey("PublisherId")]
        public Publisher Publisher { get; set; }
    }
}
