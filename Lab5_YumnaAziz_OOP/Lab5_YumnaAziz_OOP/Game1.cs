using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Lab5_YumnaAziz_OOP
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Grid gridObject = new Grid();
        int[,] grid = {
            {3, 3, 3, 3, 3, 3, 3, 3, 3, 3},
            {3, 0 ,0, 1, 1, 2, 2, 0, 0, 3},
            {3, 0, 0, 0, 1, 2, 2, 2, 0, 3},
            {3, 0, 1, 1, 2, 2, 2, 0, 0, 3},
            {3, 0, 1, 0, 0, 2, 2, 2, 0, 3},
            {3, 1, 1, 0, 0, 0, 2, 2, 1, 3},
            {3, 0, 1, 1, 0, 0, 2, 1, 0, 3},
            {3, 1, 0, 2, 2, 0, 1, 0, 2, 3},
            {3, 2, 2, 0, 1, 0, 0, 0, 2, 3},
            {3, 3, 3, 3, 3, 3, 3, 3, 3, 3}
            };
        Tile[,] tiles = new Tile[10, 10];
        Texture2D[] images = new Texture2D[4]; //For tiles
        Texture2D[] playerImages = new Texture2D[8];
        Player player = new Player(1, 1); //Player starts on tile 1, 1;
        Rectangle playerPosition;
 
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferHeight = 600;
            graphics.PreferredBackBufferWidth = 600;
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            /*   y/x 0 1 2 3 4 5 6 7 8 9  x
               *   0 3 3 3 3 3 3 3 3 3 3
               *   1 3 0 0 1 1 2 2 0 0 3
               *   2 3 0 0 0 1 2 2 2 0 3
               *   3 3 0 1 1 2 2 2 0 0 3 
               *   4 3 0 1 0 0 2 2 2 0 3
               *   5 3 1 1 0 0 0 2 2 1 3
               *   6 3 0 1 1 0 0 2 1 0 3
               *   7 3 1 0 2 2 0 1 0 2 3
               *   8 3 2 2 0 1 0 0 0 2 3
               *   9 3 3 3 3 3 3 3 3 3 3
            */
            tiles = gridObject.Load(grid); //an array of object tiles
            playerPosition = new Rectangle(player.getPlayerX()* 60, player.getPlayerY() * 60, 55, 55);
                //player.getPlayerX(), player.getPlayerY(), 50, 50);
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            // if directioon = 0 up1, 1 up2, 2 down1 3 down2,  
            //Load the tiles in an array
            images[0] = Content.Load<Texture2D>("images/SandTile");
            images[1] = Content.Load<Texture2D>("images/GrassTile"); 
            images[2] = Content.Load<Texture2D>("images/WaterTile");
            images[3] = Content.Load<Texture2D>("images/RockTile");
            playerImages[0] = Content.Load<Texture2D>("images/Up1"); //
            playerImages[1] = Content.Load<Texture2D>("images/Up2");
            playerImages[2] = Content.Load<Texture2D>("images/Down1");
            playerImages[3] = Content.Load<Texture2D>("images/Down2");
            playerImages[4] = Content.Load<Texture2D>("images/Left1");
            playerImages[5] = Content.Load<Texture2D>("images/Left2");
            playerImages[6] = Content.Load<Texture2D>("images/Right1");
            playerImages[7] = Content.Load<Texture2D>("images/Right2");
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            KeyboardState keyboard = Keyboard.GetState();
            
            if(keyboard.IsKeyDown(Keys.Up))
            {
                playerPosition.Y =-1;
            }
            
            if(keyboard.IsKeyDown(Keys.Down))
            {
                playerPosition.Y =+1;
            }
            if(keyboard.IsKeyDown(Keys.Left))
            {
                playerPosition.X =-1;
            }
            if(keyboard.IsKeyDown(Keys.Right))
            {
                playerPosition.X =+1;
            }
            /*
            if(keyboard.IsKeyDown(Keys.Up))
            {
                if (player.canMove(gridObject, player.getPlayerX(), player.getPlayerY() - 1) == true)
                {
                   player.setPlayerY(player.getPlayerY() - 1);
                   playerPosition.Y = (player.getPlayerY() - 1);
                   player.setPlayerDirection(1);
                 
                }
            }
            
            if (keyboard.IsKeyDown(Keys.Down))
            {
                if (player.canMove(gridObject, player.getPlayerX(), player.getPlayerY() + 1) == true)
                {
                    player.setPlayerY(player.getPlayerY() + 1);
                    playerPosition.Y = (player.getPlayerY() + 1);
                    player.setPlayerDirection(2);
                }
            }

            if (keyboard.IsKeyDown(Keys.Left))
            {
                if (player.canMove(gridObject, player.getPlayerX()-1, player.getPlayerY()) == true)
                {
                    player.setPlayerX(player.getPlayerX() - 1);
                    playerPosition.X = (player.getPlayerX() - 1);
                    player.setPlayerDirection(4);
                }
            }

            if (keyboard.IsKeyDown(Keys.Right))
            {
                if (player.canMove(gridObject, player.getPlayerX() + 1, player.getPlayerY()) == true)
                {
                    player.setPlayerX(player.getPlayerX() + 1);
                    playerPosition.X = (player.getPlayerX() + 1);
                    player.setPlayerDirection(6);
                }
            }
            */
            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            
            spriteBatch.Begin();
            
            //tiles = gridObject.getTileArray();

            //
            for (int i = 0; i < 10; i++)
            {
                for(int j = 0; j<10; j++) 
                {
                    String type = tiles[i, j].getType();
                    if(type == "sand")
                    {
                        //Where 60 is the width and heigth of the tile
                        spriteBatch.Draw(images[0], new Vector2(60*i, 60*j), Color.White); 
                    }

                    if(type == "grass")
                    {
                        spriteBatch.Draw(images[1], new Vector2(60 * i, 60 * j), Color.White);
                    }

                    if (type == "water")
                    {
                        spriteBatch.Draw(images[2], new Vector2(60 * i, 60 * j), Color.White);
                    }

                    if (type == "rock")
                    {
                        spriteBatch.Draw(images[3], new Vector2(60 * i, 60 * j), Color.White);
                    }
                    //spriteBatch.Draw(tiles[i, j].getTile(), new Vector2(60*i, 60*j), Color.White);
                }
            }
            for(int i = 0; i<8; i++)
            {
                     if(player.getPlayerDirection() == i)
                {
                    spriteBatch.Draw(playerImages[i], playerPosition, Color.White);
                }
            }
           

            spriteBatch.End();


                // TODO: Add your drawing code here

                base.Draw(gameTime);
        }
    }
}
