using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Dio.Models
{
    public class Professor : People
    {
        public decimal Salario { get; set; }

        public override void ShowName()
        {
            Console.WriteLine($"Nome: {Nome} Idade: {Idade} Salario: {Salario}");
        }
    }
}