
using Core.Interfaces;
using System;

namespace Services.Elementary
{

    public class Rule : IRule
    {
        private string _ruleSet;

        public Rule(string ruleSet)
        {
            _ruleSet = ruleSet;
        }
        
        public Rule(int ruleSet)
        {
            _ruleSet = Convert.ToString(ruleSet, 2).PadLeft(8, '0');
        }

        public bool Apply(ICell cell, ICell[] neighbors)
        {
            ICell leftNeighbor = neighbors[0];
            ICell rightNeighbor = neighbors[1];

            switch ( (leftNeighbor.IsAlive, cell.IsAlive, rightNeighbor.IsAlive) )
            {
                case (true, true, true): return int.Parse(_ruleSet[0].ToString()) == 1; 
                case (true, true, false): return int.Parse(_ruleSet[1].ToString()) == 1; 
                case (true, false, true): return int.Parse(_ruleSet[2].ToString()) == 1; 
                case (true, false, false): return int.Parse(_ruleSet[3].ToString()) == 1; 
                case (false, true, true): return int.Parse(_ruleSet[4].ToString()) == 1; 
                case (false, true, false): return int.Parse(_ruleSet[5].ToString()) == 1; 
                case (false, false, true): return int.Parse(_ruleSet[6].ToString()) == 1; 
                case (false, false, false): return int.Parse(_ruleSet[7].ToString()) == 1; 
            }
        }
    }
}
