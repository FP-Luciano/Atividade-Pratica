using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Pratica.Model
{
    internal class CalcMedia
    {
        public static decimal _Media = 7m;
        public decimal _maiorNota;
        public decimal _SomaNota;
        public decimal _MediaAluno;
        public decimal _nota01;
        public decimal _nota02;
        public string _resultado;

        public CalcMedia(decimal nota1, decimal nota2)
        {
            _nota01 = nota1;
            _nota02 = nota2;

            _SomaNota = nota1 + nota2;
            _MediaAluno = _SomaNota / 2;

            if (_MediaAluno >= _Media)
            {
                _resultado = "Aprovado";
            }
            else
            {
                _resultado = "Reprovado";
            }

            if (nota1 > nota2)
            {
                _maiorNota = nota1;
            }
            else
            {
                _maiorNota = nota2;
            }
        }

        public decimal Media
        {
            get => _MediaAluno;
            private set => _MediaAluno = value;
        }

        public decimal MaiorNota
        {
            get => _maiorNota;
            private set => _maiorNota = value;
        }
        public string Resultado
        {
            get => _resultado;
            private set => _resultado = value;
        }
        public Alunos Aluno { get; set; }
    }
}

