using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriDiet.Common.Enums
{
    public enum DietStyleEnum
    {
        HighCarbLowProtein,  // Nhiều carb, ít protein
        HighProteinLowCarb,  // Nhiều protein, ít carb
        Vegetarian,          // Ăn chay (có thể có sữa, trứng)
        Vegan,              // Thuần chay (không có sản phẩm từ động vật)
        Balanced            // Chế độ ăn cân bằng
    }
}
