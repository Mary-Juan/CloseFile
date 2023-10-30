void Test1()
{
    string filePath = @"c:\iman.txt";
    FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
    var txt = fs.ReadByte();

    fs.Close();

}

 void Test2()
{
    string filePath = @"c:\iman.txt";
    FileStream fs = null;
    try
    {
        fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
        var txt = fs.ReadByte();
    }
    finally
    {
        fs?.Close();
    }
}
