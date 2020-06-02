using System;

namespace Aulao8POO
{
    public class Boleto : Pagamento
    {
        public DateTime DataVencimento {get; set; }
        public string BancoEmissor  {get; set; }
        public string CodDeBarras  {get; set; }

        public string Registrar(){
            return"boleto registrado com sucesso";

            
        }
    }
} 