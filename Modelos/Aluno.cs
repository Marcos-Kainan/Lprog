// introdução para introdução para manipulação de objeto:
using System;
namespace Modelos{
  
  class Aluno{
    public string matricula;
    public int periodo;
    
    public Disciplina[] disciplinas = new Disciplina[2];
    
    public void Imprimir(){
      Console.WriteLine("***********************");
      
      Console.WriteLine("Aluno");
      Console.WriteLine("Matricula:" + this.matricula);
      Console.WriteLine("Periodo:" + this.periodo);
      
      Console.WriteLine("***********************");
    }
  }
}