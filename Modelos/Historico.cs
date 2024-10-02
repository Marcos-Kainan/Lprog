using System;
using System.Collections.Generic;
namespace Modelos {

  class Historico {

    public Disciplina Disciplina {
      get; set;
    }

    public List<double> notas = new List<double>();
    
    public double  Soma{
    
      get{   
      double soma = 0.0;
      foreach(double nota in notas) {
        soma += nota;
      }
    
      return soma;
      }
    } 
      
    public bool Aprovado {
      get {
      return this.Soma >= 60.0;
        }
      } 

    public void Imprimir() {
      Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>");
      this.Disciplina.Imprimir();
      
      if(this.Aprovado) {
        Console.WriteLine("Aprovado");
      } else {
        Console.WriteLine("Reprovado");
        }
       Console.WriteLine("Nota final: " + this.Soma);
      Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>");    
    }

  }

}