namespace JUMP_Csharp;

internal class Program
{
    static void Main()
    {
        // aqui usarei todos os jumps disponiveis na linguagem C#
        // break, continue e return
        //BREAK: instrução de parada.
        //CONTINUE: instrução de pulo.
        //RETURN: instrução que devolver um valor e que para loops.

        //USANDO BREAK
        //Exemplo:
        var numero = 0;
        while (numero < 10)
        {
            //usando if para caso o numero seja 5 :
            if (numero == 5)
            {
                break; // usando break para sair do loop caso o numero seja 5.
            }

            Console.WriteLine(numero);
            numero++;
        }


        //USANDO CONTINUE 
        //Exemplo:

        var numero2 = 0;
        while (numero2 < 10)
        { 
            numero2++; // colocando o incremento aqui para não ficar em um loop infinito, ou seja, ficar pulando o 5 infinitamente.

            // fazendo uma condicional para caso "numero2" seja igual a 5.
            if(numero2 == 5)
            {
                continue; // aqui o continue irá pular o numero 5 e continuará a exibir até o numero 10 sem o 5 nele.
            }
            // ou seja, usando esse exemplo, ele pula de 5 para 6.
            Console.WriteLine(numero2);
        }
        // chamando a função estatica Teste
        Teste(5); // aqui não sera mostrado nada já que numero é igual a 5 e a função será pulada
        Teste(4); // como não é 5, aqui irá aparecer o numero 4.
    


        // chamando a função estatica Nome
        Nome(5); // aqui irá imprimir "Deu certo"

        // chamando o valor junto: 
        var valor = Nome(5);
        Console.WriteLine(valor); // aqui irá imprimir "Deu certo" e o valor "Ruan" junto.
    }

    //USANDO RETURN
    //Exemplo:
    //criando uma função estatica porque irei chamala dentro da main.
    //lembrando que funções estaticas so podem chamar outras funções estaticas.
    static void Teste(int numero)
    {
        //criando uma condicional if
        if(numero == 5)
            return; // aqui funciona como o break, mas o return pode ser usado em loops e em funções
                    // tudo oq estiver abaixo de return será iguinorado caso a condicional seja ativada
                    // e a função será pulada.
        Console.WriteLine(numero);
    }

    //criando outra função estatica 
    // usando outra funcionalidade do RETURN
    //Exemplo: 
    static string Nome(int numero)
    { // aqui estou usando o return para retorna algo
        if (numero == 5)
        { // caso o numero for 5, irá imprimir que deu certo e irá retorna "Ruan" e sairá da função.
            Console.WriteLine("Deu certo");
            return "Ruan";
        }
        // caso contrario, irá retorna "Não deu certo".
        return "Não deu certo";
    }
}
