namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }

        // TODO: Sobrescrever o método "InstalarAplicativo" - feito

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.Clear();
            Console.WriteLine("Instalando o Aplicativo:  " + nomeApp);
        }
    }
}