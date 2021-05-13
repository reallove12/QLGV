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

namespace DTO
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLGV")]
	public partial class QLGVDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertGiaoVien(GiaoVien instance);
    partial void UpdateGiaoVien(GiaoVien instance);
    partial void DeleteGiaoVien(GiaoVien instance);
    partial void InsertMonHoc(MonHoc instance);
    partial void UpdateMonHoc(MonHoc instance);
    partial void DeleteMonHoc(MonHoc instance);
    partial void InsertPhanCong(PhanCong instance);
    partial void UpdatePhanCong(PhanCong instance);
    partial void DeletePhanCong(PhanCong instance);
    partial void InsertTaiKhoan(TaiKhoan instance);
    partial void UpdateTaiKhoan(TaiKhoan instance);
    partial void DeleteTaiKhoan(TaiKhoan instance);
    #endregion
		
		public QLGVDataContext() : 
				base(global::DTO.Properties.Settings.Default.QLGVConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QLGVDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLGVDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLGVDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLGVDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<GiaoVien> GiaoViens
		{
			get
			{
				return this.GetTable<GiaoVien>();
			}
		}
		
		public System.Data.Linq.Table<MonHoc> MonHocs
		{
			get
			{
				return this.GetTable<MonHoc>();
			}
		}
		
		public System.Data.Linq.Table<PhanCong> PhanCongs
		{
			get
			{
				return this.GetTable<PhanCong>();
			}
		}
		
		public System.Data.Linq.Table<TaiKhoan> TaiKhoans
		{
			get
			{
				return this.GetTable<TaiKhoan>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.GiaoVien")]
	public partial class GiaoVien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MAGV;
		
		private string _TENGV;
		
		private System.Nullable<System.DateTime> _NGAYSINH;
		
		private string _DIACHI;
		
		private string _SDT;
		
		private EntitySet<PhanCong> _PhanCongs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMAGVChanging(int value);
    partial void OnMAGVChanged();
    partial void OnTENGVChanging(string value);
    partial void OnTENGVChanged();
    partial void OnNGAYSINHChanging(System.Nullable<System.DateTime> value);
    partial void OnNGAYSINHChanged();
    partial void OnDIACHIChanging(string value);
    partial void OnDIACHIChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    #endregion
		
		public GiaoVien()
		{
			this._PhanCongs = new EntitySet<PhanCong>(new Action<PhanCong>(this.attach_PhanCongs), new Action<PhanCong>(this.detach_PhanCongs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAGV", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MAGV
		{
			get
			{
				return this._MAGV;
			}
			set
			{
				if ((this._MAGV != value))
				{
					this.OnMAGVChanging(value);
					this.SendPropertyChanging();
					this._MAGV = value;
					this.SendPropertyChanged("MAGV");
					this.OnMAGVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENGV", DbType="NVarChar(150)")]
		public string TENGV
		{
			get
			{
				return this._TENGV;
			}
			set
			{
				if ((this._TENGV != value))
				{
					this.OnTENGVChanging(value);
					this.SendPropertyChanging();
					this._TENGV = value;
					this.SendPropertyChanged("TENGV");
					this.OnTENGVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAYSINH", DbType="DateTime")]
		public System.Nullable<System.DateTime> NGAYSINH
		{
			get
			{
				return this._NGAYSINH;
			}
			set
			{
				if ((this._NGAYSINH != value))
				{
					this.OnNGAYSINHChanging(value);
					this.SendPropertyChanging();
					this._NGAYSINH = value;
					this.SendPropertyChanged("NGAYSINH");
					this.OnNGAYSINHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIACHI", DbType="NVarChar(250)")]
		public string DIACHI
		{
			get
			{
				return this._DIACHI;
			}
			set
			{
				if ((this._DIACHI != value))
				{
					this.OnDIACHIChanging(value);
					this.SendPropertyChanging();
					this._DIACHI = value;
					this.SendPropertyChanged("DIACHI");
					this.OnDIACHIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="VarChar(10)")]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="GiaoVien_PhanCong", Storage="_PhanCongs", ThisKey="MAGV", OtherKey="MAGV")]
		public EntitySet<PhanCong> PhanCongs
		{
			get
			{
				return this._PhanCongs;
			}
			set
			{
				this._PhanCongs.Assign(value);
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
		
		private void attach_PhanCongs(PhanCong entity)
		{
			this.SendPropertyChanging();
			entity.GiaoVien = this;
		}
		
		private void detach_PhanCongs(PhanCong entity)
		{
			this.SendPropertyChanging();
			entity.GiaoVien = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MonHoc")]
	public partial class MonHoc : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MAMH;
		
		private string _TENMH;
		
		private System.Nullable<double> _SOTC;
		
		private EntitySet<PhanCong> _PhanCongs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMAMHChanging(int value);
    partial void OnMAMHChanged();
    partial void OnTENMHChanging(string value);
    partial void OnTENMHChanged();
    partial void OnSOTCChanging(System.Nullable<double> value);
    partial void OnSOTCChanged();
    #endregion
		
		public MonHoc()
		{
			this._PhanCongs = new EntitySet<PhanCong>(new Action<PhanCong>(this.attach_PhanCongs), new Action<PhanCong>(this.detach_PhanCongs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAMH", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MAMH
		{
			get
			{
				return this._MAMH;
			}
			set
			{
				if ((this._MAMH != value))
				{
					this.OnMAMHChanging(value);
					this.SendPropertyChanging();
					this._MAMH = value;
					this.SendPropertyChanged("MAMH");
					this.OnMAMHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENMH", DbType="NVarChar(150)")]
		public string TENMH
		{
			get
			{
				return this._TENMH;
			}
			set
			{
				if ((this._TENMH != value))
				{
					this.OnTENMHChanging(value);
					this.SendPropertyChanging();
					this._TENMH = value;
					this.SendPropertyChanged("TENMH");
					this.OnTENMHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SOTC", DbType="Float")]
		public System.Nullable<double> SOTC
		{
			get
			{
				return this._SOTC;
			}
			set
			{
				if ((this._SOTC != value))
				{
					this.OnSOTCChanging(value);
					this.SendPropertyChanging();
					this._SOTC = value;
					this.SendPropertyChanged("SOTC");
					this.OnSOTCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="MonHoc_PhanCong", Storage="_PhanCongs", ThisKey="MAMH", OtherKey="MAMH")]
		public EntitySet<PhanCong> PhanCongs
		{
			get
			{
				return this._PhanCongs;
			}
			set
			{
				this._PhanCongs.Assign(value);
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
		
		private void attach_PhanCongs(PhanCong entity)
		{
			this.SendPropertyChanging();
			entity.MonHoc = this;
		}
		
		private void detach_PhanCongs(PhanCong entity)
		{
			this.SendPropertyChanging();
			entity.MonHoc = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PhanCong")]
	public partial class PhanCong : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MAHP;
		
		private System.Nullable<int> _MAMH;
		
		private System.Nullable<int> _MAGV;
		
		private System.Nullable<System.DateTime> _NGAYBD;
		
		private System.Nullable<System.DateTime> _NGAYKT;
		
		private EntityRef<GiaoVien> _GiaoVien;
		
		private EntityRef<MonHoc> _MonHoc;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMAHPChanging(string value);
    partial void OnMAHPChanged();
    partial void OnMAMHChanging(System.Nullable<int> value);
    partial void OnMAMHChanged();
    partial void OnMAGVChanging(System.Nullable<int> value);
    partial void OnMAGVChanged();
    partial void OnNGAYBDChanging(System.Nullable<System.DateTime> value);
    partial void OnNGAYBDChanged();
    partial void OnNGAYKTChanging(System.Nullable<System.DateTime> value);
    partial void OnNGAYKTChanged();
    #endregion
		
		public PhanCong()
		{
			this._GiaoVien = default(EntityRef<GiaoVien>);
			this._MonHoc = default(EntityRef<MonHoc>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAHP", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MAHP
		{
			get
			{
				return this._MAHP;
			}
			set
			{
				if ((this._MAHP != value))
				{
					this.OnMAHPChanging(value);
					this.SendPropertyChanging();
					this._MAHP = value;
					this.SendPropertyChanged("MAHP");
					this.OnMAHPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAMH", DbType="Int")]
		public System.Nullable<int> MAMH
		{
			get
			{
				return this._MAMH;
			}
			set
			{
				if ((this._MAMH != value))
				{
					if (this._MonHoc.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMAMHChanging(value);
					this.SendPropertyChanging();
					this._MAMH = value;
					this.SendPropertyChanged("MAMH");
					this.OnMAMHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAGV", DbType="Int")]
		public System.Nullable<int> MAGV
		{
			get
			{
				return this._MAGV;
			}
			set
			{
				if ((this._MAGV != value))
				{
					if (this._GiaoVien.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMAGVChanging(value);
					this.SendPropertyChanging();
					this._MAGV = value;
					this.SendPropertyChanged("MAGV");
					this.OnMAGVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAYBD", DbType="DateTime")]
		public System.Nullable<System.DateTime> NGAYBD
		{
			get
			{
				return this._NGAYBD;
			}
			set
			{
				if ((this._NGAYBD != value))
				{
					this.OnNGAYBDChanging(value);
					this.SendPropertyChanging();
					this._NGAYBD = value;
					this.SendPropertyChanged("NGAYBD");
					this.OnNGAYBDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAYKT", DbType="DateTime")]
		public System.Nullable<System.DateTime> NGAYKT
		{
			get
			{
				return this._NGAYKT;
			}
			set
			{
				if ((this._NGAYKT != value))
				{
					this.OnNGAYKTChanging(value);
					this.SendPropertyChanging();
					this._NGAYKT = value;
					this.SendPropertyChanged("NGAYKT");
					this.OnNGAYKTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="GiaoVien_PhanCong", Storage="_GiaoVien", ThisKey="MAGV", OtherKey="MAGV", IsForeignKey=true)]
		public GiaoVien GiaoVien
		{
			get
			{
				return this._GiaoVien.Entity;
			}
			set
			{
				GiaoVien previousValue = this._GiaoVien.Entity;
				if (((previousValue != value) 
							|| (this._GiaoVien.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._GiaoVien.Entity = null;
						previousValue.PhanCongs.Remove(this);
					}
					this._GiaoVien.Entity = value;
					if ((value != null))
					{
						value.PhanCongs.Add(this);
						this._MAGV = value.MAGV;
					}
					else
					{
						this._MAGV = default(Nullable<int>);
					}
					this.SendPropertyChanged("GiaoVien");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="MonHoc_PhanCong", Storage="_MonHoc", ThisKey="MAMH", OtherKey="MAMH", IsForeignKey=true)]
		public MonHoc MonHoc
		{
			get
			{
				return this._MonHoc.Entity;
			}
			set
			{
				MonHoc previousValue = this._MonHoc.Entity;
				if (((previousValue != value) 
							|| (this._MonHoc.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._MonHoc.Entity = null;
						previousValue.PhanCongs.Remove(this);
					}
					this._MonHoc.Entity = value;
					if ((value != null))
					{
						value.PhanCongs.Add(this);
						this._MAMH = value.MAMH;
					}
					else
					{
						this._MAMH = default(Nullable<int>);
					}
					this.SendPropertyChanged("MonHoc");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TaiKhoan")]
	public partial class TaiKhoan : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MATK;
		
		private string _USERNAME;
		
		private string _PASSWORD;
		
		private string _QUYEN;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMATKChanging(int value);
    partial void OnMATKChanged();
    partial void OnUSERNAMEChanging(string value);
    partial void OnUSERNAMEChanged();
    partial void OnPASSWORDChanging(string value);
    partial void OnPASSWORDChanged();
    partial void OnQUYENChanging(string value);
    partial void OnQUYENChanged();
    #endregion
		
		public TaiKhoan()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MATK", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MATK
		{
			get
			{
				return this._MATK;
			}
			set
			{
				if ((this._MATK != value))
				{
					this.OnMATKChanging(value);
					this.SendPropertyChanging();
					this._MATK = value;
					this.SendPropertyChanged("MATK");
					this.OnMATKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_USERNAME", DbType="VarChar(150)")]
		public string USERNAME
		{
			get
			{
				return this._USERNAME;
			}
			set
			{
				if ((this._USERNAME != value))
				{
					this.OnUSERNAMEChanging(value);
					this.SendPropertyChanging();
					this._USERNAME = value;
					this.SendPropertyChanged("USERNAME");
					this.OnUSERNAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PASSWORD", DbType="VarChar(150)")]
		public string PASSWORD
		{
			get
			{
				return this._PASSWORD;
			}
			set
			{
				if ((this._PASSWORD != value))
				{
					this.OnPASSWORDChanging(value);
					this.SendPropertyChanging();
					this._PASSWORD = value;
					this.SendPropertyChanged("PASSWORD");
					this.OnPASSWORDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QUYEN", DbType="VarChar(50)")]
		public string QUYEN
		{
			get
			{
				return this._QUYEN;
			}
			set
			{
				if ((this._QUYEN != value))
				{
					this.OnQUYENChanging(value);
					this.SendPropertyChanging();
					this._QUYEN = value;
					this.SendPropertyChanged("QUYEN");
					this.OnQUYENChanged();
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
