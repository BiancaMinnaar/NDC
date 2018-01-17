using System;
using SourceConsole.Templates;

namespace SourceConsole
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ViewTemplate tt = new ViewTemplate(new TemplateDataModel(){ClassName="LoginView"});
            string fileOut = tt.TransformText();
            System.IO.File.WriteAllText("View.cs", fileOut);  
        }
    }
}
