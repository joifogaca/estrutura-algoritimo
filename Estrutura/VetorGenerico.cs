using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estrutura_algoritimo.Estrutura
{
    public class VetorGenerico<T>
    {
        private T[] elementos;

        private int tamanho;
        public VetorGenerico(int capacidade)
        {
            this.tamanho = 0;
            elementos = new T[capacidade];
        }

        private void aumentaCapacidade()
        {
            if (this.tamanho == this.elementos.Length)
            {
                T[] elementosNovos = new T[this.elementos.Length * 2];
                for (int i = 0; i < this.elementos.Length; i++)
                {
                    elementosNovos[i] = this.elementos[i];
                }
                this.elementos = elementosNovos;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("[ ");

            // 0 1 2 3 4 5 6 = tamanho é 5
            // B C E F G + +
            for (int i = 0; i < tamanho - 1; i++)
            {

                sb.Append(elementos[i]);
                sb.Append(",");

            }

            if (tamanho > 0)
            {
                sb.Append(elementos[tamanho - 1]);
            }

            sb.Append("]");



            return sb.ToString();
        }

        public Boolean Adicionar(T value, int posicao)
        {
            this.aumentaCapacidade();
            if (!(posicao >= 0 && posicao < tamanho))
            {
                throw new ArgumentException("Posição Inválida!");
            }

            for (int i = tamanho; i >= posicao; i--)
            {
                this.elementos[i + 1] = this.elementos[i];
            }

            this.elementos[posicao] = value;
            this.tamanho++;

            return true;
        }

        public Boolean Adicionar(T value)
        {
            this.aumentaCapacidade();
            if (value == null)
            {
                return false;
            }

            if (tamanho < elementos.Length)
            {
                elementos[tamanho] = value;
                tamanho++;
                return true;
            }
            else
            {
                return false;
            }

        }

        public Object GetByIndex(int index)
        {
            if (index < 0 || index >= tamanho)
            {
                throw new ArgumentException("Posição Inválida!");
            }

            return elementos[index];
        }

        public int GetPositionBy(T element)
        {
           
            for (int i = 0; i < tamanho; i++)
            {
                if ((object)element == (object)elementos[i])
                {
                    return i;
                }
            }
            return -1;
        }

        // B G D E F
        //0 1 2 3 4
        public void removeAt(int pos)
        {

            if (!(pos >= 0 && pos < tamanho))
            {
                throw new ArgumentException("Posição Inválida!");
            }

            for (int i = pos; i < tamanho; i++)
            {
                this.elementos[i] = this.elementos[i + 1];
            }

            this.tamanho--;

        }



        public void remove(T element)
        {

            int pos = this.GetPositionBy(element);

            if (pos < 0)
            {
                throw new ArgumentException("Elemento" + element + "não existe no vetor");
            }

            this.removeAt(pos);
        }

    }
}
