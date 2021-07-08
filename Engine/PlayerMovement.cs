using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public partial class Player : LivingCreature
    {
        public void MoveTo(string dir)
        {
            foreach (var location in _Location.ConnectedLocations.Where(location => location.Key == dir))
            {
                _Location = location.Value;
            }
        }
        public void WarpTo(int Int)
        {
            _Location = World.LocationByID(Int);
        }
    }
}
