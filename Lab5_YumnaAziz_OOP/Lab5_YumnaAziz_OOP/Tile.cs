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
    {
        private String type; //Can be Water Land Grass or Rock
        private bool walk = true;
        private bool damage = true;
        private int height = 60;
        private int width = 60;
        

        public Tile(String type1)
        {
            this.type = type1;

            if(type.ToLower() == "water")
            {
                walk = false;
                damage = true;
            }
            if(type.ToLower() == "land")
            {
                walk = true;
                damage = false;
            }
            if(type.ToLower() == "grass")
            {
                walk = true;
                damage = false;
            }
            if(type.ToLower() == "rock")
            {
                walk = false;
                damage = false;
            }

        }
        

        public void setType(String type)
        {
            this.type = type;
        }

        public String getType()
        {
            return type;
        }
        
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
