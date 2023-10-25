using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2___ConsoleApp.Construction
{
    class Construction
    {
        public Construction(float builders, float height, float width, int entrances, int humanCapacity, string buildMaterial)
        {
            Builders = builders;
            Height = height;
            Width = width;
            Entrances = entrances;
            HumanCapacity = humanCapacity;
            BuildMaterial = buildMaterial;
        }

        public float Builders { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }
        public int Entrances { get; set; }
        public int HumanCapacity { get; set; }
        public string BuildMaterial { get; set; }
        
    }
}
