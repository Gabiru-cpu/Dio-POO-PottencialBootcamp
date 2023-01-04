using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Dio.Models
{
    //selando classes e metodos sintaxe: ###   sealed   ###   
    public sealed class Diretor : People
    {
    public Diretor(string nome) : base(nome)
    {
        
    }
        public decimal Salario { get; set; }

        public sealed override void ShowName()
        {
            Console.WriteLine($"Nome: {Nome} Idade: {Idade} Salario: {Salario}");
        }
    }
}