using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Models;

public class Person
{
    public string? Name { get; set; }
    public int Age { get; set; }

    public void Show(){
        Console.WriteLine($"Nome: {Name} | Idade: {Age}");
    }
}