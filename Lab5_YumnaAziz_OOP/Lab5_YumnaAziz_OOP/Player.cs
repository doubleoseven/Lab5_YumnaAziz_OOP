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
        int direction; //playerPicUp1, playerPicUp2, playerPicDown1, playerPicDown2,
                            //playerPicLeft1, playerPicLeft2, playerPicRight1, playerPicRight2 

            public Player(int x, int y)
        {
            row = x;
            column = y;
            direction = 1;
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

        public int getPlayerDirection()
        {
            return direction;
        }
        
        public void setPlayerDirection(int d)
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
