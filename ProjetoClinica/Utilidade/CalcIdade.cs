using System;
using ProjetoClinica.Context;

namespace ProjetoClinica.Utilidade
{
    public class CalcIdade
    {
         


        public static int CalcularIdadeCliente(int _clienteId)
        {
            int anoAtual = DateTime.Now.Year;
            projeto_clinicaContext context = new projeto_clinicaContext();
            var cliente = context.tb_cliente.Find(_clienteId);
            var anoNasc = Convert.ToDateTime(cliente.cl_data_nascimento);
            int anoNascInt = anoNasc.Year;
            int idade = anoAtual - anoNascInt;

            if (DateTime.Now < anoNasc.AddYears(idade))
            {
                idade--;
            }

            return idade;
        }

        public static int CalcularIdadeFuncionario(int _funcionarioId)
        {
            int anoAtual = DateTime.Now.Year;
            projeto_clinicaContext context = new projeto_clinicaContext();
            var funcionario = context.tb_funcionarios.Find(_funcionarioId);
            var anoNasc = Convert.ToDateTime(funcionario.fun_DataNascimento);
            int anoNascInt = anoNasc.Year;
            int idade = anoAtual - anoNascInt;

            if (DateTime.Now < anoNasc.AddYears(idade))
            {
                idade--;
            }

            return idade;
        }




    }
}
