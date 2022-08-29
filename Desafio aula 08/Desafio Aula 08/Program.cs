using DesafioAula08;


string mensagem = "";
try
{
    Console.WriteLine("Bem-vindo ao cadastro de contas banciarias");

    List<ContaBancaria> listaContas = new List<ContaBancaria>();
    for (int contagem = 1; contagem <= 3; contagem++)
    {
        Console.WriteLine("Cadastre uma nova conta");
        Console.WriteLine($"Digite o tipo  {contagem}:");
        string tipoConta = Console.ReadLine();

        Console.WriteLine($"Digite a AGENCIA {contagem}:");
        int agencia = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Digite o numero  {contagem}:");
        int numeroConta = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Qual é o saldo   {contagem}:");
        double saldoConta = Convert.ToDouble(Console.ReadLine());

        ContaBancaria contaBancaria = new ContaBancaria(tipoConta, numeroConta, agencia, saldoConta);

        listaContas.Add(contaBancaria);
    }

    Console.WriteLine("Qual numero conta voce gostaria de ver?");
    int numeroContaBusca = Convert.ToInt32(Console.ReadLine());


    if (listaContas.Where(conta => conta.Numero == numeroContaBusca).Any())
    {
         ContaBancaria contaBancariaBusca = listaContas.Where(conta => conta.Numero == numeroContaBusca).FirstOrDefault();
       mensagem = contaBancariaBusca.ExibirDadosContas(); 
    }
    else
    {
        mensagem = "Essa conta nao existe";
    }
}
catch (Exception ex)
{
    mensagem = "O erro encontrado no sistema foi:" + ex.Message;
}
finally {
    Console.WriteLine(mensagem);
}




