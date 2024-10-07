using System;
using System.Collections.Generic;
namespace Modelos {

    class Turma {
        public List<Historico> historicos = new List<Historico>();
        private int ano;
        private int semestre;
        private Professor professor;
        private Disciplina disciplina;
        private string identificador;
        public int Ano{
            get=>this.ano;
            set{
                this.ano=value;
            }
        }
        public int Semestre{
            get=>this.semestre;
            set{
                if(value>0){
                    if(value>2){
                        this.semestre=2;
                    }else{
                         this.semestre=value;
                    }
                }else{
                  this.semestre=1;
                }
            }
        }
        public Professor Professor{
            get=>this.professor;
            set{
                this.professor=value;
            }
        }
        public Disciplina Disciplina{
            get=>this.disciplina;
            set{
                this.disciplina=value;
            }
        }
        public string Identificador{
            get=>this.identificador;
            set{
                if(!String.IsNullOrWhiteSpace(value)){
                 this.identificador=value;
                }
            }
        }
        public double Media(){
            double soma=0.0;
            foreach (Historico historico in historicos){
                soma+=historico.Soma;
            }
            if(historicos.Count!=0){
                return soma/historicos.Count;
            }else{
                return 0;
            }
        }
        public void Imprimir(){
            Console.WriteLine("**************************************");
            Console.WriteLine("Turma");
            Console.WriteLine("identificador: "+this.identificador);
            Console.WriteLine("Ano: "+this.Ano);
            Console.WriteLine("Disciplina: "+this.Disciplina.Nome);
            Console.WriteLine("Semestre: "+this.Semestre);
            Console.WriteLine("Professor: "+this.Professor.Nome);
            Console.WriteLine("**************************************");
        }
        public List<Historico> Aprovados(){
            List<Historico> aprovados = new List<Historico>();
            foreach (Historico historico in historicos){
                if(historico.Aprovado){
                    aprovados.Add(historico);
                }
            } return aprovados;
        }
        public List<Historico> Reprovados(){
            List<Historico> reprovados = new List<Historico>();
            foreach (Historico historico in historicos){
                if(!historico.Aprovado){
                    reprovados.Add(historico);
                }
            } return reprovados;
        }
        public void Matricular(Aluno aluno){
            Historico historico1 = new Historico();
            Console.WriteLine ("Digite a nota do aluno nessa turma:");
            double nota= double.Parse(Console.ReadLine());
            historico1.notas.Add(nota);
            Console.WriteLine ("Digite o numero de faltas do aluno nessa turma:");
            int faltas = int.Parse(Console.ReadLine());
            historico1.Faltas= faltas;
            historico1.Turma= this;
            historico1.Aluno=aluno;
            this.historicos.Add(historico1);
            aluno.historicos.Add(historico1);
        }
        public void Desmatricular(Aluno aluno){
            Historico historico=historicos.Find(historico =>historico.Aluno.Matricula==aluno.Matricula);
            if (historico!=null){
                this.historicos.Remove(historico);
                aluno.historicos.Remove(historico);
                Console.WriteLine ("Aluno desmatriculado com sucesso");
            }else{
                Console.WriteLine ("Esse aluno não faz parte dessa turma");
            }

        }    
    }   
}