//ArchiCAD 22 4023 INT FULL. Classes generated from XML, not XSD

namespace GreenBuildingXML_ArchiCAD
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Xml;

    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.gbxml.org/schema", IsNullable = false)]
    public partial class gbXML
    {

        private gbXMLZone zoneField;

        private gbXMLConstruction[] constructionField;

        private gbXMLLayer[] layerField;

        private gbXMLMaterial[] materialField;

        private gbXMLCampus campusField;

        private gbXMLWeather weatherField;

        private gbXMLDocumentHistory documentHistoryField;

        private gbXMLSchedule[] scheduleField;

        private gbXMLWeekSchedule[] weekScheduleField;

        private gbXMLDaySchedule[] dayScheduleField;

        private string areaUnitField;

        private string lengthUnitField;

        private string temperatureUnitField;

        private bool useSIUnitsForResultsField;

        private decimal versionField;

        private string volumeUnitField;

        /// <remarks/>
        public gbXMLZone Zone
        {
            get
            {
                return this.zoneField;
            }
            set
            {
                this.zoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Construction")]
        public gbXMLConstruction[] Construction
        {
            get
            {
                return this.constructionField;
            }
            set
            {
                this.constructionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Layer")]
        public gbXMLLayer[] Layer
        {
            get
            {
                return this.layerField;
            }
            set
            {
                this.layerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Material")]
        public gbXMLMaterial[] Material
        {
            get
            {
                return this.materialField;
            }
            set
            {
                this.materialField = value;
            }
        }

        /// <remarks/>
        public gbXMLCampus Campus
        {
            get
            {
                return this.campusField;
            }
            set
            {
                this.campusField = value;
            }
        }

        /// <remarks/>
        public gbXMLWeather Weather
        {
            get
            {
                return this.weatherField;
            }
            set
            {
                this.weatherField = value;
            }
        }

        /// <remarks/>
        public gbXMLDocumentHistory DocumentHistory
        {
            get
            {
                return this.documentHistoryField;
            }
            set
            {
                this.documentHistoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Schedule")]
        public gbXMLSchedule[] Schedule
        {
            get
            {
                return this.scheduleField;
            }
            set
            {
                this.scheduleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WeekSchedule")]
        public gbXMLWeekSchedule[] WeekSchedule
        {
            get
            {
                return this.weekScheduleField;
            }
            set
            {
                this.weekScheduleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DaySchedule")]
        public gbXMLDaySchedule[] DaySchedule
        {
            get
            {
                return this.dayScheduleField;
            }
            set
            {
                this.dayScheduleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string areaUnit
        {
            get
            {
                return this.areaUnitField;
            }
            set
            {
                this.areaUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string lengthUnit
        {
            get
            {
                return this.lengthUnitField;
            }
            set
            {
                this.lengthUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string temperatureUnit
        {
            get
            {
                return this.temperatureUnitField;
            }
            set
            {
                this.temperatureUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool useSIUnitsForResults
        {
            get
            {
                return this.useSIUnitsForResultsField;
            }
            set
            {
                this.useSIUnitsForResultsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string volumeUnit
        {
            get
            {
                return this.volumeUnitField;
            }
            set
            {
                this.volumeUnitField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLZone
    {

        private string nameField;

        private byte descriptionField;

        private gbXMLZoneDesignHeatT designHeatTField;

        private gbXMLZoneDesignCoolT designCoolTField;

        private string coolSchedIdRefField;

        private string heatSchedIdRefField;

        private string idField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public byte Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public gbXMLZoneDesignHeatT DesignHeatT
        {
            get
            {
                return this.designHeatTField;
            }
            set
            {
                this.designHeatTField = value;
            }
        }

        /// <remarks/>
        public gbXMLZoneDesignCoolT DesignCoolT
        {
            get
            {
                return this.designCoolTField;
            }
            set
            {
                this.designCoolTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string coolSchedIdRef
        {
            get
            {
                return this.coolSchedIdRefField;
            }
            set
            {
                this.coolSchedIdRefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string heatSchedIdRef
        {
            get
            {
                return this.heatSchedIdRefField;
            }
            set
            {
                this.heatSchedIdRefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLZoneDesignHeatT
    {

        private string unitField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLZoneDesignCoolT
    {

        private string unitField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLConstruction
    {

        private string nameField;

        private gbXMLConstructionUvalue uvalueField;

        private gbXMLConstructionLayerId layerIdField;

        private gbXMLConstructionLoadCalcInputParameters loadCalcInputParametersField;

        private string idField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("U-value")]
        public gbXMLConstructionUvalue Uvalue
        {
            get
            {
                return this.uvalueField;
            }
            set
            {
                this.uvalueField = value;
            }
        }

        /// <remarks/>
        public gbXMLConstructionLayerId LayerId
        {
            get
            {
                return this.layerIdField;
            }
            set
            {
                this.layerIdField = value;
            }
        }

        /// <remarks/>
        public gbXMLConstructionLoadCalcInputParameters LoadCalcInputParameters
        {
            get
            {
                return this.loadCalcInputParametersField;
            }
            set
            {
                this.loadCalcInputParametersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLConstructionUvalue
    {

        private string unitField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLConstructionLayerId
    {

        private string layerIdRefField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string layerIdRef
        {
            get
            {
                return this.layerIdRefField;
            }
            set
            {
                this.layerIdRefField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLConstructionLoadCalcInputParameters
    {

        private gbXMLConstructionLoadCalcInputParametersCLTDParameters cLTDParametersField;

        /// <remarks/>
        public gbXMLConstructionLoadCalcInputParametersCLTDParameters CLTDParameters
        {
            get
            {
                return this.cLTDParametersField;
            }
            set
            {
                this.cLTDParametersField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLConstructionLoadCalcInputParametersCLTDParameters
    {

        private string wallColorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string wallColor
        {
            get
            {
                return this.wallColorField;
            }
            set
            {
                this.wallColorField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLLayer
    {

        private string nameField;

        private gbXMLLayerMaterialId[] materialIdField;

        private string idField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialId")]
        public gbXMLLayerMaterialId[] MaterialId
        {
            get
            {
                return this.materialIdField;
            }
            set
            {
                this.materialIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLLayerMaterialId
    {

        private string materialIdRefField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string materialIdRef
        {
            get
            {
                return this.materialIdRefField;
            }
            set
            {
                this.materialIdRefField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLMaterial
    {

        private gbXMLMaterialRvalue rvalueField;

        private gbXMLMaterialThickness thicknessField;

        private string nameField;

        private gbXMLMaterialConductivity conductivityField;

        private gbXMLMaterialDensity densityField;

        private gbXMLMaterialSpecificHeat specificHeatField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("R-value")]
        public gbXMLMaterialRvalue Rvalue
        {
            get
            {
                return this.rvalueField;
            }
            set
            {
                this.rvalueField = value;
            }
        }

        /// <remarks/>
        public gbXMLMaterialThickness Thickness
        {
            get
            {
                return this.thicknessField;
            }
            set
            {
                this.thicknessField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public gbXMLMaterialConductivity Conductivity
        {
            get
            {
                return this.conductivityField;
            }
            set
            {
                this.conductivityField = value;
            }
        }

        /// <remarks/>
        public gbXMLMaterialDensity Density
        {
            get
            {
                return this.densityField;
            }
            set
            {
                this.densityField = value;
            }
        }

        /// <remarks/>
        public gbXMLMaterialSpecificHeat SpecificHeat
        {
            get
            {
                return this.specificHeatField;
            }
            set
            {
                this.specificHeatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLMaterialRvalue
    {

        private string unitField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLMaterialThickness
    {

        private string unitField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLMaterialConductivity
    {

        private string unitField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLMaterialDensity
    {

        private string unitField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLMaterialSpecificHeat
    {

        private string unitField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLCampus
    {

        private gbXMLCampusLocation locationField;

        private gbXMLCampusSurface[] surfaceField;

        private gbXMLCampusBuilding buildingField;

        private string idField;

        /// <remarks/>
        public gbXMLCampusLocation Location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Surface")]
        public gbXMLCampusSurface[] Surface
        {
            get
            {
                return this.surfaceField;
            }
            set
            {
                this.surfaceField = value;
            }
        }

        /// <remarks/>
        public gbXMLCampusBuilding Building
        {
            get
            {
                return this.buildingField;
            }
            set
            {
                this.buildingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLCampusLocation
    {

        private string nameField;

        private decimal longitudeField;

        private decimal latitudeField;

        private decimal cADModelAzimuthField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public decimal Longitude
        {
            get
            {
                return this.longitudeField;
            }
            set
            {
                this.longitudeField = value;
            }
        }

        /// <remarks/>
        public decimal Latitude
        {
            get
            {
                return this.latitudeField;
            }
            set
            {
                this.latitudeField = value;
            }
        }

        /// <remarks/>
        public decimal CADModelAzimuth
        {
            get
            {
                return this.cADModelAzimuthField;
            }
            set
            {
                this.cADModelAzimuthField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLCampusSurface
    {

        private string nameField;

        private gbXMLCampusSurfaceRectangularGeometry rectangularGeometryField;

        private gbXMLCampusSurfacePlanarGeometry planarGeometryField;

        private gbXMLCampusSurfaceAdjacentSpaceId adjacentSpaceIdField;

        private string constructionIdRefField;

        private bool exposedToSunField;

        private string idField;

        private string surfaceTypeField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public gbXMLCampusSurfaceRectangularGeometry RectangularGeometry
        {
            get
            {
                return this.rectangularGeometryField;
            }
            set
            {
                this.rectangularGeometryField = value;
            }
        }

        /// <remarks/>
        public gbXMLCampusSurfacePlanarGeometry PlanarGeometry
        {
            get
            {
                return this.planarGeometryField;
            }
            set
            {
                this.planarGeometryField = value;
            }
        }

        /// <remarks/>
        public gbXMLCampusSurfaceAdjacentSpaceId AdjacentSpaceId
        {
            get
            {
                return this.adjacentSpaceIdField;
            }
            set
            {
                this.adjacentSpaceIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string constructionIdRef
        {
            get
            {
                return this.constructionIdRefField;
            }
            set
            {
                this.constructionIdRefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool exposedToSun
        {
            get
            {
                return this.exposedToSunField;
            }
            set
            {
                this.exposedToSunField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string surfaceType
        {
            get
            {
                return this.surfaceTypeField;
            }
            set
            {
                this.surfaceTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLCampusSurfaceRectangularGeometry
    {

        private decimal azimuthField;

        private decimal tiltField;

        private decimal widthField;

        private decimal heightField;

        private decimal[] cartesianPointField;

        /// <remarks/>
        public decimal Azimuth
        {
            get
            {
                return this.azimuthField;
            }
            set
            {
                this.azimuthField = value;
            }
        }

        /// <remarks/>
        public decimal Tilt
        {
            get
            {
                return this.tiltField;
            }
            set
            {
                this.tiltField = value;
            }
        }

        /// <remarks/>
        public decimal Width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        public decimal Height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Coordinate", IsNullable = false)]
        public decimal[] CartesianPoint
        {
            get
            {
                return this.cartesianPointField;
            }
            set
            {
                this.cartesianPointField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLCampusSurfacePlanarGeometry
    {

        private decimal[][] polyLoopField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("CartesianPoint", IsNullable = false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Coordinate", IsNullable = false, NestingLevel = 1)]
        public decimal[][] PolyLoop
        {
            get
            {
                return this.polyLoopField;
            }
            set
            {
                this.polyLoopField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLCampusSurfaceAdjacentSpaceId
    {

        private string spaceIdRefField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string spaceIdRef
        {
            get
            {
                return this.spaceIdRefField;
            }
            set
            {
                this.spaceIdRefField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLCampusBuilding
    {

        private gbXMLCampusBuildingArea areaField;

        private gbXMLCampusBuildingBuildingStorey[] buildingStoreyField;

        private gbXMLCampusBuildingSpace[] spaceField;

        private string buildingTypeField;

        private string idField;

        /// <remarks/>
        public gbXMLCampusBuildingArea Area
        {
            get
            {
                return this.areaField;
            }
            set
            {
                this.areaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BuildingStorey")]
        public gbXMLCampusBuildingBuildingStorey[] BuildingStorey
        {
            get
            {
                return this.buildingStoreyField;
            }
            set
            {
                this.buildingStoreyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Space")]
        public gbXMLCampusBuildingSpace[] Space
        {
            get
            {
                return this.spaceField;
            }
            set
            {
                this.spaceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string buildingType
        {
            get
            {
                return this.buildingTypeField;
            }
            set
            {
                this.buildingTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLCampusBuildingArea
    {

        private string unitField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLCampusBuildingBuildingStorey
    {

        private string nameField;

        private decimal levelField;

        private string idField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public decimal Level
        {
            get
            {
                return this.levelField;
            }
            set
            {
                this.levelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLCampusBuildingSpace
    {

        private object nameField;

        private ushort descriptionField;

        private string typeCodeField;

        private gbXMLCampusBuildingSpaceArea areaField;

        private gbXMLCampusBuildingSpaceVolume volumeField;

        private gbXMLCampusBuildingSpaceCADObjectId cADObjectIdField;

        private gbXMLCampusBuildingSpaceLightPowerPerArea lightPowerPerAreaField;

        private gbXMLCampusBuildingSpaceEquipPowerPerArea equipPowerPerAreaField;

        private gbXMLCampusBuildingSpacePeopleNumber peopleNumberField;

        private gbXMLCampusBuildingSpacePeopleHeatGain[] peopleHeatGainField;

        private gbXMLCampusBuildingSpacePlanarGeometry[] planarGeometryField;

        private gbXMLCampusBuildingSpaceShellGeometry shellGeometryField;

        private gbXMLCampusBuildingSpaceSpaceBoundary[] spaceBoundaryField;

        private string buildingStoreyIdRefField;

        private string equipmentScheduleIdRefField;

        private string idField;

        private string lightScheduleIdRefField;

        private string peopleScheduleIdRefField;

        private string zoneIdRefField;

        /// <remarks/>
        public object Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public ushort Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public string TypeCode
        {
            get
            {
                return this.typeCodeField;
            }
            set
            {
                this.typeCodeField = value;
            }
        }

        /// <remarks/>
        public gbXMLCampusBuildingSpaceArea Area
        {
            get
            {
                return this.areaField;
            }
            set
            {
                this.areaField = value;
            }
        }

        /// <remarks/>
        public gbXMLCampusBuildingSpaceVolume Volume
        {
            get
            {
                return this.volumeField;
            }
            set
            {
                this.volumeField = value;
            }
        }

        /// <remarks/>
        public gbXMLCampusBuildingSpaceCADObjectId CADObjectId
        {
            get
            {
                return this.cADObjectIdField;
            }
            set
            {
                this.cADObjectIdField = value;
            }
        }

        /// <remarks/>
        public gbXMLCampusBuildingSpaceLightPowerPerArea LightPowerPerArea
        {
            get
            {
                return this.lightPowerPerAreaField;
            }
            set
            {
                this.lightPowerPerAreaField = value;
            }
        }

        /// <remarks/>
        public gbXMLCampusBuildingSpaceEquipPowerPerArea EquipPowerPerArea
        {
            get
            {
                return this.equipPowerPerAreaField;
            }
            set
            {
                this.equipPowerPerAreaField = value;
            }
        }

        /// <remarks/>
        public gbXMLCampusBuildingSpacePeopleNumber PeopleNumber
        {
            get
            {
                return this.peopleNumberField;
            }
            set
            {
                this.peopleNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PeopleHeatGain")]
        public gbXMLCampusBuildingSpacePeopleHeatGain[] PeopleHeatGain
        {
            get
            {
                return this.peopleHeatGainField;
            }
            set
            {
                this.peopleHeatGainField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PlanarGeometry")]
        public gbXMLCampusBuildingSpacePlanarGeometry[] PlanarGeometry
        {
            get
            {
                return this.planarGeometryField;
            }
            set
            {
                this.planarGeometryField = value;
            }
        }

        /// <remarks/>
        public gbXMLCampusBuildingSpaceShellGeometry ShellGeometry
        {
            get
            {
                return this.shellGeometryField;
            }
            set
            {
                this.shellGeometryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SpaceBoundary")]
        public gbXMLCampusBuildingSpaceSpaceBoundary[] SpaceBoundary
        {
            get
            {
                return this.spaceBoundaryField;
            }
            set
            {
                this.spaceBoundaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string buildingStoreyIdRef
        {
            get
            {
                return this.buildingStoreyIdRefField;
            }
            set
            {
                this.buildingStoreyIdRefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string equipmentScheduleIdRef
        {
            get
            {
                return this.equipmentScheduleIdRefField;
            }
            set
            {
                this.equipmentScheduleIdRefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string lightScheduleIdRef
        {
            get
            {
                return this.lightScheduleIdRefField;
            }
            set
            {
                this.lightScheduleIdRefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string peopleScheduleIdRef
        {
            get
            {
                return this.peopleScheduleIdRefField;
            }
            set
            {
                this.peopleScheduleIdRefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string zoneIdRef
        {
            get
            {
                return this.zoneIdRefField;
            }
            set
            {
                this.zoneIdRefField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLCampusBuildingSpaceArea
    {

        private string unitField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLCampusBuildingSpaceVolume
    {

        private string unitField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLCampusBuildingSpaceCADObjectId
    {

        private string programIdRefField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string programIdRef
        {
            get
            {
                return this.programIdRefField;
            }
            set
            {
                this.programIdRefField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLCampusBuildingSpaceLightPowerPerArea
    {

        private string unitField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLCampusBuildingSpaceEquipPowerPerArea
    {

        private string unitField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLCampusBuildingSpacePeopleNumber
    {

        private string unitField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLCampusBuildingSpacePeopleHeatGain
    {

        private string heatGainTypeField;

        private string unitField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string heatGainType
        {
            get
            {
                return this.heatGainTypeField;
            }
            set
            {
                this.heatGainTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLCampusBuildingSpacePlanarGeometry
    {

        private decimal[][] polyLoopField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("CartesianPoint", IsNullable = false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Coordinate", IsNullable = false, NestingLevel = 1)]
        public decimal[][] PolyLoop
        {
            get
            {
                return this.polyLoopField;
            }
            set
            {
                this.polyLoopField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLCampusBuildingSpaceShellGeometry
    {

        private decimal[][][][] closedShellField;

        private string idField;

        private string unitField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PolyLoop", typeof(decimal[][]), IsNullable = false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("CartesianPoint", typeof(decimal[]), IsNullable = false, NestingLevel = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Coordinate", typeof(decimal), IsNullable = false, NestingLevel = 2)]
        public decimal[][][][] ClosedShell
        {
            get
            {
                return this.closedShellField;
            }
            set
            {
                this.closedShellField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLCampusBuildingSpaceSpaceBoundary
    {

        private gbXMLCampusBuildingSpaceSpaceBoundaryPlanarGeometry planarGeometryField;

        private string surfaceIdRefField;

        /// <remarks/>
        public gbXMLCampusBuildingSpaceSpaceBoundaryPlanarGeometry PlanarGeometry
        {
            get
            {
                return this.planarGeometryField;
            }
            set
            {
                this.planarGeometryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string surfaceIdRef
        {
            get
            {
                return this.surfaceIdRefField;
            }
            set
            {
                this.surfaceIdRefField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLCampusBuildingSpaceSpaceBoundaryPlanarGeometry
    {

        private decimal[][] polyLoopField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("CartesianPoint", IsNullable = false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Coordinate", IsNullable = false, NestingLevel = 1)]
        public decimal[][] PolyLoop
        {
            get
            {
                return this.polyLoopField;
            }
            set
            {
                this.polyLoopField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLWeather
    {

        private string cityField;

        private gbXMLWeatherGroundTemp[] groundTempField;

        private string idField;

        /// <remarks/>
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GroundTemp")]
        public gbXMLWeatherGroundTemp[] GroundTemp
        {
            get
            {
                return this.groundTempField;
            }
            set
            {
                this.groundTempField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLWeatherGroundTemp
    {

        private string unitField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLDocumentHistory
    {

        private gbXMLDocumentHistoryProgramInfo programInfoField;

        private gbXMLDocumentHistoryPersonInfo personInfoField;

        private gbXMLDocumentHistoryCreatedBy createdByField;

        /// <remarks/>
        public gbXMLDocumentHistoryProgramInfo ProgramInfo
        {
            get
            {
                return this.programInfoField;
            }
            set
            {
                this.programInfoField = value;
            }
        }

        /// <remarks/>
        public gbXMLDocumentHistoryPersonInfo PersonInfo
        {
            get
            {
                return this.personInfoField;
            }
            set
            {
                this.personInfoField = value;
            }
        }

        /// <remarks/>
        public gbXMLDocumentHistoryCreatedBy CreatedBy
        {
            get
            {
                return this.createdByField;
            }
            set
            {
                this.createdByField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLDocumentHistoryProgramInfo
    {

        private string companyNameField;

        private string productNameField;

        private string versionField;

        private string platformField;

        private string idField;

        /// <remarks/>
        public string CompanyName
        {
            get
            {
                return this.companyNameField;
            }
            set
            {
                this.companyNameField = value;
            }
        }

        /// <remarks/>
        public string ProductName
        {
            get
            {
                return this.productNameField;
            }
            set
            {
                this.productNameField = value;
            }
        }

        /// <remarks/>
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        public string Platform
        {
            get
            {
                return this.platformField;
            }
            set
            {
                this.platformField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLDocumentHistoryPersonInfo
    {

        private string firstNameField;

        private string lastNameField;

        private string companyNameField;

        private string idField;

        /// <remarks/>
        public string FirstName
        {
            get
            {
                return this.firstNameField;
            }
            set
            {
                this.firstNameField = value;
            }
        }

        /// <remarks/>
        public string LastName
        {
            get
            {
                return this.lastNameField;
            }
            set
            {
                this.lastNameField = value;
            }
        }

        /// <remarks/>
        public string CompanyName
        {
            get
            {
                return this.companyNameField;
            }
            set
            {
                this.companyNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLDocumentHistoryCreatedBy
    {

        private System.DateTime dateField;

        private string personIdField;

        private string programIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string personId
        {
            get
            {
                return this.personIdField;
            }
            set
            {
                this.personIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string programId
        {
            get
            {
                return this.programIdField;
            }
            set
            {
                this.programIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLSchedule
    {

        private string nameField;

        private gbXMLScheduleYearSchedule yearScheduleField;

        private string idField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public gbXMLScheduleYearSchedule YearSchedule
        {
            get
            {
                return this.yearScheduleField;
            }
            set
            {
                this.yearScheduleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLScheduleYearSchedule
    {

        private string beginDateField;

        private string endDateField;

        private gbXMLScheduleYearScheduleWeekScheduleId weekScheduleIdField;

        private string idField;

        /// <remarks/>
        public string BeginDate
        {
            get
            {
                return this.beginDateField;
            }
            set
            {
                this.beginDateField = value;
            }
        }

        /// <remarks/>
        public string EndDate
        {
            get
            {
                return this.endDateField;
            }
            set
            {
                this.endDateField = value;
            }
        }

        /// <remarks/>
        public gbXMLScheduleYearScheduleWeekScheduleId WeekScheduleId
        {
            get
            {
                return this.weekScheduleIdField;
            }
            set
            {
                this.weekScheduleIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLScheduleYearScheduleWeekScheduleId
    {

        private string weekScheduleIdRefField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string weekScheduleIdRef
        {
            get
            {
                return this.weekScheduleIdRefField;
            }
            set
            {
                this.weekScheduleIdRefField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLWeekSchedule
    {

        private string nameField;

        private gbXMLWeekScheduleDay[] dayField;

        private string idField;

        private string typeField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Day")]
        public gbXMLWeekScheduleDay[] Day
        {
            get
            {
                return this.dayField;
            }
            set
            {
                this.dayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLWeekScheduleDay
    {

        private string dayScheduleIdRefField;

        private string dayTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dayScheduleIdRef
        {
            get
            {
                return this.dayScheduleIdRefField;
            }
            set
            {
                this.dayScheduleIdRefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dayType
        {
            get
            {
                return this.dayTypeField;
            }
            set
            {
                this.dayTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLDaySchedule
    {

        private string nameField;

        private decimal[] scheduleValueField;

        private string idField;

        private string typeField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ScheduleValue")]
        public decimal[] ScheduleValue
        {
            get
            {
                return this.scheduleValueField;
            }
            set
            {
                this.scheduleValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }


}
