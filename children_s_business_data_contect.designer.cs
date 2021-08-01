﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace project_market_registry
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="children`s_business_database")]
	public partial class children_s_business_data_contectDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTable(Table instance);
    partial void UpdateTable(Table instance);
    partial void DeleteTable(Table instance);
    #endregion
		
		public children_s_business_data_contectDataContext() : 
				base(global::project_market_registry.Properties.Settings.Default.children_s_business_databaseConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public children_s_business_data_contectDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public children_s_business_data_contectDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public children_s_business_data_contectDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public children_s_business_data_contectDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Table> Tables
		{
			get
			{
				return this.GetTable<Table>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Table]")]
	public partial class Table : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Order_Number;
		
		private string _Product_Name;
		
		private string _Description;
		
		private System.Nullable<int> _Units__Kilogram_;
		
		private System.Nullable<double> _Price_____;
		
		private System.Nullable<double> _Taxes____;
		
		private System.Nullable<double> _Total_Price____;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOrder_NumberChanging(int value);
    partial void OnOrder_NumberChanged();
    partial void OnProduct_NameChanging(string value);
    partial void OnProduct_NameChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnUnits__Kilogram_Changing(System.Nullable<int> value);
    partial void OnUnits__Kilogram_Changed();
    partial void OnPrice_____Changing(System.Nullable<double> value);
    partial void OnPrice_____Changed();
    partial void OnTaxes____Changing(System.Nullable<double> value);
    partial void OnTaxes____Changed();
    partial void OnTotal_Price____Changing(System.Nullable<double> value);
    partial void OnTotal_Price____Changed();
    #endregion
		
		public Table()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Order Number]", Storage="_Order_Number", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Order_Number
		{
			get
			{
				return this._Order_Number;
			}
			set
			{
				if ((this._Order_Number != value))
				{
					this.OnOrder_NumberChanging(value);
					this.SendPropertyChanging();
					this._Order_Number = value;
					this.SendPropertyChanged("Order_Number");
					this.OnOrder_NumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Product Name]", Storage="_Product_Name", DbType="NVarChar(MAX)")]
		public string Product_Name
		{
			get
			{
				return this._Product_Name;
			}
			set
			{
				if ((this._Product_Name != value))
				{
					this.OnProduct_NameChanging(value);
					this.SendPropertyChanging();
					this._Product_Name = value;
					this.SendPropertyChanged("Product_Name");
					this.OnProduct_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(MAX)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Units (Kilogram)]", Storage="_Units__Kilogram_", DbType="Int")]
		public System.Nullable<int> Units__Kilogram_
		{
			get
			{
				return this._Units__Kilogram_;
			}
			set
			{
				if ((this._Units__Kilogram_ != value))
				{
					this.OnUnits__Kilogram_Changing(value);
					this.SendPropertyChanging();
					this._Units__Kilogram_ = value;
					this.SendPropertyChanged("Units__Kilogram_");
					this.OnUnits__Kilogram_Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Price ($) ]", Storage="_Price_____", DbType="Float")]
		public System.Nullable<double> Price_____
		{
			get
			{
				return this._Price_____;
			}
			set
			{
				if ((this._Price_____ != value))
				{
					this.OnPrice_____Changing(value);
					this.SendPropertyChanging();
					this._Price_____ = value;
					this.SendPropertyChanged("Price_____");
					this.OnPrice_____Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Taxes (%)]", Storage="_Taxes____", DbType="Float")]
		public System.Nullable<double> Taxes____
		{
			get
			{
				return this._Taxes____;
			}
			set
			{
				if ((this._Taxes____ != value))
				{
					this.OnTaxes____Changing(value);
					this.SendPropertyChanging();
					this._Taxes____ = value;
					this.SendPropertyChanged("Taxes____");
					this.OnTaxes____Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Total Price ($)]", Storage="_Total_Price____", DbType="Float")]
		public System.Nullable<double> Total_Price____
		{
			get
			{
				return this._Total_Price____;
			}
			set
			{
				if ((this._Total_Price____ != value))
				{
					this.OnTotal_Price____Changing(value);
					this.SendPropertyChanging();
					this._Total_Price____ = value;
					this.SendPropertyChanged("Total_Price____");
					this.OnTotal_Price____Changed();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
