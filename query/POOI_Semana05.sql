
create procedure usp_formulario_combo
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
go

usp_formulario_combo 'comboRegion'
go

usp_formulario_combo 'comboDepartamento'
go

usp_formulario_combo 'comboTrabajo'
go

create OR ALTER procedure usp_formulario_combo_AllInOne
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
go

usp_formulario_combo_AllInOne 