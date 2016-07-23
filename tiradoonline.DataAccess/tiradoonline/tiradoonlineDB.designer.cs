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

namespace tiradoonline.DataAccess.tiradoonline
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="tiradoonline")]
	public partial class tiradoonlineDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCountry(Country instance);
    partial void UpdateCountry(Country instance);
    partial void DeleteCountry(Country instance);
    partial void InsertLanguage(Language instance);
    partial void UpdateLanguage(Language instance);
    partial void DeleteLanguage(Language instance);
    partial void InsertState(State instance);
    partial void UpdateState(State instance);
    partial void DeleteState(State instance);
    partial void InsertZipCode(ZipCode instance);
    partial void UpdateZipCode(ZipCode instance);
    partial void DeleteZipCode(ZipCode instance);
    #endregion
		
		public tiradoonlineDBDataContext() : 
				base(global::tiradoonline.DataAccess.Properties.Settings.Default.tiradoonlineConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public tiradoonlineDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public tiradoonlineDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public tiradoonlineDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public tiradoonlineDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Country> Countries
		{
			get
			{
				return this.GetTable<Country>();
			}
		}
		
		public System.Data.Linq.Table<Language> Languages
		{
			get
			{
				return this.GetTable<Language>();
			}
		}
		
		public System.Data.Linq.Table<State> States
		{
			get
			{
				return this.GetTable<State>();
			}
		}
		
		public System.Data.Linq.Table<ZipCode> ZipCodes
		{
			get
			{
				return this.GetTable<ZipCode>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_Countries_get")]
		public ISingleResult<sp_Countries_getResult> sp_Countries_get()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<sp_Countries_getResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_States_get")]
		public ISingleResult<sp_States_getResult> sp_States_get()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<sp_States_getResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_Languages_get")]
		public ISingleResult<sp_Languages_getResult> sp_Languages_get()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<sp_Languages_getResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_ZipCode_City_State_ZipCode_get")]
		public ISingleResult<sp_ZipCode_City_State_ZipCode_getResult> sp_ZipCode_City_State_ZipCode_get([global::System.Data.Linq.Mapping.ParameterAttribute(Name="City", DbType="VarChar(50)")] string city, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="State", DbType="VarChar(50)")] string state, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ZipCode", DbType="VarChar(20)")] string zipCode)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), city, state, zipCode);
			return ((ISingleResult<sp_ZipCode_City_State_ZipCode_getResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_ZipCode_ZipCode_get")]
		public ISingleResult<sp_ZipCode_ZipCode_getResult> sp_ZipCode_ZipCode_get([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ZipCode", DbType="VarChar(20)")] string zipCode)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), zipCode);
			return ((ISingleResult<sp_ZipCode_ZipCode_getResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_ZipCode_State_get")]
		public ISingleResult<sp_ZipCode_State_getResult> sp_ZipCode_State_get([global::System.Data.Linq.Mapping.ParameterAttribute(Name="State", DbType="VarChar(50)")] string state)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), state);
			return ((ISingleResult<sp_ZipCode_State_getResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Countries")]
	public partial class Country : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CountryID;
		
		private string _CountryAbbr;
		
		private string _CountryName;
		
		private System.DateTime _create_dt;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCountryIDChanging(int value);
    partial void OnCountryIDChanged();
    partial void OnCountryAbbrChanging(string value);
    partial void OnCountryAbbrChanged();
    partial void OnCountryNameChanging(string value);
    partial void OnCountryNameChanged();
    partial void Oncreate_dtChanging(System.DateTime value);
    partial void Oncreate_dtChanged();
    #endregion
		
		public Country()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CountryID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CountryID
		{
			get
			{
				return this._CountryID;
			}
			set
			{
				if ((this._CountryID != value))
				{
					this.OnCountryIDChanging(value);
					this.SendPropertyChanging();
					this._CountryID = value;
					this.SendPropertyChanged("CountryID");
					this.OnCountryIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CountryAbbr", DbType="VarChar(2) NOT NULL", CanBeNull=false)]
		public string CountryAbbr
		{
			get
			{
				return this._CountryAbbr;
			}
			set
			{
				if ((this._CountryAbbr != value))
				{
					this.OnCountryAbbrChanging(value);
					this.SendPropertyChanging();
					this._CountryAbbr = value;
					this.SendPropertyChanged("CountryAbbr");
					this.OnCountryAbbrChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CountryName", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string CountryName
		{
			get
			{
				return this._CountryName;
			}
			set
			{
				if ((this._CountryName != value))
				{
					this.OnCountryNameChanging(value);
					this.SendPropertyChanging();
					this._CountryName = value;
					this.SendPropertyChanged("CountryName");
					this.OnCountryNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_create_dt", DbType="DateTime NOT NULL")]
		public System.DateTime create_dt
		{
			get
			{
				return this._create_dt;
			}
			set
			{
				if ((this._create_dt != value))
				{
					this.Oncreate_dtChanging(value);
					this.SendPropertyChanging();
					this._create_dt = value;
					this.SendPropertyChanged("create_dt");
					this.Oncreate_dtChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Languages")]
	public partial class Language : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _LanguageID;
		
		private string _Language1;
		
		private System.DateTime _create_dt;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnLanguageIDChanging(int value);
    partial void OnLanguageIDChanged();
    partial void OnLanguage1Changing(string value);
    partial void OnLanguage1Changed();
    partial void Oncreate_dtChanging(System.DateTime value);
    partial void Oncreate_dtChanged();
    #endregion
		
		public Language()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LanguageID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int LanguageID
		{
			get
			{
				return this._LanguageID;
			}
			set
			{
				if ((this._LanguageID != value))
				{
					this.OnLanguageIDChanging(value);
					this.SendPropertyChanging();
					this._LanguageID = value;
					this.SendPropertyChanged("LanguageID");
					this.OnLanguageIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Language", Storage="_Language1", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Language1
		{
			get
			{
				return this._Language1;
			}
			set
			{
				if ((this._Language1 != value))
				{
					this.OnLanguage1Changing(value);
					this.SendPropertyChanging();
					this._Language1 = value;
					this.SendPropertyChanged("Language1");
					this.OnLanguage1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_create_dt", DbType="DateTime NOT NULL")]
		public System.DateTime create_dt
		{
			get
			{
				return this._create_dt;
			}
			set
			{
				if ((this._create_dt != value))
				{
					this.Oncreate_dtChanging(value);
					this.SendPropertyChanging();
					this._create_dt = value;
					this.SendPropertyChanged("create_dt");
					this.Oncreate_dtChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.States")]
	public partial class State : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _StateID;
		
		private string _State1;
		
		private string _StateAbbr;
		
		private EntitySet<ZipCode> _ZipCodes;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnStateIDChanging(int value);
    partial void OnStateIDChanged();
    partial void OnState1Changing(string value);
    partial void OnState1Changed();
    partial void OnStateAbbrChanging(string value);
    partial void OnStateAbbrChanged();
    #endregion
		
		public State()
		{
			this._ZipCodes = new EntitySet<ZipCode>(new Action<ZipCode>(this.attach_ZipCodes), new Action<ZipCode>(this.detach_ZipCodes));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StateID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int StateID
		{
			get
			{
				return this._StateID;
			}
			set
			{
				if ((this._StateID != value))
				{
					this.OnStateIDChanging(value);
					this.SendPropertyChanging();
					this._StateID = value;
					this.SendPropertyChanged("StateID");
					this.OnStateIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="State", Storage="_State1", DbType="VarChar(30)")]
		public string State1
		{
			get
			{
				return this._State1;
			}
			set
			{
				if ((this._State1 != value))
				{
					this.OnState1Changing(value);
					this.SendPropertyChanging();
					this._State1 = value;
					this.SendPropertyChanged("State1");
					this.OnState1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StateAbbr", DbType="VarChar(2)")]
		public string StateAbbr
		{
			get
			{
				return this._StateAbbr;
			}
			set
			{
				if ((this._StateAbbr != value))
				{
					this.OnStateAbbrChanging(value);
					this.SendPropertyChanging();
					this._StateAbbr = value;
					this.SendPropertyChanged("StateAbbr");
					this.OnStateAbbrChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="State_ZipCode", Storage="_ZipCodes", ThisKey="StateID", OtherKey="StateID")]
		public EntitySet<ZipCode> ZipCodes
		{
			get
			{
				return this._ZipCodes;
			}
			set
			{
				this._ZipCodes.Assign(value);
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
		
		private void attach_ZipCodes(ZipCode entity)
		{
			this.SendPropertyChanging();
			entity.State = this;
		}
		
		private void detach_ZipCodes(ZipCode entity)
		{
			this.SendPropertyChanging();
			entity.State = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ZipCode")]
	public partial class ZipCode : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ZipCodeID;
		
		private System.Nullable<double> _Zipcode1;
		
		private int _ZipCodeTypeID;
		
		private string _City;
		
		private int _StateID;
		
		private string _LocationType;
		
		private System.Nullable<double> _Lat;
		
		private System.Nullable<double> _Long;
		
		private string _Location;
		
		private bool _Decommisioned;
		
		private string _TaxReturnsFiled;
		
		private string _EstimatedPopulation;
		
		private string _TotalWages;
		
		private EntityRef<State> _State;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnZipCodeIDChanging(int value);
    partial void OnZipCodeIDChanged();
    partial void OnZipcode1Changing(System.Nullable<double> value);
    partial void OnZipcode1Changed();
    partial void OnZipCodeTypeIDChanging(int value);
    partial void OnZipCodeTypeIDChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnStateIDChanging(int value);
    partial void OnStateIDChanged();
    partial void OnLocationTypeChanging(string value);
    partial void OnLocationTypeChanged();
    partial void OnLatChanging(System.Nullable<double> value);
    partial void OnLatChanged();
    partial void OnLongChanging(System.Nullable<double> value);
    partial void OnLongChanged();
    partial void OnLocationChanging(string value);
    partial void OnLocationChanged();
    partial void OnDecommisionedChanging(bool value);
    partial void OnDecommisionedChanged();
    partial void OnTaxReturnsFiledChanging(string value);
    partial void OnTaxReturnsFiledChanged();
    partial void OnEstimatedPopulationChanging(string value);
    partial void OnEstimatedPopulationChanged();
    partial void OnTotalWagesChanging(string value);
    partial void OnTotalWagesChanged();
    #endregion
		
		public ZipCode()
		{
			this._State = default(EntityRef<State>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ZipCodeID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ZipCodeID
		{
			get
			{
				return this._ZipCodeID;
			}
			set
			{
				if ((this._ZipCodeID != value))
				{
					this.OnZipCodeIDChanging(value);
					this.SendPropertyChanging();
					this._ZipCodeID = value;
					this.SendPropertyChanged("ZipCodeID");
					this.OnZipCodeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Zipcode", Storage="_Zipcode1", DbType="Float")]
		public System.Nullable<double> Zipcode1
		{
			get
			{
				return this._Zipcode1;
			}
			set
			{
				if ((this._Zipcode1 != value))
				{
					this.OnZipcode1Changing(value);
					this.SendPropertyChanging();
					this._Zipcode1 = value;
					this.SendPropertyChanged("Zipcode1");
					this.OnZipcode1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ZipCodeTypeID", DbType="Int NOT NULL")]
		public int ZipCodeTypeID
		{
			get
			{
				return this._ZipCodeTypeID;
			}
			set
			{
				if ((this._ZipCodeTypeID != value))
				{
					this.OnZipCodeTypeIDChanging(value);
					this.SendPropertyChanging();
					this._ZipCodeTypeID = value;
					this.SendPropertyChanged("ZipCodeTypeID");
					this.OnZipCodeTypeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StateID", DbType="Int NOT NULL")]
		public int StateID
		{
			get
			{
				return this._StateID;
			}
			set
			{
				if ((this._StateID != value))
				{
					if (this._State.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnStateIDChanging(value);
					this.SendPropertyChanging();
					this._StateID = value;
					this.SendPropertyChanged("StateID");
					this.OnStateIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LocationType", DbType="NVarChar(255)")]
		public string LocationType
		{
			get
			{
				return this._LocationType;
			}
			set
			{
				if ((this._LocationType != value))
				{
					this.OnLocationTypeChanging(value);
					this.SendPropertyChanging();
					this._LocationType = value;
					this.SendPropertyChanged("LocationType");
					this.OnLocationTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Lat", DbType="Float")]
		public System.Nullable<double> Lat
		{
			get
			{
				return this._Lat;
			}
			set
			{
				if ((this._Lat != value))
				{
					this.OnLatChanging(value);
					this.SendPropertyChanging();
					this._Lat = value;
					this.SendPropertyChanged("Lat");
					this.OnLatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Long", DbType="Float")]
		public System.Nullable<double> Long
		{
			get
			{
				return this._Long;
			}
			set
			{
				if ((this._Long != value))
				{
					this.OnLongChanging(value);
					this.SendPropertyChanging();
					this._Long = value;
					this.SendPropertyChanged("Long");
					this.OnLongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Location", DbType="NVarChar(255)")]
		public string Location
		{
			get
			{
				return this._Location;
			}
			set
			{
				if ((this._Location != value))
				{
					this.OnLocationChanging(value);
					this.SendPropertyChanging();
					this._Location = value;
					this.SendPropertyChanged("Location");
					this.OnLocationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Decommisioned", DbType="Bit NOT NULL")]
		public bool Decommisioned
		{
			get
			{
				return this._Decommisioned;
			}
			set
			{
				if ((this._Decommisioned != value))
				{
					this.OnDecommisionedChanging(value);
					this.SendPropertyChanging();
					this._Decommisioned = value;
					this.SendPropertyChanged("Decommisioned");
					this.OnDecommisionedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaxReturnsFiled", DbType="NVarChar(255)")]
		public string TaxReturnsFiled
		{
			get
			{
				return this._TaxReturnsFiled;
			}
			set
			{
				if ((this._TaxReturnsFiled != value))
				{
					this.OnTaxReturnsFiledChanging(value);
					this.SendPropertyChanging();
					this._TaxReturnsFiled = value;
					this.SendPropertyChanged("TaxReturnsFiled");
					this.OnTaxReturnsFiledChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EstimatedPopulation", DbType="NVarChar(255)")]
		public string EstimatedPopulation
		{
			get
			{
				return this._EstimatedPopulation;
			}
			set
			{
				if ((this._EstimatedPopulation != value))
				{
					this.OnEstimatedPopulationChanging(value);
					this.SendPropertyChanging();
					this._EstimatedPopulation = value;
					this.SendPropertyChanged("EstimatedPopulation");
					this.OnEstimatedPopulationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalWages", DbType="NVarChar(255)")]
		public string TotalWages
		{
			get
			{
				return this._TotalWages;
			}
			set
			{
				if ((this._TotalWages != value))
				{
					this.OnTotalWagesChanging(value);
					this.SendPropertyChanging();
					this._TotalWages = value;
					this.SendPropertyChanged("TotalWages");
					this.OnTotalWagesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="State_ZipCode", Storage="_State", ThisKey="StateID", OtherKey="StateID", IsForeignKey=true)]
		public State State
		{
			get
			{
				return this._State.Entity;
			}
			set
			{
				State previousValue = this._State.Entity;
				if (((previousValue != value) 
							|| (this._State.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._State.Entity = null;
						previousValue.ZipCodes.Remove(this);
					}
					this._State.Entity = value;
					if ((value != null))
					{
						value.ZipCodes.Add(this);
						this._StateID = value.StateID;
					}
					else
					{
						this._StateID = default(int);
					}
					this.SendPropertyChanged("State");
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
	
	public partial class sp_Countries_getResult
	{
		
		private int _CountryID;
		
		private string _CountryAbbr;
		
		private string _Country;
		
		public sp_Countries_getResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CountryID", DbType="Int NOT NULL")]
		public int CountryID
		{
			get
			{
				return this._CountryID;
			}
			set
			{
				if ((this._CountryID != value))
				{
					this._CountryID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CountryAbbr", DbType="VarChar(2) NOT NULL", CanBeNull=false)]
		public string CountryAbbr
		{
			get
			{
				return this._CountryAbbr;
			}
			set
			{
				if ((this._CountryAbbr != value))
				{
					this._CountryAbbr = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Country", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Country
		{
			get
			{
				return this._Country;
			}
			set
			{
				if ((this._Country != value))
				{
					this._Country = value;
				}
			}
		}
	}
	
	public partial class sp_States_getResult
	{
		
		private int _StateID;
		
		private string _StateAbbr;
		
		private string _State;
		
		public sp_States_getResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StateID", DbType="Int NOT NULL")]
		public int StateID
		{
			get
			{
				return this._StateID;
			}
			set
			{
				if ((this._StateID != value))
				{
					this._StateID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StateAbbr", DbType="VarChar(2)")]
		public string StateAbbr
		{
			get
			{
				return this._StateAbbr;
			}
			set
			{
				if ((this._StateAbbr != value))
				{
					this._StateAbbr = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State", DbType="VarChar(30)")]
		public string State
		{
			get
			{
				return this._State;
			}
			set
			{
				if ((this._State != value))
				{
					this._State = value;
				}
			}
		}
	}
	
	public partial class sp_Languages_getResult
	{
		
		private int _LanguageID;
		
		private string _Language;
		
		public sp_Languages_getResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LanguageID", DbType="Int NOT NULL")]
		public int LanguageID
		{
			get
			{
				return this._LanguageID;
			}
			set
			{
				if ((this._LanguageID != value))
				{
					this._LanguageID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Language", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Language
		{
			get
			{
				return this._Language;
			}
			set
			{
				if ((this._Language != value))
				{
					this._Language = value;
				}
			}
		}
	}
	
	public partial class sp_ZipCode_City_State_ZipCode_getResult
	{
		
		private int _ZipCodeID;
		
		private System.Nullable<double> _Zipcode;
		
		private int _ZipCodeTypeID;
		
		private string _City;
		
		private int _StateID;
		
		private string _LocationType;
		
		private System.Nullable<double> _Lat;
		
		private System.Nullable<double> _Long;
		
		private string _Location;
		
		private bool _Decommisioned;
		
		private string _TaxReturnsFiled;
		
		private string _EstimatedPopulation;
		
		private string _TotalWages;
		
		private string _State;
		
		public sp_ZipCode_City_State_ZipCode_getResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ZipCodeID", DbType="Int NOT NULL")]
		public int ZipCodeID
		{
			get
			{
				return this._ZipCodeID;
			}
			set
			{
				if ((this._ZipCodeID != value))
				{
					this._ZipCodeID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Zipcode", DbType="Float")]
		public System.Nullable<double> Zipcode
		{
			get
			{
				return this._Zipcode;
			}
			set
			{
				if ((this._Zipcode != value))
				{
					this._Zipcode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ZipCodeTypeID", DbType="Int NOT NULL")]
		public int ZipCodeTypeID
		{
			get
			{
				return this._ZipCodeTypeID;
			}
			set
			{
				if ((this._ZipCodeTypeID != value))
				{
					this._ZipCodeTypeID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this._City = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StateID", DbType="Int NOT NULL")]
		public int StateID
		{
			get
			{
				return this._StateID;
			}
			set
			{
				if ((this._StateID != value))
				{
					this._StateID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LocationType", DbType="NVarChar(255)")]
		public string LocationType
		{
			get
			{
				return this._LocationType;
			}
			set
			{
				if ((this._LocationType != value))
				{
					this._LocationType = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Lat", DbType="Float")]
		public System.Nullable<double> Lat
		{
			get
			{
				return this._Lat;
			}
			set
			{
				if ((this._Lat != value))
				{
					this._Lat = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Long", DbType="Float")]
		public System.Nullable<double> Long
		{
			get
			{
				return this._Long;
			}
			set
			{
				if ((this._Long != value))
				{
					this._Long = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Location", DbType="NVarChar(255)")]
		public string Location
		{
			get
			{
				return this._Location;
			}
			set
			{
				if ((this._Location != value))
				{
					this._Location = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Decommisioned", DbType="Bit NOT NULL")]
		public bool Decommisioned
		{
			get
			{
				return this._Decommisioned;
			}
			set
			{
				if ((this._Decommisioned != value))
				{
					this._Decommisioned = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaxReturnsFiled", DbType="NVarChar(255)")]
		public string TaxReturnsFiled
		{
			get
			{
				return this._TaxReturnsFiled;
			}
			set
			{
				if ((this._TaxReturnsFiled != value))
				{
					this._TaxReturnsFiled = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EstimatedPopulation", DbType="NVarChar(255)")]
		public string EstimatedPopulation
		{
			get
			{
				return this._EstimatedPopulation;
			}
			set
			{
				if ((this._EstimatedPopulation != value))
				{
					this._EstimatedPopulation = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalWages", DbType="NVarChar(255)")]
		public string TotalWages
		{
			get
			{
				return this._TotalWages;
			}
			set
			{
				if ((this._TotalWages != value))
				{
					this._TotalWages = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State", DbType="VarChar(30)")]
		public string State
		{
			get
			{
				return this._State;
			}
			set
			{
				if ((this._State != value))
				{
					this._State = value;
				}
			}
		}
	}
	
	public partial class sp_ZipCode_ZipCode_getResult
	{
		
		private string _City;
		
		private string _Zipcode;
		
		private string _State;
		
		private System.Nullable<decimal> _TaxRate;
		
		public sp_ZipCode_ZipCode_getResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this._City = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Zipcode", DbType="VarChar(8000)")]
		public string Zipcode
		{
			get
			{
				return this._Zipcode;
			}
			set
			{
				if ((this._Zipcode != value))
				{
					this._Zipcode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State", DbType="VarChar(30)")]
		public string State
		{
			get
			{
				return this._State;
			}
			set
			{
				if ((this._State != value))
				{
					this._State = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaxRate", DbType="Decimal(9,5)")]
		public System.Nullable<decimal> TaxRate
		{
			get
			{
				return this._TaxRate;
			}
			set
			{
				if ((this._TaxRate != value))
				{
					this._TaxRate = value;
				}
			}
		}
	}
	
	public partial class sp_ZipCode_State_getResult
	{
		
		private int _ZipCodeID;
		
		private System.Nullable<double> _Zipcode;
		
		private int _ZipCodeTypeID;
		
		private string _City;
		
		private int _StateID;
		
		private string _LocationType;
		
		private System.Nullable<double> _Lat;
		
		private System.Nullable<double> _Long;
		
		private string _Location;
		
		private bool _Decommisioned;
		
		private string _TaxReturnsFiled;
		
		private string _EstimatedPopulation;
		
		private string _TotalWages;
		
		private int _StateID1;
		
		private string _State;
		
		private string _StateAbbr;
		
		public sp_ZipCode_State_getResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ZipCodeID", DbType="Int NOT NULL")]
		public int ZipCodeID
		{
			get
			{
				return this._ZipCodeID;
			}
			set
			{
				if ((this._ZipCodeID != value))
				{
					this._ZipCodeID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Zipcode", DbType="Float")]
		public System.Nullable<double> Zipcode
		{
			get
			{
				return this._Zipcode;
			}
			set
			{
				if ((this._Zipcode != value))
				{
					this._Zipcode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ZipCodeTypeID", DbType="Int NOT NULL")]
		public int ZipCodeTypeID
		{
			get
			{
				return this._ZipCodeTypeID;
			}
			set
			{
				if ((this._ZipCodeTypeID != value))
				{
					this._ZipCodeTypeID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this._City = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StateID", DbType="Int NOT NULL")]
		public int StateID
		{
			get
			{
				return this._StateID;
			}
			set
			{
				if ((this._StateID != value))
				{
					this._StateID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LocationType", DbType="NVarChar(255)")]
		public string LocationType
		{
			get
			{
				return this._LocationType;
			}
			set
			{
				if ((this._LocationType != value))
				{
					this._LocationType = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Lat", DbType="Float")]
		public System.Nullable<double> Lat
		{
			get
			{
				return this._Lat;
			}
			set
			{
				if ((this._Lat != value))
				{
					this._Lat = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Long", DbType="Float")]
		public System.Nullable<double> Long
		{
			get
			{
				return this._Long;
			}
			set
			{
				if ((this._Long != value))
				{
					this._Long = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Location", DbType="NVarChar(255)")]
		public string Location
		{
			get
			{
				return this._Location;
			}
			set
			{
				if ((this._Location != value))
				{
					this._Location = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Decommisioned", DbType="Bit NOT NULL")]
		public bool Decommisioned
		{
			get
			{
				return this._Decommisioned;
			}
			set
			{
				if ((this._Decommisioned != value))
				{
					this._Decommisioned = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaxReturnsFiled", DbType="NVarChar(255)")]
		public string TaxReturnsFiled
		{
			get
			{
				return this._TaxReturnsFiled;
			}
			set
			{
				if ((this._TaxReturnsFiled != value))
				{
					this._TaxReturnsFiled = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EstimatedPopulation", DbType="NVarChar(255)")]
		public string EstimatedPopulation
		{
			get
			{
				return this._EstimatedPopulation;
			}
			set
			{
				if ((this._EstimatedPopulation != value))
				{
					this._EstimatedPopulation = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalWages", DbType="NVarChar(255)")]
		public string TotalWages
		{
			get
			{
				return this._TotalWages;
			}
			set
			{
				if ((this._TotalWages != value))
				{
					this._TotalWages = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StateID1", DbType="Int NOT NULL")]
		public int StateID1
		{
			get
			{
				return this._StateID1;
			}
			set
			{
				if ((this._StateID1 != value))
				{
					this._StateID1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State", DbType="VarChar(30)")]
		public string State
		{
			get
			{
				return this._State;
			}
			set
			{
				if ((this._State != value))
				{
					this._State = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StateAbbr", DbType="VarChar(2)")]
		public string StateAbbr
		{
			get
			{
				return this._StateAbbr;
			}
			set
			{
				if ((this._StateAbbr != value))
				{
					this._StateAbbr = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
