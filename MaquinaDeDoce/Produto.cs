using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoce
{
     class Produto
    {
        //Definição de variáveis
        private int codigo;
        private string nome;
        private string descricao;
        private double preco;
        private int quantidade;
        private DateTime dtValidade;
        private Boolean situacao;

        //Método construtor
        public Produto() 
        {
            ModificarCodigo = 0;
            ModificarNome = "";
            ModificarDescricao = "";
            ModificarPreco = 0;
            ModificarQuantidade = 0;
            ModificarDtValidade = new DateTime(); // 0000/00/00 00:00
            ModificarSituacao = false;
        }//Fim do método construtor 
    public Produto(int codigo, string nome, string descricao, double preco, int quantidade, DateTime dtValidade, Boolean situacao)
        {
            ModificarCodigo = codigo;
            ModificarNome = nome;
            ModificarDescricao = descricao;
            ModificarPreco = preco;
            ModificarQuantidade = quantidade;
            ModificarDtValidade = dtValidade;
            ModificarSituacao = situacao;
        }//Fim do método construtor com parâmetros
        
        //Métodos get e set
        //Métodos de acesso e modificação
        public int ModificarCodigo
        {
            get {
                return this.codigo;
            }//fim do get - retornar o código
            set {
                this.codigo = value;
            }//Fim do set - modificar o código       
        }//Fim do modificar código

        public string ModificarNome
        {
            get { return this.nome;}
            set { this.nome = value;
        }}

        public string ModificarDescricao
        {
            get { return this.descricao; }
            set { this.descricao = value; }
        }
        public int ModificarQuantidade
        { 
            get { return this.quantidade;}
            set { this.quantidade = value;}
        }

        public DateTime ModificarDtValidade
        {
            get { return this.dtValidade;}
            set { this.dtValidade = value;}
        }

        public Boolean ModificarSituacao
        {
            get { return this.situacao; }
            set { this.situacao = value;}
        }
    
        public double ModificarPreco
        {
            get { return this.preco; }
            set { this.preco = value;}
        }

        //Método cadastrar produto
        public void CadastrarProduto(
        int codigo,
        string nome,
        string descricao,
        double preco,
        int quantidade,
        DateTime dtValidade,
        Boolean situacao
        )

        {
            ModificarCodigo      = codigo;
            ModificarNome        = nome;
            ModificarDescricao   = descricao;
            ModificarPreco       = preco;
            ModificarDtValidade  = dtValidade;
            ModificarSituacao    = situacao;
        }//Fim do metodo cadastrar produto

        //Consultar produto
        public string ConsultarProduto(int codigo)
        {
            string msg = "";//Criando uma variavel local
            if (ModificarCodigo == codigo)
            {
                msg = "\n código:" + ModificarCodigo +
                      "\n Nome:" + ModificarNome +
                      "\n Descrição" + ModificarDescricao +
                      "\n Preço:" + ModificarPreco +
                      "\n Quantidade:" + ModificarQuantidade +
                      "\n Data de Validade:" + ModificarDtValidade +
                      "\n Situação:" + ModificarSituacao;
            } else
            {
                msg = "O código digitado não existe";
            }
            return msg;
        }//Fim do metodo

        //Método atualizar
        public Boolean AtualizarProduto(int codigo, int campo, string NovoDado)
        {
            Boolean flag = false;
            if (ModificarCodigo == codigo )
            {
                switch (campo)
                {
                    case 1:
                        ModificarNome = NovoDado;
                        flag = true;
                        break;
                        
                    case 2:
                        ModificarDescricao= NovoDado;
                        flag = true;
                        break;
                    case 3:
                        ModificarPreco = Convert.ToDouble(NovoDado);
                        flag = true;
                        break;
                    case 4:
                        ModificarQuantidade = Convert.ToInt32(NovoDado);
                        flag= true;
                        break;
                    case 5:
                        ModificarDtValidade = Convert.ToDateTime(NovoDado);
                        flag= true;
                        break;
                    case 6:
                        ModificarSituacao = Convert.ToBoolean(NovoDado);
                        flag= true;
                        break;
                    default:
                        break;
                }//fim da escolha
                return flag;
            }//Fim do if
            return flag;
        }//Fim do atualizar produto
        
        public Boolean AlterarSituacao(int codigo)
        {
            Boolean flag = false;
            
            if (ModificarCodigo == codigo)
            {
                if (ModificarSituacao == true)
                { 
                    ModificarSituacao= false;
                }
                else
                {
                    ModificarSituacao = true;
                }//fim do modificar situacao
                flag = true;
            }// fim do modificar codigo
            return flag;
        }// Fim do Alterar situacao

        // Solicitar Produtos
        public Boolean SolicitarProduto(int codigo)
        {
            if (ModificarCodigo == codigo)
            {

                if (ModificarQuantidade <= 3)
                {
                    return true;
                }// fim do if
            }
                return false;
            
        }//Fim do solicitar produto









    }//Fim da classe
}// Fim do projeto
