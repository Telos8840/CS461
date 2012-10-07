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

//Github update test2

namespace TestGame
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {

        StateManager statemanager = new StateManager();
        Texture2D background;
        Texture2D player1;
        Vector2 position = new Vector2(50,50);
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        KeyboardState oldState;
        int currentFrame = 0;
        int direction = 0;
        float timer = 0f;
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
            background = Content.Load<Texture2D>(@"background");
            player1 = Content.Load<Texture2D>(@"player1");
            graphics.PreferredBackBufferWidth = background.Bounds.Width * 3;
            graphics.ApplyChanges();
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
        /// 

        private void initilize(GameTime gameTime)
        {
            var newState = Keyboard.GetState();
            if (!newState.IsKeyDown(Keys.Down) && oldState.IsKeyDown(Keys.Down))
            {
                if (statemanager.currentstate == StateManager.GameState.wagerloby)
                    statemanager.currentstate = StateManager.GameState.initilize;
                else
                    statemanager.currentstate++;
            }
            oldState = newState;
        }

        private void CheckPlayer(GameTime gameTime)
        {
            var newState = Keyboard.GetState();
            //key is let go
            if (!newState.IsKeyDown(Keys.Down) && oldState.IsKeyDown(Keys.Down))
            {
                direction = 0;
                currentFrame = 0;
            }
            else if (!newState.IsKeyDown(Keys.Left) && oldState.IsKeyDown(Keys.Left))
            {
                direction = 1;
                currentFrame = 0;
            }
            else if (!newState.IsKeyDown(Keys.Right) && oldState.IsKeyDown(Keys.Right))
            {
                direction = 2;
                currentFrame = 0;
            }
            else if (!newState.IsKeyDown(Keys.Up) && oldState.IsKeyDown(Keys.Up))
            {
                direction = 3;
                currentFrame = 0;
            }
            //key is held down
            timer += (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            if (newState.IsKeyDown(Keys.Left) && oldState.IsKeyDown(Keys.Left) && newState.IsKeyDown(Keys.Down) == false && newState.IsKeyDown(Keys.Right) == false && newState.IsKeyDown(Keys.Up) == false)
            {
                direction = 1;
                position.X -= 8;
                if (timer > 100f){
                    currentFrame++;
                    timer = 0f;
                }  
            }
            else if (newState.IsKeyDown(Keys.Right) && oldState.IsKeyDown(Keys.Right) && newState.IsKeyDown(Keys.Left) == false && newState.IsKeyDown(Keys.Down) == false && newState.IsKeyDown(Keys.Up) == false)
            {
                direction = 2;
                position.X += 8;
                if (timer > 100f)
                {
                    currentFrame++;
                    timer = 0f;
                }
            }
            else if (newState.IsKeyDown(Keys.Down) && oldState.IsKeyDown(Keys.Down) && newState.IsKeyDown(Keys.Left) == false && newState.IsKeyDown(Keys.Right) == false && newState.IsKeyDown(Keys.Up) == false)
            {
                direction = 0;
                position.Y += 8;
                if (timer > 100f)
                {
                    currentFrame++;
                    timer = 0f;
                }
            }
            else if (newState.IsKeyDown(Keys.Up) && oldState.IsKeyDown(Keys.Up) && newState.IsKeyDown(Keys.Left) == false && newState.IsKeyDown(Keys.Right) == false && newState.IsKeyDown(Keys.Down) == false)
            {
                direction = 3;
                position.Y -= 8;
                if (timer > 100f)
                {
                    currentFrame++;
                    timer = 0f;
                }
            }
            if (currentFrame > 3)
            {
                currentFrame = 0;
            }
            oldState = newState;
        }

        protected override void Update(GameTime gameTime)
        {
            switch(statemanager.currentstate){
                case StateManager.GameState.initilize:
                    initilize(gameTime);
                    break;
                case StateManager.GameState.menu:
                    initilize(gameTime);
                    break;
                case StateManager.GameState.playground:
                    CheckPlayer(gameTime);
                    break;
            }

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

            switch (statemanager.currentstate)
            {
                case StateManager.GameState.initilize:
                    GraphicsDevice.Clear(Color.Black);
                    break;
                case StateManager.GameState.menu:
                    GraphicsDevice.Clear(Color.Blue);
                    break;
                case StateManager.GameState.playground:
                    GraphicsDevice.Clear(Color.Green);
                    spriteBatch.Begin();
                    spriteBatch.Draw(background, new Rectangle(0, 0, background.Bounds.Width*3, background.Bounds.Height*3), Color.White);
                    position = new Vector2((int)position.X,(int)position.Y);
                    spriteBatch.Draw(player1, position, new Rectangle(currentFrame * 32, direction * 40, 32, 39), Color.White, 0, Vector2.Zero, 2, SpriteEffects.None, 0);
                    spriteBatch.End();
                    break;
            }
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
