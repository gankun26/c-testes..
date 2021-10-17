using System;
					
public class Program
{
	public static void Main()
	{
	//--------------------------------DOG	
	Dog dodo = new Dog();

	dodo.Name = "rezel";
	Console.WriteLine(dodo.Name);	
    
	dodo.Age = 89;
	Console.WriteLine(dodo.Age);
	
	dodo.Endereco = "avenida limeira faria";
	Console.WriteLine(dodo.Endereco);	
	//---------------------------------PERSON	
	Person nick = new Person();
	
	nick.Nome ="paulo";
	Console.WriteLine(nick.Nome);
	
	nick.Addres = "rua das maravilhas, 34";
	Console.WriteLine(nick.Addres);
		
	nick.Age = 67;
	Console.WriteLine(nick.Age);	
	//---------------------------------	JOB
	Trabalho job = new Trabalho();
	
	job.Nome = "Escritorio de dados do estado do Rio de janeiro";
	Console.WriteLine(job.Nome);
		
	job.Number = 234;
	Console.WriteLine(job.Number);
	
	job.Addres = "avenida das lagrimas, proximo a estação de trem";
	Console.WriteLine(job.Addres);
    //----------------------------------DADOS
	Dados dados = new Dados();
	
	dados.Nome = "alan santana";
	Console.WriteLine(dados.Nome);
	
	dados.Email = "alan@gmail.com";
	Console.WriteLine(dados.Email);
	
	dados.Endereco = "rua das tangerinas, 78";
	Console.WriteLine(dados.Endereco);
	
	dados.Numero = 24584546;
	Console.WriteLine(dados.Numero);
	
	dados.Cpf = 2568874;
	Console.WriteLine(dados.Cpf);	
	}
	
	//----------------------------------
	class Dog
	{
		
		private string name;
		private int age;
		private string endereco;	
		
		public string Name
		{
			get {return name;}
			set {name = value;}
			
		}
		public int Age
		{
			get {return age;}
			set{age = value;}
		}
		public string Endereco
		{
			get{return endereco;}
			set{endereco = value;}
		}
	}
	
	class Person
	{
		private string name;
		private int age;
		private string addres;
		
		public string Nome
		{
			get{return name;}
			set{name = value;}
		}
		public int Age
		{
			get{return age;}
			set{age = value;}
		}
		public string Addres
		{
			get{return addres;}
			set{addres = value;}
		}	
	}
	
	class Trabalho
	{
		private string name;
		private int number;
		private string addres;
		
		public string Nome
		{
			get{return name;}
			set{name = value;}
		}
		public int Number
		{
			get{return number;}
			set{number = value;}
		}
		public string Addres
		{
			get{return addres;}
			set{addres = value;}
		}	
	}
	
	class Dados
	{
		private string nome;
		private string endereco;
		private string email;
		private int numero;
		private int cpf;
		
		public string Nome
		{
			get{return nome;}
			set{nome = value;}
		}
		public string Endereco
		{
			get{return endereco;}
			set{endereco = value;}
		}
		public string Email
		{
			get{return email;}
			set{email = value;}
		}
		public int Numero
		{
			get{return numero;}
			set{numero = value;}
		}
		public int Cpf
		{
			get{return cpf;}
			set{cpf = value;}
		}
	}
}