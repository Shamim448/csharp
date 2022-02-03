using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    public class AlarmSender
    {
        public event Action<int, string> OnAlarm;
        public void SendAlarm(int senderId, string massage)
        {
            //Console.WriteLine(senderId);
          //  Console.WriteLine(massage);
            OnAlarm?.Invoke(senderId, massage);
        }
      
    }
}
