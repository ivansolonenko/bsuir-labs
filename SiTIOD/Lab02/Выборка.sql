USE [SiTIOD.Lab02]
GO

SELECT	t_c.[citizenship_title],
		t_d.[department_title],
		t_e.[employee_name],
		t_e.[employee_surname],
		t_h.[hiring_date],
		t_h.[dismissal_date],
		t_o.[occupation_title],
		t_o.[occupation_rate],
		t_p.[previousworkplace_title],
		t_p.[previousworkplace_years],
		t_r.[region_title],
		t_s.[socialstatus_title],
		t_w.[workingexperience_years],
		f.[age],
		f.[vacationdays_total],
		f.[vacationdays_available],
		f.[vacationdays_spent],
		f.[sickdays_thisyear],
		f.[rebukes_amount],
		f.[businesstrips_amount]
FROM [dbo].[Facts] AS f
INNER JOIN [T_Citizenship] AS t_c ON f.[citizenship_id] = t_c.[citizenship_id]
INNER JOIN [T_Department] AS t_d ON f.[department_id] = t_d.[department_id]
INNER JOIN [T_Employee] AS t_e ON f.[employee_id] = t_e.[employee_id]
INNER JOIN [T_HiringDismissal] AS t_h ON t_e.[hiringdismissal_id] = t_h.[hiringdismissal_id]
INNER JOIN [T_Occupation] AS t_o ON f.[occupation_id] = t_o.[occupation_id]
INNER JOIN [T_PreviousWorkPlace] AS t_p ON f.[previousworkplace_id] = t_p.[previousworkplace_id]
INNER JOIN [T_Region] AS t_r ON t_d.[region_id] = t_r.[region_id]
INNER JOIN [T_SocialStatus] AS t_s ON f.[socialstatus_id] = t_s.[socialstatus_id]
INNER JOIN [T_WorkingExperience] AS t_w ON f.[workingexperience_id] = t_w.[workingexperience_id]
ORDER BY f.[department_id] ASC, f.[employee_id] ASC