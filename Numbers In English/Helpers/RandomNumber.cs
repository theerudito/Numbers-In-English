using NumbersInEnglish.ApplicationContextDB;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NumbersInEnglish.Helpers
{
    public static class RandomNumber
    {
        public static int QuantityOnTable()
        {
            var _dbContext = new ApplicationContext_DB();
            var quantityOnTable = _dbContext.Number.ToList();
            return quantityOnTable.Count;
        }

        public static int GetRandomNumber()
        {
            Random random = new Random();
            return random.Next(1, QuantityOnTable());
        }

        public static List<int> numAletory(int count)
        {
            var list = new List<int>();

            var random = new Random();

            while (list.Count < count)
            {
                var num = random.Next(1, QuantityOnTable());
                if (!list.Contains(num))
                {
                    list.Add(num);
                }
            }
            return list;
        }
    }
}