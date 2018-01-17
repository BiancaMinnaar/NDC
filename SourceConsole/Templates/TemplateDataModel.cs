using System;
namespace SourceConsole.Templates
{
    public class TemplateDataModel : CorePCL.BaseViewModel
    {
        public string ProjectName { get; set; }
        public string ViewName { get; set; }
        public string ViewControllerName { get; set; }
        public string ViewModelName { get; set; }
        public string EventName { get; set; }

        public TemplateDataModel(string screenName, string projectName)
        {
            ProjectName = projectName;
            EventName = screenName;
            ViewName = screenName + "View";
            ViewControllerName = screenName + "ViewController";
            ViewModelName = screenName + "ViewModel";
        }
    }
}
