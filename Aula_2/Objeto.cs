// introdução para introdução para manipulação de objeto:
using Modelos;// podemos usar o codigos dentro da pasta modelo (tipo um biblioteca)

class AulaObjeto{// main do codigo
  
  public static void Main(string[] args){// metodo principal
    
    Aluno aluno1 = new Aluno {// declaração de variavel para aluno2
      matricula = "2024enel01", // declaração da variavel pelo programa para matricula
      periodo = 1 // declaração da variavel pelo programa para perido
    };
   
    aluno1.Imprimir();// chamada de função para imprimir os valores de aluno1 
    
    Aluno aluno2 = new Aluno {// declaração de variavel para aluno2
      matricula = "2024enel21", // declaração da variavel pelo programa para matricula
      periodo = 2 // declaração da variavel pelo programa para perido
    };

    aluno2.Imprimir();// chamada de função para imprimir os valores de aluno1 
   
    Disciplina disciplina1 = new Disciplina{
      nome ="Programação",
      semestre= 1
    };
    aluno1.disciplina[0] = disciplina1;
    aluno1.Imprimir();
    
    aluno1.disciplina[0] = disciplina1;
    aluno1.Imprimir();
    
    disciplina1.Imprimir();

    aluno

  }
}