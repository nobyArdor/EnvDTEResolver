using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TextTemplating;

namespace EnvDTEResolver
{
    public abstract class ProcessorBase : DirectiveProcessor, IDirectiveProcessor
    {
        private const string DirectiveName = "EnvDTEResolve";

        public override bool IsDirectiveSupported(string directiveName)
        {
            return string.Compare(directiveName, DirectiveName, StringComparison.OrdinalIgnoreCase) == 0;
        }

        public override void ProcessDirective(string directiveName, IDictionary<string, string> arguments)
        {
        }

        public override void FinishProcessingRun()
        {
        }

        public override string GetClassCodeForProcessingRun()
        {
            return string.Empty;
        }

        public override string GetPreInitializationCodeForProcessingRun()
        {
            return string.Empty;
        }

        public override string GetPostInitializationCodeForProcessingRun()
        {
            return string.Empty;
        }

        bool IDirectiveProcessor.RequiresProcessingRunIsHostSpecific => true;

        public override string[] GetImportsForProcessingRun()
        {
            return new[]
            {
                "EnvDTE"
            };
        }

        protected string[] AssemblyVs2017()
        {
            return new[]
            {
                "EnvDTE"
            };
        }

        protected string[] AssemblyVs2022()
        {
            return Array.Empty<string>();
        }
    }
}