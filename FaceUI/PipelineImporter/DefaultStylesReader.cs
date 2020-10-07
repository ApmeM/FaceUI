namespace FaceUI.PipelineImporter
{
    using FaceUI.DataTypes;

    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;

    public class DefaultStylesReader: ContentTypeReader<DefaultStyles>
    {
        protected override DefaultStyles Read(ContentReader reader, DefaultStyles existingInstance)
        {
            var result = new DefaultStyles();
            if (reader.ReadBoolean())
            {
                result.Scale = reader.ReadSingle();
            }
            if (reader.ReadBoolean())
            {
                result.FillColor = new Color(reader.ReadUInt32());
            }
            if (reader.ReadBoolean())
            {
                result.OutlineColor = new Color(reader.ReadUInt32());
            }
            if (reader.ReadBoolean())
            {
                result.OutlineWidth = reader.ReadInt32();
            }
            if (reader.ReadBoolean())
            {
                result.ForceAlignCenter = reader.ReadBoolean();
            }
            if (reader.ReadBoolean())
            {
                result.FontStyle = (_FontStyle)reader.ReadInt32();
            }
            if (reader.ReadBoolean())
            {
                result.SelectedHighlightColor = new Color(reader.ReadUInt32());
            }
            if (reader.ReadBoolean())
            {
                result.ShadowColor = new Color(reader.ReadUInt32());
            }
            if (reader.ReadBoolean())
            {
                result.ShadowOffset = new Vector2(reader.ReadSingle(), reader.ReadSingle());
            }
            if (reader.ReadBoolean())
            {
                result.Padding = new Vector2(reader.ReadSingle(), reader.ReadSingle());
            }
            if (reader.ReadBoolean())
            {
                result.SpaceBefore = new Vector2(reader.ReadSingle(), reader.ReadSingle());
            }
            if (reader.ReadBoolean())
            {
                result.SpaceAfter = new Vector2(reader.ReadSingle(), reader.ReadSingle());
            }
            if (reader.ReadBoolean())
            {
                result.ShadowScale = reader.ReadSingle();
            }
            if (reader.ReadBoolean())
            {
                result.DefaultSize = new Vector2(reader.ReadSingle(), reader.ReadSingle());
            }

            return result;
        }
    }
}