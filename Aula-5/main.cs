using Modelos;
using System;
using System.Collections.Generic;

// Aluno1: Ricardo dos Santos Barros
// Aluno2: Marcos Kainan Chiabai de Souza

class Aula5 {

  private static List<Turma> turmas = new List<Turma>();

  private static List<Aluno> alunos = new List<Aluno>();

  private static List<Professor> professores = new List<Professor>();

  private static List<Disciplina> disciplinas = new List<Disciplina>();

  private static void AdicionarAluno() {
    Aluno aluno = new Aluno();
    Console.WriteLine ("Digite a matricula do aluno:");
    aluno.Matricula = Console.ReadLine();
    if (!alunos.Exists(estudante => estudante.Matricula == aluno.Matricula)) {
      Console.WriteLine ("Digite o nome do aluno:");
      aluno.Nome = Console.ReadLine();
      Console.WriteLine ("Digite o período do aluno:");
      aluno.Periodo = int.Parse(Console.ReadLine());
      alunos.Add(aluno);
      Console.WriteLine ("Aluno adicionado com sucesso!");
    } else {
      Console.WriteLine ("Matricula já existente!");
    }
  }

  private static Aluno PesquisarAluno() {
    Console.WriteLine ("Digite a matricula do aluno:");
    string matricula = Console.ReadLine();
    return alunos.Find(estudante => estudante.Matricula == matricula);
  }

  private static void EditarAluno() {
    Aluno aluno = PesquisarAluno();
    if (aluno != null) {
      int opcao = 0;
      do {
        Console.WriteLine ("Digite a opcao:");
        Console.WriteLine ("0 - Voltar ao Menu de Aluno");
        Console.WriteLine ("1 - Editar Nome do Aluno");
        Console.WriteLine ("2 - Editar Periodo do Aluno");
        opcao = int.Parse(Console.ReadLine());
        switch(opcao) {
          case 1:
            Console.WriteLine ("Digite o nome do aluno:");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine ("Nome editado com sucesso!");
            break;
          case 2:
            Console.WriteLine ("Digite o periodo do aluno:");
            aluno.Periodo = int.Parse(
              Console.ReadLine()
            );
            Console.WriteLine ("Periodo editado com sucesso!");
            break;
          default:
            break;
        }
      } while (opcao > 0);
    } else {
      Console.WriteLine ("Matricula não existente!");
    }
  }

  private static void RemoverAluno() {
    Aluno aluno = PesquisarAluno();
    if (aluno != null) {
      if (aluno.historicos.Count == 0) {
        alunos.Remove(aluno);
        Console.WriteLine ("Aluno removido com sucesso!");
      } else {
        Console.WriteLine ("Desmatricule o aluno das turmas!");
      }
    } else {
      Console.WriteLine ("Matricula não existente!");
    }
  }

  private static void ImprimirAlunos() {
    foreach (Aluno aluno in alunos) {
      aluno.Imprimir();
    }
  }

  private static void ImprimirAlunoSelecionado() {
    Aluno aluno = PesquisarAluno();
    if (aluno != null) {
      aluno.Imprimir();
    } else {
      Console.WriteLine ("Matricula não existente!");
    }
  }

  private static void AdicionarNotaDoAluno() {
    Turma turma = PesquisarTurma();
    if (turma != null){
      Console.WriteLine ("Digite a matricula do aluno:");
      string matricula = Console.ReadLine();
      Historico historico1 =turma.historicos.Find(registro => registro.Aluno.Matricula == matricula);
      if(historico1!= null){
        Console.WriteLine ("Digite a nota do aluno:");
        double valor= double.Parse(Console.ReadLine());
        historico1.notas.Add(valor);
      } else {
        Console.WriteLine ("aluno não matriculado nessa turma!");
      }
    }else {
      Console.WriteLine ("turma não existente!");
    }
  }

  private static void AdicionarFaltaDoAluno() {
    Turma turma = PesquisarTurma();
    if (turma != null){
      Console.WriteLine ("Digite a matricula do aluno:");
      string matricula = Console.ReadLine();
      Historico historico1 =turma.historicos.Find(registro => registro.Aluno.Matricula == matricula);
      if(historico1!= null){
        Console.WriteLine ("Digite o numero de faltas do aluno:");

        historico1.Faltas=int.Parse(Console.ReadLine());
      } else {
        Console.WriteLine ("aluno não matriculado nessa turma!");
      }
    }else {
      Console.WriteLine ("turma não existente!");
    }
  }

