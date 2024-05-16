using DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionTest2
{
    public class TestPlayer : IPlayer
    {        
        private Choice _choice;

        public TestPlayer( Choice choice)
        {
            _choice = choice;
        }
        Choice IPlayer.GetChoice()
        {
            return _choice;
        }
    }
}
