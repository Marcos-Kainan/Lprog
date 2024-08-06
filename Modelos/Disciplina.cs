// introdução para introdução para manipulação de objeto:
using System;

namespace Modelos {

    class Disciplina {
      public string nome;
      public int semestre;

      public void Imprimir() {
        Console.WriteLine("-----------------------");
        Console.WriteLine("Disciplina");
        Console.WriteLine("Nome: " + this.nome);
        Console.WriteLine("Semestre: " + this.semestre);
        Console.WriteLine("-----------------------");
      }
    }

}