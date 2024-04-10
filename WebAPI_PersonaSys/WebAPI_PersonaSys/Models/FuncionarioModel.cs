using System.ComponentModel.DataAnnotations;
using WebAPI_PersonaSys.Enums;

namespace WebAPI_PersonaSys.Models
{
    public class FuncionarioModel
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public  DepartamentoEnum Departamento { get; set; }
        public string Cargo{ get; set; }
        public int Matricula { get; set; }
        public int Senha { get; set; }
        public PerfilEnum Perfil{ get; set; }
        public bool Ativo { get; set; }
        public DateTime DataDeCriacao { get; set; } = DateTime.Now.ToLocalTime();
        public DateTime DataDeAlteracao { get;} = DateTime.Now.ToLocalTime();

    }
}
