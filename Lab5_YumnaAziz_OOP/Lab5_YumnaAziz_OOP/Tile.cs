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
        private Texture2D tileImage;
        private Game1 game = new Game1();
        private int height = 60;
        private int width = 60;
       // var listOfTiles = new List<Texture2D>
       // String[] tiles = new String[4];
      //  Texture2D[] tiles = new 
   // {"water", "land", "grass", "rock"};
        

        public Tile(String type1)
        {
            this.type = type1;

            if(type.ToLower() == "water")
            {
                walk = true;
                damage = true;
                tileImage = game.Content.Load<Texture2D>("images/WaterTile");
            }
            if(type.ToLower() == "land")
            {
                walk = true;
                damage = false;
                tileImage = game.Content.Load<Texture2D>("images/SandTile");
            }
            if(type.ToLower() == "grass")
            {
                walk = true;
                damage = false;
                tileImage = game.Content.Load<Texture2D>("images/GrassTile");
            }
            if(type.ToLower() == "rock")
            {
                walk = false;
                damage = false;
                tileImage = game.Content.Load<Texture2D>("images/RockTile");
            }

        }
        

        public Tile()
        {
            type = null;
            tileImage = null;
        }
        
        /*
        public override void LoadContent()
        {
            tile = Game1.Equals.Content.Load<Texture2D>("WaterTile");
        }
        */

        public void setType(String type)
        {
            this.type = type;
        }

        public void setTile(Texture2D tile)
        {
            this.tileImage = tile;
        }

        public String getType()
        {
            return type;
        }

        public Texture2D getTile()
        {
            return tileImage;
        }

        public bool canWalk()
        {
            return walk;
        }

        public bool causesDamage()
        {
            return damage;
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


        
        /*
        public bool canWalk()
        {
            if(type == "water")
            {
                return (walk = false);
            }
            
            if(type == "land")
            {
                return walk;
            }
            if (type == "rock")
            {
                return walk = false;
            }

            else
                return walk;
        }
         */

    }
}
