using System;
using SourceConsole.Templates;

namespace SourceConsole
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string screenName;
            string projectName;

            if (args.Length > 0)
            {
                screenName = args[0];
                projectName = args[1];
            }
            else
            {
                Console.Write("Screen Name:");
                screenName = Console.ReadLine();
                Console.Write("Project Name:");
                projectName = Console.ReadLine();
            }
            var screenData = new TemplateDataModel(screenName, projectName);

            ViewTemplate viewTemplate = new ViewTemplate(screenData);
            string fileOut = viewTemplate.TransformText();
            System.IO.File.WriteAllText(screenData.ViewName + ".xaml", fileOut);  

            ViewCodeBehindTemplate viewCodeBehindTemplate = new ViewCodeBehindTemplate(screenData);
            string viewCodeBehindOut = viewCodeBehindTemplate.TransformText();
            System.IO.File.WriteAllText(screenData.ViewName + ".cs", viewCodeBehindOut);
        }
    }
}
