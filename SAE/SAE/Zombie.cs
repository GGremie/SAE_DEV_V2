using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended.Content;
using MonoGame.Extended.Serialization;
using MonoGame.Extended.Sprites;
using MonoGame.Extended.Tiled;
using MonoGame.Extended.Tiled.Renderers;

namespace SAE
{
    internal class Zombie
    {
        //Content.RootDirectory = "Content";
        private Texture2D _textureZombNormal, _textureZombGros, _textureZombRapide;
        private Vector2 _positionZombie;
        private int vieZombie, vitesseZombie, nbZombies = 0;
        private string typeZombie;
        public const int VIE_NORMAL = 25, VIE_GROS  = 50, VIE_RAPIDE = 10;
        public const int VITESSE_NORMAL = 25, VITESSE_GROS = 10, VITESSE_RAPIDE = 50;
        

        public Zombie(string typeZombie)
        {
            this.TypeZombie = typeZombie;
        }

        public string TypeZombie
        {
            get
            {
                return this.typeZombie;
            }

            set
            {
                this.typeZombie = value;
            }
        }

        public Texture2D TextureZombie
        {
            get
            {
                return this._textureZombNormal;
            }

            set
            {
                this._textureZombNormal = value;
            }
        }

        public Vector2 PositionZombie
        {
            get
            {
                return this._positionZombie;
            }

            set
            {
                this._positionZombie = value;
            }
        }

        public void CreationZombie()
        {
            nbZombies += 1;
            switch (this.TypeZombie)
            {
                case "Normal":
                    this.vieZombie = SAE.Zombie.VIE_NORMAL;
                    this.vitesseZombie = SAE.Zombie.VITESSE_NORMAL;
                    break;
                case "Rapide":
                    this.vieZombie = SAE.Zombie.VIE_RAPIDE;
                    this.vitesseZombie = SAE.Zombie.VITESSE_RAPIDE;
                    break;
                case "Gros":
                    this.vieZombie = SAE.Zombie.VIE_GROS;
                    this.vitesseZombie = SAE.Zombie.VITESSE_GROS;
                    break;

            }
        }
        public int NbZombies()
        {
            return nbZombies;

        }

    }
}
