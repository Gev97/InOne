using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship
{
    class Books : Information
    {
        public Books()
        {
            read = "              MASTER AND MARGARITA \n" +
            "At the sunset hour of one warm \n spring day two men were to be seen at Patriarch's Ponds. \n" +
            "The first of them--aged about forty, \n dressed in a greyish summer suit--was short, dark-haired, well-fed and bald. \n" +
            "He carried his decorous pork-pie hat by the brim and his neatly shaven face \n was embellished by black hornrimmed spectacles of preternatural dimensions. \n" +
            "The other, a broad-shouldered young man with \n curly reddish hair and a check cap pushed back to  the nape of his neck, \n was wearing a tartan shirt, chewed white trousers and black sneakers.";
        }

        
        public string Read { get => read; }
        
    }

    
}
