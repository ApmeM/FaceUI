namespace FaceUI.Utils
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    /// <summary>
    /// 
    /// </summary>
    public class DefaultGraphicDeviceWrapper : GraphicDeviceWrapper
    {
        private GraphicsDevice graphicDevice;
        /// <summary>
        /// 
        /// </summary>
        public GraphicsDevice GraphicDevice
        {
            get => this.graphicDevice;
            set
            {
                this.graphicDevice = value;
                this.PresentationParameters.BackBufferFormat = value.PresentationParameters.BackBufferFormat;
                this.PresentationParameters.DepthStencilFormat = value.PresentationParameters.DepthStencilFormat;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public override GraphicsDevice GraphicsDevice => this.GraphicDevice;
        /// <summary>
        /// 
        /// </summary>
        public override PresentationParametersWrapper PresentationParameters { get; } = new PresentationParametersWrapper();
        /// <summary>
        /// 
        /// </summary>
        public override Rectangle Viewport => this.GraphicDevice.Viewport.Bounds;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="color"></param>
        public override void Clear(Color color)
        {
            this.GraphicDevice.Clear(color);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="target"></param>
        public override void SetRenderTarget(RenderTarget2D target)
        {
            this.GraphicDevice.SetRenderTarget(target);
        }
    }
}