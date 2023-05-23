using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_2
{
    public class Desk
    {
        // desk constraints
        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 84;
        public const int MINDRAWER = 0;
        public const int MAXDRAWER = 7;

        public string CustomerName;
        public decimal DeskWidth { get; set; } // min 24" max 96"
        public decimal DeskDepth { get; set; } // min 12" and max of 48"
        public int DrawerCount { get; set; } // 0-7
       // public string Material { get; set; } // use enum surface type
        public SurfaceType Material { get; set; }

        //public Desk(int width, int depth, int drawerCount, string material, bool rush, int shipping) { }
        public Desk() { }

    }

    public enum SurfaceType
    {
        Laminate, // 0  = 100
        Oak,      // 1  = 200
        Rosewood, // 2  = 300
        Veneer,   // 3  = 125
        Pine      // 4  = 50 
    }

  }
