using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


class FilePathValidator
{
    public void ValidatePath(string path)
    {
        if (string.IsNullOrEmpty(path))
        {
            throw new ArgumentNullException("", "[ArgumentNull 오류] 경로는 null이거나 비어있을 수 없습니다.");
        }

        char[] invalidChars = { '<', '>', '|', '"', '*', '?' };

        foreach (char invalidChar in invalidChars)
        {
            foreach(char c in path)
            {
                if (c == invalidChar)
                {
                    throw new ArgumentException($"[Argument 오류] 경로에 금지 문자 '{invalidChar}'가 포함되어 있습니다.");
                }
            }
        }

        if (path.Length > 260)
        {
            throw new ArgumentOutOfRangeException("", "[ArgumentOutOfRange 오류] 경로 길이가 260자를 초과합니다.");
        }

        Console.WriteLine($"경로가 유효합니다: {path}");
    }

    public void ValidateExtension(string path, string[] allowedExtensions)
    {
        string extension = Path.GetExtension(path);

        bool isAllowed = false;

        foreach (string allowedExtension in allowedExtensions)
        {
            if (allowedExtension == extension)
            {
                isAllowed = true;
                break;
            }
        }

        if (isAllowed == false)
        {
            throw new ArgumentException($"[Argument 오류] 허용되지 않은 확장자입니다: {extension}");
        }

        Console.WriteLine($"확장자가 유효합니다: {extension}");
    }
}