USE [EFDb]
GO
/****** Object:  Table [dbo].[City]    Script Date: 2018/05/10 18:15:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[City](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[ParentId] [int] NULL,
 CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Rainfall]    Script Date: 2018/05/10 18:15:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rainfall](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CityId] [int] NOT NULL,
	[RainfallValue] [int] NOT NULL,
	[Count] [int] NOT NULL,
	[PrecipitationTime] [datetime] NOT NULL,
 CONSTRAINT [PK_Rainfall] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[City] ON 

INSERT [dbo].[City] ([Id], [Name], [ParentId]) VALUES (1, N'亚洲', NULL)
INSERT [dbo].[City] ([Id], [Name], [ParentId]) VALUES (2, N'中国', 1)
INSERT [dbo].[City] ([Id], [Name], [ParentId]) VALUES (3, N'广东省', 2)
INSERT [dbo].[City] ([Id], [Name], [ParentId]) VALUES (4, N'浙江省', 2)
INSERT [dbo].[City] ([Id], [Name], [ParentId]) VALUES (5, N'广州', 3)
INSERT [dbo].[City] ([Id], [Name], [ParentId]) VALUES (6, N'深圳', 3)
INSERT [dbo].[City] ([Id], [Name], [ParentId]) VALUES (7, N'杭州', 4)
INSERT [dbo].[City] ([Id], [Name], [ParentId]) VALUES (8, N'宁波', 4)
INSERT [dbo].[City] ([Id], [Name], [ParentId]) VALUES (9, N'天河', 5)
INSERT [dbo].[City] ([Id], [Name], [ParentId]) VALUES (10, N'宝安', 6)
INSERT [dbo].[City] ([Id], [Name], [ParentId]) VALUES (11, N'上城区', 7)
INSERT [dbo].[City] ([Id], [Name], [ParentId]) VALUES (12, N'下城区', 7)
INSERT [dbo].[City] ([Id], [Name], [ParentId]) VALUES (13, N'江东区', 8)
INSERT [dbo].[City] ([Id], [Name], [ParentId]) VALUES (14, N'江北区', 8)
INSERT [dbo].[City] ([Id], [Name], [ParentId]) VALUES (15, N'非洲', 0)
INSERT [dbo].[City] ([Id], [Name], [ParentId]) VALUES (21, N'欧洲', 0)
INSERT [dbo].[City] ([Id], [Name], [ParentId]) VALUES (22, N'清远', 3)
INSERT [dbo].[City] ([Id], [Name], [ParentId]) VALUES (23, N'白云区', 5)
INSERT [dbo].[City] ([Id], [Name], [ParentId]) VALUES (24, N'海珠区', 5)
INSERT [dbo].[City] ([Id], [Name], [ParentId]) VALUES (25, N'龙岗区', 6)
INSERT [dbo].[City] ([Id], [Name], [ParentId]) VALUES (26, N'福田区', 6)
INSERT [dbo].[City] ([Id], [Name], [ParentId]) VALUES (27, N'清城区', 22)
INSERT [dbo].[City] ([Id], [Name], [ParentId]) VALUES (28, N'佛岗区', 22)
INSERT [dbo].[City] ([Id], [Name], [ParentId]) VALUES (29, N'阳山', 22)
INSERT [dbo].[City] ([Id], [Name], [ParentId]) VALUES (30, N'西湖区', 7)
INSERT [dbo].[City] ([Id], [Name], [ParentId]) VALUES (32, N'北仑区', 8)
SET IDENTITY_INSERT [dbo].[City] OFF
SET IDENTITY_INSERT [dbo].[Rainfall] ON 

INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (1, 9, 100, 10, CAST(N'2018-05-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (2, 23, 80, 8, CAST(N'2018-04-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (3, 24, 75, 7, CAST(N'2018-03-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (4, 10, 80, 5, CAST(N'2018-02-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (5, 25, 100, 3, CAST(N'2018-01-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (6, 26, 110, 2, CAST(N'2017-12-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (7, 27, 70, 1, CAST(N'2017-11-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (8, 28, 60, 20, CAST(N'2017-10-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (9, 29, 55, 2, CAST(N'2017-09-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (10, 11, 40, 4, CAST(N'2017-08-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (11, 12, 30, 9, CAST(N'2017-07-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (12, 30, 55, 7, CAST(N'2017-06-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (13, 13, 20, 3, CAST(N'2017-05-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (14, 14, 30, 13, CAST(N'2017-04-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (15, 32, 40, 2, CAST(N'2017-03-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (16, 23, 30, 2, CAST(N'2017-02-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (17, 23, 10, 3, CAST(N'2017-05-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (18, 23, 21, 2, CAST(N'2017-08-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (19, 23, 32, 5, CAST(N'2017-11-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (20, 23, 24, 1, CAST(N'2018-02-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (21, 24, 8, 9, CAST(N'2017-02-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (22, 24, 13, 4, CAST(N'2017-05-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (23, 24, 14, 1, CAST(N'2017-08-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (24, 24, 33, 2, CAST(N'2018-05-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (25, 9, 16, 2, CAST(N'2017-02-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (26, 9, 30, 3, CAST(N'2017-05-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (27, 9, 40, 1, CAST(N'2017-08-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (28, 9, 26, 5, CAST(N'2017-11-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (29, 9, 27, 4, CAST(N'2018-02-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (30, 24, 28, 1, CAST(N'2017-11-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (31, 28, 11, 1, CAST(N'2017-02-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (32, 28, 22, 1, CAST(N'2017-05-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (33, 28, 33, 2, CAST(N'2017-08-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (34, 28, 19, 2, CAST(N'2018-02-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (35, 28, 17, 2, CAST(N'2018-05-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (36, 27, 13, 2, CAST(N'2017-05-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (37, 27, 13, 1, CAST(N'2017-02-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (38, 27, 21, 1, CAST(N'2017-11-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (39, 27, 21, 3, CAST(N'2018-02-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (40, 27, 21, 2, CAST(N'2018-05-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (41, 29, 9, 8, CAST(N'2017-02-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (42, 29, 10, 2, CAST(N'2017-05-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (43, 29, 9, 9, CAST(N'2017-11-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (44, 29, 5, 10, CAST(N'2018-02-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (45, 29, 10, 5, CAST(N'2018-05-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (46, 10, 13, 5, CAST(N'2017-02-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (47, 10, 26, 3, CAST(N'2017-05-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (48, 10, 26, 2, CAST(N'2017-08-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (49, 10, 22, 2, CAST(N'2017-11-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (50, 10, 30, 2, CAST(N'2018-05-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (51, 26, 19, 2, CAST(N'2017-02-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (52, 26, 19, 5, CAST(N'2017-05-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (53, 26, 22, 1, CAST(N'2017-08-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (54, 26, 15, 2, CAST(N'2018-02-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (55, 26, 30, 5, CAST(N'2018-05-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (56, 25, 15, 6, CAST(N'2017-02-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (57, 25, 20, 3, CAST(N'2017-02-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (58, 25, 20, 3, CAST(N'2017-05-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (59, 25, 30, 2, CAST(N'2017-08-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (60, 25, 40, 1, CAST(N'2017-11-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (61, 25, 26, 1, CAST(N'2018-05-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (62, 11, 25, 1, CAST(N'2017-02-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (63, 11, 23, 2, CAST(N'2017-05-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (64, 11, 19, 3, CAST(N'2017-11-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (65, 11, 22, 3, CAST(N'2018-02-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (66, 11, 29, 3, CAST(N'2018-05-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (67, 30, 30, 3, CAST(N'2018-05-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (68, 30, 35, 1, CAST(N'2018-02-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (69, 30, 26, 2, CAST(N'2017-11-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (70, 30, 22, 4, CAST(N'2017-05-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (71, 30, 21, 2, CAST(N'2017-02-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (72, 12, 20, 2, CAST(N'2017-02-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (73, 12, 20, 3, CAST(N'2017-05-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (74, 12, 28, 2, CAST(N'2018-02-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (75, 12, 23, 4, CAST(N'2018-05-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (76, 32, 23, 1, CAST(N'2017-05-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (77, 32, 29, 2, CAST(N'2017-08-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (78, 32, 18, 3, CAST(N'2017-11-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (79, 32, 30, 2, CAST(N'2018-02-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (80, 32, 31, 1, CAST(N'2018-05-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (81, 14, 27, 1, CAST(N'2018-05-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (82, 14, 24, 2, CAST(N'2018-02-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (84, 14, 30, 2, CAST(N'2017-11-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (85, 14, 23, 2, CAST(N'2017-08-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (86, 14, 24, 3, CAST(N'2017-02-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (87, 13, 24, 3, CAST(N'2017-02-22T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (88, 13, 20, 5, CAST(N'2017-08-22T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (89, 13, 29, 2, CAST(N'2017-11-22T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (90, 13, 18, 4, CAST(N'2017-02-22T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (91, 13, 24, 5, CAST(N'2017-05-22T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (92, 13, 24, 5, CAST(N'2018-05-22T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (93, 13, 26, 3, CAST(N'2018-02-22T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (94, 27, 22, 3, CAST(N'2017-08-22T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (95, 30, 27, 2, CAST(N'2017-08-22T00:00:00.000' AS DateTime))
INSERT [dbo].[Rainfall] ([Id], [CityId], [RainfallValue], [Count], [PrecipitationTime]) VALUES (96, 12, 23, 4, CAST(N'2017-11-22T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Rainfall] OFF
ALTER TABLE [dbo].[City] ADD  CONSTRAINT [DF_City_ParentId]  DEFAULT ((0)) FOR [ParentId]
GO
