using byteBanck_Adm.Funcionarios;
using byteBanck_Adm.SistemaInterno;
using byteBanck_Adm.Utilitario;
using ByteBank.Funcionarios;
using ByteBank_ADM.Funcionarios;

#region
//Funcionario Pedro = new Funcionario("12345678911",2000);
//Pedro.Nome = "Pedro andré";
////Pedro.Cpf = "12345678911";


//Console.WriteLine(Pedro.Nome);
//Console.WriteLine(Pedro.GetBonificacao());

//Diretor roberta = new Diretor("12345678910");
//roberta.Nome = "Roberta Silva";


//Console.WriteLine(roberta.Nome);
//Console.WriteLine(roberta.GetBonificacao());

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(Pedro);
//gerenciador.Registrar(roberta);

//Console.WriteLine("Total de bonificações: "+gerenciador.TotalDeBonificacao);
//Console.WriteLine("Total de funcionarios: " + Funcionario.TotalDeFuncionarios);

//Pedro.AumentarSalario();
//roberta.AumentarSalario();

//Console.WriteLine("novo salario do Pedro "+Pedro.Salario);
//Console.WriteLine("novo salario da Roberta " + roberta.Salario);
#endregion

//CalcularBonificacao();
UsarSistema();
void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
    
    Designer ulisses = new Designer("123456");
    ulisses.Nome = "Ulisses Souza";

    Diretor paula = new Diretor("987456");
    paula.Nome = "Paula Souza";

    Auxiliar igor = new Auxiliar("74581");
    igor.Nome = "Igor Dias";

    GerenteDeConta camila = new GerenteDeConta("852963");
    camila.Nome = "Camila Oliveira";

    gerenciador.Registrar(camila);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(ulisses);

    Console.WriteLine("Total de Bonificação = " + gerenciador.TotalDeBonificacao);

}

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor ingrid = new Diretor("12346678912");
    ingrid.Nome = "Ingrid";
    ingrid.Senha = "123";

    GerenteDeConta ursula = new GerenteDeConta("1236554987");
    ursula.Nome = "Ursula";
    ursula.Senha="123";

   

    sistema.Logar(ingrid, "123");
    sistema.Logar(ursula, "1234");

}