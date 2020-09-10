namespace GeonBit.UI.Utils
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    /// <summary>
    /// Wrapper for sprite batch to draw in a way you may want
    /// </summary>
    public interface ISpriteBatchWrapper
    {
        /// <summary>
        /// Begin
        /// </summary>
        void Begin(
            SpriteSortMode sortMode = SpriteSortMode.Deferred,
            BlendState blendState = null,
            SamplerState samplerState = null,
            DepthStencilState depthStencilState = null,
            RasterizerState rasterizerState = null,
            Effect effect = null,
            Matrix? transformMatrix = null);

        /// <summary>
        /// End
        /// </summary>
        void End();

        /// <summary>
        /// Draw
        /// </summary>
        void Draw(Texture2D texture, Rectangle destRect, Color color);

        /// <summary>
        /// Draw
        /// </summary>
        void Draw(Texture2D texture, Rectangle destRect, Rectangle srcRect, Color color);

        /// <summary>
        /// DrawString
        /// </summary>
        void DrawString(
            SpriteFont spriteFont,
            string text,
            Vector2 position,
            Color color,
            float rotation,
            Vector2 origin,
            float scalef,
            SpriteEffects effects,
            float layerDepth);

        /// <summary>
        /// GraphicsDevice
        /// </summary>
        GraphicDeviceWrapper GraphicsDevice { get; }
    }
}