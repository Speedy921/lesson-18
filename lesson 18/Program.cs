using lesson_18;

Console.WriteLine("********Fun with Polymorhism*****\n");
Hexagon hex = new Hexagon("Beth");
hex.Draw();
Circle cir = new Circle("Cindy");
//викликає реалізацію базового класу
cir.Draw();
Console.ReadLine();