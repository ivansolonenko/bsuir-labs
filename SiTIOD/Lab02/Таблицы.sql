USE [master]
GO

CREATE DATABASE [SiTIOD.Lab02] ON  PRIMARY 
( NAME = N'SiTIOD_Lab02', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\SiTIOD_Lab02.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SiTIOD_Lab02_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\SiTIOD_Lab02_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

USE [SiTIOD.Lab02]
GO

/****** Object:  Table [dbo].[T_Citizenship] ******/

CREATE TABLE [dbo].[T_Citizenship](
	[citizenship_id] [int] IDENTITY(1,1) NOT NULL,
	[citizenship_title] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_T_Citizenship] PRIMARY KEY CLUSTERED 
(
	[citizenship_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[T_Region] ******/

CREATE TABLE [dbo].[T_Region](
	[region_id] [int] IDENTITY(1,1) NOT NULL,
	[region_title] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_T_Region] PRIMARY KEY CLUSTERED 
(
	[region_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[T_Department] ******/

CREATE TABLE [dbo].[T_Department](
	[department_id] [int] IDENTITY(1,1) NOT NULL,
	[department_title] [nvarchar](50) NOT NULL,
	[region_id] [int] NOT NULL,
 CONSTRAINT [PK_T_Department] PRIMARY KEY CLUSTERED 
(
	[department_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[T_Department]  WITH CHECK ADD  CONSTRAINT [FK_T_Department_T_Region] FOREIGN KEY([region_id])
REFERENCES [dbo].[T_Region] ([region_id])
GO

ALTER TABLE [dbo].[T_Department] CHECK CONSTRAINT [FK_T_Department_T_Region]
GO

/****** Object:  Table [dbo].[T_HiringDismissal] ******/

CREATE TABLE [dbo].[T_HiringDismissal](
	[hiringdismissal_id] [int] IDENTITY(1,1) NOT NULL,
	[hiring_date] [datetime] NOT NULL,
	[dismissal_date] [datetime] NOT NULL,
 CONSTRAINT [PK_T_HiringDismissal] PRIMARY KEY CLUSTERED 
(
	[hiringdismissal_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[T_Employee] ******/

CREATE TABLE [dbo].[T_Employee](
	[employee_id] [int] IDENTITY(1,1) NOT NULL,
	[hiringdismissal_id] [int] NOT NULL,
	[employee_surname] [nvarchar](50) NOT NULL,
	[employee_name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_T_Employee] PRIMARY KEY CLUSTERED 
(
	[employee_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[T_Employee]  WITH CHECK ADD  CONSTRAINT [FK_T_Employee_HiringDismissal] FOREIGN KEY([hiringdismissal_id])
REFERENCES [dbo].[T_HiringDismissal] ([hiringdismissal_id])
GO

ALTER TABLE [dbo].[T_Employee] CHECK CONSTRAINT [FK_T_Employee_HiringDismissal]
GO

/****** Object:  Table [dbo].[T_Occupation] ******/

CREATE TABLE [dbo].[T_Occupation](
	[occupation_id] [int] IDENTITY(1,1) NOT NULL,
	[occupation_title] [nvarchar](50) NOT NULL,
	[occupation_rate] [int] NOT NULL,
 CONSTRAINT [PK_T_Occupation] PRIMARY KEY CLUSTERED 
(
	[occupation_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[T_PreviousWorkPlace] ******/

CREATE TABLE [dbo].[T_PreviousWorkPlace](
	[previousworkplace_id] [int] IDENTITY(1,1) NOT NULL,
	[previousworkplace_title] [nvarchar](50) NOT NULL,
	[previousworkplace_years] [int] NOT NULL,
 CONSTRAINT [PK_T_PreviousWorkPlace] PRIMARY KEY CLUSTERED 
(
	[previousworkplace_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[T_SocialStatus] ******/

CREATE TABLE [dbo].[T_SocialStatus](
	[socialstatus_id] [int] IDENTITY(1,1) NOT NULL,
	[socialstatus_title] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_T_SocialStatus] PRIMARY KEY CLUSTERED 
(
	[socialstatus_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[T_WorkingExperience] ******/

CREATE TABLE [dbo].[T_WorkingExperience](
	[workingexperience_id] [int] IDENTITY(1,1) NOT NULL,
	[workingexperience_years] [int] NOT NULL,
 CONSTRAINT [PK_T_WorkingExperience] PRIMARY KEY CLUSTERED 
(
	[workingexperience_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Facts] ******/

CREATE TABLE [dbo].[Facts](
	[citizenship_id] [int] NOT NULL,
	[department_id] [int] NOT NULL,
	[employee_id] [int] NOT NULL,
	[occupation_id] [int] NOT NULL,
	[previousworkplace_id] [int] NOT NULL,
	[socialstatus_id] [int] NOT NULL,
	[workingexperience_id] [int] NOT NULL,
	[age] [int] NOT NULL,
	[vacationdays_total] [int] NOT NULL,
	[vacationdays_available] [int] NOT NULL,
	[vacationdays_spent] [int] NOT NULL,
	[sickdays_thisyear] [int] NOT NULL,
	[rebukes_amount] [int] NOT NULL,
	[businesstrips_amount] [int] NOT NULL,
 CONSTRAINT [PK_Facts] PRIMARY KEY CLUSTERED 
(
	[citizenship_id] ASC,
	[department_id] ASC,
	[employee_id] ASC,
	[occupation_id] ASC,
	[previousworkplace_id] ASC,
	[socialstatus_id] ASC,
	[workingexperience_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Facts]  WITH CHECK ADD  CONSTRAINT [FK_Facts_Citizenship] FOREIGN KEY([citizenship_id])
REFERENCES [dbo].[T_Citizenship] ([citizenship_id])
GO

ALTER TABLE [dbo].[Facts] CHECK CONSTRAINT [FK_Facts_Citizenship]
GO

ALTER TABLE [dbo].[Facts]  WITH CHECK ADD  CONSTRAINT [FK_Facts_Department] FOREIGN KEY([department_id])
REFERENCES [dbo].[T_Department] ([department_id])
GO

ALTER TABLE [dbo].[Facts] CHECK CONSTRAINT [FK_Facts_Department]
GO

ALTER TABLE [dbo].[Facts]  WITH CHECK ADD  CONSTRAINT [FK_Facts_Employee] FOREIGN KEY([employee_id])
REFERENCES [dbo].[T_Employee] ([employee_id])
GO

ALTER TABLE [dbo].[Facts] CHECK CONSTRAINT [FK_Facts_Employee]
GO

ALTER TABLE [dbo].[Facts]  WITH CHECK ADD  CONSTRAINT [FK_Facts_Occupation] FOREIGN KEY([occupation_id])
REFERENCES [dbo].[T_Occupation] ([occupation_id])
GO

ALTER TABLE [dbo].[Facts] CHECK CONSTRAINT [FK_Facts_Occupation]
GO

ALTER TABLE [dbo].[Facts]  WITH CHECK ADD  CONSTRAINT [FK_Facts_PreviousWorkPlace] FOREIGN KEY([previousworkplace_id])
REFERENCES [dbo].[T_PreviousWorkPlace] ([previousworkplace_id])
GO

ALTER TABLE [dbo].[Facts] CHECK CONSTRAINT [FK_Facts_PreviousWorkPlace]
GO

ALTER TABLE [dbo].[Facts]  WITH CHECK ADD  CONSTRAINT [FK_Facts_SocialStatus] FOREIGN KEY([socialstatus_id])
REFERENCES [dbo].[T_SocialStatus] ([socialstatus_id])
GO

ALTER TABLE [dbo].[Facts] CHECK CONSTRAINT [FK_Facts_SocialStatus]
GO

ALTER TABLE [dbo].[Facts]  WITH CHECK ADD  CONSTRAINT [FK_Facts_WorkingExperience] FOREIGN KEY([workingexperience_id])
REFERENCES [dbo].[T_WorkingExperience] ([workingexperience_id])
GO

ALTER TABLE [dbo].[Facts] CHECK CONSTRAINT [FK_Facts_WorkingExperience]
GO
