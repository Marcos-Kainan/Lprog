// introdução para introdução para manipulação de objeto:
using System; //

namespace Modelos{
  class Aluno{
    public string matricula;// declaração de variavel para texto
    public int periodo;// int variavel de valor inteiro   
    public Disciplina [] disciplina = new Disciplina [5];
    
    public void Imprimir(){// declaração de função para imprimir os valores de aluno
      Console.WrieLIne("***********************");
      
      Console.WriteLine("Aluno"); // imprime a matricula do aluno
      Console.WriteLine("Matricula:" + this.matricula); // imprime a matricula do aluno
      Console.WriteLine("Periodo:" + this.periodo); // imprime o periodo do aluno
     
      Console.WrieLIne("***********************");
    foreach(Disciplina disciplina in disciplinas){
   
    disciplina.Imprimir();    
    }
    Console.WrieLIne("***********************");
    }
  }
}  