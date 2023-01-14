using byteBanck_Adm.Funcionarios;
using byteBanck_Adm.Utilitario;

Funcionario Pedro = new Funcionario();
Pedro.Nome = "Pedro andré";
Pedro.Cpf = "12345678911";
Pedro.Salario = 2000;

Console.WriteLine(Pedro.Nome);
Console.WriteLine(Pedro.GetBonificacao());

Diretor roberta = new Diretor();
roberta.Nome = "Roberta Silva";
roberta.Cpf = "12345678910";
roberta.Salario = 5000;

Console.WriteLine(roberta.Nome);
Console.WriteLine(roberta.GetBonificacao());

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(Pedro);
gerenciador.Registrar(roberta);

Console.WriteLine("Total de bonificações: "+gerenciador.TotalDeBonificacao);
Console.WriteLine("Total de funcionarios: " + Funcionario.TotalDeFuncionarios);

