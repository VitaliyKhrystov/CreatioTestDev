namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrRealtyEventsSchema

	/// <exclude/>
	public class UsrRealtyEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrRealtyEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrRealtyEventsSchema(UsrRealtyEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("718da965-0f4a-4d19-ad0d-e9482b3b8ba3");
			Name = "UsrRealtyEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c7396a38-aba5-4814-849c-953cb5a97f16");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,193,106,220,48,16,189,7,242,15,131,233,193,134,69,36,215,166,13,116,151,109,9,132,182,100,157,92,74,15,90,121,214,81,145,37,163,145,55,221,150,252,123,71,150,221,108,236,4,50,23,91,163,55,111,222,27,13,88,217,32,181,82,33,148,232,189,36,183,11,98,229,236,78,215,157,151,65,59,123,122,242,247,244,4,56,58,210,182,134,205,129,2,54,23,199,169,227,194,166,113,246,213,75,143,98,109,131,14,26,233,45,24,177,222,163,13,35,244,71,159,62,244,185,107,205,34,44,250,124,163,238,177,145,95,217,3,124,132,236,150,252,13,74,195,168,172,248,153,170,218,110,107,180,2,101,36,17,196,75,102,152,243,192,123,88,74,194,23,110,18,203,48,129,35,66,183,103,205,186,66,216,59,93,193,55,187,145,123,118,146,187,237,47,84,1,8,109,133,126,1,137,112,137,59,182,213,211,126,242,53,1,22,79,116,71,204,49,182,172,66,252,103,27,105,176,184,120,14,75,188,224,123,63,236,60,79,137,34,21,76,192,21,42,221,72,3,173,215,42,142,41,85,137,47,24,202,67,139,213,202,153,174,177,119,210,116,248,97,128,94,230,113,148,223,35,62,155,182,214,59,200,19,211,37,156,159,141,81,60,7,77,92,197,64,113,69,43,105,21,26,172,88,68,240,29,50,243,28,71,193,199,149,224,165,36,89,99,137,77,107,100,136,178,45,62,192,181,83,252,188,127,228,214,224,166,199,229,131,153,91,66,207,91,107,121,248,188,178,226,6,201,117,94,49,200,121,102,89,192,188,79,140,113,97,134,55,167,108,1,217,172,5,137,126,54,87,84,58,183,212,117,58,101,133,40,221,32,161,120,131,15,214,159,18,226,179,243,141,12,249,196,31,55,62,23,103,203,119,179,113,199,8,247,222,61,244,254,215,191,21,182,209,225,88,63,133,63,62,29,135,95,254,60,254,3,169,150,180,171,229,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e91e8680-41e0-07a2-a22f-ed478902f882"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("c7396a38-aba5-4814-849c-953cb5a97f16"),
				CreatedInSchemaUId = new Guid("718da965-0f4a-4d19-ad0d-e9482b3b8ba3"),
				ModifiedInSchemaUId = new Guid("718da965-0f4a-4d19-ad0d-e9482b3b8ba3")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("718da965-0f4a-4d19-ad0d-e9482b3b8ba3"));
		}

		#endregion

	}

	#endregion

}

