
namespace Baralho
{
    public class Monte
    {
        private List<Carta> Cartas_no_monte = new List<Carta>();
        private List<Carta> Cartas_Sortedas = new List<Carta>();
        private int Total_cartas_no_monte = 52;
        private int Total_cartas_sortedas = 0;

        public Monte()
        {
            Embaralhar();
        }
            

        public void Embaralhar()
        {
            for(int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 14; j++)
                {
                    int mul = i * j;
                    switch (i)
                    {
                        case 1:
                            Cartas_no_monte[mul].Naipe = "Ouros";
                            break;

                        case 2:
                            Cartas_no_monte[mul].Naipe = "Espadas";
                            break;
                        case 3:
                            Cartas_no_monte[mul].Naipe = "Copas";
                            break;
                        case 4:
                            Cartas_no_monte[mul].Naipe = "Paus";
                            break;
                    }
                    Cartas_no_monte[mul].Numero = j; 
                }
            }
        }
            

    }
}
