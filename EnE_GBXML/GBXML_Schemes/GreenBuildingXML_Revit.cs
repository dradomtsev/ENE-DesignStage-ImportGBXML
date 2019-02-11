//Revit 2019.1. Classes generated from XML, not XSD

namespace GreenBuildingXML_Revit
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

        private gbXMLCampus campusField;

        private gbXMLConstruction[] constructionField;

        private gbXMLLayer[] layerField;

        private gbXMLMaterial[] materialField;

        private gbXMLDocumentHistory documentHistoryField;

        private bool useSIUnitsForResultsField;

        private string temperatureUnitField;

        private string lengthUnitField;

        private string areaUnitField;

        private string volumeUnitField;

        private decimal versionField;

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
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLCampus
    {

        private gbXMLCampusLocation locationField;

        private gbXMLCampusBuilding buildingField;

        private gbXMLCampusSurface[] surfaceField;

        private bool daylightSavingsField;

        private string nameField;

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
        public bool DaylightSavings
        {
            get
            {
                return this.daylightSavingsField;
            }
            set
            {
                this.daylightSavingsField = value;
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

        private gbXMLCampusLocationStationId stationIdField;

        private byte zipcodeOrPostalCodeField;

        private decimal longitudeField;

        private decimal latitudeField;

        private decimal elevationField;

        private byte cADModelAzimuthField;

        private string nameField;

        /// <remarks/>
        public gbXMLCampusLocationStationId StationId
        {
            get
            {
                return this.stationIdField;
            }
            set
            {
                this.stationIdField = value;
            }
        }

        /// <remarks/>
        public byte ZipcodeOrPostalCode
        {
            get
            {
                return this.zipcodeOrPostalCodeField;
            }
            set
            {
                this.zipcodeOrPostalCodeField = value;
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
        public decimal Elevation
        {
            get
            {
                return this.elevationField;
            }
            set
            {
                this.elevationField = value;
            }
        }

        /// <remarks/>
        public byte CADModelAzimuth
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
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLCampusLocationStationId
    {

        private string iDTypeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IDType
        {
            get
            {
                return this.iDTypeField;
            }
            set
            {
                this.iDTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
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
    public partial class gbXMLCampusBuilding
    {

        private string streetAddressField;

        private decimal areaField;

        private gbXMLCampusBuildingSpace[] spaceField;

        private gbXMLCampusBuildingBuildingStorey[] buildingStoreyField;

        private string nameField;

        private string descriptionField;

        private string buildingTypeField;

        private string idField;

        /// <remarks/>
        public string StreetAddress
        {
            get
            {
                return this.streetAddressField;
            }
            set
            {
                this.streetAddressField = value;
            }
        }

        /// <remarks/>
        public decimal Area
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
        public string Description
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
    public partial class gbXMLCampusBuildingSpace
    {

        private decimal areaField;

        private decimal volumeField;

        private gbXMLCampusBuildingSpacePlanarGeometry planarGeometryField;

        private gbXMLCampusBuildingSpaceShellGeometry shellGeometryField;

        private gbXMLCampusBuildingSpaceSpaceBoundary[] spaceBoundaryField;

        private string nameField;

        private uint cADObjectIdField;

        private string buildingStoreyIdRefField;

        private string idField;

        /// <remarks/>
        public decimal Area
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
        public decimal Volume
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
        public gbXMLCampusBuildingSpacePlanarGeometry PlanarGeometry
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
        public uint CADObjectId
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

        private decimal[][][] closedShellField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PolyLoop", IsNullable = false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("CartesianPoint", IsNullable = false, NestingLevel = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Coordinate", IsNullable = false, NestingLevel = 2)]
        public decimal[][][] ClosedShell
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
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLCampusBuildingSpaceSpaceBoundary
    {

        private gbXMLCampusBuildingSpaceSpaceBoundaryPlanarGeometry planarGeometryField;

        private bool isSecondLevelBoundaryField;

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
        public bool isSecondLevelBoundary
        {
            get
            {
                return this.isSecondLevelBoundaryField;
            }
            set
            {
                this.isSecondLevelBoundaryField = value;
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
    public partial class gbXMLCampusBuildingBuildingStorey
    {

        private decimal levelField;

        private gbXMLCampusBuildingBuildingStoreyPlanarGeometry planarGeometryField;

        private string nameField;

        private string idField;

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
        public gbXMLCampusBuildingBuildingStoreyPlanarGeometry PlanarGeometry
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
    public partial class gbXMLCampusBuildingBuildingStoreyPlanarGeometry
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
    public partial class gbXMLCampusSurface
    {

        private gbXMLCampusSurfaceAdjacentSpaceId[] adjacentSpaceIdField;

        private gbXMLCampusSurfaceRectangularGeometry rectangularGeometryField;

        private gbXMLCampusSurfacePlanarGeometry planarGeometryField;

        private gbXMLCampusSurfaceOpening openingField;

        private string cADObjectIdField;

        private string nameField;

        private string surfaceTypeField;

        private string idField;

        private string constructionIdRefField;

        private bool exposedToSunField;

        private bool exposedToSunFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdjacentSpaceId")]
        public gbXMLCampusSurfaceAdjacentSpaceId[] AdjacentSpaceId
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
        public gbXMLCampusSurfaceOpening Opening
        {
            get
            {
                return this.openingField;
            }
            set
            {
                this.openingField = value;
            }
        }

        /// <remarks/>
        public string CADObjectId
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool exposedToSunSpecified
        {
            get
            {
                return this.exposedToSunFieldSpecified;
            }
            set
            {
                this.exposedToSunFieldSpecified = value;
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
    public partial class gbXMLCampusSurfaceRectangularGeometry
    {

        private decimal azimuthField;

        private decimal[] cartesianPointField;

        private decimal tiltField;

        private decimal widthField;

        private decimal heightField;

        private string idField;

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
    public partial class gbXMLCampusSurfaceOpening
    {

        private gbXMLCampusSurfaceOpeningRectangularGeometry rectangularGeometryField;

        private gbXMLCampusSurfaceOpeningPlanarGeometry planarGeometryField;

        private string cADObjectIdField;

        private string nameField;

        private string openingTypeField;

        private string idField;

        /// <remarks/>
        public gbXMLCampusSurfaceOpeningRectangularGeometry RectangularGeometry
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
        public gbXMLCampusSurfaceOpeningPlanarGeometry PlanarGeometry
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
        public string CADObjectId
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string openingType
        {
            get
            {
                return this.openingTypeField;
            }
            set
            {
                this.openingTypeField = value;
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
    public partial class gbXMLCampusSurfaceOpeningRectangularGeometry
    {

        private decimal[] cartesianPointField;

        private decimal widthField;

        private decimal heightField;

        private string idField;

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
    public partial class gbXMLCampusSurfaceOpeningPlanarGeometry
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
    public partial class gbXMLConstruction
    {

        private gbXMLConstructionUvalue uvalueField;

        private gbXMLConstructionAbsorptance absorptanceField;

        private gbXMLConstructionRoughness roughnessField;

        private gbXMLConstructionLayerId layerIdField;

        private string nameField;

        private string idField;

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
        public gbXMLConstructionAbsorptance Absorptance
        {
            get
            {
                return this.absorptanceField;
            }
            set
            {
                this.absorptanceField = value;
            }
        }

        /// <remarks/>
        public gbXMLConstructionRoughness Roughness
        {
            get
            {
                return this.roughnessField;
            }
            set
            {
                this.roughnessField = value;
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
    public partial class gbXMLConstructionAbsorptance
    {

        private string unitField;

        private string typeField;

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
    public partial class gbXMLConstructionRoughness
    {

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
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
    public partial class gbXMLLayer
    {

        private gbXMLLayerMaterialId[] materialIdField;

        private string idField;

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

        private string nameField;

        private gbXMLMaterialRvalue rvalueField;

        private gbXMLMaterialThickness thicknessField;

        private gbXMLMaterialConductivity conductivityField;

        private gbXMLMaterialDensity densityField;

        private gbXMLMaterialSpecificHeat specificHeatField;

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

        private ushort valueField;

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
        public ushort Value
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

        private ushort valueField;

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
        public ushort Value
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

        private gbXMLDocumentHistoryCreatedBy createdByField;

        private gbXMLDocumentHistoryPersonInfo personInfoField;

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
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLDocumentHistoryProgramInfo
    {

        private string companyNameField;

        private string productNameField;

        private string versionField;

        private string platformField;

        private gbXMLDocumentHistoryProgramInfoProjectEntity projectEntityField;

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
        public gbXMLDocumentHistoryProgramInfoProjectEntity ProjectEntity
        {
            get
            {
                return this.projectEntityField;
            }
            set
            {
                this.projectEntityField = value;
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
    public partial class gbXMLDocumentHistoryProgramInfoProjectEntity
    {

        private string uRIField;

        private gbXMLDocumentHistoryProgramInfoProjectEntityGUID gUIDField;

        /// <remarks/>
        public string URI
        {
            get
            {
                return this.uRIField;
            }
            set
            {
                this.uRIField = value;
            }
        }

        /// <remarks/>
        public gbXMLDocumentHistoryProgramInfoProjectEntityGUID GUID
        {
            get
            {
                return this.gUIDField;
            }
            set
            {
                this.gUIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLDocumentHistoryProgramInfoProjectEntityGUID
    {

        private string entityField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string entity
        {
            get
            {
                return this.entityField;
            }
            set
            {
                this.entityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
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
    public partial class gbXMLDocumentHistoryCreatedBy
    {

        private string cADModelIdField;

        private string personIdField;

        private string programIdField;

        private System.DateTime dateField;

        /// <remarks/>
        public string CADModelId
        {
            get
            {
                return this.cADModelIdField;
            }
            set
            {
                this.cADModelIdField = value;
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
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gbxml.org/schema")]
    public partial class gbXMLDocumentHistoryPersonInfo
    {

        private string idField;

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


}
