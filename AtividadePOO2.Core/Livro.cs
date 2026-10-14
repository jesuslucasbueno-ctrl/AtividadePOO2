using System;

namespace AtividadePOO2.Core;

public class Livro
{
    public int DataLivro { get; private set; }
    public string Titulo { get; private set; }
    public string Autor { get; private set; }
    public string Genero { get; private set; }
    public string DataDeLancamento { get; private set; }
    public string Idioma { get; private set; }

    public Livro(
        int dataLivro,
        string titulo,
        string autor,
        string genero,
        string dataDeLancamento,
        string idioma)
    {
        ValidarDataLivro(dataLivro);
        ValidarTitulo(titulo);
        ValidarAutor(autor);
        ValidarGenero(genero);
        ValidarDataDeLancamento(dataDeLancamento);
        ValidarIdioma(idioma);
    }

    private void ValidarDataLivro(int dataLivro)
    {
        if (dataLivro <= 0)
            throw new ArgumentException("O ano do livro é inválido.");

        DataLivro = dataLivro;
    }

    private void ValidarTitulo(string titulo)
    {
        if (string.IsNullOrWhiteSpace(titulo))
            throw new ArgumentException("O título é obrigatório.");


        Titulo = titulo;
    }

    private void ValidarAutor(string autor)
    {
        if (string.IsNullOrWhiteSpace(autor))
            throw new ArgumentException("O autor é obrigatório.");

       

        Autor = autor;
    }

    private void ValidarGenero(string genero)
    {
        if (string.IsNullOrWhiteSpace(genero))
            throw new ArgumentException("O gênero é obrigatório.");

        Genero = genero;
    }

    private void ValidarDataDeLancamento(string dataDeLancamento)
    {
        if (string.IsNullOrWhiteSpace(dataDeLancamento))
            throw new ArgumentException(
                "A data de lançamento é obrigatória.");


        DataDeLancamento = dataDeLancamento;
    }

    private void ValidarIdioma(string idioma)
    {
        if (string.IsNullOrWhiteSpace(idioma))
            throw new ArgumentException("O idioma é obrigatório.");

        Idioma = idioma;
    }
}