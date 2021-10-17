using System;

class Person{

    protected int Age {get; set;}
    protected string Name {get; set;}
}

class Student : Person {

    public Student(string nm){
    Name = nm;	  
    }
	public void Speak(){
	Console.WriteLine("Name: " + Name);
	}
}


class Job{

	protected int number {get; set;}
	protected string Email {get; set;}
}

class Funcionario : Job {
	
    public Funcionario (string value){
            
        Email = value; 
    }
    public void Dados(){
        Console.WriteLine("Email: "+ Email);
    }	
}

public class Program
{
	public static void Main()
	{
		Student novo = new Student("Alan");
		novo.Speak();
		
		Funcionario funcionario = new Funcionario("alan@gmail.com");
		funcionario.Dados();
	}
}