// introdução para introdução para manipulação de objeto:
using System;// entrada para uso

namespace Modelos{// declaração de pasta para o codigo
  class Disciplina{
    public string nome;// declaração de variavel para texto
    public int semestre;// int variavel de valor inteiro   

    public void Imprimir(){ // declaração de função para imprimir os valores de aluno
     Console.WrieLIne("---------------------");
     
      Console.WriteLine("Disciplina"); // imprime a matricula do aluno    
     Console.WriteLine("Nome:" + this.nome); // imprime a matricula do aluno
     Console.WriteLine("Semestre:" + this.semestre); // imprime o periodo do aluno
  
      Console.WrieLine("---------------------");
    }
  }
}