using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriDiet.Common.Enums
{
    public enum ActivityLevel
    {
        Sedentary = 1200,         // Ít hoặc không tập luyện (1.2)
        LightlyActive = 1375,     // Tập nhẹ 1-3 lần/tuần (1.375)
        ModeratelyActive = 1550,  // Tập vừa 3-5 lần/tuần (1.55)
        VeryActive = 1725,        // Tập nặng 6-7 lần/tuần (1.725)
        ExtraActive = 1900        // Rất nặng, vận động viên chuyên nghiệp (1.9)
    }
}
