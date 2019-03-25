using System.Collections.Generic;
using OpenClosed.Models;
using OpenClosed.StarshipRules;

namespace OpenClosed
{
    public class StarshipLogic
    {
        private List<IStarshipRule> _listStarshipRules;

        public StarshipLogic()
        {
            _listStarshipRules = new List<IStarshipRule>
            {
                new EnterpriseRule(),
                new ExcelsiorRule(),
                new ReliantRule()
            };
        }

public string GetStarshipNameAndClass(string registryCode)
{
    foreach (var rule in _listStarshipRules)
    {
        StarshipRuleResponse response = rule.GetShipDetails(registryCode);

        if (response.isMatchedShip)
        {
            return $"{response.StarshipName} ({response.StarshipClass} class)";
        }
    }

    return "Registry not recognised";
}
    }


    // ------------ Original version of StarshipLogic class, prior to refactoring to support open/closed principle ----------------
    //public class StarshipLogic
    //{
    //    public string GetStarshipNameAndClass(string registryCode)
    //    {
    //        switch (registryCode)
    //        {
    //            case "ncc1701":
    //                return "USS Enterprise (Constitution class)";
    //            case "ncc2000":
    //                return "USS Excelsior (Excelsior class)";
    //            default:
    //                return "Registry not recognised";
    //        }
    //    }
    //}

}
