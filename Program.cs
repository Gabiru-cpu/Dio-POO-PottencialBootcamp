using POO_Dio.Models;

Aluno a1 = new Aluno();
a1.Idade = 6;
a1.Nome = "Nicolas";
a1.Nota = 8;
a1.ShowName();

Professor prof1 = new Professor();
prof1.Idade = 32;
prof1.Nome = "Flavio";
prof1.Salario = 1350;
prof1.ShowName();

ContaCorrente c1 = new ContaCorrente(125, 2500);

c1.ShowSaldo();
c1.Sacar(599);
c1.ShowSaldo();


People p1 = new People();

p1.Idade = 15;
p1.Nome = "John";

p1.ShowName();