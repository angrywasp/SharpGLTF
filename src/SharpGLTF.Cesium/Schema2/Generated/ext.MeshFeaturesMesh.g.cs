// <auto-generated/>

//------------------------------------------------------------------------------------------------
//      This file has been programatically generated; DON´T EDIT!
//------------------------------------------------------------------------------------------------

#pragma warning disable SA1001
#pragma warning disable SA1027
#pragma warning disable SA1028
#pragma warning disable SA1121
#pragma warning disable SA1205
#pragma warning disable SA1309
#pragma warning disable SA1402
#pragma warning disable SA1505
#pragma warning disable SA1507
#pragma warning disable SA1508
#pragma warning disable SA1652

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Text.Json;

namespace SharpGLTF.Schema2
{
	using Collections;

	/// <summary>
	/// A texture containing feature IDs
	/// </summary>
	partial class FeatureIDTextureinEXT_mesh_features : TextureInfo
	{
	
		private static readonly Int32[] _channelsDefault = new Int32[1] {0 };
		private Int32[] _channels = _channelsDefault;
		
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
			base.SerializeProperties(writer);
			SerializeProperty(writer,"channels",_channels);
		}
	
		protected override void DeserializeProperty(string jsonPropertyName, ref Utf8JsonReader reader)
		{
			switch (jsonPropertyName)
			{
				case "channels": DeserializePropertyList<Int32>(ref reader, _channels); break;
				default: base.DeserializeProperty(jsonPropertyName,ref reader); break;
			}
		}
	
	}

	/// <summary>
	/// Feature IDs stored in an attribute or texture.
	/// </summary>
	partial class FeatureID : ExtraProperties
	{
	
		private Int32? _attribute;
		
		private const Int32 _featureCountMinimum = 1;
		private Int32 _featureCount;
		
		private String _label;
		
		private const Int32 _nullFeatureIdMinimum = 0;
		private Int32? _nullFeatureId;
		
		private const Int32 _propertyTableMinimum = 0;
		private Int32? _propertyTable;
		
		private FeatureIDTextureinEXT_mesh_features _texture;
		
	
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
			base.SerializeProperties(writer);
			SerializeProperty(writer, "attribute", _attribute);
			SerializeProperty(writer, "featureCount", _featureCount);
			SerializeProperty(writer, "label", _label);
			SerializeProperty(writer, "nullFeatureId", _nullFeatureId);
			SerializeProperty(writer, "propertyTable", _propertyTable);
			SerializePropertyObject(writer, "texture", _texture);
		}
	
		protected override void DeserializeProperty(string jsonPropertyName, ref Utf8JsonReader reader)
		{
			switch (jsonPropertyName)
			{
				case "attribute": _attribute = DeserializePropertyValue<Int32?>(ref reader); break;
				case "featureCount": _featureCount = DeserializePropertyValue<Int32>(ref reader); break;
				case "label": _label = DeserializePropertyValue<String>(ref reader); break;
				case "nullFeatureId": _nullFeatureId = DeserializePropertyValue<Int32?>(ref reader); break;
				case "propertyTable": _propertyTable = DeserializePropertyValue<Int32?>(ref reader); break;
				case "texture": _texture = DeserializePropertyValue<FeatureIDTextureinEXT_mesh_features>(ref reader); break;
				default: base.DeserializeProperty(jsonPropertyName,ref reader); break;
			}
		}
	
	}

	/// <summary>
	/// An object describing feature IDs for a mesh primitive.
	/// </summary>
	partial class MeshExtMeshFeatures : ExtraProperties
	{
	
		private const int _featureIdsMinItems = 1;
		private List<FeatureID> _featureIds;

        protected override void SerializeProperties(Utf8JsonWriter writer)
		{
			base.SerializeProperties(writer);
			SerializeProperty(writer, "featureIds", _featureIds, _featureIdsMinItems);
		}
	
		protected override void DeserializeProperty(string jsonPropertyName, ref Utf8JsonReader reader)
		{
			switch (jsonPropertyName)
			{
				case "featureIds": DeserializePropertyList<FeatureID>(ref reader, _featureIds); break;
				default: base.DeserializeProperty(jsonPropertyName,ref reader); break;
			}
		}
	
	}

}
