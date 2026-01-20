using System; 
using System.Globalization;
using System.Diagnostics;

class URI {

    static void Main(string[] args) { 
        URI obj = new URI();
        obj.SampleMethod1047();

    }

    public void SampleMethod()
    {
        double A, B, C, delta, R1, R2;

        string[] entrada = Console.ReadLine().Split(' ');

        A = Convert.ToDouble(entrada[0], CultureInfo.InvariantCulture);
        B = Convert.ToDouble(entrada[1], CultureInfo.InvariantCulture);
        C = Convert.ToDouble(entrada[2], CultureInfo.InvariantCulture);
        delta = B * B - 4.0 * A * C;

        if (delta < 0.0 || A == 0.0) {
            Console.WriteLine("Impossivel calcular");
        }
        else {
            R1 = (-B + Math.Sqrt(delta)) / (2.0 * A);
            R2 = (-B - Math.Sqrt(delta)) / (2.0 * A);

            Console.WriteLine("R1 = " + R1.ToString("F5", CultureInfo.InvariantCulture));
            Console.WriteLine("R2 = " + R2.ToString("F5", CultureInfo.InvariantCulture));
        }
    }

    public void SampleMethod1047()
    {
        int Hi, Mi, Hf, Mf;

        string[] entrada = Console.ReadLine().Split(' ');
        Hi = Convert.ToInt32(entrada[0]);
        Mi = Convert.ToInt32(entrada[1]);
        Hf = Convert.ToInt32(entrada[2]);
        Mf = Convert.ToInt32(entrada[3]);

        Hi = Hi * 60 + Mi;
        Hf = Hf * 60 + Mf;

        int duracao = Hf - Hi;
        if (duracao <= 0)
        {
            duracao += 24 * 60;
        }

        int duracaoHoras = duracao / 60;
        int duracaoMinutos = duracao % 60;

        Console.WriteLine("O JOGO DUROU " + duracaoHoras + " HORA(S) E " + duracaoMinutos + " MINUTO(S)");
    }

}