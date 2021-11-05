namespace Carro.Objeto
{
    public class Carros
    {
        public Carros(string modelo, int quantidadePortas)
        {
            Modelo = modelo;
            QuantidadePortas = quantidadePortas;
        }

        public string Modelo { get; set; }
        public int QuantidadePortas {get; set;}
    }
}