namespace TheCypher01
{
    public class Criptografar : Dicionario
    {
        public static string criptografarTexto(string texto)
        {
            texto = texto.ToLower();
            for (int i = 0; i < texto.Length; i++)
            {
                foreach (KeyValuePair<string, string> letras in dicionarios)
                {
                    if (texto.Substring(i, 1).Equals(letras.Key))
                    {
                        texto = texto.Replace(texto.Substring(i, 1), dicionarios[texto.Substring(i, 1)]);
                    }
                }
            }

            return texto;
        }
    }
}
