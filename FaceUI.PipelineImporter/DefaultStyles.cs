namespace FaceUI.PipelineImporter
{
    using System.Xml;

    using FaceUI.DataTypes;

    using Microsoft.Xna.Framework.Content.Pipeline;
    using Microsoft.Xna.Framework.Content.Pipeline.Processors;
    using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Compiler;
    using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Intermediate;

    [ContentImporter(".XML", DefaultProcessor = nameof(PassThroughProcessor), DisplayName = "Face UI style Importer")]
    public class DefaultStylesImporter : ContentImporter<DefaultStylesList>
    {
        public override DefaultStylesList Import(string filename, ContentImporterContext context)
        {
            context.Logger.LogMessage("Importing style file: {0}", filename);
            using (var input = XmlReader.Create(filename))
            {
                return IntermediateSerializer.Deserialize<DefaultStylesList>(input, string.Empty);
            }
        }
    }

    [ContentTypeWriter]
    public class DefaultStylesWriter : ContentTypeWriter<DefaultStylesList>
    {
        protected override void Write(ContentWriter writer, DefaultStylesList data)
        {
            writer.Write(data.Styles?.Length ?? 0);
            for(var i = 0; i < (data.Styles?.Length ?? 0); i++)
            {
                this.Write(writer, data.Styles[i]);
            }
        }

        protected void Write(ContentWriter writer, DefaultStyles data)
        {
            writer.Write(data.Scale != null);
            if (data.Scale != null)
            {
                writer.Write(data.Scale.Value);
            }

            writer.Write(data.FillColor != null);
            if (data.FillColor != null)
            {
                writer.Write(data.FillColor.Value.PackedValue);
            }

            writer.Write(data.OutlineColor != null);
            if (data.OutlineColor != null)
            {
                writer.Write(data.OutlineColor.Value.PackedValue);
            }

            writer.Write(data.OutlineWidth != null);
            if (data.OutlineWidth != null)
            {
                writer.Write(data.OutlineWidth.Value);
            }

            writer.Write(data.ForceAlignCenter != null);
            if (data.ForceAlignCenter != null)
            {
                writer.Write(data.ForceAlignCenter.Value);
            }

            writer.Write(data.FontStyle != null);
            if (data.FontStyle != null)
            {
                writer.Write((int)data.FontStyle.Value);
            }

            writer.Write(data.SelectedHighlightColor != null);
            if (data.SelectedHighlightColor != null)
            {
                writer.Write(data.SelectedHighlightColor.Value.PackedValue);
            }

            writer.Write(data.ShadowColor != null);
            if (data.ShadowColor != null)
            {
                writer.Write(data.ShadowColor.Value.PackedValue);
            }

            writer.Write(data.ShadowOffset != null);
            if (data.ShadowOffset != null)
            {
                writer.Write(data.ShadowOffset.Value.X);
                writer.Write(data.ShadowOffset.Value.Y);
            }

            writer.Write(data.Padding != null);
            if (data.Padding != null)
            {
                writer.Write(data.Padding.Value.X);
                writer.Write(data.Padding.Value.Y);
            }

            writer.Write(data.SpaceBefore != null);
            if (data.SpaceBefore != null)
            {
                writer.Write(data.SpaceBefore.Value.X);
                writer.Write(data.SpaceBefore.Value.Y);
            }

            writer.Write(data.SpaceAfter != null);
            if (data.SpaceAfter != null)
            {
                writer.Write(data.SpaceAfter.Value.X);
                writer.Write(data.SpaceAfter.Value.Y);
            }

            writer.Write(data.ShadowScale != null);
            if (data.ShadowScale != null)
            {
                writer.Write(data.ShadowScale.Value);
            }

            writer.Write(data.DefaultSize != null);
            if (data.DefaultSize != null)
            {
                writer.Write(data.DefaultSize.Value.X);
                writer.Write(data.DefaultSize.Value.Y);
            }
        }

        public override string GetRuntimeType(TargetPlatform targetPlatform)
        {
            return typeof(DefaultStyles).AssemblyQualifiedName;
        }


        public override string GetRuntimeReader(TargetPlatform targetPlatform)
        {
            return typeof(DefaultStylesReader).AssemblyQualifiedName;
        }
    }
}