using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell;
using VSLangProj80;

namespace DMKSoftware.CodeGenerators
{
    [ComVisible(true)]
    [Guid("AC0A9CFD-1B0A-4e4a-86A1-AB7854A33E23")]
    [CodeGeneratorRegistration(typeof(InternalResXFileCodeGeneratorEx), "InternalResXFileCodeGeneratorEx", VSConstants.UICONTEXT.CSharpProject_string, GeneratesDesignTimeSource = true)]
    [CodeGeneratorRegistration(typeof(InternalResXFileCodeGeneratorEx), "InternalResXFileCodeGeneratorEx", vsContextGuids.vsContextGuidVCSEditor, GeneratesDesignTimeSource = true)]
    [Description("Extended ResX Internal File Code Generator")]
    [ProvideObject(typeof(InternalResXFileCodeGeneratorEx))]
    public class InternalResXFileCodeGeneratorEx : BaseResXFileCodeGeneratorEx
    {
        /// <summary>
        /// Initializes a new instance of the InternalResXFileCodeGeneratorEx class.
        /// </summary>
        public InternalResXFileCodeGeneratorEx()
        {
        }

        /// <summary>
        /// Gets the boolean flag indicating whether the internal class is generated.
        /// </summary>
        protected override bool GenerateInternalClass
        {
            get
            {
                return true;
            }
        }
    }
}