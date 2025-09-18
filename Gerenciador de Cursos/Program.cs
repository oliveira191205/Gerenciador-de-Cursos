namespace Gerenciador_de_Cursos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();





//            Métodos(na service):

//      CRUD em todos - Marcela
//      Fazer matricula de aluno em curso -Larissa
//      Designar professor para curso -Felipe
//      Concluir atividade -Felipe
//      Adicionar atividade -Larissa
//      Alterar o prazo - Felipe
//      Geração de relatórios - Felipe
//      Design Certificado -Marcela
//      Certificados - Felipe
//      Presença - Felipe
//      Calcular progresso -Felipe

//      Controllers - Marcela
//      Repositories - Larissa
//      Context - Felipe
//      Dtos - Felipe
//      Interfaces - Marcela







        }
    }
}
