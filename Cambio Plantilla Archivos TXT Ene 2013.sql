select cl.Nombre_Comercial, cb.*  
from Pro_CajasBancarias as cb
join Cat_Clientes as cl on cl.Id_Cliente = cb.Id_Cliente 
where cl.Clave_Cliente IN('9','10','11') 
ORDER BY cl.Clave_Cliente

alter table Pro_CajasBancarias add Tipo_Archivo varchar(10) null
alter table Pro_CajasBancarias add Clave_ProveedorArchivo varchar(10) null

update Pro_CajasBancarias set tipo_archivo='AFIRME', CLAVE_PROVEEDORARCHIVO='21', CR='815', Numero_Plaza ='', Digito_Seguro ='N' WHERE Id_CajaBancaria = 24
update Pro_CajasBancarias set tipo_archivo='BANORTE', CLAVE_PROVEEDORARCHIVO='', Numero_Plaza ='', Digito_Seguro ='N' WHERE Id_CajaBancaria = 17
update Pro_CajasBancarias set tipo_archivo='BANREGIO', CLAVE_PROVEEDORARCHIVO='' WHERE Id_CajaBancaria = 18


Alter PROCEDURE pro_Archivos_GetNombre
(
	@Id_CajaBancaria	Numeric,
	@Fecha_Aplicacion	Datetime,
	@Id_Cia				Numeric
)
As
Begin

	Declare	@Numero_Archivo		Numeric,
			@Numero_Proceso		Numeric,
			@Clave_CIA			Varchar(12),
			@Numero_Plaza		Varchar(10),
			@DigitoSeguro		Varchar,
			@Cia_Param			Numeric,
			@CR					Varchar(6),
			@Tipo_Referencia	Varchar(2),
			@Longitud_Referencia Int,
			@Tipo_Archivo		Varchar(10),
			@Clave_ProveedorArchivo Varchar(10)
	
	Set @Cia_param = (Select Top 1 Id_Cia From Cat_ParametrosG)
	
	If @Cia_Param = @Id_Cia
		Begin	
			Select	@Numero_Archivo = IsNull(Max(Numero_Archivo), 0) + 1
			From	Pro_Archivos
			Where	Id_CajaBancaria = @Id_CajaBancaria
			And		Convert(Varchar(10), Fecha_Aplicacion, 102)	= Convert(Varchar(10), @Fecha_Aplicacion, 102)
			And		Id_Cia = @Id_Cia 
		End
	Else
		Begin
			Select	@Numero_Archivo = IsNull(Max(Numero_Archivo), 0) + 1
			From	Pro_Archivos
			Where	Id_CajaBancaria = @Id_CajaBancaria
			And		Convert(Varchar(10), Fecha_Aplicacion, 102)	=	Convert(Varchar(10), @Fecha_Aplicacion, 102)		
			And		Id_Cia <> @Id_Cia 
		End
	
	Select	@Numero_Proceso	= IsNull(Max(Num_Proceso), 0) + 1
	From	Pro_Archivos
	
	Select	@Clave_CIA		=	cb.Clave_CiaB
	From	Cat_CiasB			cb
	Join	Pro_CajasBancarias	b	On	b.Id_Banco = cb.Id_Banco
	Where	b.Id_CajaBancaria	= @Id_CajaBancaria
	And		cb.Id_Cia			= @Id_Cia
	
	Select	@Numero_Plaza			= IsNull(Numero_Plaza, ''),
			@DigitoSeguro			= IsNull(Digito_Seguro, 'N'),
			@CR						= IsNull(CR, ''),
			@Tipo_Referencia		= IsNull(Tipo_ReferenciaDepo, 'N'),
			@Longitud_Referencia	= IsNull(Longitud_ReferenciaDepo, 10),
			@Tipo_Archivo			= IsNull(Tipo_Archivo,''),
			@Clave_ProveedorArchivo = IsNull(Clave_ProveedorArchivo, '')
	From	Pro_CajasBancarias
	Where	Id_CajaBancaria	=	@Id_CajaBancaria
		
	Select  @Numero_Archivo			As	Numero,
			@Numero_Proceso			As	NumeroP,
			@Fecha_Aplicacion		As	Fecha,
			isnull(@Clave_CIA,'')	As	Cia,
			@Numero_Plaza			As	Numero_Plaza,
			@DigitoSeguro			AS	DigitoSeguro,
			@CR						As	CR,
			@Tipo_Referencia		As	Tipo_Referencia,
			@Longitud_Referencia	As	Longitud_Referencia,
			@Tipo_Archivo			As  Tipo_Archivo,
			@Clave_ProveedorArchivo As  Clave_ProveedorArchivo
		
End