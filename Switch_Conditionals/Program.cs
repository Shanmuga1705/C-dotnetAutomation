int num = 60;

switch (num){
    case 50:
        Console.WriteLine("num is 50");
        break;
    case 51:
        Console.WriteLine("num is 51");
        break;
    case 52:
    case 53:
    case 54:
        Console.WriteLine("num is between 52 and 54");
        break;
    default:
        Console.WriteLine("num is Something else");
        break;
}
