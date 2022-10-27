namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar(string numero)
        {
            Console.WriteLine($"Ligando para {numero}");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação anônima...");
        }
        public void ReceberLigacao(string numero)
        {
            Console.WriteLine($"Recebendo ligação de {numero}");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}