double metros, centimetros, kilometros;

Console.Write("Me diga a medida em metros desejada: ");
metros = Convert.ToDouble(Console.ReadLine());

centimetros = metros * 100;
kilometros = metros / 1000;
Console.WriteLine($"{centimetros} cm");
Console.WriteLine($"{metros} m");
Console.WriteLine($"{kilometros} Km");

