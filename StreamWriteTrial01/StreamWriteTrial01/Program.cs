List<string[]> list = new List<string[]>
{
    new string[] { "これは1行目のテキストです。", "これは2行目のテキストです。" },
    new string[] { "これは3行目のテキストです。", "これは4行目のテキストです。" }
};

string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
string filePath = Path.Combine(desktopPath, "output.txt");

try
{
    using (var writer = new StreamWriter(filePath))
    {
        foreach (var array in list)
        {
            foreach (var line in array)
            {
                writer.WriteLine(line);
            }
        }
    }
}catch(Exception e)
{
    Console.WriteLine("例外が発生しました。詳細は以下のメッセージを参照してください。");
    Console.WriteLine(e.Message);
    Console.WriteLine("終了するにはエンターキーを押してください。");
    Console.ReadLine();
    return;
}

Console.WriteLine("ファイルがデスクトップに出力されました。");
Console.WriteLine("終了するにはエンターキーを押してください。");
Console.ReadLine();