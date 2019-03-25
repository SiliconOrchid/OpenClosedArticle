using OpenClosed.Models;

namespace OpenClosed.StarshipRules
{
    public class ExcelsiorRule : IStarshipRule
    {
        public StarshipRuleResponse GetShipDetails(string registryCode)
        {
            if (registryCode == "ncc2000")
                return new StarshipRuleResponse
                {
                    isMatchedShip = true,
                    StarshipName = "USS Excelsior",
                    StarshipClass = "Excelsior"
                };

            return new StarshipRuleResponse();
        }
    }
}
