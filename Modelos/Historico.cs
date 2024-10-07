using System;
using System.Collections.Generic;
namespace Modelos{
  class Historico{
    private int faltas=0;
    private Aluno aluno;
    private Turma turma;
    
    public Disciplina Disciplina{
      get; set;
    } 
    public int Faltas{
      get=>this.faltas;
      set{
        if(value>=0){
         this.faltas=value; 
        }
        else{
          this.faltas=0;
        }
      }
    }
  public Aluno Aluno{
    get=>this.aluno;
    set{
      this.aluno=value;
    }
  }
   public Turma Turma{
     get=>this.turma;
     set{
       this.turma=value;
     }
   } 
    public List <double> notas = new List<double>();
    public double Soma{
      get{
        double soma = 0.0;
        foreach(double nota in notas){
          soma+=nota;
        }
        return soma;
      }
    }
    public bool Aprovado{
      get{
        return this.Soma >= 60.0 && this.faltas<10; 
      } 
    }
    public void Imprimir(){
      Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
      this.Aluno.Imprimir();
      this.Turma.Disciplina.Imprimir();
      Console.WriteLine("Nota final: "+this.Soma);
      Console.WriteLine("Quantidade de faltas: "+this.faltas);
      if(this.Aprovado){
        Console.WriteLine("Aprovado");
      }  else{
        Console.WriteLine("Reprovado");
      }
      Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
    }

  }
}
