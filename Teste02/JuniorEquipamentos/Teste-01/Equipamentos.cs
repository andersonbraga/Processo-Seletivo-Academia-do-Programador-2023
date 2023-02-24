using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teste_01
{
    public class Equipamentos
    {
        public string? Nome {get;set;}
        public double  precoPago { get; set; }
        public int numeroSerie { get; set; }    
        public DateTime dataFabricacao { get; set; }
        public string? Fabricante {get;set;}

    

     public static void NovoEquipamento(List<Equipamentos> listaEquipamentos)
        {
            var equipamentos = new Equipamentos();

            Console.WriteLine("#######Cadastre uma novo equipamento####### \n\n\n");
            

            Console.WriteLine("informe o Nome do Equipamento:");
             equipamentos.Nome = Console.ReadLine();
            
            Console.WriteLine("informe o numero de serie (apenas numeros):");
            equipamentos.numeroSerie = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("informe o preço pago na aquisição (apenas numeros):");
            equipamentos.precoPago = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("informe a data de fabricação:");
            equipamentos.dataFabricacao = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("informe o Nome do Fabricante:");
             equipamentos.Fabricante = Console.ReadLine();

            
            equipamentos.numeroSerie = 1000  + listaEquipamentos.Count;

            listaEquipamentos.Add(equipamentos);

            Console.WriteLine("Equipamento: " + equipamentos.Nome + " Cadastrado com sucesso.");

        }

    public static void ListaEquipamentos(List<Equipamentos> listaEquipamentos)
        {
            if (listaEquipamentos.Count == 0)
                Console.WriteLine("Nenhuma equipamento cadastrado.");
            else
            {
                foreach (var equipamentos in listaEquipamentos)
                {
                    Console.WriteLine("Equipamento: " + equipamentos.Nome + "\r\n Numero de Serie " + equipamentos.numeroSerie + "\r\n Fabricante: " + equipamentos.Fabricante);
                }
            }
        }

        public static void EditarEquipamentos(List<Equipamentos> listaEquipamentos)
        {
            var equipamentos = new Equipamentos();
            Console.WriteLine("informe o Nome do Equipamento que deseja alterar:");
            equipamentos.Nome = Console.ReadLine();
            
            if (listaEquipamentos.Count == 0){
                Console.WriteLine("Nome do equipamento não cadastrado");
            }
                     if (equipamentos.Nome != equipamentos.Nome )
                    {
                Console.WriteLine("Nome do equipamento não cadastrado");
                }
                
            else{
          

            var index = listaEquipamentos.FindIndex(item => equipamentos.Nome == item.Nome);
            
            Equipamentos novoEquipamento = new Equipamentos();

            Console.WriteLine("informe o  novo Nome do Equipamento:");
            equipamentos.Nome = Console.ReadLine();
            Console.WriteLine("informe o numero de serie (apenas numeros):");
            equipamentos.numeroSerie = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("informe o preço pago na aquisição (apenas numeros):");
            equipamentos.precoPago = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("informe a data de fabricação:");
            equipamentos.dataFabricacao = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("informe o Nome do Fabricante:");
            equipamentos.Fabricante = Console.ReadLine();

            novoEquipamento.Nome = equipamentos.Nome;
            novoEquipamento.numeroSerie = equipamentos.numeroSerie;
            novoEquipamento.precoPago = equipamentos.precoPago;
            novoEquipamento.dataFabricacao = equipamentos.dataFabricacao;
            novoEquipamento.Fabricante = equipamentos.Fabricante;

            listaEquipamentos[index] = novoEquipamento;
            listaEquipamentos.Add(equipamentos);
            Console.WriteLine("\r\n \r\n Equipamento: " + equipamentos.Nome + "\r\n Numero de Serie " + equipamentos.numeroSerie + "\r\n Fabricante: " + equipamentos.Fabricante);
                }
                
        }

    public static void DeletarEquipamentos(List<Equipamentos> listaEquipamentos)
    {
            Equipamentos deletarEquipamento = new Equipamentos();
            var equipamentos = new Equipamentos();
            Console.WriteLine("informe o Nome do Equipamento que deseja excluir:");
             equipamentos.Nome = Console.ReadLine();
          
            deletarEquipamento.Nome = equipamentos.Nome;

            var index = listaEquipamentos.FindIndex(item => equipamentos.Nome == item.Nome);
            listaEquipamentos[index] = deletarEquipamento;
            listaEquipamentos.RemoveAt(index);

            
    }
}
}
