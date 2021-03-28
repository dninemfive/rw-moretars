using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;

namespace moretars
{
    public class Projectile_ExplosiveWithWorker : Projectile_Explosive
    {
        public ExplosionWorkerExtension Ext
        {
            get
            {
                if (cached) return ext;
                cached = true;
                ext = base.def.GetModExtension<ExplosionWorkerExtension>();
                return ext;
            }
        }
        private ExplosionWorkerExtension ext;
        private bool cached = false;
        public ExplosionWorker Worker => Ext.worker;

        protected override void Explode()
        {
            Destroy();
            Worker.Explode(base.Position, base.Map, this);
        }
    }
}