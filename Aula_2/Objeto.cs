// introdução para introdução para manipulação de objeto:
using Modelos;

class AulaObjeto {

  public static void Main (string[] args) {

    Aluno aluno1 = new Aluno {
      matricula = "2024ENEL01",
      periodo = 1
    };

    Aluno aluno2 = new Aluno {
      matricula = "2023ENEL01",
      periodo = 3
    };

    Disciplina disciplina1 = new Disciplina {
      nome = "Algoritmo",
      semestre =1
    };

    Disciplina disciplina2 = new Disciplina {
      nome = "Calculo",
      semestre =1
    };

    Disciplina disciplina3 = new Disciplina {
      nome = "Fisica",
      semestre =3
    };

    Disciplina disciplina4 = new Disciplina {
      nome = "Programacao",
      semestre =3
    };

    aluno1.disciplinas[0] = disciplina1;
    aluno1.disciplinas[1] = disciplina2;
    aluno1.Imprimir();

    aluno2.disciplinas[0] = disciplina3;
    aluno2.disciplinas[1] = disciplina4;
    aluno2.Imprimir();

  }
}