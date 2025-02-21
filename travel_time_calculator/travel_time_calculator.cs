using System;
class TravelTimeCalculator{
    static void Main(){
        int time = 0;
        char choice;

        Console.WriteLine("Trip from Porto Alegre to Florianópolis");
        Console.WriteLine("Choose the transportation:");
        Console.WriteLine("1 - Car"+ "\n2 - Bus"+"\n3 - Plane");
        choice = char.Parse(Console.ReadLine());

        switch (choice){
            case '1':
                time = 5;
                break;
            case '2':
                time = 8;
                break;
            case '3':
                time = 1;
                break;
            default:
                time = -1;
                break;
        }
        if (time<0){
            Console.WriteLine("Invalid option");
        }
        else{
            Console.WriteLine("The trip will take {0} hour(s)", time);
        }
    }
}