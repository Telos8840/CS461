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

        private void CreateScene(){
            sceneStack.Add(new Scene(10, 10, 10, 10, null));
        }
        private void DrawScene(GameTime gametime){
            _currentScene.Draw(gametime);
        }
    }
}