  private static void AdicionarTurma() {
    Turma turma= new Turma();
      Console.WriteLine ("Digite o identificador da turma:");
      turma.Identificador=Console.ReadLine();
      if (!turmas.Exists(sala => sala.Identificador == turma.Identificador)) {
        Console.WriteLine ("Digite o codigo da professor dessa turma:");
        string identidade=Console.ReadLine();
        Professor professor= professores.Find(prof =>prof.Matricula==identidade);
        if (professor!= null){
          Console.WriteLine ("Digite a matricula do disciplina dessa turma:");
          string identificacao=Console.ReadLine();
          Disciplina disciplina=disciplinas.Find(materia => materia.Codigo==identificacao);
          if(disciplina!=null){
            turma.Professor=professor;
            turma.Disciplina=disciplina;
            Console.WriteLine ("Digite a ano dessa turma:");
            int ano= int.Parse(Console.ReadLine());
            turma.Ano=ano;
            Console.WriteLine ("Digite o semestre dessa turma:");
            int semestre= int.Parse(Console.ReadLine());
            turma.Semestre=semestre;
            turmas.Add(turma);
            Console.WriteLine ("turma adicionado com sucesso!");
          } else{
            Console.WriteLine ("Esee disciplina não existe!");
          }
        }else{
          Console.WriteLine ("Esee professor não existe!");
        }

      } else {
        Console.WriteLine ("Identificador já existente!");
      }
  }

  private static Turma PesquisarTurma() {
    Console.WriteLine ("Digite o identificador da turma desejada:");
    string identificador = Console.ReadLine();
    return turmas.Find(turm => turm.Identificador == identificador);
  }

  private static void EditarTurma() {
    Turma turma = PesquisarTurma();
      if (turma != null) {
        int opcao = 0;
        do {
          Console.WriteLine ("Digite a opcao:");
          Console.WriteLine ("0 - Voltar ao Menu da Turma");
          Console.WriteLine ("1 - Editar o identificador da Turma");
          Console.WriteLine ("2 - Editar o Ano da Turma");
          Console.WriteLine ("3 - Editar o Semestre da Turma");
          Console.WriteLine ("4 - Editar o Professor da Turma");
          opcao = int.Parse(Console.ReadLine());
          switch(opcao) {
            case 1:
              Console.WriteLine ("Digite o identificador da Turma:");
              turma.Identificador = Console.ReadLine();
              Console.WriteLine ("Identificador editado com sucesso!");
              break;
            case 2:
              Console.WriteLine ("Digite o Ano da Turma:");
              turma.Ano = int.Parse(Console.ReadLine());
              Console.WriteLine ("Ano editado com sucesso!");
              break;
            case 3:
              Console.WriteLine ("Digite o Semestre da Turma:");
              turma.Semestre = int.Parse(Console.ReadLine());
              Console.WriteLine ("Semestre editado com sucesso!");
              break;
            case 4:
              Console.WriteLine ("Digite a matricula do professor dessa turma:");
              string identidade=Console.ReadLine();
              Professor professor= professores.Find(prof =>prof.Matricula==identidade);
              Console.WriteLine ("Digite o identificador da turma:");
              turma.Identificador=Console.ReadLine();
              Console.WriteLine ("Professor editado com sucesso!");
              break;
            default:
              break;
          }
        } while (opcao > 0);
      } else {
        Console.WriteLine ("Identificador da turma não existente!");
      }
    }

  private static void RemoverTurma() {
    Turma turma = PesquisarTurma();
    if (turma != null) {
      turmas.Remove(turma);
      Console.WriteLine ("Identidade da Turma removida com sucesso!");
    } else{
      Console.WriteLine ("Identidade da Turma não existente!");
    }
  }

  private static void ImprimirTurmas() {
    foreach (Turma turma in turmas) {
      turma.Imprimir();
    }
  }

  private static void ImprimirTurmaSelecionada() {
    Turma turma = PesquisarTurma();
    if (turma!= null) {
      turma.Imprimir();
    } else {
      Console.WriteLine ("Identificador da turma não existente!");
    }
  }

  private static void ImprimirAprovadosDaTurma() {
    Turma turma = PesquisarTurma();
    if (turma != null){
      Console.WriteLine ("Lista de Alunos aprovados da turma:");
      foreach (Historico historico in turma.Aprovados()){
        historico.Imprimir();
      }
    }
  }

