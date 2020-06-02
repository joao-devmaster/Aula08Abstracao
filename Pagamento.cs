using System;

namespace Aulao8POO
{
    public class Pagamento
    {
        public DateTime data { get; set; }
        public float valor { get; set; }

        public string pagar(float valorPago){
            return "valor pago: R$"+valorPago;
        }

        public string Cancelar(){
            return "pagamento cancelado";
        }
    }
}