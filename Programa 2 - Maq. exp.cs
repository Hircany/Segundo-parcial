using System;
					
public class Program
{
	static void Main(string[] args)
	{
		int dinero=0;
		int dineroDisponible = 0;
		int cambio=0;
		string eleccionUsuario;
		int leche=50;
		int chocolate= 25;
		int galletas= 10;
		int gomitas = 50;
		int jugo = 25;
		int Ruffle = 10;
		int Mammut = 25;
		int cocacola = 25;
		int bolon = 5; 
		int confle = 10;

	
		
		Console.WriteLine("Máquina expendedora");
		Console.WriteLine("Por favor, elija el producto que desee comprar");
		Console.WriteLine("Digite 1 para leche");
		
		dineroDisponible= int.Parse(Console.ReadLine());
		
		eleccionUsuario= Console.ReadLine();
		
			
		
		switch(eleccionUsuario)
		{
			case "1":
				dinero = dinero + leche;
				break;
				
			case "2":
				dinero= dinero + chocolate;
				break;
				
			case "3":
				dinero= dinero + galletas;
				break;
				
			case "4":
				dinero= dinero + gomitas;
				break;
				
			case "5":
				dinero= dinero + jugo;
				break;

			case "6":
			    dinero= dinero + Ruffle;
				break;

			case "7":
			    dinero= dinero + Mammut;
				break;

			case "8":
			   dinero= dinero + cocacola;
			    break;

			case "9":
			   dinero= dinero + bolon;
			    break;

            case "10":
			  dinero= dinero + confle;
			  break;

			default:	
			Console.WriteLine("Error. Elige una de las 10 opciones");
				break;
		}
		
		
		if (dineroDisponible < dinero)
		{
			Console.WriteLine("No tienes suficiente dinero");
			cambio = dineroDisponible;
			Console.WriteLine ("Tu dinero (0)", cambio);
		}
		
		else if (dineroDisponible > dinero)
		{
			
			cambio= dineroDisponible - dinero;
			Console.WriteLine("Tu cambio (0)", cambio);
			Console.WriteLine("Gracias, lindo día");
		}
		
		else
		{
			Console.WriteLine ("Gracias, lindo día");
		}
		
		Console.ReadLine();
	}
}