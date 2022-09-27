namespace Devs2Blu.ProjetosAula.Classes
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }

        //método
        public string AprensentarNomeCustom()
        {
            string nomeCustom;
            nomeCustom = $"{Sobrenome}, { Nome}";
            
            return nomeCustom;
        }

    }
}