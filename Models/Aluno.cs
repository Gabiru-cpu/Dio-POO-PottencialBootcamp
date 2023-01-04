using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Dio.Models
{
    public class Aluno : People
    {
        public Aluno(string nome) : base(nome)
        {
            
        }
        public double Nota { get; set; }

        public override void ShowName()
        {
            Console.WriteLine($"Nome: {Nome} Idade: {Idade} Nota: {Nota}");
        }
    }
}