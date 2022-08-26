// See https://aka.ms/new-console-template for more information
using AtividadeLambida;
Console.WriteLine("Hello, World!");

Autor autor1 = new Autor("Micael", "Micae@hotmail.com");
Autor autor2 = new Autor("Bruno", "Bruno@hotmail.com");
Autor autor3 = new Autor("Naira", "Naira@hotmail.com");

List<Autor> autores = new List<Autor>();
autores.Add(autor1);
autores.Add(autor2);
autores.Add(autor3);

List<Autor> autores2 = new List<Autor>();
autores2.Add(autor2);
autores2.Add(autor3);

List<string> palavrasChaves1 = new List<string>();
palavrasChaves1.Add("IA");
palavrasChaves1.Add("Musica");
palavrasChaves1.Add("Spotify");

List<string> palavrasChaves2 = new List<string>();
palavrasChaves1.Add("Arquitetura");
palavrasChaves1.Add("Computação");

Artigo artigo1 = new Artigo("Recomendação de música", palavrasChaves1, "Senai", autores);
Artigo artigo2 = new Artigo("Arquitetura de computadores", palavrasChaves2, "Senai", autores2);
Artigo artigo3 = new Artigo("Recomendações Spotify", palavrasChaves1, "Senai", autores);

List<Artigo> artigos = new List<Artigo>();
artigos.Add(artigo1);
artigos.Add(artigo2);
artigos.Add(artigo3);

System.Console.WriteLine("Informe a palavra chave");
string palavraChave = Console.ReadLine();
List<Artigo> artigosFiltrados = new List<Artigo>();
foreach (var artigo in artigos)
{
    if(artigo.PalavrasChaves.Exists(p => p == palavraChave)){
        artigosFiltrados.Add(artigo);
    }
}
foreach (var artigoFiltrado in artigosFiltrados)
{
    System.Console.WriteLine(artigoFiltrado);
}