namespace MacorattiOOP.Entities
{
    public static class StringExtensions
    {
        public static string FirstThreeWords(this string texto)
        {
            return texto.Substring(0, 3).ToUpper();
        }
    }
}
