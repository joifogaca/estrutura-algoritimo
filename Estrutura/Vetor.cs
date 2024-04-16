using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estrutura_algoritimo.Estrutura
{
    public class Vetor
    {
        private string[] array;

        private int posicaoAtual;
        public Vetor(int _tamanho)
        {
            this.posicaoAtual = 0;
            array = new string[_tamanho];  
        }

        public int Tamanho()
        {
            return this.posicaoAtual;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("[ ");

            // 0 1 2 3 4 5 6 = tamanho é 5
            // B C E F G + +
            for (int i = 0;i < this.Tamanho() -1; i++)
            {
               
                sb.Append(array[i]);
                sb.Append(",");

            }

            if (Tamanho() > 0) { 
             sb.Append(",");
                sb.Append(array[Tamanho() -1]);
            }

            sb.Append("]");



            return sb.ToString();
        }

        public Boolean Adicionar(string value) 
        { 
            if(posicaoAtual < array.Length)
            {
                array[posicaoAtual] = value;
                posicaoAtual++;
                return true;
            }
            else
            {
                return false;
            }
        
        }

        public String GetByIndex(int index) {
            if (index < 0 || index <= Tamanho())
            {
                throw new ArgumentException("Posição Inválida!");
            }

            return array[index];
        }

        public int GetPositionBy(string element) {
        for (int i = 0; i < Tamanho(); i++) {
                if (element == array[i]) { 
                return i;
                }
            }
        return -1;
        }
    }
}
