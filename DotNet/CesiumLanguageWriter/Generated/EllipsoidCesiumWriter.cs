// This file was generated automatically by GenerateFromSchema.  Do NOT edit it.
// https://github.com/AnalyticalGraphicsInc/czml-writer

using CesiumLanguageWriter.Advanced;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace CesiumLanguageWriter
{
    /// <summary>
    /// Writes a <c>Ellipsoid</c> to a <see cref="CesiumOutputStream" />.  A <c>Ellipsoid</c> is a closed quadric surface that is a three dimensional analogue of an ellipse.
    /// </summary>
    public class EllipsoidCesiumWriter : CesiumPropertyWriter<EllipsoidCesiumWriter>
    {
        /// <summary>
        /// The name of the <c>show</c> property.
        /// </summary>
        public const string ShowPropertyName = "show";

        /// <summary>
        /// The name of the <c>radii</c> property.
        /// </summary>
        public const string RadiiPropertyName = "radii";

        /// <summary>
        /// The name of the <c>fill</c> property.
        /// </summary>
        public const string FillPropertyName = "fill";

        /// <summary>
        /// The name of the <c>material</c> property.
        /// </summary>
        public const string MaterialPropertyName = "material";

        /// <summary>
        /// The name of the <c>outline</c> property.
        /// </summary>
        public const string OutlinePropertyName = "outline";

        /// <summary>
        /// The name of the <c>outlineColor</c> property.
        /// </summary>
        public const string OutlineColorPropertyName = "outlineColor";

        /// <summary>
        /// The name of the <c>outlineWidth</c> property.
        /// </summary>
        public const string OutlineWidthPropertyName = "outlineWidth";

        /// <summary>
        /// The name of the <c>stackPartitions</c> property.
        /// </summary>
        public const string StackPartitionsPropertyName = "stackPartitions";

        /// <summary>
        /// The name of the <c>slicePartitions</c> property.
        /// </summary>
        public const string SlicePartitionsPropertyName = "slicePartitions";

        /// <summary>
        /// The name of the <c>subdivisions</c> property.
        /// </summary>
        public const string SubdivisionsPropertyName = "subdivisions";

        private readonly Lazy<BooleanCesiumWriter> m_show = new Lazy<BooleanCesiumWriter>(() => new BooleanCesiumWriter(ShowPropertyName), false);
        private readonly Lazy<EllipsoidRadiiCesiumWriter> m_radii = new Lazy<EllipsoidRadiiCesiumWriter>(() => new EllipsoidRadiiCesiumWriter(RadiiPropertyName), false);
        private readonly Lazy<BooleanCesiumWriter> m_fill = new Lazy<BooleanCesiumWriter>(() => new BooleanCesiumWriter(FillPropertyName), false);
        private readonly Lazy<MaterialCesiumWriter> m_material = new Lazy<MaterialCesiumWriter>(() => new MaterialCesiumWriter(MaterialPropertyName), false);
        private readonly Lazy<BooleanCesiumWriter> m_outline = new Lazy<BooleanCesiumWriter>(() => new BooleanCesiumWriter(OutlinePropertyName), false);
        private readonly Lazy<ColorCesiumWriter> m_outlineColor = new Lazy<ColorCesiumWriter>(() => new ColorCesiumWriter(OutlineColorPropertyName), false);
        private readonly Lazy<DoubleCesiumWriter> m_outlineWidth = new Lazy<DoubleCesiumWriter>(() => new DoubleCesiumWriter(OutlineWidthPropertyName), false);
        private readonly Lazy<DoubleCesiumWriter> m_stackPartitions = new Lazy<DoubleCesiumWriter>(() => new DoubleCesiumWriter(StackPartitionsPropertyName), false);
        private readonly Lazy<DoubleCesiumWriter> m_slicePartitions = new Lazy<DoubleCesiumWriter>(() => new DoubleCesiumWriter(SlicePartitionsPropertyName), false);
        private readonly Lazy<DoubleCesiumWriter> m_subdivisions = new Lazy<DoubleCesiumWriter>(() => new DoubleCesiumWriter(SubdivisionsPropertyName), false);

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        public EllipsoidCesiumWriter(string propertyName)
            : base(propertyName)
        {
        }

        /// <summary>
        /// Initializes a new instance as a copy of an existing instance.
        /// </summary>
        /// <param name="existingInstance">The existing instance to copy.</param>
        protected EllipsoidCesiumWriter(EllipsoidCesiumWriter existingInstance)
            : base(existingInstance)
        {
        }

        /// <inheritdoc />
        public override EllipsoidCesiumWriter Clone()
        {
            return new EllipsoidCesiumWriter(this);
        }

        /// <summary>
        /// Gets the writer for the <c>show</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>show</c> property defines whether or not the ellipsoid is shown.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        public BooleanCesiumWriter ShowWriter
        {
            get { return m_show.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>show</c> property.  The <c>show</c> property defines whether or not the ellipsoid is shown.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        public BooleanCesiumWriter OpenShowProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(ShowWriter);
        }

        /// <summary>
        /// Writes a value for the <c>show</c> property as a <c>boolean</c> value.  The <c>show</c> property specifies whether or not the ellipsoid is shown.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteShowProperty(bool value)
        {
            using (var writer = OpenShowProperty())
            {
                writer.WriteBoolean(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>show</c> property as a <c>reference</c> value.  The <c>show</c> property specifies whether or not the ellipsoid is shown.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteShowPropertyReference(Reference value)
        {
            using (var writer = OpenShowProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>show</c> property as a <c>reference</c> value.  The <c>show</c> property specifies whether or not the ellipsoid is shown.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteShowPropertyReference(string value)
        {
            using (var writer = OpenShowProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>show</c> property as a <c>reference</c> value.  The <c>show</c> property specifies whether or not the ellipsoid is shown.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteShowPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenShowProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>show</c> property as a <c>reference</c> value.  The <c>show</c> property specifies whether or not the ellipsoid is shown.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteShowPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenShowProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>radii</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>radii</c> property defines the dimensions of the ellipsoid.
        /// </summary>
        public EllipsoidRadiiCesiumWriter RadiiWriter
        {
            get { return m_radii.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>radii</c> property.  The <c>radii</c> property defines the dimensions of the ellipsoid.
        /// </summary>
        public EllipsoidRadiiCesiumWriter OpenRadiiProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(RadiiWriter);
        }

        /// <summary>
        /// Writes a value for the <c>radii</c> property as a <c>cartesian</c> value.  The <c>radii</c> property specifies the dimensions of the ellipsoid.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteRadiiProperty(Cartesian value)
        {
            using (var writer = OpenRadiiProperty())
            {
                writer.WriteCartesian(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>radii</c> property as a <c>cartesian</c> value.  The <c>radii</c> property specifies the dimensions of the ellipsoid.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteRadiiProperty(IList<JulianDate> dates, IList<Cartesian> values)
        {
            using (var writer = OpenRadiiProperty())
            {
                writer.WriteCartesian(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>radii</c> property as a <c>cartesian</c> value.  The <c>radii</c> property specifies the dimensions of the ellipsoid.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to use in the `values` collection.</param>
        /// <param name="length">The number of elements to use from the `values` collection.</param>
        public void WriteRadiiProperty(IList<JulianDate> dates, IList<Cartesian> values, int startIndex, int length)
        {
            using (var writer = OpenRadiiProperty())
            {
                writer.WriteCartesian(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>radii</c> property as a <c>reference</c> value.  The <c>radii</c> property specifies the dimensions of the ellipsoid.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteRadiiPropertyReference(Reference value)
        {
            using (var writer = OpenRadiiProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>radii</c> property as a <c>reference</c> value.  The <c>radii</c> property specifies the dimensions of the ellipsoid.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteRadiiPropertyReference(string value)
        {
            using (var writer = OpenRadiiProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>radii</c> property as a <c>reference</c> value.  The <c>radii</c> property specifies the dimensions of the ellipsoid.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteRadiiPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenRadiiProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>radii</c> property as a <c>reference</c> value.  The <c>radii</c> property specifies the dimensions of the ellipsoid.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteRadiiPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenRadiiProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>fill</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>fill</c> property defines whether or not the ellipsoid is filled.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        public BooleanCesiumWriter FillWriter
        {
            get { return m_fill.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>fill</c> property.  The <c>fill</c> property defines whether or not the ellipsoid is filled.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        public BooleanCesiumWriter OpenFillProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(FillWriter);
        }

        /// <summary>
        /// Writes a value for the <c>fill</c> property as a <c>boolean</c> value.  The <c>fill</c> property specifies whether or not the ellipsoid is filled.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteFillProperty(bool value)
        {
            using (var writer = OpenFillProperty())
            {
                writer.WriteBoolean(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>fill</c> property as a <c>reference</c> value.  The <c>fill</c> property specifies whether or not the ellipsoid is filled.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteFillPropertyReference(Reference value)
        {
            using (var writer = OpenFillProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>fill</c> property as a <c>reference</c> value.  The <c>fill</c> property specifies whether or not the ellipsoid is filled.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteFillPropertyReference(string value)
        {
            using (var writer = OpenFillProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>fill</c> property as a <c>reference</c> value.  The <c>fill</c> property specifies whether or not the ellipsoid is filled.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteFillPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenFillProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>fill</c> property as a <c>reference</c> value.  The <c>fill</c> property specifies whether or not the ellipsoid is filled.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteFillPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenFillProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>material</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>material</c> property defines the material to display on the surface of the ellipsoid.
        /// </summary>
        public MaterialCesiumWriter MaterialWriter
        {
            get { return m_material.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>material</c> property.  The <c>material</c> property defines the material to display on the surface of the ellipsoid.
        /// </summary>
        public MaterialCesiumWriter OpenMaterialProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(MaterialWriter);
        }

        /// <summary>
        /// Gets the writer for the <c>outline</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>outline</c> property defines whether or not the ellipsoid is outlined.  If not specified, the default value is <see langword="false"/>.
        /// </summary>
        public BooleanCesiumWriter OutlineWriter
        {
            get { return m_outline.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>outline</c> property.  The <c>outline</c> property defines whether or not the ellipsoid is outlined.  If not specified, the default value is <see langword="false"/>.
        /// </summary>
        public BooleanCesiumWriter OpenOutlineProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(OutlineWriter);
        }

        /// <summary>
        /// Writes a value for the <c>outline</c> property as a <c>boolean</c> value.  The <c>outline</c> property specifies whether or not the ellipsoid is outlined.  If not specified, the default value is <see langword="false"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteOutlineProperty(bool value)
        {
            using (var writer = OpenOutlineProperty())
            {
                writer.WriteBoolean(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outline</c> property as a <c>reference</c> value.  The <c>outline</c> property specifies whether or not the ellipsoid is outlined.  If not specified, the default value is <see langword="false"/>.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteOutlinePropertyReference(Reference value)
        {
            using (var writer = OpenOutlineProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outline</c> property as a <c>reference</c> value.  The <c>outline</c> property specifies whether or not the ellipsoid is outlined.  If not specified, the default value is <see langword="false"/>.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteOutlinePropertyReference(string value)
        {
            using (var writer = OpenOutlineProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outline</c> property as a <c>reference</c> value.  The <c>outline</c> property specifies whether or not the ellipsoid is outlined.  If not specified, the default value is <see langword="false"/>.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteOutlinePropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenOutlineProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outline</c> property as a <c>reference</c> value.  The <c>outline</c> property specifies whether or not the ellipsoid is outlined.  If not specified, the default value is <see langword="false"/>.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteOutlinePropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenOutlineProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>outlineColor</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>outlineColor</c> property defines the color of the ellipsoid outline.
        /// </summary>
        public ColorCesiumWriter OutlineColorWriter
        {
            get { return m_outlineColor.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>outlineColor</c> property.  The <c>outlineColor</c> property defines the color of the ellipsoid outline.
        /// </summary>
        public ColorCesiumWriter OpenOutlineColorProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(OutlineColorWriter);
        }

        /// <summary>
        /// Writes a value for the <c>outlineColor</c> property as a <c>rgba</c> value.  The <c>outlineColor</c> property specifies the color of the ellipsoid outline.
        /// </summary>
        /// <param name="color">The color.</param>
        public void WriteOutlineColorProperty(Color color)
        {
            using (var writer = OpenOutlineColorProperty())
            {
                writer.WriteRgba(color);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outlineColor</c> property as a <c>rgba</c> value.  The <c>outlineColor</c> property specifies the color of the ellipsoid outline.
        /// </summary>
        /// <param name="red">The red component in the range 0 to 255.</param>
        /// <param name="green">The green component in the range 0 to 255.</param>
        /// <param name="blue">The blue component in the range 0 to 255.</param>
        /// <param name="alpha">The alpha component in the range 0 to 255.</param>
        public void WriteOutlineColorProperty(int red, int green, int blue, int alpha)
        {
            using (var writer = OpenOutlineColorProperty())
            {
                writer.WriteRgba(red, green, blue, alpha);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outlineColor</c> property as a <c>rgba</c> value.  The <c>outlineColor</c> property specifies the color of the ellipsoid outline.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteOutlineColorProperty(IList<JulianDate> dates, IList<Color> values)
        {
            using (var writer = OpenOutlineColorProperty())
            {
                writer.WriteRgba(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outlineColor</c> property as a <c>rgba</c> value.  The <c>outlineColor</c> property specifies the color of the ellipsoid outline.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="colors">The color corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to use in the `colors` collection.</param>
        /// <param name="length">The number of elements to use from the `colors` collection.</param>
        public void WriteOutlineColorProperty(IList<JulianDate> dates, IList<Color> colors, int startIndex, int length)
        {
            using (var writer = OpenOutlineColorProperty())
            {
                writer.WriteRgba(dates, colors, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outlineColor</c> property as a <c>rgbaf</c> value.  The <c>outlineColor</c> property specifies the color of the ellipsoid outline.
        /// </summary>
        /// <param name="color">The color.</param>
        public void WriteOutlineColorPropertyRgbaf(Color color)
        {
            using (var writer = OpenOutlineColorProperty())
            {
                writer.WriteRgbaf(color);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outlineColor</c> property as a <c>rgbaf</c> value.  The <c>outlineColor</c> property specifies the color of the ellipsoid outline.
        /// </summary>
        /// <param name="red">The red component in the range 0 to 1.0.</param>
        /// <param name="green">The green component in the range 0 to 1.0.</param>
        /// <param name="blue">The blue component in the range 0 to 1.0.</param>
        /// <param name="alpha">The alpha component in the range 0 to 1.0.</param>
        public void WriteOutlineColorPropertyRgbaf(float red, float green, float blue, float alpha)
        {
            using (var writer = OpenOutlineColorProperty())
            {
                writer.WriteRgbaf(red, green, blue, alpha);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outlineColor</c> property as a <c>rgbaf</c> value.  The <c>outlineColor</c> property specifies the color of the ellipsoid outline.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteOutlineColorPropertyRgbaf(IList<JulianDate> dates, IList<Color> values)
        {
            using (var writer = OpenOutlineColorProperty())
            {
                writer.WriteRgbaf(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outlineColor</c> property as a <c>rgbaf</c> value.  The <c>outlineColor</c> property specifies the color of the ellipsoid outline.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="colors">The color corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to use in the `colors` collection.</param>
        /// <param name="length">The number of elements to use from the `colors` collection.</param>
        public void WriteOutlineColorPropertyRgbaf(IList<JulianDate> dates, IList<Color> colors, int startIndex, int length)
        {
            using (var writer = OpenOutlineColorProperty())
            {
                writer.WriteRgbaf(dates, colors, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outlineColor</c> property as a <c>reference</c> value.  The <c>outlineColor</c> property specifies the color of the ellipsoid outline.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteOutlineColorPropertyReference(Reference value)
        {
            using (var writer = OpenOutlineColorProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outlineColor</c> property as a <c>reference</c> value.  The <c>outlineColor</c> property specifies the color of the ellipsoid outline.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteOutlineColorPropertyReference(string value)
        {
            using (var writer = OpenOutlineColorProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outlineColor</c> property as a <c>reference</c> value.  The <c>outlineColor</c> property specifies the color of the ellipsoid outline.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteOutlineColorPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenOutlineColorProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outlineColor</c> property as a <c>reference</c> value.  The <c>outlineColor</c> property specifies the color of the ellipsoid outline.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteOutlineColorPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenOutlineColorProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>outlineWidth</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>outlineWidth</c> property defines the width of the ellipsoid outline.  If not specified, the default value is 1.0.
        /// </summary>
        public DoubleCesiumWriter OutlineWidthWriter
        {
            get { return m_outlineWidth.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>outlineWidth</c> property.  The <c>outlineWidth</c> property defines the width of the ellipsoid outline.  If not specified, the default value is 1.0.
        /// </summary>
        public DoubleCesiumWriter OpenOutlineWidthProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(OutlineWidthWriter);
        }

        /// <summary>
        /// Writes a value for the <c>outlineWidth</c> property as a <c>number</c> value.  The <c>outlineWidth</c> property specifies the width of the ellipsoid outline.  If not specified, the default value is 1.0.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteOutlineWidthProperty(double value)
        {
            using (var writer = OpenOutlineWidthProperty())
            {
                writer.WriteNumber(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outlineWidth</c> property as a <c>number</c> value.  The <c>outlineWidth</c> property specifies the width of the ellipsoid outline.  If not specified, the default value is 1.0.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteOutlineWidthProperty(IList<JulianDate> dates, IList<double> values)
        {
            using (var writer = OpenOutlineWidthProperty())
            {
                writer.WriteNumber(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outlineWidth</c> property as a <c>number</c> value.  The <c>outlineWidth</c> property specifies the width of the ellipsoid outline.  If not specified, the default value is 1.0.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The value corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to use in the `values` collection.</param>
        /// <param name="length">The number of elements to use from the `values` collection.</param>
        public void WriteOutlineWidthProperty(IList<JulianDate> dates, IList<double> values, int startIndex, int length)
        {
            using (var writer = OpenOutlineWidthProperty())
            {
                writer.WriteNumber(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outlineWidth</c> property as a <c>reference</c> value.  The <c>outlineWidth</c> property specifies the width of the ellipsoid outline.  If not specified, the default value is 1.0.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteOutlineWidthPropertyReference(Reference value)
        {
            using (var writer = OpenOutlineWidthProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outlineWidth</c> property as a <c>reference</c> value.  The <c>outlineWidth</c> property specifies the width of the ellipsoid outline.  If not specified, the default value is 1.0.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteOutlineWidthPropertyReference(string value)
        {
            using (var writer = OpenOutlineWidthProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outlineWidth</c> property as a <c>reference</c> value.  The <c>outlineWidth</c> property specifies the width of the ellipsoid outline.  If not specified, the default value is 1.0.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteOutlineWidthPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenOutlineWidthProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outlineWidth</c> property as a <c>reference</c> value.  The <c>outlineWidth</c> property specifies the width of the ellipsoid outline.  If not specified, the default value is 1.0.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteOutlineWidthPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenOutlineWidthProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>stackPartitions</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>stackPartitions</c> property defines the number of times to partition the ellipsoid into stacks.
        /// </summary>
        public DoubleCesiumWriter StackPartitionsWriter
        {
            get { return m_stackPartitions.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>stackPartitions</c> property.  The <c>stackPartitions</c> property defines the number of times to partition the ellipsoid into stacks.
        /// </summary>
        public DoubleCesiumWriter OpenStackPartitionsProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(StackPartitionsWriter);
        }

        /// <summary>
        /// Writes a value for the <c>stackPartitions</c> property as a <c>number</c> value.  The <c>stackPartitions</c> property specifies the number of times to partition the ellipsoid into stacks.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteStackPartitionsProperty(double value)
        {
            using (var writer = OpenStackPartitionsProperty())
            {
                writer.WriteNumber(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>stackPartitions</c> property as a <c>number</c> value.  The <c>stackPartitions</c> property specifies the number of times to partition the ellipsoid into stacks.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteStackPartitionsProperty(IList<JulianDate> dates, IList<double> values)
        {
            using (var writer = OpenStackPartitionsProperty())
            {
                writer.WriteNumber(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>stackPartitions</c> property as a <c>number</c> value.  The <c>stackPartitions</c> property specifies the number of times to partition the ellipsoid into stacks.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The value corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to use in the `values` collection.</param>
        /// <param name="length">The number of elements to use from the `values` collection.</param>
        public void WriteStackPartitionsProperty(IList<JulianDate> dates, IList<double> values, int startIndex, int length)
        {
            using (var writer = OpenStackPartitionsProperty())
            {
                writer.WriteNumber(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>stackPartitions</c> property as a <c>reference</c> value.  The <c>stackPartitions</c> property specifies the number of times to partition the ellipsoid into stacks.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteStackPartitionsPropertyReference(Reference value)
        {
            using (var writer = OpenStackPartitionsProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>stackPartitions</c> property as a <c>reference</c> value.  The <c>stackPartitions</c> property specifies the number of times to partition the ellipsoid into stacks.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteStackPartitionsPropertyReference(string value)
        {
            using (var writer = OpenStackPartitionsProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>stackPartitions</c> property as a <c>reference</c> value.  The <c>stackPartitions</c> property specifies the number of times to partition the ellipsoid into stacks.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteStackPartitionsPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenStackPartitionsProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>stackPartitions</c> property as a <c>reference</c> value.  The <c>stackPartitions</c> property specifies the number of times to partition the ellipsoid into stacks.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteStackPartitionsPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenStackPartitionsProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>slicePartitions</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>slicePartitions</c> property defines the number of times to partition the ellipsoid into radial slices.
        /// </summary>
        public DoubleCesiumWriter SlicePartitionsWriter
        {
            get { return m_slicePartitions.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>slicePartitions</c> property.  The <c>slicePartitions</c> property defines the number of times to partition the ellipsoid into radial slices.
        /// </summary>
        public DoubleCesiumWriter OpenSlicePartitionsProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(SlicePartitionsWriter);
        }

        /// <summary>
        /// Writes a value for the <c>slicePartitions</c> property as a <c>number</c> value.  The <c>slicePartitions</c> property specifies the number of times to partition the ellipsoid into radial slices.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteSlicePartitionsProperty(double value)
        {
            using (var writer = OpenSlicePartitionsProperty())
            {
                writer.WriteNumber(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>slicePartitions</c> property as a <c>number</c> value.  The <c>slicePartitions</c> property specifies the number of times to partition the ellipsoid into radial slices.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteSlicePartitionsProperty(IList<JulianDate> dates, IList<double> values)
        {
            using (var writer = OpenSlicePartitionsProperty())
            {
                writer.WriteNumber(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>slicePartitions</c> property as a <c>number</c> value.  The <c>slicePartitions</c> property specifies the number of times to partition the ellipsoid into radial slices.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The value corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to use in the `values` collection.</param>
        /// <param name="length">The number of elements to use from the `values` collection.</param>
        public void WriteSlicePartitionsProperty(IList<JulianDate> dates, IList<double> values, int startIndex, int length)
        {
            using (var writer = OpenSlicePartitionsProperty())
            {
                writer.WriteNumber(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>slicePartitions</c> property as a <c>reference</c> value.  The <c>slicePartitions</c> property specifies the number of times to partition the ellipsoid into radial slices.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteSlicePartitionsPropertyReference(Reference value)
        {
            using (var writer = OpenSlicePartitionsProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>slicePartitions</c> property as a <c>reference</c> value.  The <c>slicePartitions</c> property specifies the number of times to partition the ellipsoid into radial slices.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteSlicePartitionsPropertyReference(string value)
        {
            using (var writer = OpenSlicePartitionsProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>slicePartitions</c> property as a <c>reference</c> value.  The <c>slicePartitions</c> property specifies the number of times to partition the ellipsoid into radial slices.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteSlicePartitionsPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenSlicePartitionsProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>slicePartitions</c> property as a <c>reference</c> value.  The <c>slicePartitions</c> property specifies the number of times to partition the ellipsoid into radial slices.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteSlicePartitionsPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenSlicePartitionsProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>subdivisions</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>subdivisions</c> property defines the number of samples per outline ring, determining the granularity of the curvature.
        /// </summary>
        public DoubleCesiumWriter SubdivisionsWriter
        {
            get { return m_subdivisions.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>subdivisions</c> property.  The <c>subdivisions</c> property defines the number of samples per outline ring, determining the granularity of the curvature.
        /// </summary>
        public DoubleCesiumWriter OpenSubdivisionsProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(SubdivisionsWriter);
        }

        /// <summary>
        /// Writes a value for the <c>subdivisions</c> property as a <c>number</c> value.  The <c>subdivisions</c> property specifies the number of samples per outline ring, determining the granularity of the curvature.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteSubdivisionsProperty(double value)
        {
            using (var writer = OpenSubdivisionsProperty())
            {
                writer.WriteNumber(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>subdivisions</c> property as a <c>number</c> value.  The <c>subdivisions</c> property specifies the number of samples per outline ring, determining the granularity of the curvature.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteSubdivisionsProperty(IList<JulianDate> dates, IList<double> values)
        {
            using (var writer = OpenSubdivisionsProperty())
            {
                writer.WriteNumber(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>subdivisions</c> property as a <c>number</c> value.  The <c>subdivisions</c> property specifies the number of samples per outline ring, determining the granularity of the curvature.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The value corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to use in the `values` collection.</param>
        /// <param name="length">The number of elements to use from the `values` collection.</param>
        public void WriteSubdivisionsProperty(IList<JulianDate> dates, IList<double> values, int startIndex, int length)
        {
            using (var writer = OpenSubdivisionsProperty())
            {
                writer.WriteNumber(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>subdivisions</c> property as a <c>reference</c> value.  The <c>subdivisions</c> property specifies the number of samples per outline ring, determining the granularity of the curvature.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteSubdivisionsPropertyReference(Reference value)
        {
            using (var writer = OpenSubdivisionsProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>subdivisions</c> property as a <c>reference</c> value.  The <c>subdivisions</c> property specifies the number of samples per outline ring, determining the granularity of the curvature.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteSubdivisionsPropertyReference(string value)
        {
            using (var writer = OpenSubdivisionsProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>subdivisions</c> property as a <c>reference</c> value.  The <c>subdivisions</c> property specifies the number of samples per outline ring, determining the granularity of the curvature.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteSubdivisionsPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenSubdivisionsProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>subdivisions</c> property as a <c>reference</c> value.  The <c>subdivisions</c> property specifies the number of samples per outline ring, determining the granularity of the curvature.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteSubdivisionsPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenSubdivisionsProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

    }
}
