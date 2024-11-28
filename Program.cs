using System;

class Robot {
    public void Move() 
    {
        Console.WriteLine("로봇이 움직입니다.");
    }
}

class CleanRobot : Robot
{
    public void Clean() { 
        Console.WriteLine("로봇이 청소를 합니다.");
    }
}

class CookingRobot : Robot
{
    public void Cooking()
    {
        Console.WriteLine("로봇이(가) 요리를 합니다.");
    }
}


class MainClass {
    public static void Main(string[] args){
        CleanRobot clbot = new CleanRobot();
        CookingRobot ckbot =new CookingRobot();
        clbot.Move();
        clbot.Clean();
        ckbot.Cooking();
    }
}