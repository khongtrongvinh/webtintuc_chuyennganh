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

namespace weptintuc.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="News")]
	public partial class dbNewsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertKHACH_HANG(KHACH_HANG instance);
    partial void UpdateKHACH_HANG(KHACH_HANG instance);
    partial void DeleteKHACH_HANG(KHACH_HANG instance);
    partial void InsertTAI_KHOAN(TAI_KHOAN instance);
    partial void UpdateTAI_KHOAN(TAI_KHOAN instance);
    partial void DeleteTAI_KHOAN(TAI_KHOAN instance);
    partial void InsertLOAI_TIN(LOAI_TIN instance);
    partial void UpdateLOAI_TIN(LOAI_TIN instance);
    partial void DeleteLOAI_TIN(LOAI_TIN instance);
    partial void InsertTIN_TUC(TIN_TUC instance);
    partial void UpdateTIN_TUC(TIN_TUC instance);
    partial void DeleteTIN_TUC(TIN_TUC instance);
    #endregion
		
		public dbNewsDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["NewsConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public dbNewsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbNewsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbNewsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbNewsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<KHACH_HANG> KHACH_HANGs
		{
			get
			{
				return this.GetTable<KHACH_HANG>();
			}
		}
		
		public System.Data.Linq.Table<TAI_KHOAN> TAI_KHOANs
		{
			get
			{
				return this.GetTable<TAI_KHOAN>();
			}
		}
		
		public System.Data.Linq.Table<LOAI_TIN> LOAI_TINs
		{
			get
			{
				return this.GetTable<LOAI_TIN>();
			}
		}
		
		public System.Data.Linq.Table<TIN_TUC> TIN_TUCs
		{
			get
			{
				return this.GetTable<TIN_TUC>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KHACH_HANG")]
	public partial class KHACH_HANG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MAKH;
		
		private string _TENTK;
		
		private string _MATKHAU;
		
		private string _HOTEN;
		
		private string _DIACHI;
		
		private string _DIENTHOAI;
		
		private System.Nullable<System.DateTime> _NGAYSINH;
		
		private string _EMAIL;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMAKHChanging(int value);
    partial void OnMAKHChanged();
    partial void OnTENTKChanging(string value);
    partial void OnTENTKChanged();
    partial void OnMATKHAUChanging(string value);
    partial void OnMATKHAUChanged();
    partial void OnHOTENChanging(string value);
    partial void OnHOTENChanged();
    partial void OnDIACHIChanging(string value);
    partial void OnDIACHIChanged();
    partial void OnDIENTHOAIChanging(string value);
    partial void OnDIENTHOAIChanged();
    partial void OnNGAYSINHChanging(System.Nullable<System.DateTime> value);
    partial void OnNGAYSINHChanged();
    partial void OnEMAILChanging(string value);
    partial void OnEMAILChanged();
    #endregion
		
		public KHACH_HANG()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAKH", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MAKH
		{
			get
			{
				return this._MAKH;
			}
			set
			{
				if ((this._MAKH != value))
				{
					this.OnMAKHChanging(value);
					this.SendPropertyChanging();
					this._MAKH = value;
					this.SendPropertyChanged("MAKH");
					this.OnMAKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENTK", DbType="VarChar(50)")]
		public string TENTK
		{
			get
			{
				return this._TENTK;
			}
			set
			{
				if ((this._TENTK != value))
				{
					this.OnTENTKChanging(value);
					this.SendPropertyChanging();
					this._TENTK = value;
					this.SendPropertyChanged("TENTK");
					this.OnTENTKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MATKHAU", DbType="VarChar(50)")]
		public string MATKHAU
		{
			get
			{
				return this._MATKHAU;
			}
			set
			{
				if ((this._MATKHAU != value))
				{
					this.OnMATKHAUChanging(value);
					this.SendPropertyChanging();
					this._MATKHAU = value;
					this.SendPropertyChanged("MATKHAU");
					this.OnMATKHAUChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HOTEN", DbType="NVarChar(50)")]
		public string HOTEN
		{
			get
			{
				return this._HOTEN;
			}
			set
			{
				if ((this._HOTEN != value))
				{
					this.OnHOTENChanging(value);
					this.SendPropertyChanging();
					this._HOTEN = value;
					this.SendPropertyChanged("HOTEN");
					this.OnHOTENChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIACHI", DbType="NVarChar(200)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIENTHOAI", DbType="VarChar(11)")]
		public string DIENTHOAI
		{
			get
			{
				return this._DIENTHOAI;
			}
			set
			{
				if ((this._DIENTHOAI != value))
				{
					this.OnDIENTHOAIChanging(value);
					this.SendPropertyChanging();
					this._DIENTHOAI = value;
					this.SendPropertyChanged("DIENTHOAI");
					this.OnDIENTHOAIChanged();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EMAIL", DbType="VarChar(100)")]
		public string EMAIL
		{
			get
			{
				return this._EMAIL;
			}
			set
			{
				if ((this._EMAIL != value))
				{
					this.OnEMAILChanging(value);
					this.SendPropertyChanging();
					this._EMAIL = value;
					this.SendPropertyChanged("EMAIL");
					this.OnEMAILChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TAI_KHOAN")]
	public partial class TAI_KHOAN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MATK;
		
		private string _TEN_TAI_KHOAN;
		
		private string _MAT_KHAU;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMATKChanging(int value);
    partial void OnMATKChanged();
    partial void OnTEN_TAI_KHOANChanging(string value);
    partial void OnTEN_TAI_KHOANChanged();
    partial void OnMAT_KHAUChanging(string value);
    partial void OnMAT_KHAUChanged();
    #endregion
		
		public TAI_KHOAN()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TEN_TAI_KHOAN", DbType="VarChar(50)")]
		public string TEN_TAI_KHOAN
		{
			get
			{
				return this._TEN_TAI_KHOAN;
			}
			set
			{
				if ((this._TEN_TAI_KHOAN != value))
				{
					this.OnTEN_TAI_KHOANChanging(value);
					this.SendPropertyChanging();
					this._TEN_TAI_KHOAN = value;
					this.SendPropertyChanged("TEN_TAI_KHOAN");
					this.OnTEN_TAI_KHOANChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAT_KHAU", DbType="VarChar(50)")]
		public string MAT_KHAU
		{
			get
			{
				return this._MAT_KHAU;
			}
			set
			{
				if ((this._MAT_KHAU != value))
				{
					this.OnMAT_KHAUChanging(value);
					this.SendPropertyChanging();
					this._MAT_KHAU = value;
					this.SendPropertyChanged("MAT_KHAU");
					this.OnMAT_KHAUChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LOAI_TIN")]
	public partial class LOAI_TIN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MA_LOAI_TT;
		
		private string _TEN_LOAI_TT;
		
		private EntitySet<TIN_TUC> _TIN_TUCs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMA_LOAI_TTChanging(int value);
    partial void OnMA_LOAI_TTChanged();
    partial void OnTEN_LOAI_TTChanging(string value);
    partial void OnTEN_LOAI_TTChanged();
    #endregion
		
		public LOAI_TIN()
		{
			this._TIN_TUCs = new EntitySet<TIN_TUC>(new Action<TIN_TUC>(this.attach_TIN_TUCs), new Action<TIN_TUC>(this.detach_TIN_TUCs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MA_LOAI_TT", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MA_LOAI_TT
		{
			get
			{
				return this._MA_LOAI_TT;
			}
			set
			{
				if ((this._MA_LOAI_TT != value))
				{
					this.OnMA_LOAI_TTChanging(value);
					this.SendPropertyChanging();
					this._MA_LOAI_TT = value;
					this.SendPropertyChanged("MA_LOAI_TT");
					this.OnMA_LOAI_TTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TEN_LOAI_TT", DbType="NVarChar(50)")]
		public string TEN_LOAI_TT
		{
			get
			{
				return this._TEN_LOAI_TT;
			}
			set
			{
				if ((this._TEN_LOAI_TT != value))
				{
					this.OnTEN_LOAI_TTChanging(value);
					this.SendPropertyChanging();
					this._TEN_LOAI_TT = value;
					this.SendPropertyChanged("TEN_LOAI_TT");
					this.OnTEN_LOAI_TTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LOAI_TIN_TIN_TUC", Storage="_TIN_TUCs", ThisKey="MA_LOAI_TT", OtherKey="MA_LOAI_TT")]
		public EntitySet<TIN_TUC> TIN_TUCs
		{
			get
			{
				return this._TIN_TUCs;
			}
			set
			{
				this._TIN_TUCs.Assign(value);
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
		
		private void attach_TIN_TUCs(TIN_TUC entity)
		{
			this.SendPropertyChanging();
			entity.LOAI_TIN = this;
		}
		
		private void detach_TIN_TUCs(TIN_TUC entity)
		{
			this.SendPropertyChanging();
			entity.LOAI_TIN = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TIN_TUC")]
	public partial class TIN_TUC : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MATT;
		
		private int _MA_LOAI_TT;
		
		private string _TEN_TT;
		
		private string _MOTA_TT;
		
		private string _NOI_DUNG;
		
		private string _HINH_ANH;
		
		private string _NGUOI_VIET_TIN;
		
		private System.Nullable<System.DateTime> _NGAY_DANG;
		
		private EntityRef<LOAI_TIN> _LOAI_TIN;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMATTChanging(int value);
    partial void OnMATTChanged();
    partial void OnMA_LOAI_TTChanging(int value);
    partial void OnMA_LOAI_TTChanged();
    partial void OnTEN_TTChanging(string value);
    partial void OnTEN_TTChanged();
    partial void OnMOTA_TTChanging(string value);
    partial void OnMOTA_TTChanged();
    partial void OnNOI_DUNGChanging(string value);
    partial void OnNOI_DUNGChanged();
    partial void OnHINH_ANHChanging(string value);
    partial void OnHINH_ANHChanged();
    partial void OnNGUOI_VIET_TINChanging(string value);
    partial void OnNGUOI_VIET_TINChanged();
    partial void OnNGAY_DANGChanging(System.Nullable<System.DateTime> value);
    partial void OnNGAY_DANGChanged();
    #endregion
		
		public TIN_TUC()
		{
			this._LOAI_TIN = default(EntityRef<LOAI_TIN>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MATT", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MATT
		{
			get
			{
				return this._MATT;
			}
			set
			{
				if ((this._MATT != value))
				{
					this.OnMATTChanging(value);
					this.SendPropertyChanging();
					this._MATT = value;
					this.SendPropertyChanged("MATT");
					this.OnMATTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MA_LOAI_TT", DbType="Int NOT NULL")]
		public int MA_LOAI_TT
		{
			get
			{
				return this._MA_LOAI_TT;
			}
			set
			{
				if ((this._MA_LOAI_TT != value))
				{
					if (this._LOAI_TIN.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMA_LOAI_TTChanging(value);
					this.SendPropertyChanging();
					this._MA_LOAI_TT = value;
					this.SendPropertyChanged("MA_LOAI_TT");
					this.OnMA_LOAI_TTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TEN_TT", DbType="NVarChar(350) NOT NULL", CanBeNull=false)]
		public string TEN_TT
		{
			get
			{
				return this._TEN_TT;
			}
			set
			{
				if ((this._TEN_TT != value))
				{
					this.OnTEN_TTChanging(value);
					this.SendPropertyChanging();
					this._TEN_TT = value;
					this.SendPropertyChanged("TEN_TT");
					this.OnTEN_TTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MOTA_TT", DbType="NVarChar(350) NOT NULL", CanBeNull=false)]
		public string MOTA_TT
		{
			get
			{
				return this._MOTA_TT;
			}
			set
			{
				if ((this._MOTA_TT != value))
				{
					this.OnMOTA_TTChanging(value);
					this.SendPropertyChanging();
					this._MOTA_TT = value;
					this.SendPropertyChanged("MOTA_TT");
					this.OnMOTA_TTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NOI_DUNG", DbType="NVarChar(2000) NOT NULL", CanBeNull=false)]
		public string NOI_DUNG
		{
			get
			{
				return this._NOI_DUNG;
			}
			set
			{
				if ((this._NOI_DUNG != value))
				{
					this.OnNOI_DUNGChanging(value);
					this.SendPropertyChanging();
					this._NOI_DUNG = value;
					this.SendPropertyChanged("NOI_DUNG");
					this.OnNOI_DUNGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HINH_ANH", DbType="VarChar(50)")]
		public string HINH_ANH
		{
			get
			{
				return this._HINH_ANH;
			}
			set
			{
				if ((this._HINH_ANH != value))
				{
					this.OnHINH_ANHChanging(value);
					this.SendPropertyChanging();
					this._HINH_ANH = value;
					this.SendPropertyChanged("HINH_ANH");
					this.OnHINH_ANHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGUOI_VIET_TIN", DbType="NVarChar(30)")]
		public string NGUOI_VIET_TIN
		{
			get
			{
				return this._NGUOI_VIET_TIN;
			}
			set
			{
				if ((this._NGUOI_VIET_TIN != value))
				{
					this.OnNGUOI_VIET_TINChanging(value);
					this.SendPropertyChanging();
					this._NGUOI_VIET_TIN = value;
					this.SendPropertyChanged("NGUOI_VIET_TIN");
					this.OnNGUOI_VIET_TINChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAY_DANG", DbType="DateTime")]
		public System.Nullable<System.DateTime> NGAY_DANG
		{
			get
			{
				return this._NGAY_DANG;
			}
			set
			{
				if ((this._NGAY_DANG != value))
				{
					this.OnNGAY_DANGChanging(value);
					this.SendPropertyChanging();
					this._NGAY_DANG = value;
					this.SendPropertyChanged("NGAY_DANG");
					this.OnNGAY_DANGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LOAI_TIN_TIN_TUC", Storage="_LOAI_TIN", ThisKey="MA_LOAI_TT", OtherKey="MA_LOAI_TT", IsForeignKey=true)]
		public LOAI_TIN LOAI_TIN
		{
			get
			{
				return this._LOAI_TIN.Entity;
			}
			set
			{
				LOAI_TIN previousValue = this._LOAI_TIN.Entity;
				if (((previousValue != value) 
							|| (this._LOAI_TIN.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LOAI_TIN.Entity = null;
						previousValue.TIN_TUCs.Remove(this);
					}
					this._LOAI_TIN.Entity = value;
					if ((value != null))
					{
						value.TIN_TUCs.Add(this);
						this._MA_LOAI_TT = value.MA_LOAI_TT;
					}
					else
					{
						this._MA_LOAI_TT = default(int);
					}
					this.SendPropertyChanged("LOAI_TIN");
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