  private static void ImprimirReprovadosDaTurma() {
    Turma turma = PesquisarTurma();
    if (turma != null){
      Console.WriteLine ("Lista de Alunos Reprovados da turma:");
      foreach (Historico historico in turma.Reprovados()){
        historico.Imprimir();
      }
    }else {
      Console.WriteLine ("Identificador da turma não existente!");
    }
  }

  private static void ImprimirMediaDaTurma() {
    Turma turma = PesquisarTurma();
    if (turma != null){
      Console.WriteLine ("Media da turma: "+turma.Media());
    }else {
      Console.WriteLine ("Identificador da turma não existente!");
    }
  }

  private static void ImprimirHistoricoDoAlunoEmTurma() {
    Turma turma = PesquisarTurma();
      if (turma != null){
        Console.WriteLine ("Lista do Historico da turma:");
        foreach (Historico historico in turma.historicos){
          historico.Imprimir();
        }
      }else {
      Console.WriteLine ("Identificador da turma não existente!");
    }
  }

  private static void MatricularAlunoEmTurma() {
    Turma turma = PesquisarTurma();
    Aluno aluno = PesquisarAluno();
    Historico repetido= turma.historicos.Find(registro =>registro.Aluno.Matricula==aluno.Matricula);
    if (turma != null && aluno!=null && turma.Disciplina.Periodo<=aluno.Periodo && repetido==null){
      turma.Matricular(aluno);
      Console.WriteLine ("Aluno matriculado com sucesso!");
    }else{
      Console.WriteLine ("Não foi possivel matricular o aluno!");
    }
  }

  private static void DesmatricularAlunoEmTurma() {
    Turma turma = PesquisarTurma();
      Aluno aluno = PesquisarAluno();

      if (turma != null && aluno!=null){
        turma.Desmatricular(aluno);
      }else{
        Console.WriteLine ("Não foi possivel matricular o aluno!");
      }

  }

  private static void AdicionarProfessor() {
    Professor professor = new Professor();
    Console.WriteLine ("Digite a matricula do professor:");
    professor.Matricula = Console.ReadLine();
    if (!professores.Exists(prof => prof.Matricula == professor.Matricula)) {
      Console.WriteLine ("Digite o nome do professor:");
      professor.Nome = Console.ReadLine();
      professores.Add(professor);
      Console.WriteLine ("Professor adicionado com sucesso!");
    } else {
      Console.WriteLine ("Matricula já existente!");
    }
  }

  private static Professor PesquisarProfessor() {
    Console.WriteLine ("Digite a matricula do professor:");
    string matricula = Console.ReadLine();
    return professores.Find(prof => prof.Matricula == matricula);
  }

  private static void EditarProfessor() {
    Professor professor = PesquisarProfessor();
    if (professor != null) {
      int opcao = 0;
      do {
        Console.WriteLine ("Digite a opcao:");
        Console.WriteLine ("0 - Voltar ao Menu de Professor");
        Console.WriteLine ("1 - Editar Nome do Professor");
        opcao = int.Parse(
          Console.ReadLine()
        );
        switch(opcao) {
          case 1:
            Console.WriteLine ("Digite o nome do professor:");
            professor.Nome = Console.ReadLine();
            Console.WriteLine ("Nome editado com sucesso!");
            break;
          default:
            break;
        }
      } while (opcao > 0);
    } else {
      Console.WriteLine ("Matricula não existente!");
    }
  }

  private static void RemoverProfessor() {
    Professor professor = PesquisarProfessor();
    if (professor != null) {
      Turma turma1=turmas.Find(sala => sala.Professor.Matricula == professor.Matricula);
      if (turma1!=null){
        Console.WriteLine ("Remova esse professor de sua turma!");
      } else{
        professores.Remove(professor);
        Console.WriteLine ("Professor removido com sucesso!");
      }
    } else {
      Console.WriteLine ("Matricula não existente!");
    }
  }

  private static void ImprimirProfessores() {
    foreach (Professor professor in professores) {
      professor.Imprimir();
    }
  }

  private static void ImprimirProfessorSelecionado() {
    Professor professor = PesquisarProfessor();
    if (professor != null) {
      professor.Imprimir();
    } else {
      Console.WriteLine ("Matricula não existente!");
    }
  }

