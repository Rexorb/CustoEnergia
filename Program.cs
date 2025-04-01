/*
Exercício CustoEnergia
Um aparelho Ar Condicionado Split LG DUAL Inverter 9.000 Frio consome 17,1 kWh/mês de energia enquanto ligado, segundo seu fabricante.

Isso significa que, se utilizado 8h por dia, consome 136,8 kWh/mês. Considerando o custo por kWh de R$0,62258, teríamos um custo estimado de R$85,168944.

Faça um programa que estime o custo de consumo de energia de um aparelho elétrico dado o seu consumo em kWh/mês e o uso diário (em horas).

Tempo de uso diário (h) x Consumo do aparelho (kWh/mês) x Custo da energia (R$/kWh) = Custo de um mês de uso (R$)
--- Custo de Energia ---

Consumo do aparelho (em kWh/mês)...: 17,1
Horas de uso por dia...............: 8
Custo da energia (em R$/kWh).......: 0,62258

Custo estimado: R$85,17
¹ NeoEnergia, B1-Residencial, Consumo Ativo, sem considerar bandeira tarifária e impostos (acessado em 04/07/2022).

*/

double custoEnergia = 0.62258;

Console.WriteLine("Digite o consumo mensal em kWh do aparelho:");
double usoMensal = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o número de horas ao dia em que é consumido");
double usoHoras = Convert.ToDouble(Console.ReadLine());

double usoDiario = usoMensal * usoHoras;

int custoEstimadoMensal = Convert.ToInt32(usoDiario * custoEnergia);


Console.WriteLine($"O custo estimado mensalmente é de: R${custoEstimadoMensal}");


