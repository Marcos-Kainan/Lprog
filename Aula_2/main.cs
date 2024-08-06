using System;// entrada para uso

class Aula2{ // main do codigo
  // introdução de uso de estrutura dados:
  public struct Aluno{// declaração de estrutura
    public string matricula;// declaração de variavel para texto
    public int periodo;// int variavel de valor inteiro
  }
  public static void ImprimirAluno(Aluno aluno){// declaração de função para imprimir os valores de alunos
      Console.WriteLine(aluno.matricula); // imprime a matricul do aluno
      Console.WriteLine(aluno.periodo); // imprime o periodo do aluno 
      
    }
    // introdução para o uso de estrutura de dados:
    public static void Main(string[] args){// metodo principal
      
      Aluno aluno1 = new Aluno {// declaração de variavel para aluno2
        matricula = "2024enel01", // declaração da variavel pelo programa para matricula
        periodo = 1 // declaração da variavel pelo programa para perido
      };
      
      aluno1.periodo = 2; // alteração do valor da variavel periodo
      
      ImprimirAluno(aluno1); // chamada de função para imprimir os valores de aluno1
      
      Aluno aluno2 = new Aluno { // declaração de variavel para aluno2
        matricula = "2023enel02",// declaração da variavel pelo programa para matricula
        periodo = 3// declaração da variavel pelo programa para perido
      };
      
      aluno2.periodo = aluno1.periodo + 1; //alteração do valor da variavel do periodo do aluno2
      
      ImprimirAluno(aluno2);// chamda de funçãp para imprimir os valores de aluno2
    }
  }
