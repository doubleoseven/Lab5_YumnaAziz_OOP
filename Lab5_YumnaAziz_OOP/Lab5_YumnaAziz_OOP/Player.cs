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
        String direction; //playerPicUp1, playerPicUp2, playerPicDown1, playerPicDown2,
                            //playerPicLeft1, playerPicLeft2, playerPicRight1, playerPicRight2 

        public Player(int x, int y)
    {
        row = x;
        column = y;
        direction = "up1";
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

        public bool canMove(int row, int column)
        {
            Grid grid = new Grid();
            Tile tile = grid.getTile(row, column);

            if (tile.canWalk()) return true;
            else return false;
        }


    }
}
