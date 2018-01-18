using System;
using SourceConsole.Templates;

namespace SourceConsole
{
    class MainClass
    {
        static void generateClass(TemplateDataModel screenData, ITemplate template, string fileName)
        {
            string templateOutput = template.TransformText();
            System.IO.File.WriteAllText(fileName, templateOutput);
        }

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
            generateClass(screenData, viewTemplate, screenData.ViewName + ".xaml");

            ViewCodeBehindTemplate viewCodeBehindTemplate = new ViewCodeBehindTemplate(screenData);
            generateClass(screenData, viewCodeBehindTemplate, screenData.ViewName + ".cs");

            ViewControllerTemplate viewControllerTemplate = new ViewControllerTemplate(screenData);
            generateClass(screenData, viewControllerTemplate, screenData.ViewControllerName + ".cs");
        }
    }
}
