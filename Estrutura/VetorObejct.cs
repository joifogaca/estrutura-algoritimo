using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estrutura_algoritimo.Estrutura
{
 
    public class VetorObejct
    {
        private Object[] array;

        private int tamanho;
        public VetorObejct(int capacidade)
        {
            this.tamanho = 0;
            array = new Object[capacidade];
        }



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("[ ");

            // 0 1 2 3 4 5 6 = tamanho é 5
            // B C E F G + +
            for (int i = 0; i < tamanho - 1; i++)
            {

                sb.Append(array[i]);
                sb.Append(",");

            }

            if (tamanho > 0)
            {
                sb.Append(array[tamanho - 1]);
            }

            sb.Append("]");



            return sb.ToString();
        }

        public Boolean Adicionar(Object value, int posicao)
        {

            if (!(posicao >= 0 && posicao < tamanho))
            {
                throw new ArgumentException("Posição Inválida!");
            }

            for (int i = tamanho; i >= posicao; i--)
            {
                this.array[i + 1] = this.array[i];
            }

            this.array[posicao] = value;
            this.tamanho++;

            return true;
        }

        public Boolean Adicionar(Object value)
        {
            if (value == null)
            {
                return false;
            }

            if (tamanho < array.Length)
            {
                array[tamanho] = value;
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

            return array[index];
        }

        public int GetPositionBy(Object element)
        {
            for (int i = 0; i < tamanho; i++)
            {
                if (element == array[i])
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
                this.array[i] = this.array[i + 1];
            }

            this.tamanho--;

        }



        public void remove(Object element)
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
