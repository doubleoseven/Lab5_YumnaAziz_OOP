using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5_YumnaAziz_OOP
{
    class Grid
    {
        //Tile[,] tile = new Tile[10, 10];
        int[,] tiles = new int[10, 10];
        int width = 60;
        int height = 60;

        public void Load(int[,] grid)
        {
            tiles = grid;
            
        }



    }
}
