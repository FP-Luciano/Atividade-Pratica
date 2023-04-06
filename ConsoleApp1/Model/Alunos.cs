using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Pratica.Model
{
    public class Alunos
    {
        public string _nome;
        public decimal _matricula;
        public decimal _nota1;
        public decimal _nota2;

        public Alunos(string nome, decimal matricula)
        {
            _nome = nome;
            _matricula = matricula;

        }
        public Alunos(decimal nota1, decimal nota2, Alunos aluno)
        {
            _nota1 = nota1;
            _nota2 = nota2;
        }

        public string Nome
        {
            get => _nome;
            private set => _nome = value;
        }
        public decimal Matricula
        {
            get => _matricula;
            private set => _matricula = value;
        }
        public decimal Nota1
        {
            get => _nota1;
            private set => _nota1 = value;
        }
        public decimal Nota2
        {
            get => _nota2;
            private set => _nota2 = value;
        }
    }
}


