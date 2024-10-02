using System;

namespace Modelos {  
    class Disciplina {
      private string nome;
      private int periodo;
      private string codigo;
          
      public string Nome {
        get => this.nome;
        set {
          if(!String.IsNullOrWhiteSpace(value)) {
            this.nome = value;
          }
        }
      }

      public int Semestre {
        get => this.periodo;
        set {
          if (value > 0) {
            this.periodo = value;
          } else {
            this.periodo = 1;
          }
        }
      }

      public Disciplina() : this(1) {
      }

      public Disciplina(int periodo) {
        this.Semestre = periodo;
      }

      public Disciplina(string nome, int semestre)
        : this (semestre) {
          this.Nome = nome;
        }

      public void Imprimir() {
        Console.WriteLine("-----------------------");
        Console.WriteLine("Disciplina");
        Console.WriteLine("Nome da Disciplina:"+ this.nome);
        Console.WriteLine(" Periodo da Disciplina:" + this.periodo);
        Console.WriteLine ("Codigo da Disciplina: "+ this.codigo);
        Console.WriteLine("-----------------------");
      }
    }
  }


