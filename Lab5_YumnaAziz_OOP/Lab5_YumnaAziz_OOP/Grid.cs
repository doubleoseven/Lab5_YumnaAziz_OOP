using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5_YumnaAziz_OOP
{
    class Grid
    {
        Tile[,] tile;
        int[,] tiles = new int[10, 10];
        int width = 60;
        int height = 60;
        Game1 game = new Game1();

        public void Load(int[,] grid)
        {
            //http://www.dotnetperls.com/2d-array
            int width = grid.GetUperBound(0);
            int length = grid.GetUpperBound(1);
            
            tile = new Tile[width, length];
            
            for (int i = 0; i<width; i++)
            {
                for (int j = 0; j<length; j++)
                {
                    if(grid[i, j] == 0)
                    {
                        //Load the sand tile in the tile array 
                       // tile[i, j] = 
                    }
                    
                    if(grid[i, j] == 1)
                    {
                        //Load the grass title
                    }
                    
                    if(grid[i, j] == 2)
                    {
                        //Load the water title
                    }
                    
                    if(grid[i, j] == 3)
                    {
                        //Load the rock title
                        
                    }
                    
                }
            }
            
            
            
            
            /*
            for (int i = 0; i<10; i++)
            {
                for (int j = 0; j<10; j++)
                {
                    grid[i][j]
                }
            }
            
            */
        }


        public Tile getTile(int row, int column)
        {
            
        }

    }
}
