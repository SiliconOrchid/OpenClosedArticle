namespace OpenClosed.StarshipRules
{
    public class ReliantRule : IStarshipRule
    {
        public string GetShipName(string registryCode)
        {
            if (registryCode == "ncc1864")
                return "USS Reliant (Miranda class)";
            return null;
        }
    }
}
