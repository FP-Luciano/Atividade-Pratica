using Atividade_Pratica.Model;

Alunos aluno = new Alunos("Neilson Santos", 202110508);
Alunos alunoNotas = new Alunos(7.5m, 8.0m, aluno);
CalcMedia Media = new CalcMedia(alunoNotas.Nota1, alunoNotas.Nota2);

Console.WriteLine($"Aluno: {aluno.Nome}, Matricula: {aluno.Matricula} \n" +
    $"Primeira nota: {Media._nota01} \n" +
    $"Segunda nota: {Media._nota02} \n" +
    $"Média do aluno {aluno.Nome}: {Media.Media} \n" +
    $"Maior nota: {Media.MaiorNota} \n" +
    $"O aluno está {Media.Resultado}");