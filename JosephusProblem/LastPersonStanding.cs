using System;
using System.Collections.Generic;
using System.Text;

namespace JosephusProblem
{
    public class LastPersonStanding
    {
        public int[] Kill(int numOfPeople, int killingInterval)
        {
            var position = killingInterval - 1;
            var peopleCount = new int[numOfPeople];

            for (int i = 0; i <= numOfPeople - 1; i++)
            {
                while (position + 1 >= numOfPeople)
                {
                    position -= numOfPeople;
                }
                if (peopleCount[position + 1] == 0)
                {
                    position++;
                }
                if (peopleCount[position + 1] == 1)
                {
                    peopleCount[position + 1] = 0;
                }
                position = position + killingInterval + 1;
            }
            return peopleCount;
        }
    }
}
