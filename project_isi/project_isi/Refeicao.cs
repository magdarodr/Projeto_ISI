using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ISI
{
    public class Refeicao
    {
        private string restaurante;
        private string item;
        private string quantidade;
        private int calorias;

        public Refeicao(string restaurante, string item, string quantidade, int calorias)
        {
            this.restaurante = restaurante;
            this.item = item;
            this.quantidade = quantidade;
            this.calorias = calorias;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return restaurante + " " + item + " " + quantidade + " " + calorias;
        }
    }
}
