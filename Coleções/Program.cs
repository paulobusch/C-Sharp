using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var caderno = new List<Folha>();
            for (var i = 0; i < 55; i++)
                caderno.Add(new Folha() { pagina = i });
            var folhaRabisco = caderno.Where(x => x.AnalizaRabisco()).ToList();
        }
    }
    public class Folha{
    public int pagina { get; set; }
    private bool _isLimpa, _isRabisco, _isTexto;

    public Folha()
    {
        var seed = Guid.NewGuid().GetHashCode();

        var aleatorio = new Random(seed).Next(1,4);
        _isLimpa = aleatorio == 1;
        _isRabisco = aleatorio == 2;
        _isTexto = aleatorio == 3;
    }

    public bool AnalizaRabisco()
    {
        Console.WriteLine($"Análise: {pagina}");
        return _isRabisco;
    }
}
}
