using System;
namespace Modelos {

    class Professor {
        public string nome;
          public string matricula;
        public void Imprimir() {
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine(" Nome do Professor:" + this.nome);
            Console.WriteLine ("Matricula: "+ this.matricula);
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>");    
        }
    }
}