  private static void AdicionarDisciplina() {
    Disciplina disciplina = new Disciplina();
    Console.WriteLine ("Digite o codigo da disciplina:");
    disciplina.Codigo = Console.ReadLine();
    if (!disciplinas.Exists(materia => materia.Codigo == disciplina.Codigo)) {
      Console.WriteLine ("Digite o nome da disciplina:");
      disciplina.Nome = Console.ReadLine();
      Console.WriteLine ("Digite o periodo da disciplina:");
      int periodo= int.Parse(Console.ReadLine());
      disciplina.Periodo = periodo;
      disciplinas.Add(disciplina);
      Console.WriteLine ("disciplina adicionado com sucesso!");
    } else {
      Console.WriteLine ("Matricula já existente!");
    }
  }

  private static Disciplina PesquisarDisciplina() {
    Console.WriteLine ("Digite o codigo da disciplina:");
    string codigo = Console.ReadLine();
    return disciplinas.Find(materia => materia.Codigo == codigo);
  }

  private static void EditarDisciplina() {
    Disciplina disciplina = PesquisarDisciplina();
    if (disciplina != null) {
      int opcao = 0;
      do {
        Console.WriteLine ("Digite a opcao:");
        Console.WriteLine ("0 - Voltar ao Menu de Disciplina");
        Console.WriteLine ("1 - Editar Nome da Disciplina");
        Console.WriteLine ("2 - Editar Periodo da Disciplina");
        opcao = int.Parse(
          Console.ReadLine()
        );
        switch(opcao) {
          case 1:
            Console.WriteLine ("Digite o nome da disciplina:");
            disciplina.Nome = Console.ReadLine();
            Console.WriteLine ("Nome editado com sucesso!");
            break;
          case 2:
            Console.WriteLine ("Digite o periodo da disciplina:");
            disciplina.Periodo = int.Parse(
              Console.ReadLine()
            );
            Console.WriteLine ("Periodo editado com sucesso!");
            break;
          default:
            break;
        }
      } while (opcao > 0);
    } else {
      Console.WriteLine ("Matricula não existente!");
    }
  }

  private static void RemoverDisciplina() {
    Disciplina disciplina = PesquisarDisciplina();
    if (disciplina != null) {
      Turma turma2=turmas.Find(aula => aula.Disciplina.Codigo == disciplina.Codigo);
        if (turma2!=null){
          Console.WriteLine ("Remova essa disciplina das turmas existentes!");
        } else{
          disciplinas.Remove(disciplina);
          Console.WriteLine ("Disciplina removido com sucesso!");
        }
    } else {
      Console.WriteLine ("Matricula não existente!");
    }
  }

  private static void ImprimirDisciplinas() {
    foreach (Disciplina disciplina in disciplinas) {
      disciplina.Imprimir();
    }
  }

  private static void ImprimirDisciplinaSelecionada() {
    Disciplina disciplina = PesquisarDisciplina();
    if (disciplina != null) {
      disciplina.Imprimir();
    } else {
      Console.WriteLine ("Matricula não existente!");
    }
  }

  private static void MenuAluno() {
    int opcao = 0;
    do {
      Console.WriteLine ("Digite a opcao:");
      Console.WriteLine ("0 - Voltar ao Menu");
      Console.WriteLine ("1 - Adicionar Aluno");
      Console.WriteLine ("2 - Editar Aluno");
      Console.WriteLine ("3 - Remover Aluno");
      Console.WriteLine ("4 - Imprimir Aluno");
      Console.WriteLine ("5 - Imprimir Todos os Alunos");
      opcao = int.Parse(
        Console.ReadLine()
      );
      switch(opcao) {
        case 1:
          AdicionarAluno();
          break;
        case 2:
          EditarAluno();
          break;
        case 3:
          RemoverAluno();
          break;
        case 4:
          ImprimirAlunoSelecionado();
          break;
        case 5:
          ImprimirAlunos();
          break;
        default:
          break;
      }
    } while (opcao > 0);
  }

