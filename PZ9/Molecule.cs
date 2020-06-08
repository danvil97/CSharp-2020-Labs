using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ9
{
    class Molecule
    {
        public int radius, x, y, sx, sy, vx, vy;
        double k;
       public  int maxX, maxY,num,svx,svy;
        public Molecule(int Nradius, int Nx, int Ny, int Nvx, int Nvy, int NmaxX, int NmaxY, int Nnum)
        {
            radius = Nradius;
            x = Nx;
            y = Ny;
            vx = Nvx;
            vy = Nvy;
            maxX = NmaxX;
            maxY = NmaxY;
            num = Nnum;
        }
        public void Update(Molecule[] molArr)
        {
            foreach (var i in molArr)
            {
                if (i.num != num)
                {
                    if (Math.Abs((x) - (i.sx)) <= radius && Math.Abs((y) - (i.sy)) <= radius)
                    {
                        vx = i.svx;
                        vy = i.svy;
                    }
                }
            }
            if (x + vx + radius >= maxX || x + vx - radius <= 0)
            {
                vx = -vx;
            }
            if (y + vy + radius >= maxY || y + vy - radius <= 0)
            {
                vy = -vy;
            }
            x += vx;
            y += vy;
        }
        public bool Check(int rad, int x, int y, List<Molecule> molArr)
        {
            foreach (var i in molArr)
            {
                if (Math.Abs((x) - (i.x)) <= radius && Math.Abs((y) - (i.y)) <= radius)
                {
                    return false;
                }
            }
            return true;
        }
        public void ChangeSpeed(int k)
        {
            if (vx >= 0)
            {
                if (vx + k > 0)
                {
                    vx = vx + k;
                    svx = vx + k;
                }
                else
                {
                    vx = 0;
                    svx = 0;
                }
            }
            else
            {
                if (vx + k < 0)
                {
                    vx = vx - k;
                    svx = vx - k;
                }
                else
                {
                    vx = 0;
                    svx = 0;
                }
            }
            if (vy >= 0)
            {
                if (vy + k > 0)
                {
                    vy = vy + k;
                    svy = vy + k;
                }
                else
                {
                    vy = 0;
                    svy = 0;
                }
            }
            else
            {
                if (vy + k < 0)
                {
                    vy = vy - k;
                    svy = vy - k;
                }
                else
                {
                    vy = 0;
                    svy = 0;
                }
            }
        }
    }
    
}
