using System;
using System.Collections;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace TestGame
{
    class SceneManager
    {
       //Refferes to the current Scene 
       private Scene _currentScene;
       public Scene currentScene
       {
           get
           {
               return _currentScene;
           }
           set
           {
               _currentScene = value;
           }
       }
       //Stack of All of our Scenes
        private ArrayList sceneStack = new ArrayList();
        //Constructor
        public SceneManager()
        {
        }

        public void PushScene(Scene newScene){
            sceneStack.Add(newScene);
            _currentScene = newScene;
        }

        public void PopScene(Scene oldScene)
        {
            sceneStack.Remove(oldScene);
            if (sceneStack.Count == 0)
            {
                _currentScene = null;
            }
            else
            {
                _currentScene = (Scene)sceneStack[sceneStack.Count - 1];
            }
        }

        public void DrawScene(Scene scene,GraphicsDevice graphicsDevice,SpriteBatch spriteBatch,GameTime gametime)
        {
            spriteBatch.Begin();
            graphicsDevice.Clear(Color.Black);
            Texture2D shape = new Texture2D(graphicsDevice, 1, 1);
            shape.SetData(new[] { Color.White });

            spriteBatch.Draw(shape, new Rectangle(0, 0, 100, 100), Color.White);
            spriteBatch.Draw(scene.background, new Rectangle(scene.x, scene.y, scene.width, scene.height), Color.White);
            foreach(Element element in scene.elements.ToArray()){
                if (element.visible == true)
                {
                    spriteBatch.Draw(element.image, new Rectangle(element.x, element.y, element.width, element.height), Color.White);
                }
            }
            spriteBatch.End();
            //_currentScene.Draw(gametime);
        }
    }
}
