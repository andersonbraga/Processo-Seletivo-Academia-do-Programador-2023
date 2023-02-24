using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Teste_01
{
    public class Chamados
    {
        public string? tituloChamado {get;set;}
        public string?  descricaoChamado { get; set; }
        public Equipamentos equipamentos {get;set;} = new Equipamentos();
        public DateTime dataAbertura { get; set; }
        
    
    
    public static void NovoChamado(List<Chamados> listaChamados)
        {
            var chamados = new Chamados();

            Console.WriteLine("#######Cadastre uma novo chamado####### \n\n\n");
            

            Console.WriteLine("informe o Titulo do Chamado: ");
             chamados.tituloChamado = Console.ReadLine();
            
            Console.WriteLine("informe a Descrição da Chamada: ");
            chamados.descricaoChamado = Console.ReadLine();

            Console.WriteLine("informe o Nome do Equipamento: ");
            chamados.equipamentos.Nome = Console.ReadLine();

            Console.WriteLine("informe a data de fabricação:");
            chamados.dataAbertura = Convert.ToDateTime(Console.ReadLine());


            listaChamados.Add(chamados);

            Console.WriteLine("Chamado: " + chamados.tituloChamado + "  Registrado com sucesso.");
           

        }

    

        public static void ListaChamado(List<Chamados> listaChamados)
        {
         
            if (listaChamados.Count == 0)
                Console.WriteLine("Nenhuma chamado registrado.");
            else
            {
                foreach (var chamados in listaChamados)
                {
                    Console.WriteLine("Titulo do Chamado: " + chamados.tituloChamado + "\r\n Equipamento: " + chamados.equipamentos.Nome +" \r\n Data da abertura do chamado" + chamados.dataAbertura +" \r\n Dias com chamado Aberto " + chamados.dataAbertura.Subtract(DateTime.Today).TotalDays);
                    
                }
                
            }
           

        }

        public static void EditarChamado(List<Chamados> listaChamados)
        {
            var chamados = new Chamados();
            Console.WriteLine("informe o Titulo do Chamado que deseja alterar:");
            chamados.tituloChamado = Console.ReadLine();
            
            if (listaChamados.Count == 0){
                Console.WriteLine("Titulo do chamado não cadastrado");
            }
                     if (chamados.tituloChamado != chamados.tituloChamado )
                    {
                Console.WriteLine("Titulo do chamado não cadastrado");
                }
                
            else{
          

            var index = listaChamados.FindIndex(item => chamados.tituloChamado == item.tituloChamado);
            
            Chamados novoChamado = new Chamados();

            Console.WriteLine("informe o  novo Titulo do Chamado:");
            chamados.tituloChamado = Console.ReadLine();
            Console.WriteLine("informe a descrição do chamado:");
            chamados.descricaoChamado = Console.ReadLine();
            Console.WriteLine("informe o nome do equipamento");
            chamados.equipamentos.Nome = Console.ReadLine();
            Console.WriteLine("informe a data de abertura do chamado:");
            chamados.dataAbertura = Convert.ToDateTime(Console.ReadLine());
           

            novoChamado.tituloChamado = chamados.tituloChamado;
            novoChamado.descricaoChamado = chamados.descricaoChamado;
            novoChamado.equipamentos.Nome = chamados.equipamentos.Nome;
            novoChamado.dataAbertura = chamados.dataAbertura;

            listaChamados[index] = novoChamado;
            listaChamados.Add(chamados);
            Console.WriteLine("\r\n \r\n Chamado: " + chamados.tituloChamado + "\r\n Descrição " + chamados.descricaoChamado + "\r\n Equipamento: " + chamados.equipamentos.Nome + "\r\n Data Abertura: " + chamados.dataAbertura);
                }
                
        }

         public static void DeletarChamado(List<Chamados> listaChamados)
    {
            Chamados deletarChamado = new Chamados();
            var chamados = new Chamados();
            Console.WriteLine("informe o Titulo do Chamado que deseja excluir:");
             chamados.tituloChamado = Console.ReadLine();
          
            deletarChamado.tituloChamado = chamados.tituloChamado;

            var index = listaChamados.FindIndex(item => chamados.tituloChamado == item.tituloChamado);
            listaChamados[index] = deletarChamado;
            listaChamados.RemoveAt(index);

            
    }

        


  }
}