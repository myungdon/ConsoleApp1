using System;

public class MainClass
{
    public static void Main() {
        Console.WriteLine("나눌 숫자를 입력하세요: ");
        int num = int.Parse(Console.ReadLine());

        try{
            Console.WriteLine(10 / num);
        } catch(Exception ex) {
            Console.WriteLine("예외 상황 : " + ex.Message);
        }
    } 
}