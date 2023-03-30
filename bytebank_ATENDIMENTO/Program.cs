using bytebank.Modelos.Conta;
using bytebank_Util;
using System.Collections;

ArrayList _listaDeContas = new ArrayList();

void AtendimentoCliente()
{
    char opcao = '0';
	while (opcao != '6')
	{
		Console.Clear();
		Console.WriteLine("----Atendimento----");
		Console.WriteLine("1. Cadastrar Conta");
		Console.WriteLine("2. Listar Conta ");
		Console.WriteLine("3. Remover Conta ");
		Console.WriteLine("4. Ordenar Conta ");
		Console.WriteLine("5. Pesquisar Conta ");
		Console.WriteLine("6. Sair ");
		Console.WriteLine("\n");
		Console.WriteLine("Digite a opcao desejada: ");
		opcao = Console.ReadLine()[0];
		switch (opcao)
		{
			case '1':
				CadastrarConta();
				Console.WriteLine("teste");
				break;
            case '2':
                ListarContas();
                break;
            default:
				Console.WriteLine("Opcao nao implementada");
				break;
		}
	}

}
void ListarContas()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===     LISTA DE CONTAS     ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    if (_listaDeContas.Count <= 0)
    {
        Console.WriteLine("... Não há contas cadastradas! ...");
        Console.ReadKey();
        return;
    }
    foreach (ContaCorrente item in _listaDeContas)
    {
        Console.WriteLine("===  Dados da Conta  ===");
        Console.WriteLine("Número da Conta : " + item.Conta);
        Console.WriteLine("Titular da Conta: " + item.Titular.Nome);
        Console.WriteLine("CPF do Titular  : " + item.Titular.Cpf);
        Console.WriteLine("Profissão do Titular: " + item.Titular.Profissao);
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.ReadKey();
    }

}

void CadastrarConta()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===   CADASTRO DE CONTAS    ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    Console.WriteLine("=== Informe dados da conta ===");

    Console.Write("Número da Agência: ");
    int numeroAgencia = int.Parse(Console.ReadLine());

    ContaCorrente conta = new ContaCorrente(numeroAgencia);

    Console.Write("Informe o saldo inicial: ");
    conta.Saldo = double.Parse(Console.ReadLine());

    Console.Write("Infome nome do Titular: ");
    conta.Titular.Nome = Console.ReadLine();

    Console.Write("Infome CPF do Titular: ");
    conta.Titular.Cpf = Console.ReadLine();

    Console.Write("Infome Profissão do Titular: ");
    conta.Titular.Profissao = Console.ReadLine();

    _listaDeContas.Add(conta);
    Console.WriteLine("... Conta cadastrada com sucesso! ...");
    Console.ReadKey();
}

AtendimentoCliente();



#region

//try
//{
//    ListaContasCorrentes itens = new ListaContasCorrentes();
//    itens.Adicionar(new ContaCorrente(1));
//    itens.Adicionar(new ContaCorrente(1));
//    itens.Adicionar(new ContaCorrente(3));
//    itens.Adicionar(new ContaCorrente(3));
//    itens.Adicionar(new ContaCorrente(3));
//    itens.Adicionar(new ContaCorrente(3));
//    itens.Adicionar(new ContaCorrente(3));

//    ContaCorrente conta = new ContaCorrente(4);
//    itens.Adicionar(conta);

//    itens.Listar();

//    //itens.Remover(conta);
//    //itens.Listar();


//    for (int i = 0; i < itens.Tamanho; i++)
//    {
//        //ContaCorrente c = itens.RecuparItemPorIndice(i);
//        ContaCorrente c = itens[i];
//        Console.WriteLine(c.ToString());
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}


#endregion