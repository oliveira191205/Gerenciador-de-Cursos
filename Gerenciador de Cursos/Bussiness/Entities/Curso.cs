namespace Gerenciador_de_Cursos.Bussiness.Entities
{
    public class Curso
    {
        public Guid Id { get; set; }
        public Guid InstrutorId { get; set; }
        public string Nome { get; set; }
        public string Descrição { get; set; }
        public int CargaHoraria { get; set; }

    }
}
