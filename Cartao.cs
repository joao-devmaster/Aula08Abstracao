using System;

namespace Aulao8POO
{
    public class Cartao : Pagamento
    {
        protected string token = "djhudbfhdc#%#$EDFREX$%^&*";
        public string titular  {get; set; }
        public int numero  {get; set; }
        public string cvv  {get; set; }
        public string bandeira  {get; set; }

        public bool ValidarToken(){
            if(token != null){
                return true;
            }
            return false;
        }
    }
}