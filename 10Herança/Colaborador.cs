using System;

class Colaborador : Pessoa
{

    // Atributos
    private double salario;

    // Construtor
    public Colaborador(string nome, int idade, double salario)
    {
        this.nome = nome;
        this.idade = idade;
        this.salario = salario;

        mensagemPessoa();
        mensagemColaborador();
    }

    // Método
    private void mensagemColaborador()
    {
        Console.WriteLine("Salário: "+salario);
    }

}