using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_CA
{
    class Sticks
    {
        //лист со всеми палками
        private List<int> all_sticks;
        //количество элементов в листе
        private int N;
        //количество ребер/углов, которое нужно получить
        private int cnt_angles;
        //текущая длина стороны
        private int len_side = 0;

        //конструктор
        public Sticks(List<int> sticks_in, int m_in)
        {
            all_sticks = sticks_in;
            all_sticks.Sort();
            cnt_angles = m_in;
            N = all_sticks.Count;
        }

        //следующая перестановка
        bool NextSet()
        {
            int j = N - 2;
            while (j != -1 && all_sticks[j] >= all_sticks[j + 1]) j--;
            if (j == -1)
                return false; // больше перестановок нет
            int k = N - 1;
            while (all_sticks[j] >= all_sticks[k]) k--;

            int tmp = all_sticks[j];
            all_sticks[j] = all_sticks[k];
            all_sticks[k] = tmp;

            // сортируем оставшуюся часть последовательности
            int l = j + 1, r = N - 1;
            while (l < r)
            {
                tmp = all_sticks[l];
                all_sticks[l] = all_sticks[r];
                all_sticks[r] = tmp;
                l++;
                r--;
            }
            return true;
        }

        //Проверка для текущей перестановки текущей длины стороны
        bool CheckCurrent(List<int> per, int len)
        {
            len_side = len;
            int last_sum = 0;
            int cnt = 0;
            for (int i = 0; i < per.Count; i++)
            {
                if (last_sum + per[i] > len)
                    return false;
                if (last_sum + per[i] == len)
                {
                    cnt++;
                    if (cnt == cnt_angles)
                        return true;
                    last_sum = 0;
                }
                else
                {
                    last_sum += per[i];
                }
                i++;
            }
            return false;
        }

        //метод поиска
        public bool Find()
        {
            //Сумма длин всех звеньев
            int sum = 0;
            foreach (int num in all_sticks)
            {
                sum += num;
            }
            //среднее арифметическое палочек=максимальная длина стороны
            int max = sum / cnt_angles;
            do
            {
                for (int i = 1; i <= max; i++)
                {
                    if (CheckCurrent(all_sticks, i))
                        return true;
                }

            } while (NextSet());
            for (int i = 1; i <= max; i++)
            {
                if (CheckCurrent(all_sticks, i))
                    return true;
            }
            return false;
        }

        //возвращает текстом те палочки, из которых можно составить правильный m угольник
        public string ResToStr()
        {
            return null; //заглушка
        }
    }
}
