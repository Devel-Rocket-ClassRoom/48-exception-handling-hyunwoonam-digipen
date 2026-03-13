using System;

// README.md를 읽고 아래에 코드를 작성하세요.

FilePathValidator filePathValidator = new FilePathValidator();

string[] paths =
{
    "C:/Users/data/report.txt",
    "",
    "C:/Users/data/<report.txt",
    new string('a', 261)
};

string[] allowedExtensions = { ".txt", ".csv" };
string[] extensionTests = { "aaaa.txt", "bbbb.csv", "cccc.exe" };

Console.WriteLine("=== 경로 검증 테스트 ===");

foreach (string path in paths)
{
    try
    {
        filePathValidator.ValidatePath(path);
    }
    catch (ArgumentNullException ex)
    {
        Console.WriteLine($"{ex.Message}");
    }
    catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine($"{ex.Message}");
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine($"{ex.Message}");
    }
}

Console.WriteLine("\n=== 확장자 검증 테스트 ===");

foreach (string path in extensionTests)
{
    try
    {
        filePathValidator.ValidateExtension(path, allowedExtensions);
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine($"{ex.Message}");
    }
}
