// introdução para introdução para manipulação de objeto:
using System;// entrada para uso

namespace Modelos {// namespace para organização do codigo (localição e chamada de codigo dentro da pasta)              
  class Disciplina {// classe para criação de objeto
    // para a realização de manipulação de objeto é necessario criar os atributos ou variaveis para armazenamento de dados
      public string nome;// variavel para armazenar a matricula do aluno
//    public int semestre;// variavel para armazenar o periodo do aluno
     
    public Disciplina() : this(1){ 
    }   
      private int semestre;
    public Disciplina(int semestre){
      if(semestre > 0){
        this.semestre = semestre;
      }else{
        this.semestre = 1;
      }
    }

      public void Imprimir() {// metodo para imprimir os dados do aluno
        Console.WriteLine("-----------------------");// imprime uma linha de asteriscos
        
        Console.WriteLine("Disciplina");// imprime a palavra aluno
        Console.WriteLine("Nome: " + this.nome);// imprime a matricula do aluno 
        Console.WriteLine("Semestre: " + this.semestre);// imprime o periodo do aluno
        
        Console.WriteLine("-----------------------");// imprime uma linha de asteriscos
      }
    }

}