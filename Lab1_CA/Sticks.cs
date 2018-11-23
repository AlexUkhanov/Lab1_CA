using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_CA
{
    class Sticks
    {
        //массив со всеми палками
        private double[] all_sticks;
        //количество ребер/углов, которое нужно получить
        private int m;

        //конструктор
        public Sticks(List<double> sticks_in,int m_in)
        {
            all_sticks = sticks_in.ToArray();
            m = m_in;
        }

        //возвращает текстом те палочки, из которых можно составить правильный m угольник
        public string Check()
        {
            //Итоговая строка
            StringBuilder stBuild = new StringBuilder();
            //Проверяемое значение
            double cur_val;
            //Количество появлений данной переменной
            int cnt;
            for (int i = 0; i < all_sticks.Length; i++)
            {
                cnt = 1;
                if (all_sticks[i] != 0) {
                    cur_val = all_sticks[i];
                    for (int j = i + 1; j < all_sticks.Length; j++)
                    {
                        if (cur_val == all_sticks[j])
                            cnt++;
                    }
                    if (cnt >= m) {
                        for (int k = 0; k < m; k++)
                        {
                            stBuild.Append(cur_val.ToString() + ' ');
                        }
                        stBuild.Append(" Perimeter: " + (cur_val * m).ToString() + '\n');
                    }
                }
            }
            
            return stBuild.ToString();
        }
    }
}
