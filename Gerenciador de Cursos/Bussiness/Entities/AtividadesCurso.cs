namespace Gerenciador_de_Cursos.Bussiness.Entities
{
    public class AtividadesCurso
    {
        public Guid Id { get; set; }
        public Guid CursoId { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Enunciado { get; set; }
        public bool Alternativa1 { get; set; }
        public bool Alternativa2 { get; set; }
        public bool Alternativa3 { get; set; }
        public bool Alternativa4 { get; set; }
        public string Dissertativa { get; set; }
        public byte[] Midias { get; set; }
        public DateTime PrazoEnvio { get; set; }


    }
}
