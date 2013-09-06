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

namespace StarDefenseProject
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {

        // Declaration section
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        
        AnimatedSprite Explosion;
        
        Background background;
       
        Player player;
        public int iPlayAreaTop = 30;
        public int iPlayAreaBottom = 630;
        int iMaxHorizontalSpeed = 8;
        float fBoardUpdateDelay = 0f;
        float fBoardUpdateInterval = 0.01f;


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

            graphics.PreferredBackBufferHeight = 720;
            graphics.PreferredBackBufferWidth = 1280;
            graphics.ApplyChanges();
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
            Explosion = new AnimatedSprite(
              Content.Load<Texture2D>(@"Textures\Explosions"),
              0, 0, 64, 64, 16);
            Explosion.X = 0;
            Explosion.Y = 0;

            background = new Background(
                Content,
                @"Textures\PrimaryBackground",
                @"Textures\ParallaxStars");

            player = new Player(Content.Load<Texture2D>(@"Textures\PlayerShip"));

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

            // Controls
                   protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();
 
            player.SpeedChangeCount += (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (player.SpeedChangeCount > player.SpeedChangeDelay)
            {
                CheckHorizontalMovementKeys(Keyboard.GetState(),
                                            GamePad.GetState(PlayerIndex.One));
            }
 
            player.VerticalChangeCount += (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (player.VerticalChangeCount > player.VerticalChangeDelay)
            {
                CheckVerticalMovementKeys(Keyboard.GetState(),
                                          GamePad.GetState(PlayerIndex.One));
            }
            player.Update(gameTime);
 
            fBoardUpdateDelay += (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (fBoardUpdateDelay > fBoardUpdateInterval)
            {
                fBoardUpdateDelay = 0f;
                UpdateBoard();
            }
 
            // TODO: Add your update logic here
            Explosion.Update(gameTime);
            base.Update(gameTime);
        }


        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            spriteBatch.Begin();

            background.Draw(spriteBatch);

            player.Draw(spriteBatch);

        

            // Player movement under controls

            protected void CheckHorizontalMovementKeys(KeyboardState ksKeys,
                                           GamePadState gsPad)
        {
            bool bResetTimer = false;
 
            player.Thrusting = false;
            if ((ksKeys.IsKeyDown(Keys.Right)) ||
                (gsPad.ThumbSticks.Left.X > 0))
            {
                if (player.ScrollRate < iMaxHorizontalSpeed)
                {
                    player.ScrollRate += player.AccelerationRate;
                    if (player.ScrollRate > iMaxHorizontalSpeed)
                        player.ScrollRate = iMaxHorizontalSpeed;
                    bResetTimer = true;
                }
                player.Thrusting = true;
                player.Facing = 0;
            }
 
            if ((ksKeys.IsKeyDown(Keys.Left)) ||
                (gsPad.ThumbSticks.Left.X < 0))
            {
                if (player.ScrollRate > -iMaxHorizontalSpeed)
                {
                    player.ScrollRate -= player.AccelerationRate;
                    if (player.ScrollRate < -iMaxHorizontalSpeed)
                        player.ScrollRate = -iMaxHorizontalSpeed;
                    bResetTimer = true;
                }
                player.Thrusting = true;
                player.Facing = 1;
            }
 
            if (bResetTimer)
                player.SpeedChangeCount = 0.0f;
        }

        protected void CheckVerticalMovementKeys(KeyboardState ksKeys,
                                         GamePadState gsPad)
        {
 
            bool bResetTimer = false;
            
            if ((ksKeys.IsKeyDown(Keys.Up)) ||
                (gsPad.ThumbSticks.Left.Y > 0))
            {
                if (player.Y > iPlayAreaTop)
                {
                    player.Y -= player.VerticalMovementRate;
                    bResetTimer = true;
                }
            }
 
            if ((ksKeys.IsKeyDown(Keys.Down)) ||
                (gsPad.ThumbSticks.Left.Y < 0))
            {
                if (player.Y < iPlayAreaBottom)
                {
                    player.Y += player.VerticalMovementRate;
                    bResetTimer = true;
                }
            }
 
            if (bResetTimer)
                player.VerticalChangeCount = 0f;
        }

        // For updating the game board during update cycle
                public void UpdateBoard()
        {
            background.BackgroundOffset += player.ScrollRate;
            background.ParallaxOffset += player.ScrollRate * 2;
        }

            Explosion.Draw(spriteBatch, 0, 0, false);

            
            spriteBatch.End();
            base.Draw(gameTime);
             }
        }
    }
}
