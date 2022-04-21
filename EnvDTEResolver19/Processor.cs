namespace EnvDTEResolver
{
    public class Processor : ProcessorBase
    {
        public override string[] GetReferencesForProcessingRun()
        {
            return AssemblyVs2017();
        }
    }
}
