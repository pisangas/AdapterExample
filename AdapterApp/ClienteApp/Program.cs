// See https://aka.ms/new-console-template for more information
using AdapterPattern;

Motor motorDiesel = new MotorDiesel();
Motor motorGasolina = new MotorGasolina();
Motor motorElectrico = new MotorElectricoAdapter();

motorDiesel.Arrancar();
motorDiesel.Acelerar();
motorDiesel.Detener();
motorDiesel.Tanquear();

motorGasolina.Arrancar();
motorGasolina.Acelerar();
motorGasolina.Detener();
motorGasolina.Tanquear();

motorElectrico.Arrancar();
motorElectrico.Acelerar();
motorElectrico.Detener();
motorElectrico.Tanquear();


Console.ReadLine();
