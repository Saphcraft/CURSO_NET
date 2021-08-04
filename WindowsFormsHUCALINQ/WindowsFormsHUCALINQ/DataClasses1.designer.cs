﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsHUCALINQ
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="HOSPITALLINQ")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertEnfermo(Enfermo instance);
    partial void UpdateEnfermo(Enfermo instance);
    partial void DeleteEnfermo(Enfermo instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::WindowsFormsHUCALINQ.Properties.Settings.Default.HOSPITALLINQConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Enfermo> Enfermo
		{
			get
			{
				return this.GetTable<Enfermo>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Enfermo")]
	public partial class Enfermo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _inscripcion;
		
		private string _Apellido;
		
		private string _Direccion;
		
		private System.Nullable<int> _Dir;
		
		private System.Nullable<System.DateTime> _Fecha_Nac;
		
		private string _S;
		
		private System.Nullable<int> _NSS;
		
		private System.Nullable<int> _Cod_Hospital;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OninscripcionChanging(int value);
    partial void OninscripcionChanged();
    partial void OnApellidoChanging(string value);
    partial void OnApellidoChanged();
    partial void OnDireccionChanging(string value);
    partial void OnDireccionChanged();
    partial void OnDirChanging(System.Nullable<int> value);
    partial void OnDirChanged();
    partial void OnFecha_NacChanging(System.Nullable<System.DateTime> value);
    partial void OnFecha_NacChanged();
    partial void OnSChanging(string value);
    partial void OnSChanged();
    partial void OnNSSChanging(System.Nullable<int> value);
    partial void OnNSSChanged();
    partial void OnCod_HospitalChanging(System.Nullable<int> value);
    partial void OnCod_HospitalChanged();
    #endregion
		
		public Enfermo()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_inscripcion", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int inscripcion
		{
			get
			{
				return this._inscripcion;
			}
			set
			{
				if ((this._inscripcion != value))
				{
					this.OninscripcionChanging(value);
					this.SendPropertyChanging();
					this._inscripcion = value;
					this.SendPropertyChanged("inscripcion");
					this.OninscripcionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Apellido", DbType="VarChar(50)")]
		public string Apellido
		{
			get
			{
				return this._Apellido;
			}
			set
			{
				if ((this._Apellido != value))
				{
					this.OnApellidoChanging(value);
					this.SendPropertyChanging();
					this._Apellido = value;
					this.SendPropertyChanged("Apellido");
					this.OnApellidoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Direccion", DbType="VarChar(50)")]
		public string Direccion
		{
			get
			{
				return this._Direccion;
			}
			set
			{
				if ((this._Direccion != value))
				{
					this.OnDireccionChanging(value);
					this.SendPropertyChanging();
					this._Direccion = value;
					this.SendPropertyChanged("Direccion");
					this.OnDireccionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dir", DbType="Int")]
		public System.Nullable<int> Dir
		{
			get
			{
				return this._Dir;
			}
			set
			{
				if ((this._Dir != value))
				{
					this.OnDirChanging(value);
					this.SendPropertyChanging();
					this._Dir = value;
					this.SendPropertyChanged("Dir");
					this.OnDirChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fecha_Nac", DbType="Date")]
		public System.Nullable<System.DateTime> Fecha_Nac
		{
			get
			{
				return this._Fecha_Nac;
			}
			set
			{
				if ((this._Fecha_Nac != value))
				{
					this.OnFecha_NacChanging(value);
					this.SendPropertyChanging();
					this._Fecha_Nac = value;
					this.SendPropertyChanged("Fecha_Nac");
					this.OnFecha_NacChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_S", DbType="VarChar(2)")]
		public string S
		{
			get
			{
				return this._S;
			}
			set
			{
				if ((this._S != value))
				{
					this.OnSChanging(value);
					this.SendPropertyChanging();
					this._S = value;
					this.SendPropertyChanged("S");
					this.OnSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NSS", DbType="Int")]
		public System.Nullable<int> NSS
		{
			get
			{
				return this._NSS;
			}
			set
			{
				if ((this._NSS != value))
				{
					this.OnNSSChanging(value);
					this.SendPropertyChanging();
					this._NSS = value;
					this.SendPropertyChanged("NSS");
					this.OnNSSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cod_Hospital", DbType="Int")]
		public System.Nullable<int> Cod_Hospital
		{
			get
			{
				return this._Cod_Hospital;
			}
			set
			{
				if ((this._Cod_Hospital != value))
				{
					this.OnCod_HospitalChanging(value);
					this.SendPropertyChanging();
					this._Cod_Hospital = value;
					this.SendPropertyChanged("Cod_Hospital");
					this.OnCod_HospitalChanged();
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
