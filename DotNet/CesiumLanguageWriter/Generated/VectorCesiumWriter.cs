// This file was generated automatically by GenerateFromSchema.  Do NOT edit it.
// https://github.com/AnalyticalGraphicsInc/czml-writer

using CesiumLanguageWriter.Advanced;
using System;
using System.Drawing;
using System.Collections.Generic;

namespace CesiumLanguageWriter
{
    /// <summary>
    /// Writes a <c>Vector</c> to a <see cref="CesiumOutputStream" />.  A <c>Vector</c> is defines a graphical vector that originates at the `position` property and extends in the provided direction for the provided length.
    /// </summary>
    public class VectorCesiumWriter : CesiumPropertyWriter<VectorCesiumWriter>
    {
        /// <summary>
        /// The name of the <c>show</c> property.
        /// </summary>
        public const string ShowPropertyName = "show";

        /// <summary>
        /// The name of the <c>color</c> property.
        /// </summary>
        public const string ColorPropertyName = "color";

        /// <summary>
        /// The name of the <c>direction</c> property.
        /// </summary>
        public const string DirectionPropertyName = "direction";

        /// <summary>
        /// The name of the <c>length</c> property.
        /// </summary>
        public const string LengthPropertyName = "length";

        /// <summary>
        /// The name of the <c>minimumLengthInPixels</c> property.
        /// </summary>
        public const string MinimumLengthInPixelsPropertyName = "minimumLengthInPixels";

        private readonly Lazy<BooleanCesiumWriter> m_show = new Lazy<BooleanCesiumWriter>(() => new BooleanCesiumWriter(ShowPropertyName), false);
        private readonly Lazy<ColorCesiumWriter> m_color = new Lazy<ColorCesiumWriter>(() => new ColorCesiumWriter(ColorPropertyName), false);
        private readonly Lazy<DirectionCesiumWriter> m_direction = new Lazy<DirectionCesiumWriter>(() => new DirectionCesiumWriter(DirectionPropertyName), false);
        private readonly Lazy<DoubleCesiumWriter> m_length = new Lazy<DoubleCesiumWriter>(() => new DoubleCesiumWriter(LengthPropertyName), false);
        private readonly Lazy<DoubleCesiumWriter> m_minimumLengthInPixels = new Lazy<DoubleCesiumWriter>(() => new DoubleCesiumWriter(MinimumLengthInPixelsPropertyName), false);

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        public VectorCesiumWriter(string propertyName)
            : base(propertyName)
        {
        }

        /// <summary>
        /// Initializes a new instance as a copy of an existing instance.
        /// </summary>
        /// <param name="existingInstance">The existing instance to copy.</param>
        protected VectorCesiumWriter(VectorCesiumWriter existingInstance)
            : base(existingInstance)
        {
        }

        /// <inheritdoc />
        public override VectorCesiumWriter Clone()
        {
            return new VectorCesiumWriter(this);
        }

