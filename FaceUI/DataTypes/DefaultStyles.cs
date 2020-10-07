using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace FaceUI.DataTypes
{
    /// <summary>
    /// Font styles (should match the font styles defined in FaceUI engine).
    /// </summary>
    public enum _FontStyle
    {
        Regular,
        Bold,
        Italic
    };

    /// <summary>
    /// All the stylesheet possible settings for an entity state.
    /// </summary>
    public class DefaultStyles
    {
        // entity scale
        public float? Scale = null;

        // fill color
        public Color? FillColor = null;

        // outline color
        public Color? OutlineColor = null;

        // outline width
        public int? OutlineWidth = null;

        // for paragraph only - align to center
        public bool? ForceAlignCenter = null;

        // for paragraph only - font style
        public _FontStyle? FontStyle = null;

        // for lists etc - selected highlight background color
        public Color? SelectedHighlightColor = null;

        // shadow color (set to 00000000 for no shadow)
        public Color? ShadowColor = null;

        // shadow offset
        public Vector2? ShadowOffset = null;

        // padding
        public Vector2? Padding = null;

        // space before
        public Vector2? SpaceBefore = null;

        // space after
        public Vector2? SpaceAfter = null;

        // shadow scale
        public float? ShadowScale = null;

        // default entity size
        public Vector2? DefaultSize = null;
    }
}
