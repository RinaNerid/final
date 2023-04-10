string[] ar1 = new string[5] {"456567", "2", "world ",  "c:", ":c"};
string str = ("");
for (int i = 0; i < ar1.Length; i++)
    {
    if(ar1[i].Length <= 3)
        {
       str = str + ar1[i] + (";");
        } 
    }
str = str.Trim( new Char[] {';'} );
string[] ar = str.Split(";");
Console.WriteLine (string.Join(Environment.NewLine, ar, 0, ar.Length));