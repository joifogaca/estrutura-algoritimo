using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace estrutura_algoritimo.Model
{
    public class Contato
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public String Telefone { get; set; }


        public override bool Equals(object obj)
        {
            //       
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237  
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Contato contato = obj as Contato;

            if (this.Nome != contato.Nome)
            {
                return false;
            }

            if (this.Email != contato.Email)
            {
                return false;
            }

            if (this.Telefone != contato.Telefone)
            {
                return false;
            }

            // TODO: write your implementation of Equals() here

            return true;
        }

        public override string ToString()
        {
            return $"[ Nome {this.Nome}, Email: {this.Email}, Telefone: {this.Telefone}. ]";
        }

        public override int GetHashCode()
        {
            int hash = HashCode.Combine(Nome, Email, Telefone);
            return hash;
        }
    }

        // override object.GetHashCode
  
}
