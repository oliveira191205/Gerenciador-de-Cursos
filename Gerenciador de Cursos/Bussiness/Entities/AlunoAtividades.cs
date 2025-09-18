using System.Data;

namespace Gerenciador_de_Cursos.Bussiness.Entities
{
    public class AlunoAtividades
    {
        public Guid Id { get; set; }
        public Guid CursoId { get; set; }
        public Guid AlunoId { get; set; }
        public Guid AtividadesCursoId { get; set; }
        public float Nota { get; set; }
        public bool Concluido { get; set; }
        public DateTime DataEnvio { get; set; }

    }
}
