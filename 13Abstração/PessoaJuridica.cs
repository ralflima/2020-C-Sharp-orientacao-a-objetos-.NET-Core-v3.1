using System;

class PessoaJuridica : Padrao
{

    // Método obrigatório
    public override void taxaEmprestimo(double valor)
    {
        Console.WriteLine("Taxa de empréstimo para Pessoa Jurídica R$ "+(valor * 0.2));
    }

}