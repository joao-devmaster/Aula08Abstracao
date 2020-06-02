using System;

namespace Aulao8POO

{
    public class CartaoDebito : Cartao
    {
        public float saldo  {get; set; }

        public string Transferir(){
            return "transferencia efetuada";
        }
    }
}