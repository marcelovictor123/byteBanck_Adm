using byteBanck_Adm.Funcionarios;

Funcionario Pedro = new Funcionario();
Pedro.Nome = "Pedro andré";
Pedro.Cpf = "12345678911";
Pedro.Salario = 2000;

Console.WriteLine(Pedro.Nome);
Console.WriteLine(Pedro.GetBonificacao());