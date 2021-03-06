#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sistema.dal
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="bancovet")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Inserttb_agendamento(tb_agendamento instance);
    partial void Updatetb_agendamento(tb_agendamento instance);
    partial void Deletetb_agendamento(tb_agendamento instance);
    partial void Inserttb_agendservico(tb_agendservico instance);
    partial void Updatetb_agendservico(tb_agendservico instance);
    partial void Deletetb_agendservico(tb_agendservico instance);
    partial void Inserttb_cadanimal(tb_cadanimal instance);
    partial void Updatetb_cadanimal(tb_cadanimal instance);
    partial void Deletetb_cadanimal(tb_cadanimal instance);
    partial void Inserttb_cadcliente(tb_cadcliente instance);
    partial void Updatetb_cadcliente(tb_cadcliente instance);
    partial void Deletetb_cadcliente(tb_cadcliente instance);
    partial void Inserttb_servico(tb_servico instance);
    partial void Updatetb_servico(tb_servico instance);
    partial void Deletetb_servico(tb_servico instance);
    partial void Inserttb_raca(tb_raca instance);
    partial void Updatetb_raca(tb_raca instance);
    partial void Deletetb_raca(tb_raca instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::sistema.dal.Properties.Settings.Default.bancovetConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<tb_agendamento> tb_agendamento
		{
			get
			{
				return this.GetTable<tb_agendamento>();
			}
		}
		
		public System.Data.Linq.Table<tb_agendservico> tb_agendservico
		{
			get
			{
				return this.GetTable<tb_agendservico>();
			}
		}
		
		public System.Data.Linq.Table<tb_cadanimal> tb_cadanimal
		{
			get
			{
				return this.GetTable<tb_cadanimal>();
			}
		}
		
		public System.Data.Linq.Table<tb_cadcliente> tb_cadcliente
		{
			get
			{
				return this.GetTable<tb_cadcliente>();
			}
		}
		
		public System.Data.Linq.Table<tb_servico> tb_servico
		{
			get
			{
				return this.GetTable<tb_servico>();
			}
		}
		
		public System.Data.Linq.Table<tb_raca> tb_raca
		{
			get
			{
				return this.GetTable<tb_raca>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_agendamento")]
	public partial class tb_agendamento : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ag_codigo;
		
		private System.Nullable<System.DateTime> _ag_data;
		
		private string _ag_horario;
		
		private string _ag_situacao;
		
		private string _ag_animal;
		
		private string _ag_total;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onag_codigoChanging(int value);
    partial void Onag_codigoChanged();
    partial void Onag_dataChanging(System.Nullable<System.DateTime> value);
    partial void Onag_dataChanged();
    partial void Onag_horarioChanging(string value);
    partial void Onag_horarioChanged();
    partial void Onag_situacaoChanging(string value);
    partial void Onag_situacaoChanged();
    partial void Onag_animalChanging(string value);
    partial void Onag_animalChanged();
    partial void Onag_totalChanging(string value);
    partial void Onag_totalChanged();
    #endregion
		
		public tb_agendamento()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ag_codigo", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ag_codigo
		{
			get
			{
				return this._ag_codigo;
			}
			set
			{
				if ((this._ag_codigo != value))
				{
					this.Onag_codigoChanging(value);
					this.SendPropertyChanging();
					this._ag_codigo = value;
					this.SendPropertyChanged("ag_codigo");
					this.Onag_codigoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ag_data", DbType="Date")]
		public System.Nullable<System.DateTime> ag_data
		{
			get
			{
				return this._ag_data;
			}
			set
			{
				if ((this._ag_data != value))
				{
					this.Onag_dataChanging(value);
					this.SendPropertyChanging();
					this._ag_data = value;
					this.SendPropertyChanged("ag_data");
					this.Onag_dataChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ag_horario", DbType="NVarChar(50)")]
		public string ag_horario
		{
			get
			{
				return this._ag_horario;
			}
			set
			{
				if ((this._ag_horario != value))
				{
					this.Onag_horarioChanging(value);
					this.SendPropertyChanging();
					this._ag_horario = value;
					this.SendPropertyChanged("ag_horario");
					this.Onag_horarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ag_situacao", DbType="VarChar(50)")]
		public string ag_situacao
		{
			get
			{
				return this._ag_situacao;
			}
			set
			{
				if ((this._ag_situacao != value))
				{
					this.Onag_situacaoChanging(value);
					this.SendPropertyChanging();
					this._ag_situacao = value;
					this.SendPropertyChanged("ag_situacao");
					this.Onag_situacaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ag_animal", DbType="VarChar(50)")]
		public string ag_animal
		{
			get
			{
				return this._ag_animal;
			}
			set
			{
				if ((this._ag_animal != value))
				{
					this.Onag_animalChanging(value);
					this.SendPropertyChanging();
					this._ag_animal = value;
					this.SendPropertyChanged("ag_animal");
					this.Onag_animalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ag_total", DbType="VarChar(50)")]
		public string ag_total
		{
			get
			{
				return this._ag_total;
			}
			set
			{
				if ((this._ag_total != value))
				{
					this.Onag_totalChanging(value);
					this.SendPropertyChanging();
					this._ag_total = value;
					this.SendPropertyChanged("ag_total");
					this.Onag_totalChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_agendservico")]
	public partial class tb_agendservico : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ag_serv_numero;
		
		private string _ag_serv_agendamento;
		
		private string _ag_serv_servico;
		
		private string _ag_serv_quantidade;
		
		private string _ag_serv_valor_unitario;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onag_serv_numeroChanging(string value);
    partial void Onag_serv_numeroChanged();
    partial void Onag_serv_agendamentoChanging(string value);
    partial void Onag_serv_agendamentoChanged();
    partial void Onag_serv_servicoChanging(string value);
    partial void Onag_serv_servicoChanged();
    partial void Onag_serv_quantidadeChanging(string value);
    partial void Onag_serv_quantidadeChanged();
    partial void Onag_serv_valor_unitarioChanging(string value);
    partial void Onag_serv_valor_unitarioChanged();
    #endregion
		
		public tb_agendservico()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ag_serv_numero", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ag_serv_numero
		{
			get
			{
				return this._ag_serv_numero;
			}
			set
			{
				if ((this._ag_serv_numero != value))
				{
					this.Onag_serv_numeroChanging(value);
					this.SendPropertyChanging();
					this._ag_serv_numero = value;
					this.SendPropertyChanged("ag_serv_numero");
					this.Onag_serv_numeroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ag_serv_agendamento", DbType="VarChar(50)")]
		public string ag_serv_agendamento
		{
			get
			{
				return this._ag_serv_agendamento;
			}
			set
			{
				if ((this._ag_serv_agendamento != value))
				{
					this.Onag_serv_agendamentoChanging(value);
					this.SendPropertyChanging();
					this._ag_serv_agendamento = value;
					this.SendPropertyChanged("ag_serv_agendamento");
					this.Onag_serv_agendamentoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ag_serv_servico", DbType="VarChar(50)")]
		public string ag_serv_servico
		{
			get
			{
				return this._ag_serv_servico;
			}
			set
			{
				if ((this._ag_serv_servico != value))
				{
					this.Onag_serv_servicoChanging(value);
					this.SendPropertyChanging();
					this._ag_serv_servico = value;
					this.SendPropertyChanged("ag_serv_servico");
					this.Onag_serv_servicoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ag_serv_quantidade", DbType="NVarChar(50)")]
		public string ag_serv_quantidade
		{
			get
			{
				return this._ag_serv_quantidade;
			}
			set
			{
				if ((this._ag_serv_quantidade != value))
				{
					this.Onag_serv_quantidadeChanging(value);
					this.SendPropertyChanging();
					this._ag_serv_quantidade = value;
					this.SendPropertyChanged("ag_serv_quantidade");
					this.Onag_serv_quantidadeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ag_serv_valor_unitario", DbType="NVarChar(50)")]
		public string ag_serv_valor_unitario
		{
			get
			{
				return this._ag_serv_valor_unitario;
			}
			set
			{
				if ((this._ag_serv_valor_unitario != value))
				{
					this.Onag_serv_valor_unitarioChanging(value);
					this.SendPropertyChanging();
					this._ag_serv_valor_unitario = value;
					this.SendPropertyChanged("ag_serv_valor_unitario");
					this.Onag_serv_valor_unitarioChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_cadanimal")]
	public partial class tb_cadanimal : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ani_codigo;
		
		private string _ani_nome;
		
		private string _ani_sexo;
		
		private string _ani_agressivo;
		
		private string _ani_cor;
		
		private string _ani_idade;
		
		private string _ani_alergia;
		
		private string _ani_cliente;
		
		private string _ani_raca;
		
		private System.Data.Linq.Binary _ani_foto;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onani_codigoChanging(int value);
    partial void Onani_codigoChanged();
    partial void Onani_nomeChanging(string value);
    partial void Onani_nomeChanged();
    partial void Onani_sexoChanging(string value);
    partial void Onani_sexoChanged();
    partial void Onani_agressivoChanging(string value);
    partial void Onani_agressivoChanged();
    partial void Onani_corChanging(string value);
    partial void Onani_corChanged();
    partial void Onani_idadeChanging(string value);
    partial void Onani_idadeChanged();
    partial void Onani_alergiaChanging(string value);
    partial void Onani_alergiaChanged();
    partial void Onani_clienteChanging(string value);
    partial void Onani_clienteChanged();
    partial void Onani_racaChanging(string value);
    partial void Onani_racaChanged();
    partial void Onani_fotoChanging(System.Data.Linq.Binary value);
    partial void Onani_fotoChanged();
    #endregion
		
		public tb_cadanimal()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ani_codigo", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ani_codigo
		{
			get
			{
				return this._ani_codigo;
			}
			set
			{
				if ((this._ani_codigo != value))
				{
					this.Onani_codigoChanging(value);
					this.SendPropertyChanging();
					this._ani_codigo = value;
					this.SendPropertyChanged("ani_codigo");
					this.Onani_codigoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ani_nome", DbType="VarChar(50)")]
		public string ani_nome
		{
			get
			{
				return this._ani_nome;
			}
			set
			{
				if ((this._ani_nome != value))
				{
					this.Onani_nomeChanging(value);
					this.SendPropertyChanging();
					this._ani_nome = value;
					this.SendPropertyChanged("ani_nome");
					this.Onani_nomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ani_sexo", DbType="VarChar(50)")]
		public string ani_sexo
		{
			get
			{
				return this._ani_sexo;
			}
			set
			{
				if ((this._ani_sexo != value))
				{
					this.Onani_sexoChanging(value);
					this.SendPropertyChanging();
					this._ani_sexo = value;
					this.SendPropertyChanged("ani_sexo");
					this.Onani_sexoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ani_agressivo", DbType="VarChar(50)")]
		public string ani_agressivo
		{
			get
			{
				return this._ani_agressivo;
			}
			set
			{
				if ((this._ani_agressivo != value))
				{
					this.Onani_agressivoChanging(value);
					this.SendPropertyChanging();
					this._ani_agressivo = value;
					this.SendPropertyChanged("ani_agressivo");
					this.Onani_agressivoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ani_cor", DbType="VarChar(50)")]
		public string ani_cor
		{
			get
			{
				return this._ani_cor;
			}
			set
			{
				if ((this._ani_cor != value))
				{
					this.Onani_corChanging(value);
					this.SendPropertyChanging();
					this._ani_cor = value;
					this.SendPropertyChanged("ani_cor");
					this.Onani_corChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ani_idade", DbType="NVarChar(50)")]
		public string ani_idade
		{
			get
			{
				return this._ani_idade;
			}
			set
			{
				if ((this._ani_idade != value))
				{
					this.Onani_idadeChanging(value);
					this.SendPropertyChanging();
					this._ani_idade = value;
					this.SendPropertyChanged("ani_idade");
					this.Onani_idadeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ani_alergia", DbType="VarChar(50)")]
		public string ani_alergia
		{
			get
			{
				return this._ani_alergia;
			}
			set
			{
				if ((this._ani_alergia != value))
				{
					this.Onani_alergiaChanging(value);
					this.SendPropertyChanging();
					this._ani_alergia = value;
					this.SendPropertyChanged("ani_alergia");
					this.Onani_alergiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ani_cliente", DbType="VarChar(50)")]
		public string ani_cliente
		{
			get
			{
				return this._ani_cliente;
			}
			set
			{
				if ((this._ani_cliente != value))
				{
					this.Onani_clienteChanging(value);
					this.SendPropertyChanging();
					this._ani_cliente = value;
					this.SendPropertyChanged("ani_cliente");
					this.Onani_clienteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ani_raca", DbType="VarChar(50)")]
		public string ani_raca
		{
			get
			{
				return this._ani_raca;
			}
			set
			{
				if ((this._ani_raca != value))
				{
					this.Onani_racaChanging(value);
					this.SendPropertyChanging();
					this._ani_raca = value;
					this.SendPropertyChanged("ani_raca");
					this.Onani_racaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ani_foto", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary ani_foto
		{
			get
			{
				return this._ani_foto;
			}
			set
			{
				if ((this._ani_foto != value))
				{
					this.Onani_fotoChanging(value);
					this.SendPropertyChanging();
					this._ani_foto = value;
					this.SendPropertyChanged("ani_foto");
					this.Onani_fotoChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_cadcliente")]
	public partial class tb_cadcliente : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _cli_nome;
		
		private int _cli_codigo;
		
		private string _cli_celular;
		
		private string _cli_email;
		
		private string _cli_cpf;
		
		private string _cli_endereco;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Oncli_nomeChanging(string value);
    partial void Oncli_nomeChanged();
    partial void Oncli_codigoChanging(int value);
    partial void Oncli_codigoChanged();
    partial void Oncli_celularChanging(string value);
    partial void Oncli_celularChanged();
    partial void Oncli_emailChanging(string value);
    partial void Oncli_emailChanged();
    partial void Oncli_cpfChanging(string value);
    partial void Oncli_cpfChanged();
    partial void Oncli_enderecoChanging(string value);
    partial void Oncli_enderecoChanged();
    #endregion
		
		public tb_cadcliente()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cli_nome", DbType="VarChar(50)")]
		public string cli_nome
		{
			get
			{
				return this._cli_nome;
			}
			set
			{
				if ((this._cli_nome != value))
				{
					this.Oncli_nomeChanging(value);
					this.SendPropertyChanging();
					this._cli_nome = value;
					this.SendPropertyChanged("cli_nome");
					this.Oncli_nomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cli_codigo", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int cli_codigo
		{
			get
			{
				return this._cli_codigo;
			}
			set
			{
				if ((this._cli_codigo != value))
				{
					this.Oncli_codigoChanging(value);
					this.SendPropertyChanging();
					this._cli_codigo = value;
					this.SendPropertyChanged("cli_codigo");
					this.Oncli_codigoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cli_celular", DbType="NVarChar(50)")]
		public string cli_celular
		{
			get
			{
				return this._cli_celular;
			}
			set
			{
				if ((this._cli_celular != value))
				{
					this.Oncli_celularChanging(value);
					this.SendPropertyChanging();
					this._cli_celular = value;
					this.SendPropertyChanged("cli_celular");
					this.Oncli_celularChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cli_email", DbType="VarChar(50)")]
		public string cli_email
		{
			get
			{
				return this._cli_email;
			}
			set
			{
				if ((this._cli_email != value))
				{
					this.Oncli_emailChanging(value);
					this.SendPropertyChanging();
					this._cli_email = value;
					this.SendPropertyChanged("cli_email");
					this.Oncli_emailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cli_cpf", DbType="NVarChar(50)")]
		public string cli_cpf
		{
			get
			{
				return this._cli_cpf;
			}
			set
			{
				if ((this._cli_cpf != value))
				{
					this.Oncli_cpfChanging(value);
					this.SendPropertyChanging();
					this._cli_cpf = value;
					this.SendPropertyChanged("cli_cpf");
					this.Oncli_cpfChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cli_endereco", DbType="VarChar(50)")]
		public string cli_endereco
		{
			get
			{
				return this._cli_endereco;
			}
			set
			{
				if ((this._cli_endereco != value))
				{
					this.Oncli_enderecoChanging(value);
					this.SendPropertyChanging();
					this._cli_endereco = value;
					this.SendPropertyChanged("cli_endereco");
					this.Oncli_enderecoChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_servico")]
	public partial class tb_servico : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _serv_codigo;
		
		private string _serv_descricao;
		
		private string _serv_preco;
		
		private string _serv_tempo;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onserv_codigoChanging(int value);
    partial void Onserv_codigoChanged();
    partial void Onserv_descricaoChanging(string value);
    partial void Onserv_descricaoChanged();
    partial void Onserv_precoChanging(string value);
    partial void Onserv_precoChanged();
    partial void Onserv_tempoChanging(string value);
    partial void Onserv_tempoChanged();
    #endregion
		
		public tb_servico()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_serv_codigo", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int serv_codigo
		{
			get
			{
				return this._serv_codigo;
			}
			set
			{
				if ((this._serv_codigo != value))
				{
					this.Onserv_codigoChanging(value);
					this.SendPropertyChanging();
					this._serv_codigo = value;
					this.SendPropertyChanged("serv_codigo");
					this.Onserv_codigoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_serv_descricao", DbType="VarChar(50)")]
		public string serv_descricao
		{
			get
			{
				return this._serv_descricao;
			}
			set
			{
				if ((this._serv_descricao != value))
				{
					this.Onserv_descricaoChanging(value);
					this.SendPropertyChanging();
					this._serv_descricao = value;
					this.SendPropertyChanged("serv_descricao");
					this.Onserv_descricaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_serv_preco", DbType="NVarChar(50)")]
		public string serv_preco
		{
			get
			{
				return this._serv_preco;
			}
			set
			{
				if ((this._serv_preco != value))
				{
					this.Onserv_precoChanging(value);
					this.SendPropertyChanging();
					this._serv_preco = value;
					this.SendPropertyChanged("serv_preco");
					this.Onserv_precoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_serv_tempo", DbType="VarChar(50)")]
		public string serv_tempo
		{
			get
			{
				return this._serv_tempo;
			}
			set
			{
				if ((this._serv_tempo != value))
				{
					this.Onserv_tempoChanging(value);
					this.SendPropertyChanging();
					this._serv_tempo = value;
					this.SendPropertyChanged("serv_tempo");
					this.Onserv_tempoChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_raca")]
	public partial class tb_raca : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _raca_codigo;
		
		private string _raca_nome;
		
		private string _raca_pais_origem;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onraca_codigoChanging(int value);
    partial void Onraca_codigoChanged();
    partial void Onraca_nomeChanging(string value);
    partial void Onraca_nomeChanged();
    partial void Onraca_pais_origemChanging(string value);
    partial void Onraca_pais_origemChanged();
    #endregion
		
		public tb_raca()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_raca_codigo", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int raca_codigo
		{
			get
			{
				return this._raca_codigo;
			}
			set
			{
				if ((this._raca_codigo != value))
				{
					this.Onraca_codigoChanging(value);
					this.SendPropertyChanging();
					this._raca_codigo = value;
					this.SendPropertyChanged("raca_codigo");
					this.Onraca_codigoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_raca_nome", DbType="VarChar(50)")]
		public string raca_nome
		{
			get
			{
				return this._raca_nome;
			}
			set
			{
				if ((this._raca_nome != value))
				{
					this.Onraca_nomeChanging(value);
					this.SendPropertyChanging();
					this._raca_nome = value;
					this.SendPropertyChanged("raca_nome");
					this.Onraca_nomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_raca_pais_origem", DbType="VarChar(50)")]
		public string raca_pais_origem
		{
			get
			{
				return this._raca_pais_origem;
			}
			set
			{
				if ((this._raca_pais_origem != value))
				{
					this.Onraca_pais_origemChanging(value);
					this.SendPropertyChanging();
					this._raca_pais_origem = value;
					this.SendPropertyChanged("raca_pais_origem");
					this.Onraca_pais_origemChanged();
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
