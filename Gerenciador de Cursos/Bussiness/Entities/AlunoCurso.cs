namespace Gerenciador_de_Cursos.Bussiness.Entities
{
    public class AlunoCurso
    {
        public Guid Id { get; set; }
        public Guid CursoId { get; set; }
        public Guid AlunoId { get; set; }
        public bool Concluido { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Termino { get; set; }


    }
}
