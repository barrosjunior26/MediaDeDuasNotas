namespace Exercicio27
{
    class mediaDuasNotas
    {
        public static void Main(String[] args)
        {
            /*27) Crie um programa que leia duas notas de um aluno e calcule a sua média,
            mostrando uma mensagem no final, de acordo com a média atingida:
            -Média até 4.9: REPROVADO
            - Média entre 5.0 e 6.9: RECUPERAÇÃO
            - Média 7.0 ou superior: APROVADO*/

            //Declaração de variáveis
            int opcao = 0;

            do
            {   
                //Solicitação das notas do aluno
                Console.Write("Informe a primeira nota: ");
                double nota1 = double.Parse(Console.ReadLine());
                Console.Write("Informe a segunda nota: ");
                double nota2 = double.Parse(Console.ReadLine());

                //Processamento dos dados
                double resultado = (nota1 + nota2) / 2;


                //Seleção de resultado conforme a média final do aluno
                if (resultado <= 4.9)
                {
                    Console.WriteLine($"O aluno está REPROVADO com média {resultado}.");
                }else if (resultado >= 5 && resultado <= 6.9)
                {
                    Console.WriteLine($"O aluno está em RECUPERAÇÃO com média {resultado}.");
                }
                else
                {
                    Console.WriteLine($"O aluno está APROVADO com média {resultado}.");
                }
                //
                //Solicitando se o usuário deseja realizar uma nova operação ou se deseja encerrar o sistema.
                Console.WriteLine("Para NOVA OPERAÇÃO digite 1 ou 0 PARA SAIR do sistema");
                opcao = int.Parse(Console.ReadLine());
            } while (opcao != 0);
            Console.WriteLine("Saindo do sistema...");
        }
    }
}