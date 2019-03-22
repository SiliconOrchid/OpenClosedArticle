using OpenClosed.Models;

namespace OpenClosed.StarshipRules
{
    public interface IStarshipRule
    {
        StarshipRuleResponse GetShipName(string registryCode);
    }
}