  private static void MenuTurma() {
    int opcao = 0;
    do {
      Console.WriteLine ("Digite a opcao:");
      Console.WriteLine ("0 - Voltar ao Menu");
      Console.WriteLine ("1 - Adicionar Turma");
      Console.WriteLine ("2 - Editar Turma");
      Console.WriteLine ("3 - Remover Turma");
      Console.WriteLine ("4 - Imprimir Turma");
      Console.WriteLine ("5 - Imprimir Todas as Turmas");
      Console.WriteLine ("6 - Matricular Aluno Na Turma");
      Console.WriteLine ("7 - Desmatricular Aluno Na Turma");
      Console.WriteLine ("8 - Adicionar Nota Do Aluno Na Turma");
      Console.WriteLine ("9 - Adicionar Falta Do Aluno Na Turma");
      Console.WriteLine ("10 - Imprimir Alunos Aprovados Da Turma");
      Console.WriteLine ("11 - Imprimir Alunos Reprovados Da Turma");
      Console.WriteLine ("12 - Imprimir Media Da Turma");
      Console.WriteLine ("13 - Imprimir Historico do Aluno Na Turma");
      opcao = int.Parse(
        Console.ReadLine()
      );
      switch(opcao) {
        case 1:
          AdicionarTurma();
          break;
        case 2:
          EditarTurma();
          break;
        case 3:
          RemoverTurma();
          break;
        case 4:
          ImprimirTurmaSelecionada();
          break;
        case 5:
          ImprimirTurmas();
          break;
        case 6:
          MatricularAlunoEmTurma();
          break;
        case 7:
          DesmatricularAlunoEmTurma();
          break;
        case 8:
          AdicionarNotaDoAluno();
          break;
        case 9:
          AdicionarFaltaDoAluno();
          break;
        case 10:
          ImprimirAprovadosDaTurma();
          break;
        case 11:
          ImprimirReprovadosDaTurma();
          break;
        case 12:
          ImprimirMediaDaTurma();
          break;
        case 13:
          ImprimirHistoricoDoAlunoEmTurma();
          break;
        default:
          break;
      }
    } while (opcao > 0);
  }

  private static void MenuProfessor() {
    int opcao = 0;
    do {
      Console.WriteLine ("Digite a opcao:");
      Console.WriteLine ("0 - Voltar ao Menu");
      Console.WriteLine ("1 - Adicionar Professor");
      Console.WriteLine ("2 - Editar Professor");
      Console.WriteLine ("3 - Remover Professor");
      Console.WriteLine ("4 - Imprimir Professor");
      Console.WriteLine ("5 - Imprimir Todos os Professores");
      opcao = int.Parse(
        Console.ReadLine()
      );
      switch(opcao) {
        case 1:
          AdicionarProfessor();
          break;
        case 2:
          EditarProfessor();
          break;
        case 3:
          RemoverProfessor();
          break;
        case 4:
          ImprimirProfessorSelecionado();
          break;
        case 5:
          ImprimirProfessores();
          break;
        default:
          break;
      }
    } while (opcao > 0);
  }

  private static void MenuDisciplina() {
    int opcao = 0;
    do {
      Console.WriteLine ("Digite a opcao:");
      Console.WriteLine ("0 - Voltar ao Menu");
      Console.WriteLine ("1 - Adicionar Disciplina");
      Console.WriteLine ("2 - Editar Disciplina");
      Console.WriteLine ("3 - Remover Disciplina");
      Console.WriteLine ("4 - Imprimir Disciplina");
      Console.WriteLine ("5 - Imprimir Todas as Disciplinas");
      opcao = int.Parse(
        Console.ReadLine()
      );
      switch(opcao) {
        case 1:
          AdicionarDisciplina();
          break;
        case 2:
          EditarDisciplina();
          break;
        case 3:
          RemoverDisciplina();
          break;
        case 4:
          ImprimirDisciplinaSelecionada();
          break;
        case 5:
          ImprimirDisciplinas();
          break;
        default:
          break;
      }
    } while (opcao > 0);
  }

  public static void Main (string[] args) {
    int opcao = 0;
    do {
      Console.WriteLine ("Digite a opcao:");
      Console.WriteLine ("0 - Sair");
      Console.WriteLine ("1 - Alunos");
      Console.WriteLine ("2 - Turmas");
      Console.WriteLine ("3 - Professores");
      Console.WriteLine ("4 - Disciplinas");
      opcao = int.Parse(
        Console.ReadLine()
      );
      switch(opcao) {
        case 1:
          MenuAluno();
          break;
        case 2:
          MenuTurma();
          break;
        case 3:
          MenuProfessor();
          break;
        case 4:
          MenuDisciplina();
          break;
        default:
          break;
      }
    } while (opcao > 0);
  }
}