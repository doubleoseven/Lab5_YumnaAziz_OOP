using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace Lab5_YumnaAziz_OOP
{
    class Grid
    {
        private Tile[,] tileArray;
        int width = 0;
        int height = 0;
        
        //Is given an array of integers that specify which tile is which
        //Read each row, column and specify whether what the type is
        //Depedning on the type, create an array of tile objects 

        //Make a contructor

        public Grid(int w, int h)
        {
            tileArray = new Tile[w, h];
            width = w;
            height = h;
        }
        

        public void Load(int[,] grid)
        {
            //http://www.dotnetperls.com/2d-array
            //int row = grid.GetUpperBound(0); //Upper bound = max number of elements starting from 0
            //int column = grid.GetUpperBound(1);

            //tileArray = new Tile[row + 1, column + 1];

            for (int i = 0; i <width; i++)
            {
                for (int j = 0; j <height; j++)
                {
                    if(grid[i, j] == 0)
                    {
                        //Load the sand tile in the tile array 
                       // tile[i, j] = new Tile(")
                        tileArray[i, j] = new Tile("land");
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

            //return tileArray;
        }
        /*
        public Tile getTile(int row, int column)
        {
            return tileArray[row, column];
        }

        */

        public Tile getTile(int x, int y)
        {
            return tileArray[x, y];
        }
         /*
        public bool canWalk(Point point)
        {
            return(point.X>=0 && point.X<width && point)
        }
        */

        public bool canWalk(int x,  int y)
        {
            if (x > 0 && x < width && y > 0 && y < height)
            {
                if (getTile(x, y).canWalk() == true)
                {
                    return true;
                }
                else return false;
            }
            else return false;
                
        }
    }
}
