using Parcial1Lib;

Triangulo triangulo = new Triangulo(5, 10);
Console.WriteLine($"Area del triángulo: {triangulo.area()}");
Console.WriteLine($"Perímetro del triángulo: {triangulo.perimetro()}");

Circulo circulo = new Circulo(5);
Console.WriteLine($"Area del círculo: {circulo.area()}");
Console.WriteLine($"Perímetro del círculo: {circulo.perimetro()}");