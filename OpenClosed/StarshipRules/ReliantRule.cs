using OpenClosed.Models;

namespace OpenClosed.StarshipRules
{
    public class ReliantRule : IStarshipRule
    {
        public StarshipRuleResponse GetShipName(string registryCode)
        {
            if (registryCode == "ncc1864")
                return new StarshipRuleResponse
                {
                    isMatchedShip = true,
                    StarshipName = "USS Reliant",
                    StarshipClass = "Miranda"
                };

            return new StarshipRuleResponse();
        }
    }
}
