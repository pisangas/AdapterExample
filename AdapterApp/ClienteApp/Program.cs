// See https://aka.ms/new-console-template for more information
using AdapterPattern;

Motor motorDiesel = new MotorDiesel();
Motor motorGasolina = new MotorGasolina();
Motor motorElectrico = new MotorElectricoAdapter();

Console.WriteLine("Llevar mi auto a aprovisionar Gasolina, Diesel, o energia --> remoto \n");
Console.WriteLine("=================================================================");
motorDiesel.Arrancar();
motorDiesel.Acelerar();
motorDiesel.Detener();
motorDiesel.Tanquear();

Console.WriteLine("=================================================================");
motorGasolina.Arrancar();
motorGasolina.Acelerar();
motorGasolina.Detener();
motorGasolina.Tanquear();

Console.WriteLine("=================================================================");
motorElectrico.Arrancar();
motorElectrico.Acelerar();
motorElectrico.Detener();
motorElectrico.Tanquear();


Console.ReadLine();
