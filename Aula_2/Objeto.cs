// introdução para introdução para manipulação de objeto:
 /* 
using Modelos;// entrada para uso

class AulaObjeto {// classe para criação de objeto

  public static void Main (string[] args) {// metodo principal
  
    // existe a possibilidade de criar objetos a partir de uma classe
  
    Aluno aluno1 = new Aluno();// criação de objeto aluno1
    aluno1.matricula = ("2024ENEl01");// atribuição de valor para matricula do aluno1  
    Aluno aluno2 = new Aluno(3){// criação de objeto aluno2
      matricula = "2023ENEl01"// atribuição de valor para matricula do aluno2
    };
    
    /*Aluno aluno1 = new Aluno {// criação de objeto aluno1
      matricula = "2024ENEL01",// atribuição de valor para matricula do aluno1
      periodo = -1// atribuição de valor para periodo do aluno1
    };// fim do objeto aluno1
   
    Aluno aluno2 = new Aluno {// criação de objeto aluno2
      matricula = "2023ENEL01",// atribuição de valor para matricula do aluno2
      periodo = 3 // atribuição de valor para periodo do aluno2
    };// fim do objeto aluno2
    
    Disciplina disciplina1 = new Disciplina {// criação de objeto disciplina1
      nome = "Algoritmo",// atribuição de valor para nome da disciplina1
      semestre =1// atribuição de valor para semestre da disciplina1
    };// fim do objeto disciplina1
    
    Disciplina disciplina2 = new Disciplina {// criação de objeto disciplina2
      nome = "Calculo",// atribuição de valor para nome da disciplina2
      semestre =1// atribuição de valor para semestre da disciplina2
    };// fim do objeto disciplina2

    Disciplina disciplina3 = new Disciplina {// criação de objeto disciplina3
      nome = "Fisica",// atribuição de valor para nome da disciplina3
      semestre =3// atribuição de valor para semestre da disciplina3
    };// fim do objeto disciplina3

    Disciplina disciplina4 = new Disciplina {// criação de objeto disciplina4
      nome = "Programacao",// atribuição de valor para nome da disciplina4
      semestre =3// atribuição de valor para semestre da disciplina4
    };// fim do objeto disciplina4
   
    
    // condição proposta para a realização de manipulação de objeto com o codigo esse codigo em Aluno.cs:public List<Disciplina>disciplinas = new List<Disciplina>();

    aluno1.disciplinas.Add(disciplina1);// adiciona a disciplina1 ao aluno1
    aluno1.disciplinas.Add(disciplina2);// adiciona a disciplina2 ao aluno1
    aluno1.Imprimir();// chama o metodo imprimir do aluno1

    aluno2.disciplinas.Add(disciplina3);// adiciona a disciplina3 ao aluno2
    aluno2.disciplinas.Add(disciplina4);// adiciona a disciplina4 ao aluno2
    aluno2.Imprimir();// chama o metodo imprimir do aluno2
   
    // condição proposta para a realização de manipulação de objeto com o codigo esse codigo em Aluno.cs:public Disciplina[] disciplinas = new Disciplina[2];
    
      aluno1.disciplinas[0] = disciplina1;// atribuição de valor para disciplina1 do aluno1
    aluno1.disciplinas[1] = disciplina2;// atribuição de valor para disciplina2 do aluno1
    aluno1.Imprimir();// chama o metodo imprimir do aluno1

    aluno2.disciplinas[0] = disciplina3;// atribuição de valor para disciplina3 do aluno2
    aluno2.disciplinas[1] = disciplina4;// atribuição de valor para disciplina4 do aluno2
    aluno2.Imprimir();// chama o metodo imprimir do aluno2    
  }
}
*/