using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Stones
{
    public class SnakeStone : IBaseStone
    {
        public string Name { get; set; } = "Змей";
        public string Description { get; set; } = "50% силе ядовитых заклинаний. 25% силе и длительности ядов. 25% сопротивления ядам. Количество зарядов яда на оружии всегда равно 5. +1 к количеству зарядов яда, если взят перк \"Концентрированные яды\". Физические атаки уменьшаяют сопротивление ядам любым целям на 15% за каждый удар [максимум до 70%].";

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.PoisonMagePower += 0.5;
            character.PoisonPowerAndDuration += 0.25;
            character.PoisonResistance += 0.25;
        }
    }
}
