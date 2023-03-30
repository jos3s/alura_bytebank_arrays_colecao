using bytebank.Modelos.Conta;
using bytebank_Util;

public class Program
{
    public static void Main(string[] args)
    {

        try
        {
            ListaContasCorrentes itens = new ListaContasCorrentes();
            itens.Adicionar(new ContaCorrente(1));
            itens.Adicionar(new ContaCorrente(1));
            itens.Adicionar(new ContaCorrente(3));
            itens.Adicionar(new ContaCorrente(3));
            itens.Adicionar(new ContaCorrente(3));
            itens.Adicionar(new ContaCorrente(3));
            itens.Adicionar(new ContaCorrente(3));

            ContaCorrente conta = new ContaCorrente(4);
            itens.Adicionar(conta);

            itens.Listar();

            itens.Remover(conta);
            itens.Listar();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}