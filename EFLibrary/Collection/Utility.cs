using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLibrary.Collection
{
    public class Utility
    {
      
    /// <summary>
    /// shuffle the array items randomly
    /// </summary>
    /// <param name="list"></param>
    /// <returns></returns>
    public IList<object> shuffleArray  (List<object> list)
    {
        int currentIndex = list.Count;
        object temporaryValue;
        int total = list.Count;           
        int randomIndex;
        while (0 != currentIndex) {
            var random = new Random();
            randomIndex = random.Next(total)* currentIndex;
            currentIndex -= 1;
            temporaryValue = list[currentIndex];
            list[currentIndex] = list[randomIndex];
            list[randomIndex] = temporaryValue;
        }
        return list;        
    }
    }
}
