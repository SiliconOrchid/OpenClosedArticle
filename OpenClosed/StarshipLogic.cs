using System.Collections.Generic;
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

        public string GetStarshipName(string registryCode)
        {
            foreach (var rule in _listStarshipRules)
            {
                string response = rule.GetShipName(registryCode);

                if (string.IsNullOrEmpty(response))
                {
                    continue;
                }
                else
                {
                    return response;
                }
            }

            return "Registry not recognised";
        }
    }


    // ------------ Original version of StarshipLogic class, prior to refactoring to support open/closed principle ----------------
    //public class StarshipLogic
    //{
    //    public string GetStarshipName(string registryCode)
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
