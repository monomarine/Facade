using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public interface ICinemaSeats
    {
        void AdjustToViewingPosition();
        void AdjustToDefaultPosition();
        void AdjustSeatHeight(int height);
        bool IsInViewingMode { get; }
    }
}
