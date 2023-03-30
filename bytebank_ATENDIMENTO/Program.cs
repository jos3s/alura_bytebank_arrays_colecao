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

            //itens.Remover(conta);
            //itens.Listar();


            for (int i = 0; i < itens.Tamanho; i++)
            {
                //ContaCorrente c = itens.RecuparItemPorIndice(i);
                ContaCorrente c = itens[i];
                Console.WriteLine(c.ToString());
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}