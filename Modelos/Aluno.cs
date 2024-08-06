// introdução para introdução para manipulação de objeto:
using System; // entrada para uso

namespace Modelos {// namespace para organização do codigo (localição e chamada de codigo dentro da pasta)

    class Aluno {// classe para criação de objeto
      // para a realização de manipulação de objeto é necessario criar os atributos ou variaveis para armazenamento de dados
      public string matricula;// variavel para armazenar a matricula do aluno
      public int periodo; // variavel para armazenar o periodo do aluno
      public Disciplina[] disciplinas = new Disciplina[2];// variavel para armazenar o vetor de disciplinas do aluno

      public void Imprimir() {// metodo para imprimir os dados do aluno
        Console.WriteLine("*************************");// imprime uma linha de asteriscos
       
        Console.WriteLine("Aluno");// imprime a palavra aluno
        Console.WriteLine("Matricula: " + this.matricula);// imprime a matricula do aluno
        Console.WriteLine("Periodo: " + this.periodo);// imprime o periodo do aluno

        // uma maneria diferente de realizar uma repeticao para imprimir os dados das disciplinas
        foreach(Disciplina disciplina in disciplinas) {// repetição para imprimir os dados das disciplinas
          disciplina.Imprimir();// chama o metodo imprimir da classe disciplina
        }
        Console.WriteLine("*************************");// imprime uma linha de asteriscos
      }
    }

}