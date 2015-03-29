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
    class Player
    {
        private int row;
        private int column;
        private String direction; //up, down, left, right 
        private Texture2D playerImage; //We're declaring this but not loading this in the class
        

            public Player(int x, int y)
        {
            row = x;
            column = y;
            direction = "up";
            //playerImage = player;
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
        
        public void setPlayerImage(Texture2D image)
        {
            playerImage = image;
        }
        
        public Texture2D getPlayerImage()
        {
            return playerImage;
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
