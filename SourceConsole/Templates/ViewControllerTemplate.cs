﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SourceConsole.Templates {
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    
    public partial class ViewControllerTemplate : ViewControllerTemplateBase {
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 6 ""
            this.Write("using System.Threading.Tasks;\nusing ");
            
            #line default
            #line hidden
            
            #line 7 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( _DataModel.ProjectName ));
            
            #line default
            #line hidden
            
            #line 7 ""
            this.Write(".Base;\nusing ");
            
            #line default
            #line hidden
            
            #line 8 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( _DataModel.ProjectName ));
            
            #line default
            #line hidden
            
            #line 8 ""
            this.Write(".Implementation.Repository;\nusing ");
            
            #line default
            #line hidden
            
            #line 9 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( _DataModel.ProjectName ));
            
            #line default
            #line hidden
            
            #line 9 ""
            this.Write(".Implementation.Service;\nusing ");
            
            #line default
            #line hidden
            
            #line 10 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( _DataModel.ProjectName ));
            
            #line default
            #line hidden
            
            #line 10 ""
            this.Write(".Implementation.ViewModel;\nusing ");
            
            #line default
            #line hidden
            
            #line 11 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( _DataModel.ProjectName ));
            
            #line default
            #line hidden
            
            #line 11 ""
            this.Write(".Interface.Repository;\nusing ");
            
            #line default
            #line hidden
            
            #line 12 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( _DataModel.ProjectName ));
            
            #line default
            #line hidden
            
            #line 12 ""
            this.Write(".Interface.Service;\nusing ");
            
            #line default
            #line hidden
            
            #line 13 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( _DataModel.ProjectName ));
            
            #line default
            #line hidden
            
            #line 13 ""
            this.Write(".Interface.ViewController;\n\nnamespace ");
            
            #line default
            #line hidden
            
            #line 15 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( _DataModel.ProjectName ));
            
            #line default
            #line hidden
            
            #line 15 ""
            this.Write(".Implementation.ViewController\n{\n    public class ");
            
            #line default
            #line hidden
            
            #line 17 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( _DataModel.ViewControllerName ));
            
            #line default
            #line hidden
            
            #line 17 ""
            this.Write(" : ProjectBaseViewController<");
            
            #line default
            #line hidden
            
            #line 17 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( _DataModel.ViewModelName ));
            
            #line default
            #line hidden
            
            #line 17 ""
            this.Write(">, I");
            
            #line default
            #line hidden
            
            #line 17 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( _DataModel.ViewControllerName ));
            
            #line default
            #line hidden
            
            #line 17 ""
            this.Write("\n    {\n        I");
            
            #line default
            #line hidden
            
            #line 19 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( _DataModel.EventName ));
            
            #line default
            #line hidden
            
            #line 19 ""
            this.Write("Repository _Reposetory;\n        I");
            
            #line default
            #line hidden
            
            #line 20 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( _DataModel.EventName ));
            
            #line default
            #line hidden
            
            #line 20 ""
            this.Write(@"Service _Service;

        public override void SetRepositories()
        {
            _MasterRepo.NetworkInterface = (U, P, A) => ExecuteQueryWithObjectAndNetworkAccessAsync(U, P, A);
            _MasterRepo.NetworkInterfaceWithTypedParameters = (U, P, A) => ExecuteQueryWithTypedParametersAndNetworkAccessAsync(U, P, A);
            _Service = new ");
            
            #line default
            #line hidden
            
            #line 26 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( _DataModel.EventName ));
            
            #line default
            #line hidden
            
            #line 26 ""
            this.Write("Service(_MasterRepo.NetworkInterface);\n            _Reposetory = new ");
            
            #line default
            #line hidden
            
            #line 27 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( _DataModel.EventName ));
            
            #line default
            #line hidden
            
            #line 27 ""
            this.Write("Repository(_MasterRepo, _AuthService);\n        }\n\n        public async Task ");
            
            #line default
            #line hidden
            
            #line 30 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( _DataModel.EventName ));
            
            #line default
            #line hidden
            
            #line 30 ""
            this.Write("()\n        {\n            \n        }\n    }\n}");
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class ViewControllerTemplateBase {
        
        private global::System.Text.StringBuilder builder;
        
        private global::System.Collections.Generic.IDictionary<string, object> session;
        
        private global::System.CodeDom.Compiler.CompilerErrorCollection errors;
        
        private string currentIndent = string.Empty;
        
        private global::System.Collections.Generic.Stack<int> indents;
        
        private ToStringInstanceHelper _toStringHelper = new ToStringInstanceHelper();
        
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session {
            get {
                return this.session;
            }
            set {
                this.session = value;
            }
        }
        
        public global::System.Text.StringBuilder GenerationEnvironment {
            get {
                if ((this.builder == null)) {
                    this.builder = new global::System.Text.StringBuilder();
                }
                return this.builder;
            }
            set {
                this.builder = value;
            }
        }
        
        protected global::System.CodeDom.Compiler.CompilerErrorCollection Errors {
            get {
                if ((this.errors == null)) {
                    this.errors = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errors;
            }
        }
        
        public string CurrentIndent {
            get {
                return this.currentIndent;
            }
        }
        
        private global::System.Collections.Generic.Stack<int> Indents {
            get {
                if ((this.indents == null)) {
                    this.indents = new global::System.Collections.Generic.Stack<int>();
                }
                return this.indents;
            }
        }
        
        public ToStringInstanceHelper ToStringHelper {
            get {
                return this._toStringHelper;
            }
        }
        
        public void Error(string message) {
            this.Errors.Add(new global::System.CodeDom.Compiler.CompilerError(null, -1, -1, null, message));
        }
        
        public void Warning(string message) {
            global::System.CodeDom.Compiler.CompilerError val = new global::System.CodeDom.Compiler.CompilerError(null, -1, -1, null, message);
            val.IsWarning = true;
            this.Errors.Add(val);
        }
        
        public string PopIndent() {
            if ((this.Indents.Count == 0)) {
                return string.Empty;
            }
            int lastPos = (this.currentIndent.Length - this.Indents.Pop());
            string last = this.currentIndent.Substring(lastPos);
            this.currentIndent = this.currentIndent.Substring(0, lastPos);
            return last;
        }
        
        public void PushIndent(string indent) {
            this.Indents.Push(indent.Length);
            this.currentIndent = (this.currentIndent + indent);
        }
        
        public void ClearIndent() {
            this.currentIndent = string.Empty;
            this.Indents.Clear();
        }
        
        public void Write(string textToAppend) {
            this.GenerationEnvironment.Append(textToAppend);
        }
        
        public void Write(string format, params object[] args) {
            this.GenerationEnvironment.AppendFormat(format, args);
        }
        
        public void WriteLine(string textToAppend) {
            this.GenerationEnvironment.Append(this.currentIndent);
            this.GenerationEnvironment.AppendLine(textToAppend);
        }
        
        public void WriteLine(string format, params object[] args) {
            this.GenerationEnvironment.Append(this.currentIndent);
            this.GenerationEnvironment.AppendFormat(format, args);
            this.GenerationEnvironment.AppendLine();
        }
        
        public class ToStringInstanceHelper {
            
            private global::System.IFormatProvider formatProvider = global::System.Globalization.CultureInfo.InvariantCulture;
            
            public global::System.IFormatProvider FormatProvider {
                get {
                    return this.formatProvider;
                }
                set {
                    if ((value != null)) {
                        this.formatProvider = value;
                    }
                }
            }
            
            public string ToStringWithCulture(object objectToConvert) {
                if ((objectToConvert == null)) {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                global::System.Type type = objectToConvert.GetType();
                global::System.Type iConvertibleType = typeof(global::System.IConvertible);
                if (iConvertibleType.IsAssignableFrom(type)) {
                    return ((global::System.IConvertible)(objectToConvert)).ToString(this.formatProvider);
                }
                global::System.Reflection.MethodInfo methInfo = type.GetMethod("ToString", new global::System.Type[] {
                            iConvertibleType});
                if ((methInfo != null)) {
                    return ((string)(methInfo.Invoke(objectToConvert, new object[] {
                                this.formatProvider})));
                }
                return objectToConvert.ToString();
            }
        }
    }
}
