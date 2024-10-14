Random random = new Random();

int numeroScreto = Convert.ToInt32(random.Next(1, 100).ToString()); 
Console.WriteLine(numeroScreto);


do {
    Console.WriteLine("Digite o número secreto entre 1 a 100");
    int numeroDigitado = int.Parse(Console.ReadLine()!);

    if (numeroDigitado == numeroScreto) {
        Console.WriteLine("Parabens, você achou o numero secreto que é " + numeroScreto + " Fim de jogo");
        break;

    } else if (numeroDigitado < numeroScreto) {
        Console.WriteLine(" Errou, o numero secreto é maior que " + numeroDigitado);
    } else {
        Console.WriteLine(" Errou, o numero secreto é menor que " + numeroDigitado);
    }
} while (true);










