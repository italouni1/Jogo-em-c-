// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using System;
					
public class Program
{
	public class Usuario
	{
		public string nome;
		public int energia;
		public bool inicia;
	}
	
	public static void Main() 
	{
		Usuario usuario1 = new Usuario();
		Usuario usuario2 = new Usuario();
		
		Console.Write("Digite o nome do seu usuario: ");
		usuario1.nome = Console.ReadLine();
		
		Console.Write("digite N caso nao haja outro usuario: ");
		string existeOutro = Console.ReadLine();
		
		if (existeOutro == "N" || existeOutro == "n") 
		{
			usuario2.nome = "computador";
		} else {
			Console.Write("Digite o nome do outro usuario: ");
			usuario2.nome = Console.ReadLine();
		}
		
		usuario1.energia = 10; 
		usuario2.energia = 10; 
		
		Random random = new Random();
		int primeiro = random.Next(1, 2);
		
		if (primeiro == 1)
		{
			usuario1.inicia = true;
			usuario2.inicia = false;
		} else {
			usuario2.inicia = true;
			usuario1.inicia = false;
		}
		
		while (usuario1.energia > 0 || usuario2.energia > 0) 
		{
			string[] opcoes = { "copas", "espada", "ouros" };
			string[] sorteio1 = new string[3];
			string[] sorteio2 = new string[3];
			
			if (usuario1.inicia == true)
			{		
				for (int i = 0; i < 3; i++)
				{
					int index = random.Next(opcoes.Length);
					string opcao = opcoes[index];
					
					sorteio1[i] = opcao;
				}
				
				Console.Write("O usuario 1 de nome: ");
				Console.Write(usuario1.nome);
				Console.Write(" sorteou: \n");
				
				for (int i = 0; i < 3; i++)
				{
					Console.Write(sorteio1[i]);
					Console.Write("\n");
				}
				
				if (!(sorteio1[0] == sorteio1[1] && sorteio1[0] == sorteio1[2] && sorteio1[0] == sorteio1[2]))
				{
					Console.Write("e perdeu 1 energias \n");
					Console.Write("\n");

					usuario1.energia -= 1;
				} else {
					Console.Write("e nao perdeu energias \n");
					Console.Write("\n");
				};
				
				for (int i = 0; i < 3; i++)
				{
					int index = random.Next(opcoes.Length);
					string opcao = opcoes[index];
					
					sorteio2[i] = opcao;
				}
				
				Console.Write("O usuario 2 de nome: ");
				Console.Write(usuario2.nome);
				Console.Write(" sorteou: \n");	
				
				for (int i = 0; i < 3; i++)
				{
					Console.Write(sorteio2[i]);
					Console.Write("\n");
				}
				
				if (!(sorteio2[0] == sorteio1[1] && sorteio2[0] == sorteio2[2]  && sorteio2[1] == sorteio2[2])) 
				{
					Console.Write("e perdeu 1 energias \n");
					Console.Write("\n");
					usuario2.energia -= 1;
				} else {
					Console.Write("e nao perdeu energias \n");
					Console.Write("\n");
				};		
			} else {					
				for (int i = 0; i < 3; i++)
				{
					int index = random.Next(opcoes.Length);
					string opcao = opcoes[index];
					
					sorteio1[i] = opcao;
				}
				
				Console.Write("O usuario 2 de nome: ");
				Console.Write(usuario2.nome);
				Console.Write(" sorteou: \n");
				
				for (int i = 0; i < 3; i++)
				{
					Console.Write(sorteio2[i]);
					Console.Write("\n");
				}
				
				if (!(sorteio1[0] == sorteio1[1] && sorteio1[0] == sorteio1[2] && sorteio1[1] == sorteio1[2]))
				{
					Console.Write("e perdeu 1 energias \n");
					Console.Write("\n");

					usuario2.energia -= 1;
				} else {
					Console.Write("e nao perdeu energias \n");
					Console.Write("\n");
				};
				
				for (int i = 0; i < 3; i++)
				{
					int index = random.Next(opcoes.Length);
					string opcao = opcoes[index];
					
					sorteio2[i] = opcao;
				}
				
				Console.Write("O usuario 2 de nome: ");
				Console.Write(usuario1.nome);
				Console.Write(" sorteou: \n");	
				
				for (int i = 0; i < 3; i++)
				{
					Console.Write(sorteio2[i]);
					Console.Write("\n");
				}
				
				if (!(sorteio2[0] == sorteio1[1] && sorteio2[0] == sorteio2[2] && sorteio2[1] == sorteio2[2])) 
				{
					Console.Write("e perdeu 1 energias \n");
					Console.Write("\n");
					usuario1.energia -= 1;
				} else {
					Console.Write("e nao perdeu energias \n");
					Console.Write("\n");
				};	
			}
		};
		
		if (usuario1.energia > usuario2.energia)
		{
			Console.Write("O usuario 1 de nome: ");
			Console.Write(usuario1.nome);
			Console.Write(" VENCEU");	
		}
		
		if (usuario2.energia > usuario1.energia)
		{
			Console.Write("O usuario 2 de nome: ");
			Console.Write(usuario2.nome);
			Console.Write(" VENCEU");
		}
	}
}