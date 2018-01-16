using System;
using SourceConsole.Templates;

namespace SourceConsole
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ViewT tt = new ViewT();
            string fileOut = tt.TransformText();
            System.IO.File.WriteAllText("View.cs", fileOut);  
        }
    }
}
