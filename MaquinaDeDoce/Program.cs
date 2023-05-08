using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoce
{
     class Program
    {
        static void Main(string[] args)
        {
           //Conceta com a calsse control produto
            ControlProduto controlProd= new ControlProduto();

            //Chamar o método principal daquela classe
            controlProd.Operacao();






            //Console.ReadLine();//Manter a janela aberta
        }//fim do método main
    }//Fim da classe
}//Fim do projeto
