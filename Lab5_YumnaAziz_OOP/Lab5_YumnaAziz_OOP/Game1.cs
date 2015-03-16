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
 
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
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
             * 
             * 
             * 
             
            grid[0, 0] = 3;
            grid[0, 1] = 3;
            grid[0, 2] = 3;
            grid[0, 3] = 3;
            grid[0, 4] = 3;
            grid[0, 5] = 3;
            grid[0, 6] = 3;
            grid[0, 7] = 3;
            grid[0, 8] = 3;
            grid[0, 9] = 3;*/
           
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
            Tile[,] tiles = new Tile[10, 10];
            spriteBatch.Begin();
            tiles = gridObject.Load(grid); //an array of object tiles
            //tiles = gridObject.getTileArray();

            //
            for (int i = 0; i < 10; i++)
            {
                for(int j = 0; j<10; j++)
                {
                    spriteBatch.Draw(tiles[i, j].getTile(), new Vector2(60*i, 60*j), Color.White);
                }
            }

                // TODO: Add your drawing code here

                base.Draw(gameTime);
        }
    }
}
