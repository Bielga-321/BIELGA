// Crie um algoritmo em C# que, tendo 2 variáveis contendo a base e a altura de um triangulo, calcule sua área. ( b * h / 2 )
int b = 20; // Base
int h = 10; // Al

// Cálculo da área
int a = (b * h) / 2;

// Exibe resultado
Console.WriteLine("Área: " + a);

// ⁠Crie um algoritmo em C# que "calcule" e exiba a tabuada do 5 armazenando os resultados em um vetor.
int[] resultado = new int[10];

// resultado[0] = 1 * 5;
// resultado[1] = 2 * 5;
// resultado[2] = 3 * 5;

// resultado[9] = 10 * 5;

for(int cont = 0;cont < 10;cont++) {
    resultado[cont] = (cont + 1) * 5;
}

foreach(int item in resultado) { 
    Console.WriteLine(item);
}

