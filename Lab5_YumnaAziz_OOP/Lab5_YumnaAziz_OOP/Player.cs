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
        private Point playerPosition;
        private String direction; //up, down, left, right 
        private Texture2D playerImage; //We're declaring this but not loading this in the class
        

            public Player(Point player)
        {
            playerPosition = player;
            direction = "up";
            //playerImage = image;
        }

        public Point getPlayerPosition()
        {
            return playerPosition;
        }

        public void setPlayerPosition(Point point)
        {
            playerPosition = point;
        }


        public String getPlayerDirection()
        {
            return direction;
        }
        
        public void setPlayerDirection(String d)
        {
            direction = d;
        }
        /*
        public void setPlayerImage(Texture2D image)
        {
            playerImage = image;
        }
        
        public Texture2D getPlayerImage()
        {
            return playerImage;
        }

        /*
         //Accepts an array of tiles that were loaded from the game
        public bool canMove(Tile[,] tiles, int row, int column)
        {
            Tile[,] t = tiles;
            Tile tile = t[row, column];

            if (tile.canWalk()) { return true; }
            else { return false; }
        }
        */

    }
}
