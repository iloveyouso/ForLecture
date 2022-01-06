using System;

namespace Lecture
{


    class Program
    {
        static void Main(string[] args)
        {

            int num_bulb = 10000;
            int student_index = 1;
            int bulb_index = 1;
            int answer = 0;

            bool[] bulb_list = new bool[num_bulb];

            for (int i = 0; i < num_bulb; i++)
            {
                student_index = i + 1;

                for (int j = 0; j < num_bulb; j++)
                {
                    bulb_index = j + 1;

                    if (bulb_index % student_index == 0)
                    {
                        bulb_list[j] = !bulb_list[j];
                    }

                }
            }

            for (int i = 0; i < num_bulb; i++)
            {
                if (bulb_list[i] == true)
                {
                    answer += 1;
                }
            }
            Console.WriteLine(answer);
        }
    }
}
