

namespace Baralho
{
    public class Carta
    {
        public string Naipe { get; set; }
        public int Numero { get; set; }
        Carta()
        {
            Naipe = "Carta em Branco";
            Numero = 0;
        }
        Carta(string nai, int num)
        {
            Naipe = nai;
            Numero = num;
        }

        public string Nome_da_carta(string nai, int num)
        {
            string nome = " ";
            if (num < 11)
            {
                nome = nai + num;
            }
            switch (num)
            {
                case 11:
                    nome = "Valete de " + nai;
                    break;
                case 12:
                    nome = "Dama de " + nai;
                    break;
                case 13:
                    nome = "Rei de " + nai;
                    break;
            }

            return nome;
        }
    }
}
