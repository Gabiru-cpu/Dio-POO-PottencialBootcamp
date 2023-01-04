using POO_Dio.Models;
using POO_Dio.interfaces;

ICalculadora calc = new Calculadora();
//Console.WriteLine(calc.Somar(5, 10));


Aluno a1 = new Aluno("nameless");
a1.Idade = 6;
a1.Nome = "Nicolas";
a1.Nota = 8;
a1.ShowName();

Professor prof1 = new Professor("nameless");
prof1.Idade = 32;
prof1.Nome = "Flavio";
prof1.Salario = 1350;
prof1.ShowName();

ContaCorrente c1 = new ContaCorrente(125, 2500);

c1.ShowSaldo();
c1.Sacar(599);
c1.ShowSaldo();


People p1 = new People("nameless");

p1.Idade = 15;
p1.Nome = "John";

p1.ShowName();