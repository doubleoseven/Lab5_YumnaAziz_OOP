using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5_YumnaAziz_OOP
{
    class Grid
    {
        Tile[,] tile = new Tile[10, 10];
        int[,] tiles = new int[10, 10];
        int width = 60;
        int height = 60;
        Game1 game = new Game1();

        public void Load(int[,] grid)
        {
            tiles = grid;
            for (int i = 0; i<10; i++)
            {
                for (int j = 0; j<10; j++)
                {
                    grid[i][j]
                }
            }
        }



    }
}
