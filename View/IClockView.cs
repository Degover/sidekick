using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sidekick.View
{
    internal interface IClockView
    {
        void ShowTime(string time);
        void ShowDate(string date);
    }
}
