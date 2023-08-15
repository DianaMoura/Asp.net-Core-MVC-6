using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDDOTNET6.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        public int Id { get; set; }
        [MaxLength(80)]
        public string Nome { get; set; }
        [MaxLength(60)]

        public string Email { get; set; }
        [MaxLength(10,ErrorMessage = "O Tamanho Máximo é {1} caracteres")]
        [MinLength(5, ErrorMessage = "O Tamanho Máximo é {1} caracteres")]

        public string Senha { get; set; }

        public bool Administrador { get; set; }

        public bool Ativo { get; set;}

        public DateTime DataDoCadastro { get; set; }
        
        public DateTime? DataDaInativação { get; set; }


    }
}
