using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoce
{
    class Pagamento
    {
       //Declarando variáveis.
        Produto prod;
        private int codigo;
        private string descricao;
        private double valorTotal;
        private int formaDePagamento;
        private DateTime data;
        private int codCartao;
        private int bandeiraCartao;
        double trocoDisponivel;

        public Pagamento(int codigo, string descricao, double valorTotal, int formaDePagamento, DateTime data, int codCartao, int bandeiraCartao)
        {
            ModificarCodigo = codigo;
            ModificarDescricao = descricao;
            ModificarValorTotal = valorTotal;
            ModificarFormaDePagamento = formaDePagamento;
            ModificarData = data;
            ModificarCodCartao = codCartao;
            ModificarBandeiraCartao = bandeiraCartao;
        }//Fim do método construtor por parametros

        public int ModificarCodigo
        {
            get { return this.codigo; ; } set { this.codigo = value; }
        }//Fim do ModificarCodigo

        public string ModificarDescricao
        {
            get { return this.descricao; ; }
            set { this.descricao = value; }
        }//Fim do ModificarDescricao

        public double ModificarValorTotal
        {
            get { return this.valorTotal; ; }
            set { this.valorTotal = value; }
        }//Fim do ModificarValorTotal

        public int ModificarFormaDePagamento
        {
            get { return this.formaDePagamento; ; }
            set { this.formaDePagamento = value; }
        }//Fim do ModificarFormaDePagamento


        public DateTime ModificarData
        {
            get { return this.data; ; }
            set { this.data = value; }
        }//Fim do ModificarValorTotal

        public int ModificarCodCartao
        {
            get { return this.codCartao; }
            set { this.codCartao = value; }
        }//Fim do ModificarCodCartao

        public int ModificarBandeiraCartao
        {
            get { return this.bandeiraCartao;}
            set { this.bandeiraCartao = value;}
        }//Fim do ModificarBandeiraCartao

        //Metodo cadastrar pagamento

        
        public void CadastrarPagamento(int codigo, string descricao, double valorTotal, DateTime data, int codCartao, int bandeiraCartao, int formaDePagamento)
        {
            ModificarBandeiraCartao = bandeiraCartao;
            ModificarData = data;
            ModificarCodigo= codigo;
            ModificarFormaDePagamento = formaDePagamento;
            ModificarValorTotal= valorTotal;
            ModificarDescricao= descricao;
            trocoDisponivel = valorTotal + trocoDisponivel - prod.ModificarPreco;
        }//Fim do metodo cadastrar produto

        public string ConsultarPagamento(int codigo)
        {
            string msg = "";//Declarando uma variável local
            if (codigo == ModificarCodigo)
            {
                msg = "\n A descrição do pagamento:" + ModificarDescricao    +
                      "\n A forma de pagamento:" + ModificarFormaDePagamento +
                      "\n A data do pagamento:" + ModificarData              +
                      "\n O valor total: " + ModificarValorTotal             +
                      "\n O Codigo do Cartao:" + ModificarCodCartao          +
                      "\n A bandeira do cartão:" + ModificarBandeiraCartao;
            }
            else
            {
                msg = "Erro, o código não existe!";
            }
            return msg;
        }//Fim do metodo ConsultarPagamento

        //Método atualizar pagamento
        public Boolean AtualizarPagamento(int codigo, int campo, string novoDado)
        {
            Boolean flag = false;
            if (ModificarCodigo == codigo)
            {
                switch(campo)
                { case 1:
                        ModificarDescricao = novoDado;
                        flag = true;
                        break;
                  case 2:
                        ModificarData = Convert.ToDateTime(novoDado);
                        flag = true;
                        break;
                  case 3:
                        ModificarValorTotal = Convert.ToDouble(novoDado);
                        flag = true;
                        break;
                  case 4:
                        ModificarFormaDePagamento = Convert.ToInt16(novoDado);
                        flag = true;
                        break;
                  case 5:
                        ModificarCodCartao = Convert.ToInt16(novoDado);
                        flag = true;
                        break;
                  case 6:
                        ModificarBandeiraCartao = Convert.ToInt16(novoDado);
                        flag = true;
                        break;
                    default:
                        break;
                }// Fim do escolha
                return  flag;
            }//Fim do If
            return flag;
        }//Fim do metodo AtualizarPagamento


        //Criando metodo valiar cartão

        public string ValidarCartao(int sistemaExterno)
        {
            string msg = "";// Declarando variável local
            if(sistemaExterno == 1)
            {
                msg = "Pagamento aprovado";
            }
            else
            {
                msg = "Pagamento recusado";               
            }//Fim do if
            return msg;
        }//Fim do metodo ValidarCartao

        public string VerificarTroco()
        {
            string msg = "";
            int trocoMinimo = 50;
            if (trocoMinimo > trocoDisponivel)
            {
                msg = "Troco requer reposição";
            }
            else
            {
                msg = "Troco disponível";
            }//Fim do If
            return msg;
        }//Fim do metodo VerificarTroco 
        
        















    }//Fim da classe
}//Fim do projeto
