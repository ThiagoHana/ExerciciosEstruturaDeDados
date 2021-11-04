using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._1_Funcionario_ED
{
    public class Funcionario
    {
        private string nome;
        private double salario;

        public void SetNome(string valor) 
        {
            if (string.IsNullOrEmpty(valor))
                throw new Exception("Nome Obrigatorio");
            nome = valor;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetSalario(double valor)
        {
            if (valor < 0)
            {
                throw new Exception("Salario Não pode ser Negativo");
            }
            else
                salario = valor;
        }

        public double GetSalario()
        {
            return salario;
        }
    }
}
