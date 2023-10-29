using DesafioPOO.Models;

Console.WriteLine("\n.::::: Testes com Smartphone Nokia :::::.\n");

Smartphone smartNokia = new Nokia("16999991111", "G60", "12345678964336", 128);
smartNokia.Ligar();
smartNokia.InstalarAplicativo("Instagram");
smartNokia.ReceberLigacao();

Console.WriteLine("\n\n.::::: Testes com Smartphone iPhone :::::.\n");

Smartphone smartIphone = new Iphone("16999992222", "15 Pro Max", "14569825646426", 512);
smartIphone.Ligar();
smartIphone.InstalarAplicativo("Whatsapp");
smartIphone.ReceberLigacao();

Console.WriteLine("\n.:::::::::::::::::: Fim ::::::::::::::::::.\n");