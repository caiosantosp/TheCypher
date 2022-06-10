namespace TheCypher01
{
    public class Descriptografar : Dicionario
    {
        public static string descriptografarTexto(string texto)
        {
            texto = texto.ToLower();
            for (int i = 0; i < texto.Length; i++)
            {
                foreach (KeyValuePair<string, string> letras in dicionarios)
                {
                    if (texto.Contains(letras.Value))
                    {
                        texto = texto.Replace(letras.Value, letras.Key);
                    }
                }
            }

            return texto;
        }

    }
}
