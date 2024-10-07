using System;
using System.Collections.Generic;
namespace Modelos {

    class Professor {
        private string nome;
        private string matricula;

        public string Nome{
            get=>this.nome;
            set{
                if(!String.IsNullOrWhiteSpace(value)){
                     this.nome=value;
                 }
            }
        }
        public string Matricula{
            get => this.matricula;
            set{
                if(!String.IsNullOrWhiteSpace(value)){
                 this.matricula=value;
                }
            }
        }
        public void Imprimir(){
                Console.WriteLine("**************************************");
                Console.WriteLine("Professor");
                Console.WriteLine("Nome: "+this.Nome);
                Console.WriteLine("Matricula: "+this.Matricula);
                Console.WriteLine("**************************************");
        }
    }
}