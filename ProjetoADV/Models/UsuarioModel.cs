using System.ComponentModel.DataAnnotations;

namespace ProjetoADV.Models
{
    public class UsuarioModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Preencha todos os campos.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Preencha todos os campos.")]
        public int Idade { get; set; }
        [Required(ErrorMessage ="Preencha todos os campos.")]
        public string Cargo { get; set; }
    }
}
