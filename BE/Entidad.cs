using System;
using System.Linq;

namespace BE
{
    public class Entidad : IEntidad
    {
        private static Random random = new Random();
        public string ID { get; set; }

        public string generateID()
        {

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 10)
                .Select(s => s[random.Next(s.Length)]).ToArray());

        }

        public string GenerateOnlyNumberID()
        {
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, 10)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
