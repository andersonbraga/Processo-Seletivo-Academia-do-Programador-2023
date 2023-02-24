using Teste_01;


internal class Program
{
   static void Main(string[] args)
  {
    var listaEquipamentos = new List<Equipamentos>();
    var listaChamados = new List<Chamados>();

            var op = "";

            do
            {
                Console.WriteLine();
                Console.WriteLine();
              
                Console.WriteLine("\"EC\" para cadastrar um novo equipamento, \"EM\" Mostrar os Equipamentos, \"EE\" Editar os Equipamentos , \"ED\" Deletar o Equipamento , \"CC\"  Criar Chamado , \"CM\" Mostrar Chamados Abertos, \"CE\" Editar Chamados Abertos, \"CD\" Deletar Chamados Abertos,  \"sair\" para sair");
                op = Console.ReadLine(); //.ToLower();
                

                if (op == "EC" || op == "ec")
                    Equipamentos.NovoEquipamento(listaEquipamentos);
                
                else if (op == "EM" || op == "em")
                    Equipamentos.ListaEquipamentos(listaEquipamentos);
                else if (op == "EE" || op == "ee")
                    Equipamentos.EditarEquipamentos(listaEquipamentos);
                    else if (op == "ED" || op == "ed")
                    Equipamentos.DeletarEquipamentos(listaEquipamentos);
                     else if (op == "CC" || op == "cc")
                    Chamados.NovoChamado(listaChamados);
                    else if (op == "CM" || op == "cm")
                    Chamados.ListaChamado(listaChamados);
                    else if (op == "CE" || op == "ce")
                    Chamados.EditarChamado(listaChamados);
                    else if (op == "CD" || op == "cd")
                    Chamados.DeletarChamado(listaChamados);
         
            }
            while (op != "sair");
  }
}