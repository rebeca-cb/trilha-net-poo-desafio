namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone" - feito
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo" - feito
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.Clear();
            Console.WriteLine("Instalando o app:  " + nomeApp);
        }


    }
}