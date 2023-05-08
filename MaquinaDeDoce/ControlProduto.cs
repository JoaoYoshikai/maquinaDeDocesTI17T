using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoce
{
     class ControlProduto
    {
        Produto prod;

        private int opcao;
        public ControlProduto()
        {
            prod = new Produto();
            ModificarOpcao = -1;
        
        }// Fim do construtor


        //Metodo get set
        public int ModificarOpcao
        {
            get { return opcao; }
            set { opcao = value; }
        }//Fim do metodo get e set de opcao
        
      
        public void Menu()
        {
            
            Console.WriteLine("\n \n \nEscolha uma das opções abaixo: \n" +
                "0. Sair:\n "                                       +
                "1. Cadastrar um produto\n"                       +
                "2. Consultar um produto\n"                       +
                "3. Atualizar um produto\n"                       +
                "4. Mudar situação\n");
            ModificarOpcao = Convert.ToInt32(Console.ReadLine());
        }//fim do metodo menu

        //Realizar a operação switch case
        public void Operacao()
        {
            do
            {
                    Menu();//Mostrando o menu na tela
                switch (ModificarOpcao)
                {
               
                    case 0:
                        Console.WriteLine("Obrigado!");
                        Console.Clear();//Limpa tela
                        break;
                    case 1:
                        ColetarDados();
                        Console.Clear();//Limpa tela
                        break;
                    case 2:
                        Consultar();
                        Console.Clear();//Limpa tela
                        break;
                    case 3:
                        Atualizar();
                        Console.Clear();//Limpa tela
                        break;
                    case 4:                    
                        AlterarSituacao();
                        Console.Clear();//Limpa tela
                        break;
                    default:
                        Console.WriteLine("Insira uma opção válida!");
               
                        break;
                }//Fim do switch
        }while (ModificarOpcao != 0);

    }//Fim do metodo operacao
        
        
        
        
        
        
        //Criar um método de solicitação de dados
        public void ColetarDados()
        {
            //Coletar dados

            Console.WriteLine("Informe um código: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o nome do produto: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Faça uma breve descrição do produto: ");
            string descricao = Console.ReadLine();

            Console.WriteLine("Informe o preço do produto: ");
            double preco = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de produtos no estoque: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a data de validade do lote: ");
            DateTime dtValidade = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Informe a situação do produto(True - Ativo. False - Inativo): ");
            Boolean situacao = Convert.ToBoolean(Console.ReadLine());

            //Cadastrar produto
            prod.CadastrarProduto(codigo, nome, descricao, preco, quantidade, dtValidade, situacao);
            Console.WriteLine("Dado registrado!");
        }//Fim do coletarDados
        
        //Consultar
        public void Consultar()
        {
            Console.WriteLine("\n\n\nInforme o código que deseja consultar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            //Escrever o resultado na tela
            Console.WriteLine("Os dados do produto escolhido são: \n\n\n" + prod.ConsultarProduto(codigo));
        }//Fim do método consultar

        //Atualizar
        public void Atualizar()
        {
            Console.WriteLine("\n\nInforme o código do produto que deseja atualizar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            short campo = 0;
            do
            {
                Console.WriteLine("\n\nInforme o campo que deseja atualizar de acordo com a regra abaixo: \n" +
                    "1. Nome\n" +
                    "2. Descrição:\n" +
                    "3. Preço:\n" +
                    "4. Quantidade\n" +
                    "5. Data de validade: \n" +
                    "6. Situação\n");
            campo = Convert.ToInt16(Console.ReadLine());
                
                //Avisar o usuário
                
                if ((campo < 1) || (campo > 6))
                {
                    Console.WriteLine("Erro, escolha um código entre 1 e 6");
                }
            } while ((campo < 1) || (campo > 6));
           
            
            Console.WriteLine("Informe o dado para a atualização: ");
            string novoDado = Console.ReadLine();

            //Chamar o método de atualização
            prod.AtualizarProduto(codigo, campo, novoDado);
            Console.WriteLine("Alterado com sucesso");

            Console.ReadLine();//Manter a janela aberta
        }//Fim do método atualizar

        public void AlterarSituacao()
        {
            Console.WriteLine("Informe o código do produto que deseja alterar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            //Chamar o método AlterarSituacao - Classe produto
            prod.AlterarSituacao(codigo);
            Console.WriteLine("Alterado com sucesso");
        }//Fim de metodo alterar situacao


    }//Fim da classe
}//Fim do projeto
