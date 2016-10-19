// This file was generated automatically by GenerateFromSchema.  Do NOT edit it.
// https://github.com/AnalyticalGraphicsInc/czml-writer

using CesiumLanguageWriter.Advanced;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace CesiumLanguageWriter
{
    /// <summary>
    /// Writes a <c>ConicSensor</c> to a <see cref="CesiumOutputStream" />.  A <c>ConicSensor</c> is a conical sensor volume taking into account occlusion of an ellipsoid, i.e., the globe.
    /// </summary>
    public class ConicSensorCesiumWriter : CesiumPropertyWriter<ConicSensorCesiumWriter>
    {
        /// <summary>
        /// The name of the <c>show</c> property.
        /// </summary>
        public const string ShowPropertyName = "show";

        /// <summary>
        /// The name of the <c>innerHalfAngle</c> property.
        /// </summary>
        public const string InnerHalfAnglePropertyName = "innerHalfAngle";

        /// <summary>
        /// The name of the <c>outerHalfAngle</c> property.
        /// </summary>
        public const string OuterHalfAnglePropertyName = "outerHalfAngle";

        /// <summary>
        /// The name of the <c>minimumClockAngle</c> property.
        /// </summary>
        public const string MinimumClockAnglePropertyName = "minimumClockAngle";

        /// <summary>
        /// The name of the <c>maximumClockAngle</c> property.
        /// </summary>
        public const string MaximumClockAnglePropertyName = "maximumClockAngle";

        /// <summary>
        /// The name of the <c>radius</c> property.
        /// </summary>
        public const string RadiusPropertyName = "radius";

        /// <summary>
        /// The name of the <c>showIntersection</c> property.
        /// </summary>
        public const string ShowIntersectionPropertyName = "showIntersection";

        /// <summary>
        /// The name of the <c>intersectionColor</c> property.
        /// </summary>
        public const string IntersectionColorPropertyName = "intersectionColor";

        /// <summary>
        /// The name of the <c>intersectionWidth</c> property.
        /// </summary>
        public const string IntersectionWidthPropertyName = "intersectionWidth";

        /// <summary>
        /// The name of the <c>showLateralSurfaces</c> property.
        /// </summary>
        public const string ShowLateralSurfacesPropertyName = "showLateralSurfaces";

        /// <summary>
        /// The name of the <c>lateralSurfaceMaterial</c> property.
        /// </summary>
        public const string LateralSurfaceMaterialPropertyName = "lateralSurfaceMaterial";

        /// <summary>
        /// The name of the <c>showEllipsoidSurfaces</c> property.
        /// </summary>
        public const string ShowEllipsoidSurfacesPropertyName = "showEllipsoidSurfaces";

        /// <summary>
        /// The name of the <c>ellipsoidSurfaceMaterial</c> property.
        /// </summary>
        public const string EllipsoidSurfaceMaterialPropertyName = "ellipsoidSurfaceMaterial";

        /// <summary>
        /// The name of the <c>showEllipsoidHorizonSurfaces</c> property.
        /// </summary>
        public const string ShowEllipsoidHorizonSurfacesPropertyName = "showEllipsoidHorizonSurfaces";

        /// <summary>
        /// The name of the <c>ellipsoidHorizonSurfaceMaterial</c> property.
        /// </summary>
        public const string EllipsoidHorizonSurfaceMaterialPropertyName = "ellipsoidHorizonSurfaceMaterial";

        /// <summary>
        /// The name of the <c>showDomeSurfaces</c> property.
        /// </summary>
        public const string ShowDomeSurfacesPropertyName = "showDomeSurfaces";

        /// <summary>
        /// The name of the <c>domeSurfaceMaterial</c> property.
        /// </summary>
        public const string DomeSurfaceMaterialPropertyName = "domeSurfaceMaterial";

        /// <summary>
        /// The name of the <c>portionToDisplay</c> property.
        /// </summary>
        public const string PortionToDisplayPropertyName = "portionToDisplay";

        /// <summary>
        /// The name of the <c>environmentConstraint</c> property.
        /// </summary>
        public const string EnvironmentConstraintPropertyName = "environmentConstraint";

        /// <summary>
        /// The name of the <c>showEnvironmentOcclusion</c> property.
        /// </summary>
        public const string ShowEnvironmentOcclusionPropertyName = "showEnvironmentOcclusion";

        /// <summary>
        /// The name of the <c>environmentOcclusionMaterial</c> property.
        /// </summary>
        public const string EnvironmentOcclusionMaterialPropertyName = "environmentOcclusionMaterial";

        /// <summary>
        /// The name of the <c>showEnvironmentIntersection</c> property.
        /// </summary>
        public const string ShowEnvironmentIntersectionPropertyName = "showEnvironmentIntersection";

        /// <summary>
        /// The name of the <c>environmentIntersectionColor</c> property.
        /// </summary>
        public const string EnvironmentIntersectionColorPropertyName = "environmentIntersectionColor";

        /// <summary>
        /// The name of the <c>environmentIntersectionWidth</c> property.
        /// </summary>
        public const string EnvironmentIntersectionWidthPropertyName = "environmentIntersectionWidth";

        private readonly Lazy<BooleanCesiumWriter> m_show = new Lazy<BooleanCesiumWriter>(() => new BooleanCesiumWriter(ShowPropertyName), false);
        private readonly Lazy<DoubleCesiumWriter> m_innerHalfAngle = new Lazy<DoubleCesiumWriter>(() => new DoubleCesiumWriter(InnerHalfAnglePropertyName), false);
        private readonly Lazy<DoubleCesiumWriter> m_outerHalfAngle = new Lazy<DoubleCesiumWriter>(() => new DoubleCesiumWriter(OuterHalfAnglePropertyName), false);
        private readonly Lazy<DoubleCesiumWriter> m_minimumClockAngle = new Lazy<DoubleCesiumWriter>(() => new DoubleCesiumWriter(MinimumClockAnglePropertyName), false);
        private readonly Lazy<DoubleCesiumWriter> m_maximumClockAngle = new Lazy<DoubleCesiumWriter>(() => new DoubleCesiumWriter(MaximumClockAnglePropertyName), false);
        private readonly Lazy<DoubleCesiumWriter> m_radius = new Lazy<DoubleCesiumWriter>(() => new DoubleCesiumWriter(RadiusPropertyName), false);
        private readonly Lazy<BooleanCesiumWriter> m_showIntersection = new Lazy<BooleanCesiumWriter>(() => new BooleanCesiumWriter(ShowIntersectionPropertyName), false);
        private readonly Lazy<ColorCesiumWriter> m_intersectionColor = new Lazy<ColorCesiumWriter>(() => new ColorCesiumWriter(IntersectionColorPropertyName), false);
        private readonly Lazy<DoubleCesiumWriter> m_intersectionWidth = new Lazy<DoubleCesiumWriter>(() => new DoubleCesiumWriter(IntersectionWidthPropertyName), false);
        private readonly Lazy<BooleanCesiumWriter> m_showLateralSurfaces = new Lazy<BooleanCesiumWriter>(() => new BooleanCesiumWriter(ShowLateralSurfacesPropertyName), false);
        private readonly Lazy<MaterialCesiumWriter> m_lateralSurfaceMaterial = new Lazy<MaterialCesiumWriter>(() => new MaterialCesiumWriter(LateralSurfaceMaterialPropertyName), false);
        private readonly Lazy<BooleanCesiumWriter> m_showEllipsoidSurfaces = new Lazy<BooleanCesiumWriter>(() => new BooleanCesiumWriter(ShowEllipsoidSurfacesPropertyName), false);
        private readonly Lazy<MaterialCesiumWriter> m_ellipsoidSurfaceMaterial = new Lazy<MaterialCesiumWriter>(() => new MaterialCesiumWriter(EllipsoidSurfaceMaterialPropertyName), false);
        private readonly Lazy<BooleanCesiumWriter> m_showEllipsoidHorizonSurfaces = new Lazy<BooleanCesiumWriter>(() => new BooleanCesiumWriter(ShowEllipsoidHorizonSurfacesPropertyName), false);
        private readonly Lazy<MaterialCesiumWriter> m_ellipsoidHorizonSurfaceMaterial = new Lazy<MaterialCesiumWriter>(() => new MaterialCesiumWriter(EllipsoidHorizonSurfaceMaterialPropertyName), false);
        private readonly Lazy<BooleanCesiumWriter> m_showDomeSurfaces = new Lazy<BooleanCesiumWriter>(() => new BooleanCesiumWriter(ShowDomeSurfacesPropertyName), false);
        private readonly Lazy<MaterialCesiumWriter> m_domeSurfaceMaterial = new Lazy<MaterialCesiumWriter>(() => new MaterialCesiumWriter(DomeSurfaceMaterialPropertyName), false);
        private readonly Lazy<SensorVolumePortionToDisplayCesiumWriter> m_portionToDisplay = new Lazy<SensorVolumePortionToDisplayCesiumWriter>(() => new SensorVolumePortionToDisplayCesiumWriter(PortionToDisplayPropertyName), false);
        private readonly Lazy<BooleanCesiumWriter> m_environmentConstraint = new Lazy<BooleanCesiumWriter>(() => new BooleanCesiumWriter(EnvironmentConstraintPropertyName), false);
        private readonly Lazy<BooleanCesiumWriter> m_showEnvironmentOcclusion = new Lazy<BooleanCesiumWriter>(() => new BooleanCesiumWriter(ShowEnvironmentOcclusionPropertyName), false);
        private readonly Lazy<MaterialCesiumWriter> m_environmentOcclusionMaterial = new Lazy<MaterialCesiumWriter>(() => new MaterialCesiumWriter(EnvironmentOcclusionMaterialPropertyName), false);
        private readonly Lazy<BooleanCesiumWriter> m_showEnvironmentIntersection = new Lazy<BooleanCesiumWriter>(() => new BooleanCesiumWriter(ShowEnvironmentIntersectionPropertyName), false);
        private readonly Lazy<ColorCesiumWriter> m_environmentIntersectionColor = new Lazy<ColorCesiumWriter>(() => new ColorCesiumWriter(EnvironmentIntersectionColorPropertyName), false);
        private readonly Lazy<DoubleCesiumWriter> m_environmentIntersectionWidth = new Lazy<DoubleCesiumWriter>(() => new DoubleCesiumWriter(EnvironmentIntersectionWidthPropertyName), false);

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        public ConicSensorCesiumWriter(string propertyName)
            : base(propertyName)
        {
        }

        /// <summary>
        /// Initializes a new instance as a copy of an existing instance.
        /// </summary>
        /// <param name="existingInstance">The existing instance to copy.</param>
        protected ConicSensorCesiumWriter(ConicSensorCesiumWriter existingInstance)
            : base(existingInstance)
        {
        }

        /// <inheritdoc />
        public override ConicSensorCesiumWriter Clone()
        {
            return new ConicSensorCesiumWriter(this);
        }

        /// <summary>
        /// Gets the writer for the <c>show</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>show</c> property defines whether or not the entire conical sensor is shown.
        /// </summary>
        public BooleanCesiumWriter ShowWriter
        {
            get { return m_show.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>show</c> property.  The <c>show</c> property defines whether or not the entire conical sensor is shown.
        /// </summary>
        public BooleanCesiumWriter OpenShowProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(ShowWriter);
        }

        /// <summary>
        /// Writes a value for the <c>show</c> property as a <c>boolean</c> value.  The <c>show</c> property specifies whether or not the entire conical sensor is shown.
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
        /// Writes a value for the <c>show</c> property as a <c>reference</c> value.  The <c>show</c> property specifies whether or not the entire conical sensor is shown.
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
        /// Writes a value for the <c>show</c> property as a <c>reference</c> value.  The <c>show</c> property specifies whether or not the entire conical sensor is shown.
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
        /// Writes a value for the <c>show</c> property as a <c>reference</c> value.  The <c>show</c> property specifies whether or not the entire conical sensor is shown.
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
        /// Writes a value for the <c>show</c> property as a <c>reference</c> value.  The <c>show</c> property specifies whether or not the entire conical sensor is shown.
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
        /// Gets the writer for the <c>innerHalfAngle</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>innerHalfAngle</c> property defines the inner half angle of the cone.
        /// </summary>
        public DoubleCesiumWriter InnerHalfAngleWriter
        {
            get { return m_innerHalfAngle.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>innerHalfAngle</c> property.  The <c>innerHalfAngle</c> property defines the inner half angle of the cone.
        /// </summary>
        public DoubleCesiumWriter OpenInnerHalfAngleProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(InnerHalfAngleWriter);
        }

        /// <summary>
        /// Writes a value for the <c>innerHalfAngle</c> property as a <c>number</c> value.  The <c>innerHalfAngle</c> property specifies the inner half angle of the cone.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteInnerHalfAngleProperty(double value)
        {
            using (var writer = OpenInnerHalfAngleProperty())
            {
                writer.WriteNumber(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>innerHalfAngle</c> property as a <c>number</c> value.  The <c>innerHalfAngle</c> property specifies the inner half angle of the cone.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteInnerHalfAngleProperty(IList<JulianDate> dates, IList<double> values)
        {
            using (var writer = OpenInnerHalfAngleProperty())
            {
                writer.WriteNumber(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>innerHalfAngle</c> property as a <c>number</c> value.  The <c>innerHalfAngle</c> property specifies the inner half angle of the cone.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The value corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to use in the `values` collection.</param>
        /// <param name="length">The number of elements to use from the `values` collection.</param>
        public void WriteInnerHalfAngleProperty(IList<JulianDate> dates, IList<double> values, int startIndex, int length)
        {
            using (var writer = OpenInnerHalfAngleProperty())
            {
                writer.WriteNumber(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>innerHalfAngle</c> property as a <c>reference</c> value.  The <c>innerHalfAngle</c> property specifies the inner half angle of the cone.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteInnerHalfAnglePropertyReference(Reference value)
        {
            using (var writer = OpenInnerHalfAngleProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>innerHalfAngle</c> property as a <c>reference</c> value.  The <c>innerHalfAngle</c> property specifies the inner half angle of the cone.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteInnerHalfAnglePropertyReference(string value)
        {
            using (var writer = OpenInnerHalfAngleProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>innerHalfAngle</c> property as a <c>reference</c> value.  The <c>innerHalfAngle</c> property specifies the inner half angle of the cone.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteInnerHalfAnglePropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenInnerHalfAngleProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>innerHalfAngle</c> property as a <c>reference</c> value.  The <c>innerHalfAngle</c> property specifies the inner half angle of the cone.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteInnerHalfAnglePropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenInnerHalfAngleProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>outerHalfAngle</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>outerHalfAngle</c> property defines the outer half angle of the cone.
        /// </summary>
        public DoubleCesiumWriter OuterHalfAngleWriter
        {
            get { return m_outerHalfAngle.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>outerHalfAngle</c> property.  The <c>outerHalfAngle</c> property defines the outer half angle of the cone.
        /// </summary>
        public DoubleCesiumWriter OpenOuterHalfAngleProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(OuterHalfAngleWriter);
        }

        /// <summary>
        /// Writes a value for the <c>outerHalfAngle</c> property as a <c>number</c> value.  The <c>outerHalfAngle</c> property specifies the outer half angle of the cone.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteOuterHalfAngleProperty(double value)
        {
            using (var writer = OpenOuterHalfAngleProperty())
            {
                writer.WriteNumber(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outerHalfAngle</c> property as a <c>number</c> value.  The <c>outerHalfAngle</c> property specifies the outer half angle of the cone.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteOuterHalfAngleProperty(IList<JulianDate> dates, IList<double> values)
        {
            using (var writer = OpenOuterHalfAngleProperty())
            {
                writer.WriteNumber(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outerHalfAngle</c> property as a <c>number</c> value.  The <c>outerHalfAngle</c> property specifies the outer half angle of the cone.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The value corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to use in the `values` collection.</param>
        /// <param name="length">The number of elements to use from the `values` collection.</param>
        public void WriteOuterHalfAngleProperty(IList<JulianDate> dates, IList<double> values, int startIndex, int length)
        {
            using (var writer = OpenOuterHalfAngleProperty())
            {
                writer.WriteNumber(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outerHalfAngle</c> property as a <c>reference</c> value.  The <c>outerHalfAngle</c> property specifies the outer half angle of the cone.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteOuterHalfAnglePropertyReference(Reference value)
        {
            using (var writer = OpenOuterHalfAngleProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outerHalfAngle</c> property as a <c>reference</c> value.  The <c>outerHalfAngle</c> property specifies the outer half angle of the cone.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteOuterHalfAnglePropertyReference(string value)
        {
            using (var writer = OpenOuterHalfAngleProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outerHalfAngle</c> property as a <c>reference</c> value.  The <c>outerHalfAngle</c> property specifies the outer half angle of the cone.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteOuterHalfAnglePropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenOuterHalfAngleProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outerHalfAngle</c> property as a <c>reference</c> value.  The <c>outerHalfAngle</c> property specifies the outer half angle of the cone.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteOuterHalfAnglePropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenOuterHalfAngleProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>minimumClockAngle</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>minimumClockAngle</c> property defines the minimum clock angle limit of the cone.
        /// </summary>
        public DoubleCesiumWriter MinimumClockAngleWriter
        {
            get { return m_minimumClockAngle.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>minimumClockAngle</c> property.  The <c>minimumClockAngle</c> property defines the minimum clock angle limit of the cone.
        /// </summary>
        public DoubleCesiumWriter OpenMinimumClockAngleProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(MinimumClockAngleWriter);
        }

        /// <summary>
        /// Writes a value for the <c>minimumClockAngle</c> property as a <c>number</c> value.  The <c>minimumClockAngle</c> property specifies the minimum clock angle limit of the cone.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteMinimumClockAngleProperty(double value)
        {
            using (var writer = OpenMinimumClockAngleProperty())
            {
                writer.WriteNumber(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>minimumClockAngle</c> property as a <c>number</c> value.  The <c>minimumClockAngle</c> property specifies the minimum clock angle limit of the cone.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteMinimumClockAngleProperty(IList<JulianDate> dates, IList<double> values)
        {
            using (var writer = OpenMinimumClockAngleProperty())
            {
                writer.WriteNumber(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>minimumClockAngle</c> property as a <c>number</c> value.  The <c>minimumClockAngle</c> property specifies the minimum clock angle limit of the cone.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The value corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to use in the `values` collection.</param>
        /// <param name="length">The number of elements to use from the `values` collection.</param>
        public void WriteMinimumClockAngleProperty(IList<JulianDate> dates, IList<double> values, int startIndex, int length)
        {
            using (var writer = OpenMinimumClockAngleProperty())
            {
                writer.WriteNumber(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>minimumClockAngle</c> property as a <c>reference</c> value.  The <c>minimumClockAngle</c> property specifies the minimum clock angle limit of the cone.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteMinimumClockAnglePropertyReference(Reference value)
        {
            using (var writer = OpenMinimumClockAngleProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>minimumClockAngle</c> property as a <c>reference</c> value.  The <c>minimumClockAngle</c> property specifies the minimum clock angle limit of the cone.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteMinimumClockAnglePropertyReference(string value)
        {
            using (var writer = OpenMinimumClockAngleProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>minimumClockAngle</c> property as a <c>reference</c> value.  The <c>minimumClockAngle</c> property specifies the minimum clock angle limit of the cone.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteMinimumClockAnglePropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenMinimumClockAngleProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>minimumClockAngle</c> property as a <c>reference</c> value.  The <c>minimumClockAngle</c> property specifies the minimum clock angle limit of the cone.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteMinimumClockAnglePropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenMinimumClockAngleProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>maximumClockAngle</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>maximumClockAngle</c> property defines the maximum clock angle limit of the cone.
        /// </summary>
        public DoubleCesiumWriter MaximumClockAngleWriter
        {
            get { return m_maximumClockAngle.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>maximumClockAngle</c> property.  The <c>maximumClockAngle</c> property defines the maximum clock angle limit of the cone.
        /// </summary>
        public DoubleCesiumWriter OpenMaximumClockAngleProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(MaximumClockAngleWriter);
        }

        /// <summary>
        /// Writes a value for the <c>maximumClockAngle</c> property as a <c>number</c> value.  The <c>maximumClockAngle</c> property specifies the maximum clock angle limit of the cone.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteMaximumClockAngleProperty(double value)
        {
            using (var writer = OpenMaximumClockAngleProperty())
            {
                writer.WriteNumber(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>maximumClockAngle</c> property as a <c>number</c> value.  The <c>maximumClockAngle</c> property specifies the maximum clock angle limit of the cone.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteMaximumClockAngleProperty(IList<JulianDate> dates, IList<double> values)
        {
            using (var writer = OpenMaximumClockAngleProperty())
            {
                writer.WriteNumber(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>maximumClockAngle</c> property as a <c>number</c> value.  The <c>maximumClockAngle</c> property specifies the maximum clock angle limit of the cone.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The value corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to use in the `values` collection.</param>
        /// <param name="length">The number of elements to use from the `values` collection.</param>
        public void WriteMaximumClockAngleProperty(IList<JulianDate> dates, IList<double> values, int startIndex, int length)
        {
            using (var writer = OpenMaximumClockAngleProperty())
            {
                writer.WriteNumber(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>maximumClockAngle</c> property as a <c>reference</c> value.  The <c>maximumClockAngle</c> property specifies the maximum clock angle limit of the cone.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteMaximumClockAnglePropertyReference(Reference value)
        {
            using (var writer = OpenMaximumClockAngleProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>maximumClockAngle</c> property as a <c>reference</c> value.  The <c>maximumClockAngle</c> property specifies the maximum clock angle limit of the cone.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteMaximumClockAnglePropertyReference(string value)
        {
            using (var writer = OpenMaximumClockAngleProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>maximumClockAngle</c> property as a <c>reference</c> value.  The <c>maximumClockAngle</c> property specifies the maximum clock angle limit of the cone.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteMaximumClockAnglePropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenMaximumClockAngleProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>maximumClockAngle</c> property as a <c>reference</c> value.  The <c>maximumClockAngle</c> property specifies the maximum clock angle limit of the cone.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteMaximumClockAnglePropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenMaximumClockAngleProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>radius</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>radius</c> property defines the radial limit of the cone.
        /// </summary>
        public DoubleCesiumWriter RadiusWriter
        {
            get { return m_radius.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>radius</c> property.  The <c>radius</c> property defines the radial limit of the cone.
        /// </summary>
        public DoubleCesiumWriter OpenRadiusProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(RadiusWriter);
        }

        /// <summary>
        /// Writes a value for the <c>radius</c> property as a <c>number</c> value.  The <c>radius</c> property specifies the radial limit of the cone.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteRadiusProperty(double value)
        {
            using (var writer = OpenRadiusProperty())
            {
                writer.WriteNumber(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>radius</c> property as a <c>number</c> value.  The <c>radius</c> property specifies the radial limit of the cone.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteRadiusProperty(IList<JulianDate> dates, IList<double> values)
        {
            using (var writer = OpenRadiusProperty())
            {
                writer.WriteNumber(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>radius</c> property as a <c>number</c> value.  The <c>radius</c> property specifies the radial limit of the cone.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The value corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to use in the `values` collection.</param>
        /// <param name="length">The number of elements to use from the `values` collection.</param>
        public void WriteRadiusProperty(IList<JulianDate> dates, IList<double> values, int startIndex, int length)
        {
            using (var writer = OpenRadiusProperty())
            {
                writer.WriteNumber(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>radius</c> property as a <c>reference</c> value.  The <c>radius</c> property specifies the radial limit of the cone.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteRadiusPropertyReference(Reference value)
        {
            using (var writer = OpenRadiusProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>radius</c> property as a <c>reference</c> value.  The <c>radius</c> property specifies the radial limit of the cone.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteRadiusPropertyReference(string value)
        {
            using (var writer = OpenRadiusProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>radius</c> property as a <c>reference</c> value.  The <c>radius</c> property specifies the radial limit of the cone.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteRadiusPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenRadiusProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>radius</c> property as a <c>reference</c> value.  The <c>radius</c> property specifies the radial limit of the cone.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteRadiusPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenRadiusProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>showIntersection</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>showIntersection</c> property defines whether or not the intersection of the cone with the Earth is shown.
        /// </summary>
        public BooleanCesiumWriter ShowIntersectionWriter
        {
            get { return m_showIntersection.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>showIntersection</c> property.  The <c>showIntersection</c> property defines whether or not the intersection of the cone with the Earth is shown.
        /// </summary>
        public BooleanCesiumWriter OpenShowIntersectionProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(ShowIntersectionWriter);
        }

        /// <summary>
        /// Writes a value for the <c>showIntersection</c> property as a <c>boolean</c> value.  The <c>showIntersection</c> property specifies whether or not the intersection of the cone with the Earth is shown.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteShowIntersectionProperty(bool value)
        {
            using (var writer = OpenShowIntersectionProperty())
            {
                writer.WriteBoolean(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>showIntersection</c> property as a <c>reference</c> value.  The <c>showIntersection</c> property specifies whether or not the intersection of the cone with the Earth is shown.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteShowIntersectionPropertyReference(Reference value)
        {
            using (var writer = OpenShowIntersectionProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>showIntersection</c> property as a <c>reference</c> value.  The <c>showIntersection</c> property specifies whether or not the intersection of the cone with the Earth is shown.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteShowIntersectionPropertyReference(string value)
        {
            using (var writer = OpenShowIntersectionProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>showIntersection</c> property as a <c>reference</c> value.  The <c>showIntersection</c> property specifies whether or not the intersection of the cone with the Earth is shown.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteShowIntersectionPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenShowIntersectionProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>showIntersection</c> property as a <c>reference</c> value.  The <c>showIntersection</c> property specifies whether or not the intersection of the cone with the Earth is shown.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteShowIntersectionPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenShowIntersectionProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>intersectionColor</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>intersectionColor</c> property defines the color of the intersection of the cone with the Earth.
        /// </summary>
        public ColorCesiumWriter IntersectionColorWriter
        {
            get { return m_intersectionColor.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>intersectionColor</c> property.  The <c>intersectionColor</c> property defines the color of the intersection of the cone with the Earth.
        /// </summary>
        public ColorCesiumWriter OpenIntersectionColorProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(IntersectionColorWriter);
        }

        /// <summary>
        /// Writes a value for the <c>intersectionColor</c> property as a <c>rgba</c> value.  The <c>intersectionColor</c> property specifies the color of the intersection of the cone with the Earth.
        /// </summary>
        /// <param name="color">The color.</param>
        public void WriteIntersectionColorProperty(Color color)
        {
            using (var writer = OpenIntersectionColorProperty())
            {
                writer.WriteRgba(color);
            }
        }

        /// <summary>
        /// Writes a value for the <c>intersectionColor</c> property as a <c>rgba</c> value.  The <c>intersectionColor</c> property specifies the color of the intersection of the cone with the Earth.
        /// </summary>
        /// <param name="red">The red component in the range 0 to 255.</param>
        /// <param name="green">The green component in the range 0 to 255.</param>
        /// <param name="blue">The blue component in the range 0 to 255.</param>
        /// <param name="alpha">The alpha component in the range 0 to 255.</param>
        public void WriteIntersectionColorProperty(int red, int green, int blue, int alpha)
        {
            using (var writer = OpenIntersectionColorProperty())
            {
                writer.WriteRgba(red, green, blue, alpha);
            }
        }

        /// <summary>
        /// Writes a value for the <c>intersectionColor</c> property as a <c>rgba</c> value.  The <c>intersectionColor</c> property specifies the color of the intersection of the cone with the Earth.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteIntersectionColorProperty(IList<JulianDate> dates, IList<Color> values)
        {
            using (var writer = OpenIntersectionColorProperty())
            {
                writer.WriteRgba(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>intersectionColor</c> property as a <c>rgba</c> value.  The <c>intersectionColor</c> property specifies the color of the intersection of the cone with the Earth.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="colors">The color corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to use in the `colors` collection.</param>
        /// <param name="length">The number of elements to use from the `colors` collection.</param>
        public void WriteIntersectionColorProperty(IList<JulianDate> dates, IList<Color> colors, int startIndex, int length)
        {
            using (var writer = OpenIntersectionColorProperty())
            {
                writer.WriteRgba(dates, colors, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>intersectionColor</c> property as a <c>rgbaf</c> value.  The <c>intersectionColor</c> property specifies the color of the intersection of the cone with the Earth.
        /// </summary>
        /// <param name="color">The color.</param>
        public void WriteIntersectionColorPropertyRgbaf(Color color)
        {
            using (var writer = OpenIntersectionColorProperty())
            {
                writer.WriteRgbaf(color);
            }
        }

        /// <summary>
        /// Writes a value for the <c>intersectionColor</c> property as a <c>rgbaf</c> value.  The <c>intersectionColor</c> property specifies the color of the intersection of the cone with the Earth.
        /// </summary>
        /// <param name="red">The red component in the range 0 to 1.0.</param>
        /// <param name="green">The green component in the range 0 to 1.0.</param>
        /// <param name="blue">The blue component in the range 0 to 1.0.</param>
        /// <param name="alpha">The alpha component in the range 0 to 1.0.</param>
        public void WriteIntersectionColorPropertyRgbaf(float red, float green, float blue, float alpha)
        {
            using (var writer = OpenIntersectionColorProperty())
            {
                writer.WriteRgbaf(red, green, blue, alpha);
            }
        }

        /// <summary>
        /// Writes a value for the <c>intersectionColor</c> property as a <c>rgbaf</c> value.  The <c>intersectionColor</c> property specifies the color of the intersection of the cone with the Earth.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteIntersectionColorPropertyRgbaf(IList<JulianDate> dates, IList<Color> values)
        {
            using (var writer = OpenIntersectionColorProperty())
            {
                writer.WriteRgbaf(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>intersectionColor</c> property as a <c>rgbaf</c> value.  The <c>intersectionColor</c> property specifies the color of the intersection of the cone with the Earth.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="colors">The color corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to use in the `colors` collection.</param>
        /// <param name="length">The number of elements to use from the `colors` collection.</param>
        public void WriteIntersectionColorPropertyRgbaf(IList<JulianDate> dates, IList<Color> colors, int startIndex, int length)
        {
            using (var writer = OpenIntersectionColorProperty())
            {
                writer.WriteRgbaf(dates, colors, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>intersectionColor</c> property as a <c>reference</c> value.  The <c>intersectionColor</c> property specifies the color of the intersection of the cone with the Earth.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteIntersectionColorPropertyReference(Reference value)
        {
            using (var writer = OpenIntersectionColorProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>intersectionColor</c> property as a <c>reference</c> value.  The <c>intersectionColor</c> property specifies the color of the intersection of the cone with the Earth.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteIntersectionColorPropertyReference(string value)
        {
            using (var writer = OpenIntersectionColorProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>intersectionColor</c> property as a <c>reference</c> value.  The <c>intersectionColor</c> property specifies the color of the intersection of the cone with the Earth.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteIntersectionColorPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenIntersectionColorProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>intersectionColor</c> property as a <c>reference</c> value.  The <c>intersectionColor</c> property specifies the color of the intersection of the cone with the Earth.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteIntersectionColorPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenIntersectionColorProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>intersectionWidth</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>intersectionWidth</c> property defines the width of the intersection in pixels.
        /// </summary>
        public DoubleCesiumWriter IntersectionWidthWriter
        {
            get { return m_intersectionWidth.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>intersectionWidth</c> property.  The <c>intersectionWidth</c> property defines the width of the intersection in pixels.
        /// </summary>
        public DoubleCesiumWriter OpenIntersectionWidthProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(IntersectionWidthWriter);
        }

        /// <summary>
        /// Writes a value for the <c>intersectionWidth</c> property as a <c>number</c> value.  The <c>intersectionWidth</c> property specifies the width of the intersection in pixels.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteIntersectionWidthProperty(double value)
        {
            using (var writer = OpenIntersectionWidthProperty())
            {
                writer.WriteNumber(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>intersectionWidth</c> property as a <c>number</c> value.  The <c>intersectionWidth</c> property specifies the width of the intersection in pixels.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteIntersectionWidthProperty(IList<JulianDate> dates, IList<double> values)
        {
            using (var writer = OpenIntersectionWidthProperty())
            {
                writer.WriteNumber(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>intersectionWidth</c> property as a <c>number</c> value.  The <c>intersectionWidth</c> property specifies the width of the intersection in pixels.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The value corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to use in the `values` collection.</param>
        /// <param name="length">The number of elements to use from the `values` collection.</param>
        public void WriteIntersectionWidthProperty(IList<JulianDate> dates, IList<double> values, int startIndex, int length)
        {
            using (var writer = OpenIntersectionWidthProperty())
            {
                writer.WriteNumber(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>intersectionWidth</c> property as a <c>reference</c> value.  The <c>intersectionWidth</c> property specifies the width of the intersection in pixels.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteIntersectionWidthPropertyReference(Reference value)
        {
            using (var writer = OpenIntersectionWidthProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>intersectionWidth</c> property as a <c>reference</c> value.  The <c>intersectionWidth</c> property specifies the width of the intersection in pixels.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteIntersectionWidthPropertyReference(string value)
        {
            using (var writer = OpenIntersectionWidthProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>intersectionWidth</c> property as a <c>reference</c> value.  The <c>intersectionWidth</c> property specifies the width of the intersection in pixels.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteIntersectionWidthPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenIntersectionWidthProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>intersectionWidth</c> property as a <c>reference</c> value.  The <c>intersectionWidth</c> property specifies the width of the intersection in pixels.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteIntersectionWidthPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenIntersectionWidthProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>showLateralSurfaces</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>showLateralSurfaces</c> property defines whether or not the lateral surfaces of the cone are shown.
        /// </summary>
        public BooleanCesiumWriter ShowLateralSurfacesWriter
        {
            get { return m_showLateralSurfaces.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>showLateralSurfaces</c> property.  The <c>showLateralSurfaces</c> property defines whether or not the lateral surfaces of the cone are shown.
        /// </summary>
        public BooleanCesiumWriter OpenShowLateralSurfacesProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(ShowLateralSurfacesWriter);
        }

        /// <summary>
        /// Writes a value for the <c>showLateralSurfaces</c> property as a <c>boolean</c> value.  The <c>showLateralSurfaces</c> property specifies whether or not the lateral surfaces of the cone are shown.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteShowLateralSurfacesProperty(bool value)
        {
            using (var writer = OpenShowLateralSurfacesProperty())
            {
                writer.WriteBoolean(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>showLateralSurfaces</c> property as a <c>reference</c> value.  The <c>showLateralSurfaces</c> property specifies whether or not the lateral surfaces of the cone are shown.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteShowLateralSurfacesPropertyReference(Reference value)
        {
            using (var writer = OpenShowLateralSurfacesProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>showLateralSurfaces</c> property as a <c>reference</c> value.  The <c>showLateralSurfaces</c> property specifies whether or not the lateral surfaces of the cone are shown.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteShowLateralSurfacesPropertyReference(string value)
        {
            using (var writer = OpenShowLateralSurfacesProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>showLateralSurfaces</c> property as a <c>reference</c> value.  The <c>showLateralSurfaces</c> property specifies whether or not the lateral surfaces of the cone are shown.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteShowLateralSurfacesPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenShowLateralSurfacesProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>showLateralSurfaces</c> property as a <c>reference</c> value.  The <c>showLateralSurfaces</c> property specifies whether or not the lateral surfaces of the cone are shown.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteShowLateralSurfacesPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenShowLateralSurfacesProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>lateralSurfaceMaterial</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>lateralSurfaceMaterial</c> property defines the material to use for the cone's lateral surfaces.
        /// </summary>
        public MaterialCesiumWriter LateralSurfaceMaterialWriter
        {
            get { return m_lateralSurfaceMaterial.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>lateralSurfaceMaterial</c> property.  The <c>lateralSurfaceMaterial</c> property defines the material to use for the cone's lateral surfaces.
        /// </summary>
        public MaterialCesiumWriter OpenLateralSurfaceMaterialProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(LateralSurfaceMaterialWriter);
        }

        /// <summary>
        /// Gets the writer for the <c>showEllipsoidSurfaces</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>showEllipsoidSurfaces</c> property defines whether or not ellipsoid surfaces are shown.
        /// </summary>
        public BooleanCesiumWriter ShowEllipsoidSurfacesWriter
        {
            get { return m_showEllipsoidSurfaces.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>showEllipsoidSurfaces</c> property.  The <c>showEllipsoidSurfaces</c> property defines whether or not ellipsoid surfaces are shown.
        /// </summary>
        public BooleanCesiumWriter OpenShowEllipsoidSurfacesProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(ShowEllipsoidSurfacesWriter);
        }

        /// <summary>
        /// Writes a value for the <c>showEllipsoidSurfaces</c> property as a <c>boolean</c> value.  The <c>showEllipsoidSurfaces</c> property specifies whether or not ellipsoid surfaces are shown.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteShowEllipsoidSurfacesProperty(bool value)
        {
            using (var writer = OpenShowEllipsoidSurfacesProperty())
            {
                writer.WriteBoolean(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>showEllipsoidSurfaces</c> property as a <c>reference</c> value.  The <c>showEllipsoidSurfaces</c> property specifies whether or not ellipsoid surfaces are shown.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteShowEllipsoidSurfacesPropertyReference(Reference value)
        {
            using (var writer = OpenShowEllipsoidSurfacesProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>showEllipsoidSurfaces</c> property as a <c>reference</c> value.  The <c>showEllipsoidSurfaces</c> property specifies whether or not ellipsoid surfaces are shown.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteShowEllipsoidSurfacesPropertyReference(string value)
        {
            using (var writer = OpenShowEllipsoidSurfacesProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>showEllipsoidSurfaces</c> property as a <c>reference</c> value.  The <c>showEllipsoidSurfaces</c> property specifies whether or not ellipsoid surfaces are shown.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteShowEllipsoidSurfacesPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenShowEllipsoidSurfacesProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>showEllipsoidSurfaces</c> property as a <c>reference</c> value.  The <c>showEllipsoidSurfaces</c> property specifies whether or not ellipsoid surfaces are shown.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteShowEllipsoidSurfacesPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenShowEllipsoidSurfacesProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>ellipsoidSurfaceMaterial</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>ellipsoidSurfaceMaterial</c> property defines the material to use for the cone's ellipsoid surfaces.
        /// </summary>
        public MaterialCesiumWriter EllipsoidSurfaceMaterialWriter
        {
            get { return m_ellipsoidSurfaceMaterial.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>ellipsoidSurfaceMaterial</c> property.  The <c>ellipsoidSurfaceMaterial</c> property defines the material to use for the cone's ellipsoid surfaces.
        /// </summary>
        public MaterialCesiumWriter OpenEllipsoidSurfaceMaterialProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(EllipsoidSurfaceMaterialWriter);
        }

        /// <summary>
        /// Gets the writer for the <c>showEllipsoidHorizonSurfaces</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>showEllipsoidHorizonSurfaces</c> property defines whether or not ellipsoid horizon surfaces are shown.
        /// </summary>
        public BooleanCesiumWriter ShowEllipsoidHorizonSurfacesWriter
        {
            get { return m_showEllipsoidHorizonSurfaces.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>showEllipsoidHorizonSurfaces</c> property.  The <c>showEllipsoidHorizonSurfaces</c> property defines whether or not ellipsoid horizon surfaces are shown.
        /// </summary>
        public BooleanCesiumWriter OpenShowEllipsoidHorizonSurfacesProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(ShowEllipsoidHorizonSurfacesWriter);
        }

        /// <summary>
        /// Writes a value for the <c>showEllipsoidHorizonSurfaces</c> property as a <c>boolean</c> value.  The <c>showEllipsoidHorizonSurfaces</c> property specifies whether or not ellipsoid horizon surfaces are shown.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteShowEllipsoidHorizonSurfacesProperty(bool value)
        {
            using (var writer = OpenShowEllipsoidHorizonSurfacesProperty())
            {
                writer.WriteBoolean(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>showEllipsoidHorizonSurfaces</c> property as a <c>reference</c> value.  The <c>showEllipsoidHorizonSurfaces</c> property specifies whether or not ellipsoid horizon surfaces are shown.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteShowEllipsoidHorizonSurfacesPropertyReference(Reference value)
        {
            using (var writer = OpenShowEllipsoidHorizonSurfacesProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>showEllipsoidHorizonSurfaces</c> property as a <c>reference</c> value.  The <c>showEllipsoidHorizonSurfaces</c> property specifies whether or not ellipsoid horizon surfaces are shown.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteShowEllipsoidHorizonSurfacesPropertyReference(string value)
        {
            using (var writer = OpenShowEllipsoidHorizonSurfacesProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>showEllipsoidHorizonSurfaces</c> property as a <c>reference</c> value.  The <c>showEllipsoidHorizonSurfaces</c> property specifies whether or not ellipsoid horizon surfaces are shown.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteShowEllipsoidHorizonSurfacesPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenShowEllipsoidHorizonSurfacesProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>showEllipsoidHorizonSurfaces</c> property as a <c>reference</c> value.  The <c>showEllipsoidHorizonSurfaces</c> property specifies whether or not ellipsoid horizon surfaces are shown.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteShowEllipsoidHorizonSurfacesPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenShowEllipsoidHorizonSurfacesProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>ellipsoidHorizonSurfaceMaterial</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>ellipsoidHorizonSurfaceMaterial</c> property defines the material to use for the cone's ellipsoid horizon surfaces.
        /// </summary>
        public MaterialCesiumWriter EllipsoidHorizonSurfaceMaterialWriter
        {
            get { return m_ellipsoidHorizonSurfaceMaterial.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>ellipsoidHorizonSurfaceMaterial</c> property.  The <c>ellipsoidHorizonSurfaceMaterial</c> property defines the material to use for the cone's ellipsoid horizon surfaces.
        /// </summary>
        public MaterialCesiumWriter OpenEllipsoidHorizonSurfaceMaterialProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(EllipsoidHorizonSurfaceMaterialWriter);
        }

        /// <summary>
        /// Gets the writer for the <c>showDomeSurfaces</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>showDomeSurfaces</c> property defines whether or not dome surfaces are shown.
        /// </summary>
        public BooleanCesiumWriter ShowDomeSurfacesWriter
        {
            get { return m_showDomeSurfaces.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>showDomeSurfaces</c> property.  The <c>showDomeSurfaces</c> property defines whether or not dome surfaces are shown.
        /// </summary>
        public BooleanCesiumWriter OpenShowDomeSurfacesProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(ShowDomeSurfacesWriter);
        }

        /// <summary>
        /// Writes a value for the <c>showDomeSurfaces</c> property as a <c>boolean</c> value.  The <c>showDomeSurfaces</c> property specifies whether or not dome surfaces are shown.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteShowDomeSurfacesProperty(bool value)
        {
            using (var writer = OpenShowDomeSurfacesProperty())
            {
                writer.WriteBoolean(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>showDomeSurfaces</c> property as a <c>reference</c> value.  The <c>showDomeSurfaces</c> property specifies whether or not dome surfaces are shown.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteShowDomeSurfacesPropertyReference(Reference value)
        {
            using (var writer = OpenShowDomeSurfacesProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>showDomeSurfaces</c> property as a <c>reference</c> value.  The <c>showDomeSurfaces</c> property specifies whether or not dome surfaces are shown.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteShowDomeSurfacesPropertyReference(string value)
        {
            using (var writer = OpenShowDomeSurfacesProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>showDomeSurfaces</c> property as a <c>reference</c> value.  The <c>showDomeSurfaces</c> property specifies whether or not dome surfaces are shown.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteShowDomeSurfacesPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenShowDomeSurfacesProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>showDomeSurfaces</c> property as a <c>reference</c> value.  The <c>showDomeSurfaces</c> property specifies whether or not dome surfaces are shown.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteShowDomeSurfacesPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenShowDomeSurfacesProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>domeSurfaceMaterial</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>domeSurfaceMaterial</c> property defines the material to use for the cone's dome surfaces.
        /// </summary>
        public MaterialCesiumWriter DomeSurfaceMaterialWriter
        {
            get { return m_domeSurfaceMaterial.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>domeSurfaceMaterial</c> property.  The <c>domeSurfaceMaterial</c> property defines the material to use for the cone's dome surfaces.
        /// </summary>
        public MaterialCesiumWriter OpenDomeSurfaceMaterialProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(DomeSurfaceMaterialWriter);
        }

        /// <summary>
        /// Gets the writer for the <c>portionToDisplay</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>portionToDisplay</c> property defines what part of the sensor should be displayed.
        /// </summary>
        public SensorVolumePortionToDisplayCesiumWriter PortionToDisplayWriter
        {
            get { return m_portionToDisplay.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>portionToDisplay</c> property.  The <c>portionToDisplay</c> property defines what part of the sensor should be displayed.
        /// </summary>
        public SensorVolumePortionToDisplayCesiumWriter OpenPortionToDisplayProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(PortionToDisplayWriter);
        }

        /// <summary>
        /// Writes a value for the <c>portionToDisplay</c> property as a <c>portionToDisplay</c> value.  The <c>portionToDisplay</c> property specifies what part of the sensor should be displayed.
        /// </summary>
        /// <param name="value">The portion of the sensor to display.</param>
        public void WritePortionToDisplayProperty(CesiumSensorVolumePortionToDisplay value)
        {
            using (var writer = OpenPortionToDisplayProperty())
            {
                writer.WritePortionToDisplay(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>portionToDisplay</c> property as a <c>reference</c> value.  The <c>portionToDisplay</c> property specifies what part of the sensor should be displayed.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WritePortionToDisplayPropertyReference(Reference value)
        {
            using (var writer = OpenPortionToDisplayProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>portionToDisplay</c> property as a <c>reference</c> value.  The <c>portionToDisplay</c> property specifies what part of the sensor should be displayed.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WritePortionToDisplayPropertyReference(string value)
        {
            using (var writer = OpenPortionToDisplayProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>portionToDisplay</c> property as a <c>reference</c> value.  The <c>portionToDisplay</c> property specifies what part of the sensor should be displayed.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WritePortionToDisplayPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenPortionToDisplayProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>portionToDisplay</c> property as a <c>reference</c> value.  The <c>portionToDisplay</c> property specifies what part of the sensor should be displayed.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WritePortionToDisplayPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenPortionToDisplayProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>environmentConstraint</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>environmentConstraint</c> property defines whether or not the sensor will intersect the environment, e.g. terrain or models.
        /// </summary>
        public BooleanCesiumWriter EnvironmentConstraintWriter
        {
            get { return m_environmentConstraint.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>environmentConstraint</c> property.  The <c>environmentConstraint</c> property defines whether or not the sensor will intersect the environment, e.g. terrain or models.
        /// </summary>
        public BooleanCesiumWriter OpenEnvironmentConstraintProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(EnvironmentConstraintWriter);
        }

        /// <summary>
        /// Writes a value for the <c>environmentConstraint</c> property as a <c>boolean</c> value.  The <c>environmentConstraint</c> property specifies whether or not the sensor will intersect the environment, e.g. terrain or models.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteEnvironmentConstraintProperty(bool value)
        {
            using (var writer = OpenEnvironmentConstraintProperty())
            {
                writer.WriteBoolean(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>environmentConstraint</c> property as a <c>reference</c> value.  The <c>environmentConstraint</c> property specifies whether or not the sensor will intersect the environment, e.g. terrain or models.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteEnvironmentConstraintPropertyReference(Reference value)
        {
            using (var writer = OpenEnvironmentConstraintProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>environmentConstraint</c> property as a <c>reference</c> value.  The <c>environmentConstraint</c> property specifies whether or not the sensor will intersect the environment, e.g. terrain or models.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteEnvironmentConstraintPropertyReference(string value)
        {
            using (var writer = OpenEnvironmentConstraintProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>environmentConstraint</c> property as a <c>reference</c> value.  The <c>environmentConstraint</c> property specifies whether or not the sensor will intersect the environment, e.g. terrain or models.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteEnvironmentConstraintPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenEnvironmentConstraintProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>environmentConstraint</c> property as a <c>reference</c> value.  The <c>environmentConstraint</c> property specifies whether or not the sensor will intersect the environment, e.g. terrain or models.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteEnvironmentConstraintPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenEnvironmentConstraintProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>showEnvironmentOcclusion</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>showEnvironmentOcclusion</c> property defines whether or not the portion of the terrain occluded by the environment will be drawn with a separate material.
        /// </summary>
        public BooleanCesiumWriter ShowEnvironmentOcclusionWriter
        {
            get { return m_showEnvironmentOcclusion.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>showEnvironmentOcclusion</c> property.  The <c>showEnvironmentOcclusion</c> property defines whether or not the portion of the terrain occluded by the environment will be drawn with a separate material.
        /// </summary>
        public BooleanCesiumWriter OpenShowEnvironmentOcclusionProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(ShowEnvironmentOcclusionWriter);
        }

        /// <summary>
        /// Writes a value for the <c>showEnvironmentOcclusion</c> property as a <c>boolean</c> value.  The <c>showEnvironmentOcclusion</c> property specifies whether or not the portion of the terrain occluded by the environment will be drawn with a separate material.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteShowEnvironmentOcclusionProperty(bool value)
        {
            using (var writer = OpenShowEnvironmentOcclusionProperty())
            {
                writer.WriteBoolean(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>showEnvironmentOcclusion</c> property as a <c>reference</c> value.  The <c>showEnvironmentOcclusion</c> property specifies whether or not the portion of the terrain occluded by the environment will be drawn with a separate material.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteShowEnvironmentOcclusionPropertyReference(Reference value)
        {
            using (var writer = OpenShowEnvironmentOcclusionProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>showEnvironmentOcclusion</c> property as a <c>reference</c> value.  The <c>showEnvironmentOcclusion</c> property specifies whether or not the portion of the terrain occluded by the environment will be drawn with a separate material.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteShowEnvironmentOcclusionPropertyReference(string value)
        {
            using (var writer = OpenShowEnvironmentOcclusionProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>showEnvironmentOcclusion</c> property as a <c>reference</c> value.  The <c>showEnvironmentOcclusion</c> property specifies whether or not the portion of the terrain occluded by the environment will be drawn with a separate material.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteShowEnvironmentOcclusionPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenShowEnvironmentOcclusionProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>showEnvironmentOcclusion</c> property as a <c>reference</c> value.  The <c>showEnvironmentOcclusion</c> property specifies whether or not the portion of the terrain occluded by the environment will be drawn with a separate material.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteShowEnvironmentOcclusionPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenShowEnvironmentOcclusionProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>environmentOcclusionMaterial</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>environmentOcclusionMaterial</c> property defines the material to use for the portion of the sensor occluded by the environment.
        /// </summary>
        public MaterialCesiumWriter EnvironmentOcclusionMaterialWriter
        {
            get { return m_environmentOcclusionMaterial.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>environmentOcclusionMaterial</c> property.  The <c>environmentOcclusionMaterial</c> property defines the material to use for the portion of the sensor occluded by the environment.
        /// </summary>
        public MaterialCesiumWriter OpenEnvironmentOcclusionMaterialProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(EnvironmentOcclusionMaterialWriter);
        }

        /// <summary>
        /// Gets the writer for the <c>showEnvironmentIntersection</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>showEnvironmentIntersection</c> property defines whether or not a line showing where the sensor intersects the environment will be drawn.
        /// </summary>
        public BooleanCesiumWriter ShowEnvironmentIntersectionWriter
        {
            get { return m_showEnvironmentIntersection.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>showEnvironmentIntersection</c> property.  The <c>showEnvironmentIntersection</c> property defines whether or not a line showing where the sensor intersects the environment will be drawn.
        /// </summary>
        public BooleanCesiumWriter OpenShowEnvironmentIntersectionProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(ShowEnvironmentIntersectionWriter);
        }

        /// <summary>
        /// Writes a value for the <c>showEnvironmentIntersection</c> property as a <c>boolean</c> value.  The <c>showEnvironmentIntersection</c> property specifies whether or not a line showing where the sensor intersects the environment will be drawn.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteShowEnvironmentIntersectionProperty(bool value)
        {
            using (var writer = OpenShowEnvironmentIntersectionProperty())
            {
                writer.WriteBoolean(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>showEnvironmentIntersection</c> property as a <c>reference</c> value.  The <c>showEnvironmentIntersection</c> property specifies whether or not a line showing where the sensor intersects the environment will be drawn.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteShowEnvironmentIntersectionPropertyReference(Reference value)
        {
            using (var writer = OpenShowEnvironmentIntersectionProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>showEnvironmentIntersection</c> property as a <c>reference</c> value.  The <c>showEnvironmentIntersection</c> property specifies whether or not a line showing where the sensor intersects the environment will be drawn.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteShowEnvironmentIntersectionPropertyReference(string value)
        {
            using (var writer = OpenShowEnvironmentIntersectionProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>showEnvironmentIntersection</c> property as a <c>reference</c> value.  The <c>showEnvironmentIntersection</c> property specifies whether or not a line showing where the sensor intersects the environment will be drawn.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteShowEnvironmentIntersectionPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenShowEnvironmentIntersectionProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>showEnvironmentIntersection</c> property as a <c>reference</c> value.  The <c>showEnvironmentIntersection</c> property specifies whether or not a line showing where the sensor intersects the environment will be drawn.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteShowEnvironmentIntersectionPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenShowEnvironmentIntersectionProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>environmentIntersectionColor</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>environmentIntersectionColor</c> property defines the color of the intersection line between the sensor and the environment.
        /// </summary>
        public ColorCesiumWriter EnvironmentIntersectionColorWriter
        {
            get { return m_environmentIntersectionColor.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>environmentIntersectionColor</c> property.  The <c>environmentIntersectionColor</c> property defines the color of the intersection line between the sensor and the environment.
        /// </summary>
        public ColorCesiumWriter OpenEnvironmentIntersectionColorProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(EnvironmentIntersectionColorWriter);
        }

        /// <summary>
        /// Writes a value for the <c>environmentIntersectionColor</c> property as a <c>rgba</c> value.  The <c>environmentIntersectionColor</c> property specifies the color of the intersection line between the sensor and the environment.
        /// </summary>
        /// <param name="color">The color.</param>
        public void WriteEnvironmentIntersectionColorProperty(Color color)
        {
            using (var writer = OpenEnvironmentIntersectionColorProperty())
            {
                writer.WriteRgba(color);
            }
        }

        /// <summary>
        /// Writes a value for the <c>environmentIntersectionColor</c> property as a <c>rgba</c> value.  The <c>environmentIntersectionColor</c> property specifies the color of the intersection line between the sensor and the environment.
        /// </summary>
        /// <param name="red">The red component in the range 0 to 255.</param>
        /// <param name="green">The green component in the range 0 to 255.</param>
        /// <param name="blue">The blue component in the range 0 to 255.</param>
        /// <param name="alpha">The alpha component in the range 0 to 255.</param>
        public void WriteEnvironmentIntersectionColorProperty(int red, int green, int blue, int alpha)
        {
            using (var writer = OpenEnvironmentIntersectionColorProperty())
            {
                writer.WriteRgba(red, green, blue, alpha);
            }
        }

        /// <summary>
        /// Writes a value for the <c>environmentIntersectionColor</c> property as a <c>rgba</c> value.  The <c>environmentIntersectionColor</c> property specifies the color of the intersection line between the sensor and the environment.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteEnvironmentIntersectionColorProperty(IList<JulianDate> dates, IList<Color> values)
        {
            using (var writer = OpenEnvironmentIntersectionColorProperty())
            {
                writer.WriteRgba(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>environmentIntersectionColor</c> property as a <c>rgba</c> value.  The <c>environmentIntersectionColor</c> property specifies the color of the intersection line between the sensor and the environment.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="colors">The color corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to use in the `colors` collection.</param>
        /// <param name="length">The number of elements to use from the `colors` collection.</param>
        public void WriteEnvironmentIntersectionColorProperty(IList<JulianDate> dates, IList<Color> colors, int startIndex, int length)
        {
            using (var writer = OpenEnvironmentIntersectionColorProperty())
            {
                writer.WriteRgba(dates, colors, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>environmentIntersectionColor</c> property as a <c>rgbaf</c> value.  The <c>environmentIntersectionColor</c> property specifies the color of the intersection line between the sensor and the environment.
        /// </summary>
        /// <param name="color">The color.</param>
        public void WriteEnvironmentIntersectionColorPropertyRgbaf(Color color)
        {
            using (var writer = OpenEnvironmentIntersectionColorProperty())
            {
                writer.WriteRgbaf(color);
            }
        }

        /// <summary>
        /// Writes a value for the <c>environmentIntersectionColor</c> property as a <c>rgbaf</c> value.  The <c>environmentIntersectionColor</c> property specifies the color of the intersection line between the sensor and the environment.
        /// </summary>
        /// <param name="red">The red component in the range 0 to 1.0.</param>
        /// <param name="green">The green component in the range 0 to 1.0.</param>
        /// <param name="blue">The blue component in the range 0 to 1.0.</param>
        /// <param name="alpha">The alpha component in the range 0 to 1.0.</param>
        public void WriteEnvironmentIntersectionColorPropertyRgbaf(float red, float green, float blue, float alpha)
        {
            using (var writer = OpenEnvironmentIntersectionColorProperty())
            {
                writer.WriteRgbaf(red, green, blue, alpha);
            }
        }

        /// <summary>
        /// Writes a value for the <c>environmentIntersectionColor</c> property as a <c>rgbaf</c> value.  The <c>environmentIntersectionColor</c> property specifies the color of the intersection line between the sensor and the environment.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteEnvironmentIntersectionColorPropertyRgbaf(IList<JulianDate> dates, IList<Color> values)
        {
            using (var writer = OpenEnvironmentIntersectionColorProperty())
            {
                writer.WriteRgbaf(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>environmentIntersectionColor</c> property as a <c>rgbaf</c> value.  The <c>environmentIntersectionColor</c> property specifies the color of the intersection line between the sensor and the environment.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="colors">The color corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to use in the `colors` collection.</param>
        /// <param name="length">The number of elements to use from the `colors` collection.</param>
        public void WriteEnvironmentIntersectionColorPropertyRgbaf(IList<JulianDate> dates, IList<Color> colors, int startIndex, int length)
        {
            using (var writer = OpenEnvironmentIntersectionColorProperty())
            {
                writer.WriteRgbaf(dates, colors, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>environmentIntersectionColor</c> property as a <c>reference</c> value.  The <c>environmentIntersectionColor</c> property specifies the color of the intersection line between the sensor and the environment.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteEnvironmentIntersectionColorPropertyReference(Reference value)
        {
            using (var writer = OpenEnvironmentIntersectionColorProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>environmentIntersectionColor</c> property as a <c>reference</c> value.  The <c>environmentIntersectionColor</c> property specifies the color of the intersection line between the sensor and the environment.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteEnvironmentIntersectionColorPropertyReference(string value)
        {
            using (var writer = OpenEnvironmentIntersectionColorProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>environmentIntersectionColor</c> property as a <c>reference</c> value.  The <c>environmentIntersectionColor</c> property specifies the color of the intersection line between the sensor and the environment.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteEnvironmentIntersectionColorPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenEnvironmentIntersectionColorProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>environmentIntersectionColor</c> property as a <c>reference</c> value.  The <c>environmentIntersectionColor</c> property specifies the color of the intersection line between the sensor and the environment.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteEnvironmentIntersectionColorPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenEnvironmentIntersectionColorProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>environmentIntersectionWidth</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>environmentIntersectionWidth</c> property defines the width in meters of the intersection line between the sensor and the environment.
        /// </summary>
        public DoubleCesiumWriter EnvironmentIntersectionWidthWriter
        {
            get { return m_environmentIntersectionWidth.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>environmentIntersectionWidth</c> property.  The <c>environmentIntersectionWidth</c> property defines the width in meters of the intersection line between the sensor and the environment.
        /// </summary>
        public DoubleCesiumWriter OpenEnvironmentIntersectionWidthProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(EnvironmentIntersectionWidthWriter);
        }

        /// <summary>
        /// Writes a value for the <c>environmentIntersectionWidth</c> property as a <c>number</c> value.  The <c>environmentIntersectionWidth</c> property specifies the width in meters of the intersection line between the sensor and the environment.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteEnvironmentIntersectionWidthProperty(double value)
        {
            using (var writer = OpenEnvironmentIntersectionWidthProperty())
            {
                writer.WriteNumber(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>environmentIntersectionWidth</c> property as a <c>number</c> value.  The <c>environmentIntersectionWidth</c> property specifies the width in meters of the intersection line between the sensor and the environment.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteEnvironmentIntersectionWidthProperty(IList<JulianDate> dates, IList<double> values)
        {
            using (var writer = OpenEnvironmentIntersectionWidthProperty())
            {
                writer.WriteNumber(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>environmentIntersectionWidth</c> property as a <c>number</c> value.  The <c>environmentIntersectionWidth</c> property specifies the width in meters of the intersection line between the sensor and the environment.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The value corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to use in the `values` collection.</param>
        /// <param name="length">The number of elements to use from the `values` collection.</param>
        public void WriteEnvironmentIntersectionWidthProperty(IList<JulianDate> dates, IList<double> values, int startIndex, int length)
        {
            using (var writer = OpenEnvironmentIntersectionWidthProperty())
            {
                writer.WriteNumber(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>environmentIntersectionWidth</c> property as a <c>reference</c> value.  The <c>environmentIntersectionWidth</c> property specifies the width in meters of the intersection line between the sensor and the environment.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteEnvironmentIntersectionWidthPropertyReference(Reference value)
        {
            using (var writer = OpenEnvironmentIntersectionWidthProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>environmentIntersectionWidth</c> property as a <c>reference</c> value.  The <c>environmentIntersectionWidth</c> property specifies the width in meters of the intersection line between the sensor and the environment.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteEnvironmentIntersectionWidthPropertyReference(string value)
        {
            using (var writer = OpenEnvironmentIntersectionWidthProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>environmentIntersectionWidth</c> property as a <c>reference</c> value.  The <c>environmentIntersectionWidth</c> property specifies the width in meters of the intersection line between the sensor and the environment.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteEnvironmentIntersectionWidthPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenEnvironmentIntersectionWidthProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>environmentIntersectionWidth</c> property as a <c>reference</c> value.  The <c>environmentIntersectionWidth</c> property specifies the width in meters of the intersection line between the sensor and the environment.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteEnvironmentIntersectionWidthPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenEnvironmentIntersectionWidthProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

    }
}
