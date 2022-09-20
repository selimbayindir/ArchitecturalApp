// See https://aka.ms/new-console-template for more information
using Entities.Concrete;

Console.WriteLine("Hello, World!");


Person person = new Person();
person.Id = 1;
person.Name = "SElim";
person.LastName = "BAYINDIR";
Console.WriteLine(person.Name);