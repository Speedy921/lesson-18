using lesson_18;

Console.WriteLine("********Fun with Polymorhism*****\n");

//зробимо массив сумісних з Shape обьектів
Sharpe[] myShapes = {new Hexagon(), new Circle(), new Hexagon("Mick"), new Circle("Beth"), new Hexagon("Linda") };

//пройдемо у циклі по усім елементам та провзаємодієм 
//з поліморфним інтерфейсом
foreach(Sharpe s in myShapes)
{
    s.Draw();
}

Console.ReadLine();

//приховування членів
//тут викликається метод Draw() классу ThreeDCircle
ThreeDCircle o = new ThreeDCircle();
o.Draw();

//тут викликається метод Draw(), батьківського классу
((Circle)o).Draw();

Console.ReadLine();