using System;
class MainClass {
    public static void Main(string[] args){
        //for(int i = 1; i <= 10; i++) Console.WriteLine(i);
        int i = 1;
        while (true)
        {
            Console.WriteLine(i);
            i++;

            if (i > 10) break;
        }
    }
}