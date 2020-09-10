namespace GeonBit.UI.Utils
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    internal class DefaultSpriteBatchWrapper : ISpriteBatchWrapper
    {
        public SpriteBatch Spritebatch { get; set; }

        public void Begin(
            SpriteSortMode sortMode = SpriteSortMode.Deferred,
            BlendState blendState = null,
            SamplerState samplerState = null,
            DepthStencilState depthStencilState = null,
            RasterizerState rasterizerState = null,
            Effect effect = null,
            Matrix? transformMatrix = null)
        {
            this.Spritebatch.Begin(sortMode, blendState, samplerState, depthStencilState, rasterizerState, effect, transformMatrix);
        }

        public void End()
        {
            this.Spritebatch.End();
        }

        public void Draw(Texture2D texture, Rectangle destRect, Color color)
        {
            this.Spritebatch.Draw(texture, destRect, color);
        }

        public void Draw(Texture2D texture, Rectangle destRect, Rectangle srcRect, Color color)
        {
            this.Spritebatch.Draw(texture, destRect, srcRect, color);
        }

        public void DrawString(
            SpriteFont spriteFont,
            string text,
            Vector2 position,
            Color color,
            float rotation,
            Vector2 origin,
            float scalef,
            SpriteEffects effects,
            float layerDepth)
        {
            this.Spritebatch.DrawString(spriteFont, text, position, color, rotation, origin, scalef, effects, layerDepth);
        }

        public GraphicDeviceWrapper GraphicsDevice { get; set; }
    }
}