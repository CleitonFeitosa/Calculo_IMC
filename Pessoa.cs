using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Pessoa
{
    public double peso, altura;

    public double imccalc()
    {
        return (peso / (altura * altura));
    }
    public string verifimc(double imccalc)
    {
        if (imccalc < 18.5)
        {
            return ("Você esta Abaixo do Peso");
        }
        else if (imccalc < 25)
        {
            return ("Você está com o Peso Normal");
        }
        else if (imccalc < 30)
        {
            return ("Você esta Acima do Peso");
        }
        else if (imccalc <35)
        {
            return ("Você esta em Obesidade I");
        }
        else if (imccalc < 40)
        {
            return ("Você esta em Obesidade II");
        }
        else
        {
            return ("Você esta em Obesidade III");
        }

    }
    public void mensagem()
    {
        double obterimc = imccalc();

        string obtersituação = verifimc(obterimc);

        Console.WriteLine("O seu IMC é: " + obterimc + "e " + obtersituação);
    }
}