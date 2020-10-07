namespace FaceUI.Utils
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    using Color = Microsoft.Xna.Framework.Color;

    /// <summary>
    /// 
    /// </summary>
    public abstract class GraphicDeviceWrapper
    {
        /// <summary>
        /// 
        /// </summary>
        public abstract Rectangle Viewport { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="color"></param>
        public abstract void Clear(Color color);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="target"></param>
        public abstract void SetRenderTarget(RenderTarget2D target);

        /// <summary>
        /// 
        /// </summary>
        public abstract GraphicsDevice GraphicsDevice { get; }

        /// <summary>
        /// 
        /// </summary>
        public abstract PresentationParametersWrapper PresentationParameters { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="instance"></param>
        public static implicit operator GraphicsDevice(GraphicDeviceWrapper instance)
        {
            return instance.GraphicsDevice;
        }
    }
}