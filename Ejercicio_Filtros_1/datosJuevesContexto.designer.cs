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

namespace Ejercicio_Filtros
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="FILTROSLINQ")]
	public partial class datosJuevesContextoDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertdatosJueves(datosJueves instance);
    partial void UpdatedatosJueves(datosJueves instance);
    partial void DeletedatosJueves(datosJueves instance);
    #endregion
		
		public datosJuevesContextoDataContext() : 
				base(global::Ejercicio_Filtros.Properties.Settings.Default.FILTROSLINQConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public datosJuevesContextoDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public datosJuevesContextoDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public datosJuevesContextoDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public datosJuevesContextoDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<datosJueves> datosJueves
		{
			get
			{
				return this.GetTable<datosJueves>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.datosJueves")]
	public partial class datosJueves : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Nombre;
		
		private string _Apellidos;
		
		private System.Nullable<System.DateTime> _Fecha_inscripcion;
		
		private System.Nullable<System.DateTime> _Fecha_contratacion;
		
		private string _Curso;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnApellidosChanging(string value);
    partial void OnApellidosChanged();
    partial void OnFecha_inscripcionChanging(System.Nullable<System.DateTime> value);
    partial void OnFecha_inscripcionChanged();
    partial void OnFecha_contratacionChanging(System.Nullable<System.DateTime> value);
    partial void OnFecha_contratacionChanged();
    partial void OnCursoChanging(string value);
    partial void OnCursoChanged();
    #endregion
		
		public datosJueves()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="NVarChar(50)")]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Apellidos", DbType="NVarChar(50)")]
		public string Apellidos
		{
			get
			{
				return this._Apellidos;
			}
			set
			{
				if ((this._Apellidos != value))
				{
					this.OnApellidosChanging(value);
					this.SendPropertyChanging();
					this._Apellidos = value;
					this.SendPropertyChanged("Apellidos");
					this.OnApellidosChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fecha_inscripcion", DbType="DateTime")]
		public System.Nullable<System.DateTime> Fecha_inscripcion
		{
			get
			{
				return this._Fecha_inscripcion;
			}
			set
			{
				if ((this._Fecha_inscripcion != value))
				{
					this.OnFecha_inscripcionChanging(value);
					this.SendPropertyChanging();
					this._Fecha_inscripcion = value;
					this.SendPropertyChanged("Fecha_inscripcion");
					this.OnFecha_inscripcionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fecha_contratacion", DbType="DateTime")]
		public System.Nullable<System.DateTime> Fecha_contratacion
		{
			get
			{
				return this._Fecha_contratacion;
			}
			set
			{
				if ((this._Fecha_contratacion != value))
				{
					this.OnFecha_contratacionChanging(value);
					this.SendPropertyChanging();
					this._Fecha_contratacion = value;
					this.SendPropertyChanged("Fecha_contratacion");
					this.OnFecha_contratacionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Curso", DbType="NVarChar(50)")]
		public string Curso
		{
			get
			{
				return this._Curso;
			}
			set
			{
				if ((this._Curso != value))
				{
					this.OnCursoChanging(value);
					this.SendPropertyChanging();
					this._Curso = value;
					this.SendPropertyChanged("Curso");
					this.OnCursoChanged();
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
