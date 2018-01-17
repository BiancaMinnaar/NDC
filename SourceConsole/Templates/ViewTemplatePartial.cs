using System;
namespace SourceConsole.Templates
{
    partial class ViewTemplate
    {
        TemplateDataModel _DataModel;

        public ViewTemplate(TemplateDataModel dataModel)
        {
            _DataModel = dataModel;
        }
    }
}
