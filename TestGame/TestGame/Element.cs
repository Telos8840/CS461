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
    class Element
    {
        public int x;
        public int y;
        public int width;
        public int height;
        public Texture2D image;
        public bool visible;
        public int zlayer;
        public int dataID;
        public int type;

        public Element(int x,int y, Texture2D image)
        {
            this.x = x;
            this.y = y;
            this.image = image;
            this.width = image.Bounds.Width;
            this.height = image.Bounds.Height;
            this.visible = true;
        }

        public void OnClick()
        {
        }

        public void Draw()
        {
        }

        public void Update()
        {
        }

        public void Delete()
        {
        }

    }
}
