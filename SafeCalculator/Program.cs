#nullable enable
using System;

// README.md를 읽고 코드를 작성하세요.

SafeCalculator calc = new SafeCalculator();

string? input1 = Console.ReadLine();
string? input2 = Console.ReadLine();

Console.WriteLine("=== 테스트 1: 정상 입력 ===");

calc.Divide(input1, input2);

Console.WriteLine("\n=== 테스트 2: 0으로 나누기 ===");

input1 = Console.ReadLine();
input2 = Console.ReadLine();

calc.Divide(input1, input2);

Console.WriteLine("\n=== 테스트 3: 잘못된 형식 ===");

input1 = Console.ReadLine();
input2 = Console.ReadLine();

calc.Divide(input1, input2);
