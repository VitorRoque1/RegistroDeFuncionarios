class Program
{
    static void Main(string[] args)
    {

        char opcao = ' ';

        do
        {
            Console.Clear();
            Console.WriteLine("                                                Cadastro de Funcionarios\n                    ");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\n1 - Cadastrar Funcionarios");
            Console.WriteLine("2 - Consultar Funcionarios");
            Console.WriteLine("0 - Sair \n");

            Console.Write("Opcão: ");
            opcao = Convert.ToChar(Console.ReadLine());

            switch (opcao)
            {
                case '1':
                    registroDeFuncionario();
                    break;

                case '2':
                    ConsultarFuncionarios();
                    break;

                default:

                    if (opcao != '0')
                        Console.Write("Opcão invalida!");
                    break;
            }


        } while (opcao != 0);


        static void registroDeFuncionario()
        {
            Console.Clear();
            //Console.Write("Cadastrar Funcionario\n");
            //Console.Write("Informe o nome: ");
            //string nome = Console.ReadLine()!;
            //Console.Write("Informe o CPF: ");
            //string CPF = Console.ReadLine();
            //Console.Write("Informe o cargo: ");
            //string cargo = Console.ReadLine()!;
            //Console.Write("Informe o E-mail: ");
            //string email = Console.ReadLine()!;
            //Console.Write("Contato: ");
            //string contato = Console.ReadLine();
            Console.Write("Cadastro de Funcionarios\n");
            Console.Write("\nInforme o nome: ");
            string nome = Console.ReadLine();
            Console.Write("Informe o CPF: ");
            string cpf = Console.ReadLine();
            Console.Write("Informe o cargo: ");
            string cargo = Console.ReadLine();
            Console.Write("Salario: ");
            string salario = Console.ReadLine();
            Console.Write("Informe o E-mail: ");
            string email = Console.ReadLine();
            Console.Write("Contato: ");
            string contato = Console.ReadLine();

            Console.Write("\nCadastro efetuado com sucesso...");
            Thread.Sleep(2000);








            // Gravação dos dados no ficheiro
            string ficheiro = @"funcionarios.txt";
            StreamWriter listas;
            if (File.Exists(ficheiro) == true)
            {
                listas = File.AppendText(ficheiro);
            }
            else
            {
                listas = File.CreateText(ficheiro);
            }

            // Grava no ficheiro

            string linha = nome.ToString() + ";" + cpf + ";" + cargo + ";" + salario + ";" + email + ";" + contato;
            listas.WriteLine(linha);
            listas.Close();



        }
        static void ConsultarFuncionarios()
        {
            Console.Clear();
            string ficheiro = @"funcionarios.txt";
            StreamReader consultar;

            // verifica se o ficheiro existe
            if (File.Exists(ficheiro) == true)
            {
                consultar = File.OpenText(ficheiro);
                string linha = "";
                while ((linha = consultar.ReadLine()) != null) // vai efetuar a leitura do ficheiro até o final
                {
                    string[] campos = new string[6];
                    campos = linha.Split(';');

                    // imprime dados
                    Console.WriteLine("Nome: {0}\nCpf: {1}\ncargo: {2}\nsalario: {3}\nE-mail: {4}\nContato: {5}\n", campos[0], campos[1], campos[2], campos[3], campos[4], campos[5]);
                }
                consultar.Close(); // fecha o ficheiro
            }
            else
            {
                Console.WriteLine("Não existe nenhum ficheiro de registro.");
            }

            Console.ReadLine();

        }



    }
}