namespace OpenClosed.StarshipRules
{
    public class EnterpriseRule : IStarshipRule
    {
        public string GetShipName(string registryCode)
        {
            if (registryCode == "ncc1701")
                return "USS Enterprise (Constitution class)";
            return null;
        }
    }
}
