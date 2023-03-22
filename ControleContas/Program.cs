
using ControleContas.Model;

Conta conta = new Conta("1234");
Conta conta2 = new Conta("4321", 1000.99m);
Conta Conta3 = new Conta("654321",2341.42m);

Console.WriteLine($"Conta: {conta2.Numero}; Saldo: {conta2.Saldo}");
Console.WriteLine($"O saldo total é: {conta2.SaldoTotal}");
Console.WriteLine($"A conta de maior saldo é {conta2.ContaMaioraSaldo}");