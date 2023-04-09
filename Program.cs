// Calcule o montante final de um investimento a juros simples.

double capital;
double taxaJuros;
double tempoInvestimento;
double juros;
double montante;

Console.WriteLine("--- Cálculo do Montante de Juros Simples ---\n");

Console.Write("Digite o valor do capital (em reais): R$ ");
capital = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a taxa de juros (em decimal): ");
taxaJuros = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o tempo de investimento (em anos): ");
tempoInvestimento = Convert.ToDouble(Console.ReadLine());

juros = capital * taxaJuros * tempoInvestimento;
montante = capital + juros;

Console.WriteLine($"\nJuros: R$ {juros:F2}");
Console.WriteLine($"Montante: R$ {montante:F2}");