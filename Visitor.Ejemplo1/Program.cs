// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Visitor.Ejemplo1;

var tv = new TV();
var phone = new Phone();
var computer = new Computer();
var repairService = new RepairService();

tv.Accept(repairService);
phone.Accept(repairService);
computer.Accept(repairService);
