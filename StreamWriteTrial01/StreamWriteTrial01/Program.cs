List<string[]> list = new List<string[]>
{
    new string[] { "これは1行目のテキストです。", "これは2行目のテキストです。" },
    new string[] { "これは3行目のテキストです。", "これは4行目のテキストです。" }
};

string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
string filePath = Path.Combine(desktopPath, "output.txt");

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

Console.WriteLine("ファイルがデスクトップに出力されました。");