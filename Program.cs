using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone i1 = new Iphone("6789998212", "iPhone 6e", "2612", 128);
i1.InstalarAplicativo("Telegram");
i1.Ligar();

Nokia n1 = new Nokia("67348824", "Nokia E20", "1226", 256);
n1.ReceberLigacao();
n1.InstalarAplicativo("WhatsApp");