using System;

class Robot {
    public String Name;
    public String Move;

    public Robot(String name) {
        Name = name;
        Console.WriteLine("로봇 이름은 " + name + "입니다.");
    }

    public Robot(String name, String move){
        Name = name;
        Move = move;
        Console.WriteLine(name + "이(가) " +  move + "를 합니다.");
    }

    //public CleanRobot : Robot (String name, String move){
    //    Name = name;
    //    Console.WriteLine(name + "이(가)" + move);
    //}
}


class MainClass {
    public static void Main(string[] args){
        Robot robot1 = new Robot("홀리몰리");
        Robot robot2 = new Robot("피카츄", "청소");
    }
}