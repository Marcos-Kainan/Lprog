using Modelos;
using System;
using System.Collections.Generic;

// Aluno1: Nome1
// Aluno2: Nome2
// Aluno3: Nome3

class Aula5 {

  private static List<Aluno> alunos = new List<Aluno>();
  private static List<Turma> turmas = new List<Turma>();
  private static List<Professor> professores = new List<Professor>();
  private static List<Disciplina> disciplinas = new List<Disciplina>();

  private static void AdicionarAluno() {
    Aluno aluno = new Aluno();
    Console.WriteLine("Digite a matricula do aluno:");
    aluno.Matricula = Console.ReadLine();
    if (!alunos.Exists(estudante => estudante.Matricula == aluno.Matricula)) {
      Console.WriteLine("Digite o nome do aluno:");
      aluno.Nome = Console.ReadLine();
      alunos.Add(aluno);
      Console.WriteLine("Aluno adicionado com sucesso!");
    } else {
      Console.WriteLine("Matricula já existente!");
    }
  }

  private static Aluno PesquisarAluno() {
    Console.WriteLine("Digite a matricula do aluno:");
    string matricula = Console.ReadLine();
    return alunos.Find(estudante => estudante.Matricula == matricula);
  }

  private static void EditarAluno() {
    Aluno aluno = PesquisarAluno();
    if (aluno != null) {
      int opcao = 0;
      do {
        Console.WriteLine("==================== Editar Aluno ==========================");
        Console.WriteLine("0 - Voltar ao Menu de Aluno");
        Console.WriteLine("1 - Editar Nome do Aluno");
        Console.WriteLine("2 - Editar Periodo do Aluno");

        Console.WriteLine("Digite a opcao:");
        opcao = int.Parse(Console.ReadLine());

        switch (opcao) {
          case 1:
            Console.WriteLine("Digite o nome do aluno:");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Nome editado com sucesso!");
            break;
          case 2:
            Console.WriteLine("Digite o periodo do aluno:");
            aluno.Periodo = int.Parse(Console.ReadLine());
            Console.WriteLine("Periodo editado com sucesso!");
            break;
          default:
            break;
        }
      } while (opcao > 0);
    } else {
      Console.WriteLine("Matricula não existente!");
    }
  }

  private static void RemoverAluno() {
    Aluno aluno = PesquisarAluno();
    if (aluno != null) {
      if (aluno.historicos.Count == 0) {
        alunos.Remove(aluno);
        Console.WriteLine("Aluno removido com sucesso!");
      } else {
        Console.WriteLine("Desmatricule o aluno das turmas!");
      }
    } else {
      Console.WriteLine("Matricula não existente!");
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
      Console.WriteLine("Matricula não existente!");
    }
  }

  private static void AdicionarNotaDoAluno() { }

  private static void AdicionarFaltaDoAluno() { }

  private static void AdicionarTurma() { }

  private static Turma PesquisarTurma() {
    return new Turma();
  }

  private static void EditarTurma() { }

  private static void RemoverTurma() { }

  private static void ImprimirTurmas() { }

  private static void ImprimirTurmaSelecionada() { }

  private static void ImprimirAprovadosDaTurma() { }

  private static void ImprimirReprovadosDaTurma() { }

  private static void ImprimirMediaDaTurma() { }

  private static void ImprimirHistoricoDoAlunoEmTurma() { }

  private static void MatricularAlunoEmTurma() { }

  private static void DesmatricularAlunoEmTurma() { }

  private static void AdicionarProfessor() {
    Professor professor = new Professor();
    Console.WriteLine("Digite a Matricula de professor");
    professor.matricula = Console.ReadLine();
    if (!professores.Exists(query => query.matricula == professor.matricula)) {
      Console.WriteLine("Digite o nome do professor");
      professor.nome = Console.ReadLine();
      professores.Add(professor);
      Console.WriteLine("Professor adicionado com sucesso!");
    } else {
      Console.WriteLine("Matricula já existente!");
    }
  }

  private static Professor PesquisarProfessor() {
    Console.WriteLine("Digite a matricula do professor");
    string matricula = Console.ReadLine();
    return professores.Find(estudante => estudante.matricula == matricula);
  }

  private static void EditarProfessor() {
    Professor professor = PesquisarProfessor();
    if (professor != null) {
      int opcao = 0;
      do {
        Console.WriteLine("==================== Editar Professor ==========================");
        Console.WriteLine("0 - Voltar ao Menu do Professor");
        Console.WriteLine("1 - Editar Nome do Professor");

        Console.WriteLine("Digite a opcao:");
        opcao = int.Parse(Console.ReadLine());

        switch (opcao) {
          case 1:
            Console.WriteLine("Digite o nome do professor:");
            professor.nome = Console.ReadLine();
            Console.WriteLine("Nome editado com sucesso!");
            break;
          default:
            break;
        }
      } while (opcao > 0);
    } else {
      Console.WriteLine("Matricula não existente!");
    }
  }

