using System;
using System.Collections.Generic;
using System.Text;

public class SafeCalculator
{
    public void Divide(string num1, string num2)
    {
        try
        {
            int result = int.Parse(num1) / int.Parse(num2);

            Console.WriteLine($"{num1} / {num2} = {result}");
        }
        catch(FormatException)
        {
            Console.WriteLine("올바른 숫자를 입력하세요.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("0으로 나눌 수 없습니다.");
        }
        finally
        {
            Console.WriteLine("계산기를 종료합니다.");
        }
    }

}

