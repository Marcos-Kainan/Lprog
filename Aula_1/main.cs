using System;// entrada para uso

class Aula1{ // main do codigo
    static double f(double x, double a, double b, double c)
    {// função para calculo de segundo grau
        double y = a * x * x + b * x + c; // a realização do calculo e armazena na variavel y 
        return y;// retorno do calculo para main
    }

    static double[] zeros(double a, double b, double c)
    {//função zero
        double[] z = new double[2];// declarção para vetor
        if (a != 0) { // se A for diferente de 0
            
        double delta = b * b - 4 * a * c; // calculo do delta
        if (delta >= 0){ // condição para realizar o calculo de delta
            z[0] = (-b + Math.Sqrt(delta)) / 2 * a;// calculo de x1
            z[1] = (-b + Math.Sqrt(delta)) / 2 * a;// calculo de x2
         }
        }else{
            z[0] =z[1]= -c/b; // calculo de x1 e x2 
        }    
        return z;// retorno ou saida do valor amarzenado em z para main
    }
    public static void Main(string[] args){ // metodo principal
        int v = 0; // variavel inteira 
        Console.WriteLine(v);// imprime o valor da variavel v

        double y = f(1, 2, 3, 4);// atribuição de valor para função f
        Console.WriteLine(y); // imprime o valor de y

        Console.WriteLine("digite o Valor de x");// imprensão de idicando para digitar o valor de x
        double x = double.Parse(Console.ReadLine());// entrada de valor via teclado para x 
        Console.WriteLine("Resultado:");
        y = f(x, 2, 3, 4); // entrada de valor para a função f(esperando digitar o valor de x via teclado)
        Console.WriteLine(y);//imprime o valor de y
/*
        double[] z = zeros(0, 4, 2); // entrada de valor para a função zeros      
        for (int i = 0; i < 2; i++)
        { // condição de repetição para imprimir os valores de z
            Console.WriteLine(z[i]); // imprime o valor de z 
            }
*/        
    }
}