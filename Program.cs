using ConsumoApi_Aluno.Entities;
using ConsumoApi_Aluno.Entities.Services;

namespace ConsumindoApi
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Console.Write("Informe o ID:");
            int  id = int.Parse(Console.ReadLine());

            AlunoServices alunoServices = new AlunoServices();
            
            Aluno alunoEncontrado = await alunoServices.Integracao(id);

            if(!alunoEncontrado.Verifica) {
                Console.WriteLine("Aluno Encontrado");
                Console.WriteLine($"Nome:{alunoEncontrado.Nome}, Situação:{alunoEncontrado.Situacao}, Matricula:{alunoEncontrado.Matricula}");
                
            } else {
                Console.WriteLine("Aluno não encontrado!");
            }
        }
    }
}