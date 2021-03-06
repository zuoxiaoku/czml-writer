﻿// <auto-generated>
// This file was generated automatically by GenerateFromSchema. Do NOT edit it.
// https://github.com/AnalyticalGraphicsInc/czml-writer
// </auto-generated>

using CesiumLanguageWriter.Advanced;
using System;
using JetBrains.Annotations;
using System.Collections.Generic;

namespace CesiumLanguageWriter
{
    /// <summary>
    /// Writes a <c>LineCount</c> to a <see cref="CesiumOutputStream"/>. A <c>LineCount</c> is the number of grid lines along each axis.
    /// </summary>
    public class LineCountCesiumWriter : CesiumInterpolatablePropertyWriter<LineCountCesiumWriter>, ICesiumDeletablePropertyWriter, ICesiumCartesian2ValuePropertyWriter, ICesiumReferenceValuePropertyWriter
    {
        /// <summary>
        /// The name of the <c>cartesian2</c> property.
        /// </summary>
        public const string Cartesian2PropertyName = "cartesian2";

        /// <summary>
        /// The name of the <c>reference</c> property.
        /// </summary>
        public const string ReferencePropertyName = "reference";

        /// <summary>
        /// The name of the <c>delete</c> property.
        /// </summary>
        public const string DeletePropertyName = "delete";

        private readonly Lazy<CesiumCartesian2ValuePropertyAdaptor<LineCountCesiumWriter>> m_asCartesian2;
        private readonly Lazy<CesiumReferenceValuePropertyAdaptor<LineCountCesiumWriter>> m_asReference;

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name="propertyName">The name of the property.</param>
        public LineCountCesiumWriter([NotNull] string propertyName)
            : base(propertyName)
        {
            m_asCartesian2 = CreateAsCartesian2();
            m_asReference = CreateAsReference();
        }

        /// <summary>
        /// Initializes a new instance as a copy of an existing instance.
        /// </summary>
        /// <param name="existingInstance">The existing instance to copy.</param>
        protected LineCountCesiumWriter([NotNull] LineCountCesiumWriter existingInstance)
            : base(existingInstance)
        {
            m_asCartesian2 = CreateAsCartesian2();
            m_asReference = CreateAsReference();
        }

        /// <inheritdoc/>
        public override LineCountCesiumWriter Clone()
        {
            return new LineCountCesiumWriter(this);
        }

        /// <summary>
        /// Writes the value expressed as a <c>cartesian2</c>, which is the number of grid lines along each axis.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteCartesian2(Rectangular value)
        {
            const string PropertyName = Cartesian2PropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteCartesian2(Output, value);
        }

        /// <summary>
        /// Writes the value expressed as a <c>cartesian2</c>, which is the number of grid lines along each axis.
        /// </summary>
        /// <param name="x">The X component.</param>
        /// <param name="y">The Y component.</param>
        public void WriteCartesian2(double x, double y)
        {
            WriteCartesian2(new Rectangular(x, y));
        }

        /// <summary>
        /// Writes the value expressed as a <c>cartesian2</c>, which is the number of grid lines along each axis.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteCartesian2(IList<JulianDate> dates, IList<Rectangular> values)
        {
            WriteCartesian2(dates, values, 0, dates.Count);
        }

        /// <summary>
        /// Writes the value expressed as a <c>cartesian2</c>, which is the number of grid lines along each axis.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteCartesian2(IList<JulianDate> dates, IList<Rectangular> values, int startIndex, int length)
        {
            const string PropertyName = Cartesian2PropertyName;
            OpenIntervalIfNecessary();
            CesiumWritingHelper.WriteCartesian2(Output, PropertyName, dates, values, startIndex, length);
        }

        /// <summary>
        /// Writes the value expressed as a <c>reference</c>, which is the number of grid lines along each axis specified as a reference to another property.
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
        /// Writes the value expressed as a <c>reference</c>, which is the number of grid lines along each axis specified as a reference to another property.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteReference(string value)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, value);
        }

        /// <summary>
        /// Writes the value expressed as a <c>reference</c>, which is the number of grid lines along each axis specified as a reference to another property.
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
        /// Writes the value expressed as a <c>reference</c>, which is the number of grid lines along each axis specified as a reference to another property.
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
        /// Writes the value expressed as a <c>delete</c>, which is whether the client should delete existing samples or interval data for this property. Data will be deleted for the containing interval, or if there is no containing interval, then all data. If true, all other properties in this property will be ignored.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteDelete(bool value)
        {
            const string PropertyName = DeletePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            Output.WriteValue(value);
        }

        /// <summary>
        /// Returns a wrapper for this instance that implements <see cref="ICesiumCartesian2ValuePropertyWriter"/>. Because the returned instance is a wrapper for this instance, you may call <see cref="ICesiumElementWriter.Close"/> on either this instance or the wrapper, but you must not call it on both.
        /// </summary>
        /// <returns>The wrapper.</returns>
        public CesiumCartesian2ValuePropertyAdaptor<LineCountCesiumWriter> AsCartesian2()
        {
            return m_asCartesian2.Value;
        }

        private Lazy<CesiumCartesian2ValuePropertyAdaptor<LineCountCesiumWriter>> CreateAsCartesian2()
        {
            return new Lazy<CesiumCartesian2ValuePropertyAdaptor<LineCountCesiumWriter>>(CreateCartesian2, false);
        }

        private CesiumCartesian2ValuePropertyAdaptor<LineCountCesiumWriter> CreateCartesian2()
        {
            return CesiumValuePropertyAdaptors.CreateCartesian2(this);
        }

        /// <summary>
        /// Returns a wrapper for this instance that implements <see cref="ICesiumReferenceValuePropertyWriter"/>. Because the returned instance is a wrapper for this instance, you may call <see cref="ICesiumElementWriter.Close"/> on either this instance or the wrapper, but you must not call it on both.
        /// </summary>
        /// <returns>The wrapper.</returns>
        public CesiumReferenceValuePropertyAdaptor<LineCountCesiumWriter> AsReference()
        {
            return m_asReference.Value;
        }

        private Lazy<CesiumReferenceValuePropertyAdaptor<LineCountCesiumWriter>> CreateAsReference()
        {
            return new Lazy<CesiumReferenceValuePropertyAdaptor<LineCountCesiumWriter>>(CreateReference, false);
        }

        private CesiumReferenceValuePropertyAdaptor<LineCountCesiumWriter> CreateReference()
        {
            return CesiumValuePropertyAdaptors.CreateReference(this);
        }

    }
}
