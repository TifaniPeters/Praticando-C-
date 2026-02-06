// Sistema de Autenticação

string ADMIN_USER = "Admin";

Console.WriteLine("Digite seu nome de usuário:");

string username = Console.ReadLine()!;

if (username == ADMIN_USER)
{
    Console.WriteLine($"Bem-vindo, {username}!");
}

else
{
    Console.WriteLine("Usuário não cadastrado.");
    Console.WriteLine("Opções disponíveis:");
    Console.WriteLine("[1] Cadastrar novo usuário");
    Console.WriteLine("[2] Acessar como convidado");
    Console.WriteLine("[3] Sair");

    int nome = int.Parse(Console.ReadLine()!);

   

    switch (nome)
    {
        case 1:
            Console.WriteLine($"Novo usuário:{username} cadastrado com sucesso!");
            break;
        case 2:
            Console.WriteLine("Acesso concedido como convidado!");
            break;
        case 3:
            Console.WriteLine("Sair");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

















