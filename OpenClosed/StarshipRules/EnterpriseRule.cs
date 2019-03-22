using OpenClosed.Models;

namespace OpenClosed.StarshipRules
{
public class EnterpriseRule : IStarshipRule
{
    public StarshipRuleResponse GetShipName(string registryCode)
    {
        if (registryCode == "ncc1701")
            return new StarshipRuleResponse
            {
                isMatchedShip = true,
                StarshipName = "USS Enterprise",
                StarshipClass = "Constitution"
            };

        return new StarshipRuleResponse();
    }
}
}
