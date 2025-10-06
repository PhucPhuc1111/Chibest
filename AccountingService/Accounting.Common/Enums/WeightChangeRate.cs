using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriDiet.Common.Enums
{
    public enum WeightChangeRate
    {
        Lose1KgPerWeek = -1000,
        Lose075KgPerWeek = -750,
        Lose05KgPerWeek = -500,
        Lose025KgPerWeek = -250,
        MaintainWeight = 0,
        Gain025KgPerWeek = 250,
        Gain05KgPerWeek = 500
    }
}
