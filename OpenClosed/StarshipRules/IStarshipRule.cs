using OpenClosed.Models;

namespace OpenClosed.StarshipRules
{
    public interface IStarshipRule
    {
        StarshipRuleResponse GetShipDetails(string registryCode);
    }
}
