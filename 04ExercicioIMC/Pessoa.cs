using System;
class Pessoa
{

    // Atributos
    public double peso, altura;

    // Cálculo
    public double calculo()
    {
        return peso / (altura * altura);
    }

    // Situação
    public string situacao(double imc)
    {
        // Variável
        string retorno;

        // Condicional
        if(imc < 18.5)
        {
            retorno = "Abaixo do peso";
        }
        else if(imc < 25)
        {
            retorno = "Peso normal";
        }
        else if(imc < 30)
        {
            retorno = "Acima do peso";
        }
        else if(imc < 35)
        {
            retorno = "Obesidade I";
        }
        else if(imc < 40)
        {
            retorno = "Obesidade II";
        }
        else
        {
            retorno = "Obesidade III";
        }

        // Retorno
        return retorno;
    }

    // Mensagem
    public void mensagem()
    {
        // Obter o cálculo
        double obterCalculo = calculo();

        // Obter situação
        string obterSituacao = situacao(obterCalculo);

        // Exibir mensagem
        Console.WriteLine("Seu IMC é de "+obterCalculo);
        Console.WriteLine("Sua situação é "+obterSituacao);
    }

}