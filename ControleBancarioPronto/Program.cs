// See https://aka.ms/new-console-template for more information
using ControleBancario.Model;

try
{
    Cliente cliente1 = new Cliente("João", "32145178932", new DateTime(2004, 5, 10), "unifoa@joao.com");
    Cliente cliente2 = new Cliente("Henrique", "65432154323", new DateTime(2004, 7, 5), "unifoa@henrique.com");

    // criando conta
    Conta contaCorrente1 = new Conta(12345, 2000m, cliente1);
    Conta contaCorrente2 = new Conta(12345, 1000m, cliente2);

    // testando deposisto
    contaCorrente1.Depositar(500m);
    contaCorrente2.Depositar(250m);

    //informando saldo apos deposito
    Console.WriteLine("----------------------------------------------------------------------------------");
    Console.WriteLine();
    Console.WriteLine($"Saldo depois do depósito: {contaCorrente1.Saldo}");
    Console.WriteLine($"Saldo depois do depósito: {contaCorrente2.Saldo}");
    Console.WriteLine();
    Console.WriteLine("----------------------------------------------------------------------------------");

    //testando saque
    contaCorrente1.Saque(300m);
    contaCorrente2.Saque(150m);

    //informando saldo apos saque
    Console.WriteLine("----------------------------------------------------------------------------------");
    Console.WriteLine();
    Console.WriteLine($"Saldo depois do saque: {contaCorrente1.Saldo}");
    Console.WriteLine($"Saldo depois do saque: {contaCorrente2.Saldo}");
    Console.WriteLine();
    Console.WriteLine("----------------------------------------------------------------------------------");

    //-------------------------------------------------------------------------------------------------------------------------------//

    // criando conta especial
    ContaEspecial contaEspecial1 = new ContaEspecial(20041, 500m, 1000m, cliente1);
    ContaEspecial contaEspecial2 = new ContaEspecial(20042, 250m, 500m, cliente2);

    // testando deposito da conta especial
    contaEspecial1.Depositar(500m);
    contaEspecial2.Depositar(250m);

    //informando saldo apos deposito
    Console.WriteLine("----------------------------------------------------------------------------------");
    Console.WriteLine();
    Console.WriteLine($"Saldo depois do depósito: {contaEspecial1.Saldo}");
    Console.WriteLine($"Saldo depois do depósito: {contaEspecial2.Saldo}");
    Console.WriteLine();
    Console.WriteLine("----------------------------------------------------------------------------------");

    //testando saque da conta especial
    contaEspecial1.Saque(300m);
    contaEspecial2.Saque(150m);

    //informando saldo apos saque
    Console.WriteLine("----------------------------------------------------------------------------------");
    Console.WriteLine();
    Console.WriteLine($"Saldo depois do saque: {contaEspecial1.Saldo}");
    Console.WriteLine($"Saldo depois do saque: {contaEspecial2.Saldo}");
    Console.WriteLine();
    Console.WriteLine("----------------------------------------------------------------------------------");


    //-------------------------------------------------------------------------------------------------------------------------------//

    // Transferência entre contas
    contaCorrente1.Transferir(200m, contaEspecial2);
    contaCorrente2.Transferir(100m, contaEspecial1);

    Console.WriteLine("----------------------------------------------------------------------------------");
    Console.WriteLine();
    Console.WriteLine($"Saldo conta corrente depois da transferência: {contaCorrente1.Saldo}");
    Console.WriteLine($"Saldo conta corrente depois da transferência: {contaCorrente2.Saldo}");
    Console.WriteLine();
    Console.WriteLine("----------------------------------------------------------------------------------");

    Console.WriteLine("----------------------------------------------------------------------------------");
    Console.WriteLine();
    Console.WriteLine($"Saldo conta especial depois de receber transferência: {contaEspecial1.Saldo}");
    Console.WriteLine($"Saldo conta especial depois de receber transferência: {contaEspecial2.Saldo}");
    Console.WriteLine();
    Console.WriteLine("----------------------------------------------------------------------------------");

}
catch (ArgumentException)
{
    Console.WriteLine("Erro");
}
