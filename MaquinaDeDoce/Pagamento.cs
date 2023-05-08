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
        private int codigo;
        private string descricao;
        private double valorTotal;
        private int formaDePagamento;
        private DateTime data;
        private int codCartao;
        private int bandeiraCartao;

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
        }//Fim do ModificarValorTotal


        public DateTime ModificarData
        {
            get { return this.data; ; }
            set { this.data = value; }
        }//Fim do ModificarValorTotal












    }//Fim da classe
}//Fim do projeto
