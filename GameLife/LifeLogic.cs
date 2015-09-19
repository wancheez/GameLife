using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace GameLife
{
    public class LifeLogic
    {
        public bool[,] Universe;
        int xNum, yNum;

        public bool[,] UniverseArray
        {
            get {return Universe;}
        }

        public LifeLogic(int x, int y, bool[,]Univ)
        {
            xNum = x;
            yNum = y;
            Universe = Univ;
        }

        public Color RedColor 
        {
            get { return Colors.Red; }
        }

        public void nextStep()
        {
            for (int i = 1; i < xNum-1; i++)
            {
                for (int j = 1; j < yNum-1; j++)
                {
                    if ( (!Universe[i,j] && checkNeighbors(i, j) == 3) || 
                        (Universe[i,j] && (checkNeighbors(i, j) == 3 || checkNeighbors(i, j) == 2)))
                    {
                        Universe[i,j] = true; //Клетка оживает или остается живой
                    } else
                    {
                        Universe[i,j] = false;
                    }
                }
            }
        }

        private int checkNeighbors(int i, int j)
        {
            int counter = 0;
            counter += (Universe[i + 1,j]) ? 1 : 0;
            counter += (Universe[i + 1,j - 1]) ? 1 : 0;
            counter += (Universe[i + 1,j + 1]) ? 1 : 0;
            counter += (Universe[i - 1,j]) ? 1 : 0;
            counter += (Universe[i - 1,j + 1]) ? 1 : 0;
            counter += (Universe[i - 1,j - 1]) ? 1 : 0;
            counter += (Universe[i,j + 1]) ? 1 : 0;
            counter += (Universe[i,j - 1]) ? 1 : 0;
            return counter;
        }

    }
}
