// This file was generated automatically by GenerateFromSchema.  Do NOT edit it.
// https://github.com/AnalyticalGraphicsInc/czml-writer

using CesiumLanguageWriter.Advanced;
using System;
using System.Collections.Generic;

namespace CesiumLanguageWriter
{
    /// <summary>
    /// Writes a <c>NearFarScalar</c> to a <see cref="CesiumOutputStream" />.  A <c>NearFarScalar</c> is a numeric value which will be linearly interpolated between two values based on an object's distance from the camera, in eye coordinates.  The computed value will interpolate between the near value and the far value while the camera distance falls between the near distance and the far distance, and will be clamped to the near or far value while the distance is less than the near distance or greater than the far distance, respectively.
    /// </summary>
    public class NearFarScalarCesiumWriter : CesiumInterpolatablePropertyWriter<NearFarScalarCesiumWriter>
    {
        /// <summary>
        /// The name of the <c>nearFarScalar</c> property.
        /// </summary>
        public const string NearFarScalarPropertyName = "nearFarScalar";

        /// <summary>
        /// The name of the <c>reference</c> property.
        /// </summary>
        public const string ReferencePropertyName = "reference";

        private readonly Lazy<ICesiumInterpolatableValuePropertyWriter<NearFarScalar>> m_asNearFarScalar;
        private readonly Lazy<ICesiumValuePropertyWriter<Reference>> m_asReference;

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        public NearFarScalarCesiumWriter(string propertyName)
            : base(propertyName)
        {
            m_asNearFarScalar = new Lazy<ICesiumInterpolatableValuePropertyWriter<NearFarScalar>>(CreateNearFarScalarAdaptor, false);
            m_asReference = new Lazy<ICesiumValuePropertyWriter<Reference>>(CreateReferenceAdaptor, false);
        }

        /// <summary>
        /// Initializes a new instance as a copy of an existing instance.
        /// </summary>
        /// <param name="existingInstance">The existing instance to copy.</param>
        protected NearFarScalarCesiumWriter(NearFarScalarCesiumWriter existingInstance)
            : base(existingInstance)
        {
            m_asNearFarScalar = new Lazy<ICesiumInterpolatableValuePropertyWriter<NearFarScalar>>(CreateNearFarScalarAdaptor, false);
            m_asReference = new Lazy<ICesiumValuePropertyWriter<Reference>>(CreateReferenceAdaptor, false);
        }

        /// <inheritdoc />
        public override NearFarScalarCesiumWriter Clone()
        {
            return new NearFarScalarCesiumWriter(this);
        }

        /// <summary>
        /// Writes the value expressed as a <c>nearFarScalar</c>, which is the value specified as four values `[NearDistance, NearValue, FarDistance, FarValue]`, with distances in eye coordinates in meters.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteNearFarScalar(NearFarScalar value)
        {
            const string PropertyName = NearFarScalarPropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteNearFarScalar(Output, value);
        }

        /// <summary>
        /// Writes the value expressed as a <c>nearFarScalar</c>, which is the value specified as four values `[NearDistance, NearValue, FarDistance, FarValue]`, with distances in eye coordinates in meters.
        /// </summary>
        /// <param name="nearDistance">The lower bound of the camera distance range.</param>
        /// <param name="nearValue">The value to use at the lower bound of the camera distance range.</param>
        /// <param name="farDistance">The upper bound of the camera distance range.</param>
        /// <param name="farValue">The value to use at the upper bound of the camera distance range.</param>
        public void WriteNearFarScalar(double nearDistance, double nearValue, double farDistance, double farValue)
        {
            WriteNearFarScalar(new NearFarScalar(nearDistance, nearValue, farDistance, farValue));
        }

        /// <summary>
        /// Writes the value expressed as a <c>nearFarScalar</c>, which is the value specified as four values `[NearDistance, NearValue, FarDistance, FarValue]`, with distances in eye coordinates in meters.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteNearFarScalar(IList<JulianDate> dates, IList<NearFarScalar> values)
        {
            WriteNearFarScalar(dates, values, 0, dates.Count);
        }

        /// <summary>
        /// Writes the value expressed as a <c>nearFarScalar</c>, which is the value specified as four values `[NearDistance, NearValue, FarDistance, FarValue]`, with distances in eye coordinates in meters.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to use in the `values` collection.</param>
        /// <param name="length">The number of elements to use from the `values` collection.</param>
        public void WriteNearFarScalar(IList<JulianDate> dates, IList<NearFarScalar> values, int startIndex, int length)
        {
            const string PropertyName = NearFarScalarPropertyName;
            OpenIntervalIfNecessary();
            CesiumWritingHelper.WriteNearFarScalar(Output, PropertyName, dates, values, startIndex, length);
        }

        /// <summary>
        /// Writes the value expressed as a <c>reference</c>, which is the value specified as a reference to another property.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteReference(Reference value)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, value);
        }

        /// <summary>
        /// Writes the value expressed as a <c>reference</c>, which is the value specified as a reference to another property.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteReference(string value)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, value);
        }

        /// <summary>
        /// Writes the value expressed as a <c>reference</c>, which is the value specified as a reference to another property.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteReference(string identifier, string propertyName)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, identifier, propertyName);
        }

        /// <summary>
        /// Writes the value expressed as a <c>reference</c>, which is the value specified as a reference to another property.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteReference(string identifier, string[] propertyNames)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, identifier, propertyNames);
        }

        /// <summary>
        /// Returns a wrapper for this instance that implements <see cref="ICesiumInterpolatableValuePropertyWriter{T}" /> to write a value in <c>NearFarScalar</c> format.  Because the returned instance is a wrapper for this instance, you may call <see cref="ICesiumElementWriter.Close" /> on either this instance or the wrapper, but you must not call it on both.
        /// </summary>
        /// <returns>The wrapper.</returns>
        public ICesiumInterpolatableValuePropertyWriter<NearFarScalar> AsNearFarScalar()
        {
            return m_asNearFarScalar.Value;
        }

        private ICesiumInterpolatableValuePropertyWriter<NearFarScalar> CreateNearFarScalarAdaptor()
        {
            return new CesiumInterpolatableWriterAdaptor<NearFarScalarCesiumWriter, NearFarScalar>(this, (me, value) => me.WriteNearFarScalar(value), (me, dates, values, startIndex, length) => me.WriteNearFarScalar(dates, values, startIndex, length));
        }

        /// <summary>
        /// Returns a wrapper for this instance that implements <see cref="ICesiumValuePropertyWriter{T}" /> to write a value in <c>Reference</c> format.  Because the returned instance is a wrapper for this instance, you may call <see cref="ICesiumElementWriter.Close" /> on either this instance or the wrapper, but you must not call it on both.
        /// </summary>
        /// <returns>The wrapper.</returns>
        public ICesiumValuePropertyWriter<Reference> AsReference()
        {
            return m_asReference.Value;
        }

        private ICesiumValuePropertyWriter<Reference> CreateReferenceAdaptor()
        {
            return new CesiumWriterAdaptor<NearFarScalarCesiumWriter, Reference>(this, (me, value) => me.WriteReference(value));
        }

    }
}
