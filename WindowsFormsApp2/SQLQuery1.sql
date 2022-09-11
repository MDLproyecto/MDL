use Ke_Fruta

if not exists (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'Usuarios')
create table [dbo].[Usuarios]
(
	[Id_User] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[CI] VARCHAR(8) NOT NULL,
	[Nombres] VARCHAR(50) NOT NULL,
	[Usuario] VARCHAR(50) NOT NULL,
	[Password] VARCHAR(50) NOT NULL,
	[Telefono] VARCHAR(9) NULL,
	[Email] VARCHAR(50) NOT NULL,
	[Tipo_usuario] VARCHAR(50) NULL
)

if not exists (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'Semillas')
create table [dbo].[Semillas]
(
	[Id_Semilla] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[Tipo_De_Semilla] VARCHAR(50) NOT NULL,
	[Precio_X_Kilo] INT NOT NULL,
)

if not exists (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'Compras')
create table [dbo].[Compras]
(
	[Id_Compra] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[Nombre] VARCHAR(50) NOT NULL,
	[Cantidad] INT NOT NULL,
	[Precio] INT NOT NULL,
	[Precio_Final] INT NOT NULL,
	[Fecha_Actual] VARCHAR(9) NOT NULL,
	[Hora_Actual] VARCHAR(8) NOT NULL,
	[Comprador] VARCHAR(10) NOT NULL
)

insert into Usuarios values ('54287596', 'Juan Carlos', 'Juan01', '123','094225538','juan@gmail.com','Admin'),
							('43164362', 'Matias Rodriguez', 'Matias02', '123','094225538','matias@gmail.com','Productor'),
							('76237232', 'Carla Magna', 'Carla03', '123','094225538','Carla@gmail.com','Cliente');

							
insert into Semillas values ('Trigo','250'),
							('Cebada','200'),
							('Limon','400'),
							('Naranja','450'),
							('Manzana','455'),
							('Papa Rosada','300'),
							('Zapallo Criollo','310');



