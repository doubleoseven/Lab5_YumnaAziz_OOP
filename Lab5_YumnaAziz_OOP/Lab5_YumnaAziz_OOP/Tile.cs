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
    class Tile
    //Riles array in which to load each image. 
        //place the images in a tile ob
    {
        private String type; //Can be Water Land Grass or Rock
        private bool walk = true;
        private bool damage = true;
       // private Texture2D tileImage;
        private int height = 60;
        private int width = 60;
       // var listOfTiles = new List<Texture2D>
       // String[] tiles = new String[4];
      //  Texture2D[] tiles = new 
   // {"water", "land", "grass", "rock"};
        

        public Tile(String type1)
        {
            this.type = type1;
            //tileImage = null;
            
            if(type.ToLower() == "water")
            {
                walk = false;
                damage = true;
                //tileImage = tile;
                //LoadContent("WaterTile");
            }
            if(type.ToLower() == "land")
            {
                walk = true;
                damage = false;
                //tileImage = tile;
                //LoadContent("SandTile");
            }
            if(type.ToLower() == "grass")
            {
                walk = true;
                damage = false;
                //tileImage = tile;
                //LoadContent("GrassTile");
            }
            if(type.ToLower() == "rock")
            {
                walk = false;
                damage = false;
                //tileImage = tile;
                //LoadContent("RockTile");
            }

        }
        
        public Tile()
        {
            type = null;
            //tileImage = null;
        }

        public void setType(String type)
        {
            this.type = type;
        }
        

        public String getType()
        {
            return type;
        }
        /*
        public Texture2D getTile()
        {
            return tileImage;
        }

        public void setTile(Texture2D tile)
        {
            this.tileImage = tile;
        } */

        public bool canWalk()
        {
            return this.walk;
        }

        public bool causesDamage()
        {
            return this.damage;
        }

        public void setDamage (bool damage)
        {
            this.damage = damage;
        }

        public void setWalk (bool walk)
        {
            this.walk = walk;
        }

        public void setHeight(int height)
        {
            this.height = height;
        }

        public void setWidth(int width)
        {
            this.width = width;
        }

        public int getWidth()
        {
            return width;
        }

        public int getHeight()
        {
            return height;
        }

    }
}
