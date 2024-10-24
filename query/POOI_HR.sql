USE [bd_hr]
GO
/****** Object:  StoredProcedure [dbo].[USP_COUNTRIES_CRUD]    Script Date: 16/10/2024 21:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[USP_COUNTRIES_CRUD]  
@indicador varchar(30),  
@country_id char(2),  
@country_name varchar(40),  
@region_id int  
as  
begin  
  
 -- Insertar   
 IF @indicador = 'Insertar'  
 Begin  
  INSERT INTO countries(country_id, country_name, region_id)  
  values (@country_id, @country_name, @region_id)  
  --PRINT 'Insercion'  
 End  
 -- Eliminar (AR)  
 IF @indicador = 'Eliminar'  
 Begin  
  Delete from countries where country_id= @country_id  
  --PRINT 'Eliminar'  
 End  
  
 -- Actualizar (AR)  
 IF @indicador = 'Actualizar'  
 Begin  
  Update countries  
  set country_name=@country_name, region_id=@region_id   
  WHERE country_id= @country_id  
  --PRINT 'Actualizar'  
 End  
 -- Consultar por Id (AR)  
 IF @indicador = 'ConsultarXId'  
 Begin  
  select country_id, country_name, region_id   
  from countries where country_id=@country_id  
  --PRINT 'ConsultarXId'  
 End  
  
 -- Consultar Todo  
 IF @indicador = 'ConsultarTodo'  
 Begin  
  select country_id, country_name, region_id from countries  
  --PRINT 'ConsultarTodo'  
 End  
end  

GO
/****** Object:  StoredProcedure [dbo].[usp_formulario_combo]    Script Date: 16/10/2024 21:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_formulario_combo]
@indicador varchar(50)
as
begin

	if @indicador='comboRegion'
	begin
		select region_id as combo_id, region_name as combo_name from regions
	end
	if @indicador='comboDepartamento'
	begin
		select department_id as combo_id, department_name as combo_name from departments
	end
	if @indicador='comboTrabajo'
	begin
		select job_id as combo_id, job_title as combo_name from jobs 
	end
end
GO
/****** Object:  StoredProcedure [dbo].[usp_formulario_combo_AllInOne]    Script Date: 16/10/2024 21:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[usp_formulario_combo_AllInOne]
as
begin

	Declare @table table(
		combo_identificador varchar(50),
		combo_id int,
		combo_name varchar(50)
	)

	insert into @table(combo_identificador,combo_id, combo_name)
	select 'COMBO_REGION',  region_id , region_name  from regions

	insert into @table(combo_identificador,combo_id, combo_name)
	select 'COMBO_DEPARTAMENTO', department_id , department_name  from departments

	insert into @table(combo_identificador, combo_id, combo_name)
	select 'COMBO_TRABAJO', job_id , job_title  from jobs 
	
	select combo_identificador, combo_id, combo_name from @table

end
GO
/****** Object:  StoredProcedure [dbo].[usp_pais_busqueda]    Script Date: 16/10/2024 21:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[usp_pais_busqueda]
@country_name varchar(2),
@region_id int
as
begin
	select country_id, country_name, region_id
		from countries
	where
	country_name like CONCAT(@country_name,'%') and
	region_id= @region_id
end
GO
/****** Object:  StoredProcedure [dbo].[usp_paises_crud]    Script Date: 16/10/2024 21:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[usp_paises_crud]
@indicador varchar(40),
@country_id char(2), 
@country_name varchar(40), 
@region_id int
as
begin
	
	if @indicador = 'Insertar'
	Begin
	-- Insercion
	insert into countries(country_id, country_name, region_id)
	values (@country_id, @country_name, @region_id)
	End

	if @indicador = 'Eliminar'
	Begin
	delete from countries where country_id= @country_id
	End



	if @indicador ='Actualizar'
	begin
		update countries set country_name= @country_name, region_id=@region_id 
		where country_id=@country_id
	end

	if @indicador = 'ConsultarXId'
	Begin
		select country_id, country_name, region_id from countries 
		where country_id= @country_id
	End

	if @indicador ='ConsultarTodo'
	Begin
		select country_id, country_name, region_id  from countries
	End

end
GO
/****** Object:  StoredProcedure [dbo].[usp_persona_crud]    Script Date: 16/10/2024 21:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create   procedure [dbo].[usp_persona_crud]
@indicador varchar(40),
@codigo int,
@nombre varchar(40),
@apellido varchar(40),
@correo varchar(100)
as
begin

if @indicador= 'consultar'
begin
	SELECT [codigo]
      ,[nombre]
      ,[apellido]
      ,[correo]
  FROM [dbo].[Personas]
end

if @indicador = 'insertar'
begin
	INSERT INTO dbo.Personas (codigo, nombre, apellido, correo)
	VALUES (@codigo, @nombre, @apellido, @correo)
end

if @indicador = 'getXId'
begin
	select codigo, nombre,apellido, correo from Personas where codigo=@codigo
end

end
GO
/****** Object:  StoredProcedure [dbo].[usp_prueba_listar]    Script Date: 16/10/2024 21:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[usp_prueba_listar]
@nombrePais varchar(40),
@nombreRegion varchar(40)
as
begin
	select r.region_id, r.region_name,
		c.country_id, c.country_name
		from countries c inner join regions r
				on c.region_id=r.region_id
		where 
		(@nombrePais ='' or c.country_name like Concat(@nombrePais,'%')) 
		and (@nombreRegion ='' or r.region_name like Concat(@nombreRegion,'%')) 

end
GO
/****** Object:  StoredProcedure [dbo].[usp_region_crud]    Script Date: 16/10/2024 21:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[usp_region_crud]
@indicador varchar(40),
@region_id INT, 
@region_name varchar(25)
as
begin
	
	if @indicador = 'Insertar'
	Begin
	insert into regions(region_name)
	values (@region_name)
	End

	if @indicador = 'Eliminar'
	Begin
		delete from regions where region_id= @region_id
	End

	if @indicador ='Actualizar'
	begin
		update regions set region_name= @region_name
		where region_id=@region_id
	end

	if @indicador = 'ConsultarXId'
	Begin
		select region_id, region_name  from regions 
		where region_id= @region_id
	End

	if @indicador ='ConsultarTodo'
	Begin
		select region_id, region_name  from regions 
	End

end
GO
