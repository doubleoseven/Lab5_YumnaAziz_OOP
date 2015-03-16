using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5_YumnaAziz_OOP
{
    class Grid
    {
        private Tile[,] tileArray;
        //int[,] tiles = new int[10, 10];
        //int width = 60;
        //int height = 60;
        
        //Is given an array of integers that specify which tile is which
        //Read each row, column and specify whether what the type is
        //Depedning on the type, create an array of tile objects 

        public Tile[,] Load(int[,] grid)
        {
            //http://www.dotnetperls.com/2d-array
            int row = grid.GetUpperBound(0);
            int column = grid.GetUpperBound(1);

            tileArray = new Tile[row + 1, column + 1];

            for (int i = 0; i <= row; i++)
            {
                for (int j = 0; j <= column; j++)
                {
                    if(grid[i, j] == 0)
                    {
                        //Load the sand tile in the tile array 
                       // tile[i, j] = new Tile(")
                        tileArray[i, j] = new Tile("sand");
                    }
                    
                    if(grid[i, j] == 1)
                    {
                        //Load the grass title
                        tileArray[i, j] = new Tile("grass");
                    }
                    
                    if(grid[i, j] == 2)
                    {
                        //Load the water title
                        tileArray[i, j] = new Tile("water");
                    }
                    
                    if(grid[i, j] == 3)
                    {
                        //Load the rock title
                        tileArray[i, j] = new Tile("rock");
                        
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

            return tileArray;
        }
        
        public Tile getTile(int row, int column)
        {
            return tileArray[row, column];
        }
         

    }
}
