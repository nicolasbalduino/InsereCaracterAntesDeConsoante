string frase;
char insereAntes;

bool EhVogal(char letra)
{
    letra = char.ToLower(letra);
    char[] vogais = { 'a', 'e', 'i', 'o', 'u', 'á', 'é', 'í', 'ó', 'ú', 'ã', 'õ', 'ê', 'ô' };

    for (int i = 0; i < vogais.Length; i++)
        if (vogais[i] == letra)
            return true;

    return false;
}

string InsereAntes(string frase, char insereAntes)
{
    string aux = "\0";

    for (int i = 0; i < frase.Length; i++)
    {
        if (char.IsLetter(frase[i]) && !EhVogal(frase[i]))
            aux += insereAntes;
        aux += frase[i];
    }

    return aux;
}

Console.Write("Digite algo: ");
frase = Console.ReadLine();

Console.Write("Digite um caracter para inserir antes das consoantes: ");
insereAntes = char.Parse(Console.ReadLine());

Console.WriteLine($"Letras inseridas: {InsereAntes(frase, insereAntes)}");

