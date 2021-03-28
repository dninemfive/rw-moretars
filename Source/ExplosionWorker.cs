using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace moretars
{
    public abstract class ExplosionWorker
    {
        public abstract void Explode(IntVec3 position, Map map, Projectile proj = null);
    }
    public class ExplosionWorkerExtension : DefModExtension
    {
        public ExplosionWorker worker;
    }
}