        /// <summary>
        /// Gets the writer for the <c>show</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>show</c> property defines whether or not the vector is shown.
        /// </summary>
        public BooleanCesiumWriter ShowWriter
        {
            get { return m_show.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>show</c> property.  The <c>show</c> property defines whether or not the vector is shown.
        /// </summary>
        public BooleanCesiumWriter OpenShowProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(ShowWriter);
        }

        /// <summary>
        /// Writes a value for the <c>show</c> property as a <c>boolean</c> value.  The <c>show</c> property specifies whether or not the vector is shown.
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
        /// Writes a value for the <c>show</c> property as a <c>reference</c> value.  The <c>show</c> property specifies whether or not the vector is shown.
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
        /// Writes a value for the <c>show</c> property as a <c>reference</c> value.  The <c>show</c> property specifies whether or not the vector is shown.
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
        /// Writes a value for the <c>show</c> property as a <c>reference</c> value.  The <c>show</c> property specifies whether or not the vector is shown.
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
        /// Writes a value for the <c>show</c> property as a <c>reference</c> value.  The <c>show</c> property specifies whether or not the vector is shown.
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
        /// Gets the writer for the <c>color</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>color</c> property defines the color of the vector.
        /// </summary>
        public ColorCesiumWriter ColorWriter
        {
            get { return m_color.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>color</c> property.  The <c>color</c> property defines the color of the vector.
        /// </summary>
        public ColorCesiumWriter OpenColorProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(ColorWriter);
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgba</c> value.  The <c>color</c> property specifies the color of the vector.
        /// </summary>
        /// <param name="color">The color.</param>
        public void WriteColorProperty(Color color)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgba(color);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgba</c> value.  The <c>color</c> property specifies the color of the vector.
        /// </summary>
        /// <param name="red">The red component in the range 0 to 255.</param>
        /// <param name="green">The green component in the range 0 to 255.</param>
        /// <param name="blue">The blue component in the range 0 to 255.</param>
        /// <param name="alpha">The alpha component in the range 0 to 255.</param>
        public void WriteColorProperty(int red, int green, int blue, int alpha)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgba(red, green, blue, alpha);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgba</c> value.  The <c>color</c> property specifies the color of the vector.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteColorProperty(IList<JulianDate> dates, IList<Color> values)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgba(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgba</c> value.  The <c>color</c> property specifies the color of the vector.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="colors">The color corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to use in the `colors` collection.</param>
        /// <param name="length">The number of elements to use from the `colors` collection.</param>
        public void WriteColorProperty(IList<JulianDate> dates, IList<Color> colors, int startIndex, int length)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgba(dates, colors, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgbaf</c> value.  The <c>color</c> property specifies the color of the vector.
        /// </summary>
        /// <param name="color">The color.</param>
        public void WriteColorPropertyRgbaf(Color color)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgbaf(color);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgbaf</c> value.  The <c>color</c> property specifies the color of the vector.
        /// </summary>
        /// <param name="red">The red component in the range 0 to 1.0.</param>
        /// <param name="green">The green component in the range 0 to 1.0.</param>
        /// <param name="blue">The blue component in the range 0 to 1.0.</param>
        /// <param name="alpha">The alpha component in the range 0 to 1.0.</param>
        public void WriteColorPropertyRgbaf(float red, float green, float blue, float alpha)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgbaf(red, green, blue, alpha);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgbaf</c> value.  The <c>color</c> property specifies the color of the vector.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteColorPropertyRgbaf(IList<JulianDate> dates, IList<Color> values)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgbaf(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgbaf</c> value.  The <c>color</c> property specifies the color of the vector.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="colors">The color corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to use in the `colors` collection.</param>
        /// <param name="length">The number of elements to use from the `colors` collection.</param>
        public void WriteColorPropertyRgbaf(IList<JulianDate> dates, IList<Color> colors, int startIndex, int length)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgbaf(dates, colors, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>reference</c> value.  The <c>color</c> property specifies the color of the vector.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteColorPropertyReference(Reference value)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>reference</c> value.  The <c>color</c> property specifies the color of the vector.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteColorPropertyReference(string value)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>reference</c> value.  The <c>color</c> property specifies the color of the vector.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteColorPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>reference</c> value.  The <c>color</c> property specifies the color of the vector.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteColorPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>direction</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>direction</c> property defines the direction of the vector.
        /// </summary>
        public DirectionCesiumWriter DirectionWriter
        {
            get { return m_direction.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>direction</c> property.  The <c>direction</c> property defines the direction of the vector.
        /// </summary>
        public DirectionCesiumWriter OpenDirectionProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(DirectionWriter);
        }

        /// <summary>
        /// Writes a value for the <c>direction</c> property as a <c>spherical</c> value.  The <c>direction</c> property specifies the direction of the vector.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteDirectionProperty(Spherical value)
        {
            using (var writer = OpenDirectionProperty())
            {
                writer.WriteSpherical(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>direction</c> property as a <c>spherical</c> value.  The <c>direction</c> property specifies the direction of the vector.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteDirectionProperty(IList<JulianDate> dates, IList<Spherical> values)
        {
            using (var writer = OpenDirectionProperty())
            {
                writer.WriteSpherical(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>direction</c> property as a <c>spherical</c> value.  The <c>direction</c> property specifies the direction of the vector.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to use in the `values` collection.</param>
        /// <param name="length">The number of elements to use from the `values` collection.</param>
        public void WriteDirectionProperty(IList<JulianDate> dates, IList<Spherical> values, int startIndex, int length)
        {
            using (var writer = OpenDirectionProperty())
            {
                writer.WriteSpherical(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>direction</c> property as a <c>unitSpherical</c> value.  The <c>direction</c> property specifies the direction of the vector.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteDirectionPropertyUnitSpherical(UnitSpherical value)
        {
            using (var writer = OpenDirectionProperty())
            {
                writer.WriteUnitSpherical(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>direction</c> property as a <c>unitSpherical</c> value.  The <c>direction</c> property specifies the direction of the vector.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteDirectionPropertyUnitSpherical(IList<JulianDate> dates, IList<UnitSpherical> values)
        {
            using (var writer = OpenDirectionProperty())
            {
                writer.WriteUnitSpherical(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>direction</c> property as a <c>unitSpherical</c> value.  The <c>direction</c> property specifies the direction of the vector.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to use in the `values` collection.</param>
        /// <param name="length">The number of elements to use from the `values` collection.</param>
        public void WriteDirectionPropertyUnitSpherical(IList<JulianDate> dates, IList<UnitSpherical> values, int startIndex, int length)
        {
            using (var writer = OpenDirectionProperty())
            {
                writer.WriteUnitSpherical(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>direction</c> property as a <c>cartesian</c> value.  The <c>direction</c> property specifies the direction of the vector.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteDirectionPropertyCartesian(Cartesian value)
        {
            using (var writer = OpenDirectionProperty())
            {
                writer.WriteCartesian(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>direction</c> property as a <c>cartesian</c> value.  The <c>direction</c> property specifies the direction of the vector.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteDirectionPropertyCartesian(IList<JulianDate> dates, IList<Cartesian> values)
        {
            using (var writer = OpenDirectionProperty())
            {
                writer.WriteCartesian(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>direction</c> property as a <c>cartesian</c> value.  The <c>direction</c> property specifies the direction of the vector.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to use in the `values` collection.</param>
        /// <param name="length">The number of elements to use from the `values` collection.</param>
        public void WriteDirectionPropertyCartesian(IList<JulianDate> dates, IList<Cartesian> values, int startIndex, int length)
        {
            using (var writer = OpenDirectionProperty())
            {
                writer.WriteCartesian(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>direction</c> property as a <c>unitCartesian</c> value.  The <c>direction</c> property specifies the direction of the vector.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteDirectionPropertyUnitCartesian(UnitCartesian value)
        {
            using (var writer = OpenDirectionProperty())
            {
                writer.WriteUnitCartesian(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>direction</c> property as a <c>unitCartesian</c> value.  The <c>direction</c> property specifies the direction of the vector.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteDirectionPropertyUnitCartesian(IList<JulianDate> dates, IList<UnitCartesian> values)
        {
            using (var writer = OpenDirectionProperty())
            {
                writer.WriteUnitCartesian(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>direction</c> property as a <c>unitCartesian</c> value.  The <c>direction</c> property specifies the direction of the vector.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to use in the `values` collection.</param>
        /// <param name="length">The number of elements to use from the `values` collection.</param>
        public void WriteDirectionPropertyUnitCartesian(IList<JulianDate> dates, IList<UnitCartesian> values, int startIndex, int length)
        {
            using (var writer = OpenDirectionProperty())
            {
                writer.WriteUnitCartesian(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>direction</c> property as a <c>reference</c> value.  The <c>direction</c> property specifies the direction of the vector.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteDirectionPropertyReference(Reference value)
        {
            using (var writer = OpenDirectionProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>direction</c> property as a <c>reference</c> value.  The <c>direction</c> property specifies the direction of the vector.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteDirectionPropertyReference(string value)
        {
            using (var writer = OpenDirectionProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>direction</c> property as a <c>reference</c> value.  The <c>direction</c> property specifies the direction of the vector.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteDirectionPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenDirectionProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>direction</c> property as a <c>reference</c> value.  The <c>direction</c> property specifies the direction of the vector.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteDirectionPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenDirectionProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>length</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>length</c> property defines the graphical length of the vector.
        /// </summary>
        public DoubleCesiumWriter LengthWriter
        {
            get { return m_length.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>length</c> property.  The <c>length</c> property defines the graphical length of the vector.
        /// </summary>
        public DoubleCesiumWriter OpenLengthProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(LengthWriter);
        }

        /// <summary>
        /// Writes a value for the <c>length</c> property as a <c>number</c> value.  The <c>length</c> property specifies the graphical length of the vector.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteLengthProperty(double value)
        {
            using (var writer = OpenLengthProperty())
            {
                writer.WriteNumber(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>length</c> property as a <c>number</c> value.  The <c>length</c> property specifies the graphical length of the vector.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteLengthProperty(IList<JulianDate> dates, IList<double> values)
        {
            using (var writer = OpenLengthProperty())
            {
                writer.WriteNumber(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>length</c> property as a <c>number</c> value.  The <c>length</c> property specifies the graphical length of the vector.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The value corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to use in the `values` collection.</param>
        /// <param name="length">The number of elements to use from the `values` collection.</param>
        public void WriteLengthProperty(IList<JulianDate> dates, IList<double> values, int startIndex, int length)
        {
            using (var writer = OpenLengthProperty())
            {
                writer.WriteNumber(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>length</c> property as a <c>reference</c> value.  The <c>length</c> property specifies the graphical length of the vector.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteLengthPropertyReference(Reference value)
        {
            using (var writer = OpenLengthProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>length</c> property as a <c>reference</c> value.  The <c>length</c> property specifies the graphical length of the vector.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteLengthPropertyReference(string value)
        {
            using (var writer = OpenLengthProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>length</c> property as a <c>reference</c> value.  The <c>length</c> property specifies the graphical length of the vector.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteLengthPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenLengthProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>length</c> property as a <c>reference</c> value.  The <c>length</c> property specifies the graphical length of the vector.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteLengthPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenLengthProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>minimumLengthInPixels</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>minimumLengthInPixels</c> property defines the minimum graphical length of the vector in pixels.
        /// </summary>
        public DoubleCesiumWriter MinimumLengthInPixelsWriter
        {
            get { return m_minimumLengthInPixels.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>minimumLengthInPixels</c> property.  The <c>minimumLengthInPixels</c> property defines the minimum graphical length of the vector in pixels.
        /// </summary>
        public DoubleCesiumWriter OpenMinimumLengthInPixelsProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(MinimumLengthInPixelsWriter);
        }

        /// <summary>
        /// Writes a value for the <c>minimumLengthInPixels</c> property as a <c>number</c> value.  The <c>minimumLengthInPixels</c> property specifies the minimum graphical length of the vector in pixels.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteMinimumLengthInPixelsProperty(double value)
        {
            using (var writer = OpenMinimumLengthInPixelsProperty())
            {
                writer.WriteNumber(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>minimumLengthInPixels</c> property as a <c>number</c> value.  The <c>minimumLengthInPixels</c> property specifies the minimum graphical length of the vector in pixels.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteMinimumLengthInPixelsProperty(IList<JulianDate> dates, IList<double> values)
        {
            using (var writer = OpenMinimumLengthInPixelsProperty())
            {
                writer.WriteNumber(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>minimumLengthInPixels</c> property as a <c>number</c> value.  The <c>minimumLengthInPixels</c> property specifies the minimum graphical length of the vector in pixels.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The value corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to use in the `values` collection.</param>
        /// <param name="length">The number of elements to use from the `values` collection.</param>
        public void WriteMinimumLengthInPixelsProperty(IList<JulianDate> dates, IList<double> values, int startIndex, int length)
        {
            using (var writer = OpenMinimumLengthInPixelsProperty())
            {
                writer.WriteNumber(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>minimumLengthInPixels</c> property as a <c>reference</c> value.  The <c>minimumLengthInPixels</c> property specifies the minimum graphical length of the vector in pixels.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteMinimumLengthInPixelsPropertyReference(Reference value)
        {
            using (var writer = OpenMinimumLengthInPixelsProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>minimumLengthInPixels</c> property as a <c>reference</c> value.  The <c>minimumLengthInPixels</c> property specifies the minimum graphical length of the vector in pixels.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteMinimumLengthInPixelsPropertyReference(string value)
        {
            using (var writer = OpenMinimumLengthInPixelsProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>minimumLengthInPixels</c> property as a <c>reference</c> value.  The <c>minimumLengthInPixels</c> property specifies the minimum graphical length of the vector in pixels.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteMinimumLengthInPixelsPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenMinimumLengthInPixelsProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>minimumLengthInPixels</c> property as a <c>reference</c> value.  The <c>minimumLengthInPixels</c> property specifies the minimum graphical length of the vector in pixels.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteMinimumLengthInPixelsPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenMinimumLengthInPixelsProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

    }
}
