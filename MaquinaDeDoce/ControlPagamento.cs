using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MaquinaDeDoce
{
     class ControlPagamento
    {
        Pagamento pag;

        private int opcao;
        public ControlPagamento()
        {
            ModificarOpcao = -1;

        }//Fim do construtor
    
        //Metodo get e set

        public int ModificarOpcao
        {
            get { return opcao; } 
            set { opcao = value; }
        }//Fim do metodo get e set

        public void Menu()
        {
            Console.WriteLine("\n\n\nEscolha uma das opções abaixo: \n" +
                             "0. Sair:\n" +
                             "1. Consultar pagamento\n" +
                             "2. Atualizar pagamento\n" +
                             "3. Cadastrar pagamento\n");
            ModificarOpcao = Convert.ToInt32(Console.ReadLine());
        }//fim do metodo menu
    
       //Coletar pagamento
        public void ColetarPagamento()
        {
            Console.WriteLine("Informe um código: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a descrição do pagamento: ");
            string descricao = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Informe o valor total: ");
            double valorTotal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a data: ");
            DateTime data = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Informe o código do cartão: ");
            int codCartao = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a bandeira do cartão: ");
            int bandeiraCartao = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a forma de pagamento:");
            int formaDePagamento = Convert.ToInt32(Console.ReadLine());

            //Cadastrar pagamento
            pag.CadastrarPagamento(codigo, descricao, valorTotal, data, codCartao, bandeiraCartao, formaDePagamento);
            Console.WriteLine("Pagamento registrado com sucesso!");
        }//Fim do ColetarPagamento()
    
        //Metodo consultando pagamento 
        public void Consultar()
        {
            Console.WriteLine("\n\n\nInforme o código do pagamento que deseja consultar");
            int codigo = Convert.ToInt32(Console.ReadLine());
            //escrever resultados na tela
            Console.WriteLine("Os dados são: " + pag.ConsultarPagamento(codigo));
        }// fim do método consultar pagamento


        //Atualizar pagamento

        public void atualizar()
        {
            Console.WriteLine("Informe o código do pagamento que deseja atualizar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            int campo = 0;
            do
            {
                Console.WriteLine("\n\nInforme o campo que deseja atualizar abaixo:\n " +
                                 "1. Descrição:\n " +
                                 "2. Valor Total:\n " +
                                 "3. Data:\n " +
                                 "4. Código cartão:\n " +
                                 "5. Bandeira do cartão:\n " +
                                 "6. Forma de pagamento:\n ");
                campo = Convert.ToInt32(Console.ReadLine());
                //Avisar o usuário

                if ((campo <1) || (campo > 6))
                {
                    Console.WriteLine("Escolha uma opção valida");
                }//Fim do if
            } while ((campo < 1) || (campo > 6));

            Console.WriteLine("Informe o dado para a atualização: ");
            string novoDado = Console.ReadLine();

            //Chamar o método de atualização
            pag.AtualizarPagamento(codigo, campo, novoDado);
            Console.WriteLine("Alterado com sucesso!");

            Console.ReadLine(); // Manter janela aberta 
        }// fim do metodo atualizar pagamento
    
                   
        
       public void OperacaoPagamento()
        {
            do
            {
                Menu(); //Mostrando o menu
                switch (ModificarOpcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        Console.Clear();
                        break;
                    case 1:
                        Consultar();
                        Console.Clear();//Limpa tela
                        break;
                    case 2:
                        atualizar();
                        Console.Clear();
                        break;
                    case 3:
                        ColetarPagamento();
                        Console.Clear();
                        break;
                    default: Console.WriteLine("Insira uma opção válida.");
                        break;
                }// fim do switch
            } while (ModificarOpcao != 0);
        }//Fim da operacaopagamento
        
        
    
    
    
    
    
    
    
    
    
    
    
    
    
    }//Fim da classe
}//Fim do projeto
