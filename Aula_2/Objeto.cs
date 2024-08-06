// introdução para introdução para manipulação de objeto:
using Modelos;// podemos usar o codigos dentro da pasta modelo (tipo um biblioteca)

class AulaObjeto{// main do codigo
  public static void Main (string[] args{
  Aluno aluno1 = new Aluno{
    matricula = "2024enel01",
    periodo =1
    };
  Aluno aluno2 = new Aluno{
    matricula = "2023enl02",
    periodo =2
  };
  Disciplina disciplina1 = new Disciplina{
    nome = "Algoritmo",
    semestre = 1
  };
  Disciplina disciplina2 = new Disciplina{
    nome = "Calculo",
    semestre = 2
  }; 
  Disciplina disciplina3 = new Disciplina {
    nome = "Fisica",
    semestre =3
  };

  Disciplina disciplina4 = new Disciplina {
    nome = "Programacao",
    semestre =3
    };
    
    aluno1.disciplina[0] = disciplina1;
    aluno1.disciplina[1] = disciplina2;
    aluno1.Imprimir();

    aluno2.disciplina[0] = disciplina3;
    aluno2.disciplina[1] = disciplina4;
    aluno2.Imprimir();
  
  }
}