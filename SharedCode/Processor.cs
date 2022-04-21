using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TextTemplating;

namespace EnvDTEResolver
{
    
    public class Processor : DirectiveProcessor, IDirectiveProcessor
    {
        private const string DirectiveName = "EnvDTEResolve";
        private Version _vsVersion;
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


        public override string[] GetReferencesForProcessingRun()
        {
            if (_vsVersion.Major > 16)
                return Array.Empty<string>();

            return new[]
            {
                "EnvDTE"
            };
        }

        public override string[] GetImportsForProcessingRun()
        {
            return new[]
            {
                "EnvDTE"
            };
        }


        public override void Initialize(ITextTemplatingEngineHost host)
        {
            
            var assemblyName = host.GetType().Assembly.FullName;
            var parts = assemblyName.Split(new []{','}, StringSplitOptions.RemoveEmptyEntries);
            var version = parts.Length < 2 ? null : parts[1].Trim();
            _vsVersion = Version.Parse(version.Replace("Version=", string.Empty));
            
        }
        //bool IDirectiveProcessor.RequiresProcessingRunIsHostSpecific => true;
    }
}
