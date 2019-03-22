namespace OpenClosed.StarshipRules
{
    public class ExcelsiorRule : IStarshipRule
    {
        public string GetShipName(string registryCode)
        {
            if (registryCode == "ncc2000")
                return "USS Excelsior (Excelsior class)";
            return null;
        }
    }
}
