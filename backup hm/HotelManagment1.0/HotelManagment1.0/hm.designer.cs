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

namespace HotelManagment1._0
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="HM")]
	public partial class hmDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertReservationRoom(ReservationRoom instance);
    partial void UpdateReservationRoom(ReservationRoom instance);
    partial void DeleteReservationRoom(ReservationRoom instance);
    partial void InsertReservedRoom(ReservedRoom instance);
    partial void UpdateReservedRoom(ReservedRoom instance);
    partial void DeleteReservedRoom(ReservedRoom instance);
    partial void InsertRoom(Room instance);
    partial void UpdateRoom(Room instance);
    partial void DeleteRoom(Room instance);
    #endregion
		
		public hmDataContext() : 
				base(global::HotelManagment1._0.Properties.Settings.Default.HMConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public hmDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public hmDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public hmDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public hmDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ReservationRoom> ReservationRooms
		{
			get
			{
				return this.GetTable<ReservationRoom>();
			}
		}
		
		public System.Data.Linq.Table<ReservedRoom> ReservedRooms
		{
			get
			{
				return this.GetTable<ReservedRoom>();
			}
		}
		
		public System.Data.Linq.Table<Room> Rooms
		{
			get
			{
				return this.GetTable<Room>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ReservationRoom")]
	public partial class ReservationRoom : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _res_id;
		
		private string _guest_name;
		
		private string _guest_contact;
		
		private string _guest_address;
		
		private string _date_in;
		
		private string _date_out;
		
		private string _madeBy;
		
		private string _booking_date;
		
		private string _single;
		
		private string _double;
		
		private string _deluxe;
		
		private EntitySet<ReservedRoom> _ReservedRooms;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onres_idChanging(int value);
    partial void Onres_idChanged();
    partial void Onguest_nameChanging(string value);
    partial void Onguest_nameChanged();
    partial void Onguest_contactChanging(string value);
    partial void Onguest_contactChanged();
    partial void Onguest_addressChanging(string value);
    partial void Onguest_addressChanged();
    partial void Ondate_inChanging(string value);
    partial void Ondate_inChanged();
    partial void Ondate_outChanging(string value);
    partial void Ondate_outChanged();
    partial void OnmadeByChanging(string value);
    partial void OnmadeByChanged();
    partial void Onbooking_dateChanging(string value);
    partial void Onbooking_dateChanged();
    partial void OnsingleChanging(string value);
    partial void OnsingleChanged();
    partial void OndoubleChanging(string value);
    partial void OndoubleChanged();
    partial void OndeluxeChanging(string value);
    partial void OndeluxeChanged();
    #endregion
		
		public ReservationRoom()
		{
			this._ReservedRooms = new EntitySet<ReservedRoom>(new Action<ReservedRoom>(this.attach_ReservedRooms), new Action<ReservedRoom>(this.detach_ReservedRooms));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_res_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int res_id
		{
			get
			{
				return this._res_id;
			}
			set
			{
				if ((this._res_id != value))
				{
					this.Onres_idChanging(value);
					this.SendPropertyChanging();
					this._res_id = value;
					this.SendPropertyChanged("res_id");
					this.Onres_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_guest_name", DbType="NVarChar(50)")]
		public string guest_name
		{
			get
			{
				return this._guest_name;
			}
			set
			{
				if ((this._guest_name != value))
				{
					this.Onguest_nameChanging(value);
					this.SendPropertyChanging();
					this._guest_name = value;
					this.SendPropertyChanged("guest_name");
					this.Onguest_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_guest_contact", DbType="NVarChar(MAX)")]
		public string guest_contact
		{
			get
			{
				return this._guest_contact;
			}
			set
			{
				if ((this._guest_contact != value))
				{
					this.Onguest_contactChanging(value);
					this.SendPropertyChanging();
					this._guest_contact = value;
					this.SendPropertyChanged("guest_contact");
					this.Onguest_contactChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_guest_address", DbType="NVarChar(MAX)")]
		public string guest_address
		{
			get
			{
				return this._guest_address;
			}
			set
			{
				if ((this._guest_address != value))
				{
					this.Onguest_addressChanging(value);
					this.SendPropertyChanging();
					this._guest_address = value;
					this.SendPropertyChanged("guest_address");
					this.Onguest_addressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date_in", DbType="NVarChar(MAX)")]
		public string date_in
		{
			get
			{
				return this._date_in;
			}
			set
			{
				if ((this._date_in != value))
				{
					this.Ondate_inChanging(value);
					this.SendPropertyChanging();
					this._date_in = value;
					this.SendPropertyChanged("date_in");
					this.Ondate_inChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date_out", DbType="NVarChar(MAX)")]
		public string date_out
		{
			get
			{
				return this._date_out;
			}
			set
			{
				if ((this._date_out != value))
				{
					this.Ondate_outChanging(value);
					this.SendPropertyChanging();
					this._date_out = value;
					this.SendPropertyChanged("date_out");
					this.Ondate_outChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_madeBy", DbType="NVarChar(MAX)")]
		public string madeBy
		{
			get
			{
				return this._madeBy;
			}
			set
			{
				if ((this._madeBy != value))
				{
					this.OnmadeByChanging(value);
					this.SendPropertyChanging();
					this._madeBy = value;
					this.SendPropertyChanged("madeBy");
					this.OnmadeByChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_booking_date", DbType="NVarChar(50)")]
		public string booking_date
		{
			get
			{
				return this._booking_date;
			}
			set
			{
				if ((this._booking_date != value))
				{
					this.Onbooking_dateChanging(value);
					this.SendPropertyChanging();
					this._booking_date = value;
					this.SendPropertyChanged("booking_date");
					this.Onbooking_dateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_single", DbType="NChar(10)")]
		public string single
		{
			get
			{
				return this._single;
			}
			set
			{
				if ((this._single != value))
				{
					this.OnsingleChanging(value);
					this.SendPropertyChanging();
					this._single = value;
					this.SendPropertyChanged("single");
					this.OnsingleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[double]", Storage="_double", DbType="NChar(10)")]
		public string @double
		{
			get
			{
				return this._double;
			}
			set
			{
				if ((this._double != value))
				{
					this.OndoubleChanging(value);
					this.SendPropertyChanging();
					this._double = value;
					this.SendPropertyChanged("@double");
					this.OndoubleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_deluxe", DbType="NChar(10)")]
		public string deluxe
		{
			get
			{
				return this._deluxe;
			}
			set
			{
				if ((this._deluxe != value))
				{
					this.OndeluxeChanging(value);
					this.SendPropertyChanging();
					this._deluxe = value;
					this.SendPropertyChanged("deluxe");
					this.OndeluxeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ReservationRoom_ReservedRoom", Storage="_ReservedRooms", ThisKey="res_id", OtherKey="res_id")]
		public EntitySet<ReservedRoom> ReservedRooms
		{
			get
			{
				return this._ReservedRooms;
			}
			set
			{
				this._ReservedRooms.Assign(value);
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
		
		private void attach_ReservedRooms(ReservedRoom entity)
		{
			this.SendPropertyChanging();
			entity.ReservationRoom = this;
		}
		
		private void detach_ReservedRooms(ReservedRoom entity)
		{
			this.SendPropertyChanging();
			entity.ReservationRoom = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ReservedRoom")]
	public partial class ReservedRoom : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _res_room_id;
		
		private System.Nullable<int> _res_id;
		
		private string _type;
		
		private string _quantity;
		
		private EntityRef<ReservationRoom> _ReservationRoom;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onres_room_idChanging(int value);
    partial void Onres_room_idChanged();
    partial void Onres_idChanging(System.Nullable<int> value);
    partial void Onres_idChanged();
    partial void OntypeChanging(string value);
    partial void OntypeChanged();
    partial void OnquantityChanging(string value);
    partial void OnquantityChanged();
    #endregion
		
		public ReservedRoom()
		{
			this._ReservationRoom = default(EntityRef<ReservationRoom>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_res_room_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int res_room_id
		{
			get
			{
				return this._res_room_id;
			}
			set
			{
				if ((this._res_room_id != value))
				{
					this.Onres_room_idChanging(value);
					this.SendPropertyChanging();
					this._res_room_id = value;
					this.SendPropertyChanged("res_room_id");
					this.Onres_room_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_res_id", DbType="Int")]
		public System.Nullable<int> res_id
		{
			get
			{
				return this._res_id;
			}
			set
			{
				if ((this._res_id != value))
				{
					if (this._ReservationRoom.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onres_idChanging(value);
					this.SendPropertyChanging();
					this._res_id = value;
					this.SendPropertyChanged("res_id");
					this.Onres_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_type", DbType="NChar(10)")]
		public string type
		{
			get
			{
				return this._type;
			}
			set
			{
				if ((this._type != value))
				{
					this.OntypeChanging(value);
					this.SendPropertyChanging();
					this._type = value;
					this.SendPropertyChanged("type");
					this.OntypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_quantity", DbType="NChar(10)")]
		public string quantity
		{
			get
			{
				return this._quantity;
			}
			set
			{
				if ((this._quantity != value))
				{
					this.OnquantityChanging(value);
					this.SendPropertyChanging();
					this._quantity = value;
					this.SendPropertyChanged("quantity");
					this.OnquantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ReservationRoom_ReservedRoom", Storage="_ReservationRoom", ThisKey="res_id", OtherKey="res_id", IsForeignKey=true)]
		public ReservationRoom ReservationRoom
		{
			get
			{
				return this._ReservationRoom.Entity;
			}
			set
			{
				ReservationRoom previousValue = this._ReservationRoom.Entity;
				if (((previousValue != value) 
							|| (this._ReservationRoom.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ReservationRoom.Entity = null;
						previousValue.ReservedRooms.Remove(this);
					}
					this._ReservationRoom.Entity = value;
					if ((value != null))
					{
						value.ReservedRooms.Add(this);
						this._res_id = value.res_id;
					}
					else
					{
						this._res_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("ReservationRoom");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Room")]
	public partial class Room : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _room_no;
		
		private string _status;
		
		private string _room_type;
		
		private string _price;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void Onroom_noChanging(string value);
    partial void Onroom_noChanged();
    partial void OnstatusChanging(string value);
    partial void OnstatusChanged();
    partial void Onroom_typeChanging(string value);
    partial void Onroom_typeChanged();
    partial void OnpriceChanging(string value);
    partial void OnpriceChanged();
    #endregion
		
		public Room()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_room_no", DbType="NChar(10)")]
		public string room_no
		{
			get
			{
				return this._room_no;
			}
			set
			{
				if ((this._room_no != value))
				{
					this.Onroom_noChanging(value);
					this.SendPropertyChanging();
					this._room_no = value;
					this.SendPropertyChanged("room_no");
					this.Onroom_noChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="NChar(10)")]
		public string status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_room_type", DbType="NChar(10)")]
		public string room_type
		{
			get
			{
				return this._room_type;
			}
			set
			{
				if ((this._room_type != value))
				{
					this.Onroom_typeChanging(value);
					this.SendPropertyChanging();
					this._room_type = value;
					this.SendPropertyChanged("room_type");
					this.Onroom_typeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="NChar(10)")]
		public string price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
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