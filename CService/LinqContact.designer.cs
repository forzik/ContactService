﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.18408
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CService
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Employees")]
	public partial class LinqContactDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Определения метода расширяемости
    partial void OnCreated();
    partial void InsertContacts(Contacts instance);
    partial void UpdateContacts(Contacts instance);
    partial void DeleteContacts(Contacts instance);
    partial void InsertTelephones(Telephones instance);
    partial void UpdateTelephones(Telephones instance);
    partial void DeleteTelephones(Telephones instance);
    #endregion
		
		public LinqContactDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["EmployeesConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LinqContactDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqContactDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqContactDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqContactDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Contacts> Contacts
		{
			get
			{
				return this.GetTable<Contacts>();
			}
		}
		
		public System.Data.Linq.Table<Telephones> Telephones
		{
			get
			{
				return this.GetTable<Telephones>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Contacts")]
	public partial class Contacts : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ContactID;
		
		private string _ContactFirstName;
		
		private string _ContactLastName;
		
		private string _ContactPatronymic;
		
		private System.Nullable<int> _ContactTelephoneID;
		
		private string _ContactAdress;
		
		private EntityRef<Telephones> _Telephones;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnContactIDChanging(int value);
    partial void OnContactIDChanged();
    partial void OnContactFirstNameChanging(string value);
    partial void OnContactFirstNameChanged();
    partial void OnContactLastNameChanging(string value);
    partial void OnContactLastNameChanged();
    partial void OnContactPatronymicChanging(string value);
    partial void OnContactPatronymicChanged();
    partial void OnContactTelephoneIDChanging(System.Nullable<int> value);
    partial void OnContactTelephoneIDChanged();
    partial void OnContactAdressChanging(string value);
    partial void OnContactAdressChanged();
    #endregion
		
		public Contacts()
		{
			this._Telephones = default(EntityRef<Telephones>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ContactID
		{
			get
			{
				return this._ContactID;
			}
			set
			{
				if ((this._ContactID != value))
				{
					this.OnContactIDChanging(value);
					this.SendPropertyChanging();
					this._ContactID = value;
					this.SendPropertyChanged("ContactID");
					this.OnContactIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactFirstName", DbType="NVarChar(128) NOT NULL", CanBeNull=false)]
		public string ContactFirstName
		{
			get
			{
				return this._ContactFirstName;
			}
			set
			{
				if ((this._ContactFirstName != value))
				{
					this.OnContactFirstNameChanging(value);
					this.SendPropertyChanging();
					this._ContactFirstName = value;
					this.SendPropertyChanged("ContactFirstName");
					this.OnContactFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactLastName", DbType="NVarChar(128) NOT NULL", CanBeNull=false)]
		public string ContactLastName
		{
			get
			{
				return this._ContactLastName;
			}
			set
			{
				if ((this._ContactLastName != value))
				{
					this.OnContactLastNameChanging(value);
					this.SendPropertyChanging();
					this._ContactLastName = value;
					this.SendPropertyChanged("ContactLastName");
					this.OnContactLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactPatronymic", DbType="NVarChar(128) NOT NULL", CanBeNull=false)]
		public string ContactPatronymic
		{
			get
			{
				return this._ContactPatronymic;
			}
			set
			{
				if ((this._ContactPatronymic != value))
				{
					this.OnContactPatronymicChanging(value);
					this.SendPropertyChanging();
					this._ContactPatronymic = value;
					this.SendPropertyChanged("ContactPatronymic");
					this.OnContactPatronymicChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactTelephoneID", DbType="Int")]
		public System.Nullable<int> ContactTelephoneID
		{
			get
			{
				return this._ContactTelephoneID;
			}
			set
			{
				if ((this._ContactTelephoneID != value))
				{
					if (this._Telephones.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnContactTelephoneIDChanging(value);
					this.SendPropertyChanging();
					this._ContactTelephoneID = value;
					this.SendPropertyChanged("ContactTelephoneID");
					this.OnContactTelephoneIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactAdress", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string ContactAdress
		{
			get
			{
				return this._ContactAdress;
			}
			set
			{
				if ((this._ContactAdress != value))
				{
					this.OnContactAdressChanging(value);
					this.SendPropertyChanging();
					this._ContactAdress = value;
					this.SendPropertyChanged("ContactAdress");
					this.OnContactAdressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Telephones_Contacts", Storage="_Telephones", ThisKey="ContactTelephoneID", OtherKey="TelephoneID", IsForeignKey=true)]
		public Telephones Telephones
		{
			get
			{
				return this._Telephones.Entity;
			}
			set
			{
				Telephones previousValue = this._Telephones.Entity;
				if (((previousValue != value) 
							|| (this._Telephones.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Telephones.Entity = null;
						previousValue.Contacts.Remove(this);
					}
					this._Telephones.Entity = value;
					if ((value != null))
					{
						value.Contacts.Add(this);
						this._ContactTelephoneID = value.TelephoneID;
					}
					else
					{
						this._ContactTelephoneID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Telephones");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Telephones")]
	public partial class Telephones : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _TelephoneID;
		
		private string _TelephoneNumber;
		
		private EntitySet<Contacts> _Contacts;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTelephoneIDChanging(int value);
    partial void OnTelephoneIDChanged();
    partial void OnTelephoneNumberChanging(string value);
    partial void OnTelephoneNumberChanged();
    #endregion
		
		public Telephones()
		{
			this._Contacts = new EntitySet<Contacts>(new Action<Contacts>(this.attach_Contacts), new Action<Contacts>(this.detach_Contacts));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TelephoneID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int TelephoneID
		{
			get
			{
				return this._TelephoneID;
			}
			set
			{
				if ((this._TelephoneID != value))
				{
					this.OnTelephoneIDChanging(value);
					this.SendPropertyChanging();
					this._TelephoneID = value;
					this.SendPropertyChanged("TelephoneID");
					this.OnTelephoneIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TelephoneNumber", DbType="NVarChar(128) NOT NULL", CanBeNull=false)]
		public string TelephoneNumber
		{
			get
			{
				return this._TelephoneNumber;
			}
			set
			{
				if ((this._TelephoneNumber != value))
				{
					this.OnTelephoneNumberChanging(value);
					this.SendPropertyChanging();
					this._TelephoneNumber = value;
					this.SendPropertyChanged("TelephoneNumber");
					this.OnTelephoneNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Telephones_Contacts", Storage="_Contacts", ThisKey="TelephoneID", OtherKey="ContactTelephoneID")]
		public EntitySet<Contacts> Contacts
		{
			get
			{
				return this._Contacts;
			}
			set
			{
				this._Contacts.Assign(value);
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
		
		private void attach_Contacts(Contacts entity)
		{
			this.SendPropertyChanging();
			entity.Telephones = this;
		}
		
		private void detach_Contacts(Contacts entity)
		{
			this.SendPropertyChanging();
			entity.Telephones = null;
		}
	}
}
#pragma warning restore 1591