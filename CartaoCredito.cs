using System;

namespace Aulao8POO
{
    public class CartaoCredito : Cartao
    {
        public float limite { get; set; }

        public void AumentarLimite(float acrescimo){
            limite = limite + acrescimo;
        }
    }
}