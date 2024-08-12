// introdução para introdução para manipulação de objeto:
using System; // entrada para uso
using System.Collections.Generic;// entrada para uso

namespace Modelos {// namespace para organização do codigo (localição e chamada de codigo dentro da pasta)

    class Aluno {// classe para criação de objeto
      // para a realização de manipulação de objeto é necessario criar os atributos ou variaveis para armazenamento de dados
      public string matricula;// variavel para armazenar a matricula do aluno

      //public int periodo;// variavel para armazenar o periodo do aluno(aula 2)
      
      private int periodo; // variavel para armazenar o periodo do aluno( modificado para a aula 3) formas de acessar a variavel não pode ser modificada proteger o dado 
      
      public List<Disciplina>disciplinas = new List<Disciplina>();// variavel para armazenar a disciplina do aluno( modifição na aula 3 para o codigo da aula 2)
      
      //public Disciplina[] disciplinas = new Disciplina[2];// variavel para armazenar o vetor de disciplinas do aluno(aula 2)
      
      public Aluno() : this(1){ // construtor para a aula 3
      }
      
      public Aluno( int periodo){ // construtor para a aula 3
        if(periodo > 0){ // condição de se periodo for maior a 0  (aula 3)
          this.periodo = periodo;// atribuição de valor para periodo do aluno 
        }else{ // se não
          this.periodo = 1; // atribuição de valor para periodo do aluno
        }// fim do if
      }// fim do construtor

      // para realizar a chamada de um valor ja criado é  possivel de realizar se estiver com outro valor
    
      // Mas como realizar a chamada de função de periodo para ser realizado : utilizamos o this
      
      public Aluno (int periodo, string matricula):this(periodo){// construtor para a aula 3
        if(!String.IsNullOrWhiteSpace(matricula)){// condição de se matricula for diferente de vazio( e observa o valor da matricula)
          this.matricula = matricula;// atribuição de valor para matricula do aluno     
        } // fim do if 
      }// fim do construtor
        
      ~Aluno(){//  principal objetivo de um destrutor é liberar recursos não gerenciados que o objeto possa estar mantendo, como arquivos ou conexões de rede, antes que o objeto seja removido da memória.
        foreach(Disciplina disciplina in disciplinas){ // irar observar com um for no dec c
          disciplinas.Remove(disciplina);// irar remover a disciplina do aluno
        }// fim do foreach
      }// fim do destrutor

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