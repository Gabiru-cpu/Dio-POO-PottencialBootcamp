using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Dio.Models
{
    public class People
    {
        public People(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public virtual void ShowName()
        {
            Console.WriteLine($"Nome:   {Nome} Idade:   {Idade}");
        }
    }
}