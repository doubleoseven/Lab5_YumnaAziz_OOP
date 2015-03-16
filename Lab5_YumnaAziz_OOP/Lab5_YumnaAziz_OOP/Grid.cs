using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5_YumnaAziz_OOP
{
    class Grid
    {
        private Tile[,] tile;
        //int[,] tiles = new int[10, 10];
        //int width = 60;
        //int height = 60;
        
        //Is given an array of integers that specify which tile is which
        //Read each row, column and specify whether what the type is
        //Depedning on the type, create an array of tile objects 

        public Tile[,] Load(int[,] grid)
        {
            //http://www.dotnetperls.com/2d-array
            int width = grid.GetUpperBound(0);
            int length = grid.GetUpperBound(1);
            
            tile = new Tile[width, length];
            
            for (int i = 0; i<width; i++)
            {
                for (int j = 0; j<length; j++)
                {
                    if(grid[i, j] == 0)
                    {
                        //Load the sand tile in the tile array 
                       // tile[i, j] = new Tile(")
                        tile[i, j] = new Tile("sand");
                    }
                    
                    if(grid[i, j] == 1)
                    {
                        //Load the grass title
                        tile[i, j] = new Tile("grass");
                    }
                    
                    if(grid[i, j] == 2)
                    {
                        //Load the water title
                        tile[i, j] = new Tile("water");
                    }
                    
                    if(grid[i, j] == 3)
                    {
                        //Load the rock title
                        tile[i, j] = new Tile("rock");
                        
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

            return tile;
        }

        public Tile[,] getTileArray()
        {
            return tile;
        }

        /*
        public Tile getTile(int row, int column)
        {
            
        }
         */

    }
}
