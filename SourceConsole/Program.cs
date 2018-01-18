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

            var viewTemplate = new ViewTemplate(screenData);
            generateClass(screenData, viewTemplate, screenData.ViewName + ".xaml");

            var viewCodeBehindTemplate = new ViewCodeBehindTemplate(screenData);
            generateClass(screenData, viewCodeBehindTemplate, screenData.ViewName + ".cs");

            var viewControllerTemplate = new ViewControllerTemplate(screenData);
            generateClass(screenData, viewControllerTemplate, screenData.ViewControllerName + ".cs");

            var viewModelTemplate = new ViewModelTemplate(screenData);
            generateClass(screenData, viewModelTemplate, screenData.ViewModelName + ".cs");

            var repositoryTemplate = new RepositoryTemplate(screenData);
            generateClass(screenData, repositoryTemplate, screenData.RepositoryName + ".cs");
        }
    }
}
