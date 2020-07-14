using System;

class Aluno
{

    // Atributos
    public string nome;
    public double nota1, nota2;

    // Média
    public double media()
    {
        return (nota1+nota2)/2;
    }

    // Situação
    public string situacao(double media)
    {
        return media >= 7 ? "aprovado" : "reprovado";
    }

    // Mensagem
    public void mensagem()
    {
        // Obter a média
        double obterMedia = media();

        // Obter a situação
        string obterSituacao = situacao(obterMedia);

        // Mensagem
        Console.WriteLine(nome+" está "+obterSituacao+" com média "+obterMedia);
    }

}