  private static void RemoverProfessor() { }

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
      Console.WriteLine("Matricula não existente!");
    }
  }

  private static void AdicionarDisciplina() {
   /*
    Disciplina disciplina = new Disciplina();
    Console.WriteLine("Digite o codigo da disciplina");
    disciplina.codigo = Console.ReadLine();
    if (!disciplinas.Exists(query => query.codigo == disciplina.codigo)) {
      Console.WriteLine("Digite o nome da Disciplina");
      disciplina.nome = Console.ReadLine();
      disciplinas.Add(disciplina);
      Console.WriteLine("Disciplina adicionada com sucesso!");
    } else {
      Console.WriteLine("Código já existente!");
    }
    
  }

  private static void AdicionarDisciplina() {      
  
    Disciplina disciplina = new Disciplina();
      Console.WriteLine("Digite o codigo da disciplina:");
      disciplina.codigo = Console.ReadLine();
      if (!disciplinas.Exists(d => d.codigo == disciplina.codigo)) {
          Console.WriteLine("Digite o nome da Disciplina:");
          disciplina.Nome = Console.ReadLine();
          disciplinas.Add(disciplina);
          Console.WriteLine("Disciplina adicionada com sucesso!");
      } else {
          Console.WriteLine("Codigo já existente!");
      }
    
  }

  private static Disciplina PesquisarDisciplina() {
    /*
    Console.WriteLine("Digite o codigo da Disciplina:");
      string codigo = Console.ReadLine();
      return disciplinas.Find(d => d.codigo == codigo);
  */
  }

  private static void ImprimirDisciplinas() {
     
    foreach (Disciplina disciplina in disciplinas) {
          disciplina.Imprimir();
      }
  }
/*
  private static void ImprimirDisciplinaSelecionada() {
     
    Disciplina disciplina = PesquisarDisciplina();
      if (disciplina != null) {
          disciplina.Imprimir();
      } else {
          Console.WriteLine("Disciplina não existente!");
      }
  }
*/
  private static void MenuAluno() {
    int opcao = 0;
    do {
      Console.WriteLine("==================== Menu para Aluno ==========================");
      Console.WriteLine("0 - Voltar ao Menu");
      Console.WriteLine("1 - Adicionar Aluno");
      Console.WriteLine("2 - Editar Aluno");
      Console.WriteLine("3 - Remover Aluno");
      Console.WriteLine("4 - Imprimir Aluno");
      Console.WriteLine("5 - Imprimir Todos os Alunos");

      Console.WriteLine("Digite a opcao:");
      opcao = int.Parse(Console.ReadLine());

      switch (opcao) {
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
      Console.WriteLine("==================== Menu para Turma ==========================");
    
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
      
      Console.WriteLine ("Digite a opcao:");
      opcao = int.Parse(Console.ReadLine());
      
      
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
      Console.WriteLine("==================== Menu para Professor ==========================");
      Console.WriteLine ("0 - Voltar ao Menu");
      Console.WriteLine ("1 - Adicionar Professor");
      Console.WriteLine ("2 - Editar Professor");
      Console.WriteLine ("3 - Remover Professor");
      Console.WriteLine ("4 - Imprimir Professor");
      Console.WriteLine ("5 - Imprimir Todos os Professores");
      
      Console.WriteLine ("Digite a opcao:");
      opcao = int.Parse(Console.ReadLine());
     
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
      Console.WriteLine("==================== Menu para Disciplina ==========================");
     
      Console.WriteLine ("0 - Voltar ao Menu");
      Console.WriteLine ("1 - Adicionar Disciplina");
      Console.WriteLine ("2 - Editar Disciplina");
      Console.WriteLine ("3 - Remover Disciplina");
      Console.WriteLine ("4 - Imprimir Disciplina");
      Console.WriteLine ("5 - Imprimir Todas as Disciplinas");
      
    Console.WriteLine ("Digite a opcao:");
    opcao = int.Parse(Console.ReadLine());
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
  public static void Main (string[] args) {
    int opcao = 0;
    do {
      Console.WriteLine("==================== Menu Principal ==========================");
      Console.WriteLine ("0 - Sair");
      Console.WriteLine ("1 - Alunos");
      Console.WriteLine ("2 - Turmas");
      Console.WriteLine ("3 - Professores");
      Console.WriteLine ("4 - Disciplinas");
      
      Console.WriteLine ("Digite a opcao:");
      opcao = int.Parse(Console.ReadLine());
     
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
