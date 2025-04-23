namespace Terrasoft.Core.Process
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: UsrCalcAverageRealtyPriceProcessMethodsWrapper

	/// <exclude/>
	public class UsrCalcAverageRealtyPriceProcessMethodsWrapper : ProcessModel
	{

		public UsrCalcAverageRealtyPriceProcessMethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("ScriptTask1Execute", ScriptTask1Execute);
		}

		#region Methods: Private

		private bool ScriptTask1Execute(ProcessExecutingContext context) {
			var userConnection = Get<UserConnection>("UserConnection");
			
			var esq = new EntitySchemaQuery(userConnection.EntitySchemaManager, "UsrReality");
			
			var priceColumn = esq.AddColumn("UsrPrice");
			var areaColumn = esq.AddColumn("UsrArea");
			
			Guid typeId = Get<Guid>("RealityTypeIdParameter");
			Guid offerTypeId = Get<Guid>("RealityOfferTypeIdParameter");
			
			var typeFilter = esq.CreateFilterWithParameters(FilterComparisonType.Equal, "UsrType", typeId);
			esq.Filters.Add(typeFilter);
			
			var offerTypeFilter = esq.CreateFilterWithParameters(FilterComparisonType.Equal, "UsrOfferType", offerTypeId);
			esq.Filters.Add(typeFilter);
			
			string sqlText = esq.GetSelectQuery(userConnection).GetSqlText();
			Set("SqlTextParameter", sqlText); 
			
			var entityCollection = esq.GetEntityCollection(userConnection);
			
			decimal totalEUR = 0;
			decimal totalArea = 0;
			
			foreach(var entity in entityCollection){
				decimal price = entity.GetTypedColumnValue<decimal>(priceColumn.Name);
				decimal area = entity.GetTypedColumnValue<decimal>(areaColumn.Name);
				totalEUR = totalEUR + price;
				totalArea = totalArea + area;
			}
			
			decimal result = 0;
			if(totalArea > 0){
				result = totalEUR/totalArea;
			}
			
			Set("AvgPriceEURParameter", result); 
			
			return true;
		}

		#endregion

	}

	#endregion

}

