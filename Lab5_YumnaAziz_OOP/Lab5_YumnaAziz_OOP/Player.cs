using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5_YumnaAziz_OOP
{
    class Player
    {
        private int row;
        private int column;
        String direction; //up, down, left, right 

            public Player(int x, int y)
        {
            row = x;
            column = y;
            direction = "up";
        }


        public int getPlayerX()
        {
            return row;
        }

        public int getPlayerY()
        {
            return column;
        }

        public void setPlayerX(int x)
        {
            row = x;
        }

        public void setPlayerY(int y)
        {
            column = y;
        }

        public String getPlayerDirection()
        {
            return direction;
        }
        
        public void setPlayerDirection(String d)
        {
            direction = d;
        }
        
         //Accepts an array of tiles that were loaded from the game
        public bool canMove(Tile[,] tiles, int row, int column)
        {
            Tile[,] t = tiles;
            Tile tile = t[row, column];

            if (tile.canWalk()) { return true; }
            else { return false; }
        }


    }
}
