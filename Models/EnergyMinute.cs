using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyVisualize.Models
{
    public class EnergyMinute
    {
        public int Id { get; set; }

        public DateTime Minute { get; set; }
        public float EnergyKwh { get; set; }
        public float MaxPower { get; set; } // 🔥 peak ใน 1 นาที

        public EnergyMinute(DateTime Minute, float EnergyKwh, float MaxPower) 
        { 
            this.Minute = Minute;
            this.EnergyKwh = EnergyKwh;
            this.MaxPower = MaxPower;
        }
    }
}
