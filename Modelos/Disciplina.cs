using System;

namespace Modelos {

  class Disciplina{
     private string nome;
     private int periodo;
     private string codigo;

    public int Periodo{
      get => this.periodo;
      set{
        if(value>0){
          this.periodo=value;
        }else{
          this.periodo=1;
        }
      }
    }
    public string Nome{
      get => this.nome;
      set{
        if(!String.IsNullOrWhiteSpace(value)){
             this.nome=value;
         }
      }
    }
    public string Codigo{
      get => this.codigo;
      set{
        if(!String.IsNullOrWhiteSpace(value)){
             this.codigo=value;
         }
      }
    }
    public Disciplina(): this(1){
    }
    public Disciplina(int periodo){
      this.periodo = periodo;
    }
    public Disciplina(int periodo,string nome): this(periodo){
         this.Nome = nome;
     }
     public void Imprimir(){
         Console.WriteLine("--------------------------------------");
         Console.WriteLine("Nome: "+this.Nome);
         Console.WriteLine("periodo: "+this.periodo);
         Console.WriteLine("Codigo: "+this.Codigo);
         Console.WriteLine("--------------------------------------");
       }
    }
}