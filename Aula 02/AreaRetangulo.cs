using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite a base e a altura do retângulo");
    double b = double.Parse(Console.ReadLine());
    double a = double.Parse(Console.ReadLine());
    
    double area = b * a; 
    double per = (2*b) + (2*a);
    double dia = Math.Sqrt((b*b) + (a*a));

    Console.WriteLine($"Área = {area:0.00} - Perímetro = {per:0.00} - Diagonal = {dia:0.00}");

  }
}
