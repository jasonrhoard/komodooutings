                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoOutings_Repo
{
    public class KomodoOutings_Repo
    {
        private List<KomodoOutings> _listOfOutings = new List<KomodoOutings>();
        private List<KomodoOutings> _combinedCosts = new List<KomodoOutings>();
        private List<KomodoOutings> _outingCosts = new List<KomodoOutings>();
        //Display a list of all outings
        public List<KomodoOutings> DisplayAllOutings()
        {
            return _listOfOutings;
        }
        //Add individual outings to a list
        public void AddOutingsToList(KomodoOutings outings)
        {
            _listOfOutings.Add(outings);
        }
        //Display combined cost for all outings
        public List<KomodoOutings> DisplayCombinedCosts()
        {
            return _combinedCosts;
        }
        //Display outing costs by type of outing
        public List<KomodoOutings> DisplayOutingcosts()
        {
            return _outingCosts;
        }

        private  KomodoOutings GetCombinedCosts(decimal outing)
        {
            foreach(KomodoOutings cost in _combinedCosts)
            {
                if (cost.CostPerEvent == outing)
                {
                    return cost;
                }
            }
            return null;
        }
    }
}
