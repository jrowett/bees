using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bees.Model
{
    public abstract class BeeBase
    {
        private float _health;
        public BeeBase()
        {
            _health = 100;
        }

        public float Health
        {
            get { return _health; }
        }

        public void Damage(int percentage)
        {
            if (Dead) return;

            float factor = percentage / 100f;
            float reduceBy = _health * factor;
            float result = _health - reduceBy;

            _health = result;
        }

        public bool Dead
        {
            get
            {
                return _health < MinimumHealthThreshold;
            }
        }

        protected abstract float MinimumHealthThreshold { get; }
    }
}
