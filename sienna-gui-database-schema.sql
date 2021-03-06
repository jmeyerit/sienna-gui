--READ FIRST
-- Change the "USE [meyer3js]" with the database name you have provided in your own SQL Server instance

USE [meyer3js]
GO
/****** Object:  Table [dbo].[tAddress]    Script Date: 1/22/2017 11:13:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tAddress](
	[AddressID] [int] IDENTITY(1,1) NOT NULL,
	[HouseNumber] [nvarchar](25) NOT NULL,
	[StreetName] [nvarchar](100) NOT NULL,
	[CityID] [int] NOT NULL,
	[StateID] [int] NOT NULL,
 CONSTRAINT [PK_tAddress] PRIMARY KEY CLUSTERED 
(
	[AddressID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tCity]    Script Date: 1/22/2017 11:13:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tCity](
	[CityID] [int] IDENTITY(1,1) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tCity] PRIMARY KEY CLUSTERED 
(
	[CityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tState]    Script Date: 1/22/2017 11:13:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tState](
	[StateID] [int] IDENTITY(1,1) NOT NULL,
	[StateAbr] [nchar](2) NOT NULL,
	[State] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tState] PRIMARY KEY CLUSTERED 
(
	[StateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[tAddress] ON 

GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (43, N'101', N'Church St', 9, 42)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (48, N'1114', N'Wastewater Rd', 10, 42)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (11, N'113', N'East Parkway', 6, 42)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (47, N'1187', N'Lake Dr', 10, 42)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (12, N'119', N'East Parkway', 6, 42)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (46, N'12', N'Hopewell St', 10, 42)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (36, N'1204', N'Clinch Ave', 8, 42)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (45, N'1235', N'Circle Dr', 10, 42)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (49, N'1254', N'Bennington Way', 10, 42)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (60, N'127', N'Pearl St', 5, 33)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (37, N'1458', N'White Ave', 8, 42)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (57, N'1501', N'Cincinnati-Batavia Pike', 11, 1)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (58, N'159', N'South Riverside Dr', 11, 1)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (56, N'1650', N'Cincinnati-Batavia Pike', 11, 1)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (54, N'1773', N'East Ohio Pike', 3, 1)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (50, N'1778', N'East Ohio Pike', 3, 1)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (39, N'1807', N'Cumberland Ave', 8, 42)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (59, N'1816', N'Clough Pike', 11, 1)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (69, N'201', N'East Pascagoula St', 12, 25)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (21, N'204', N'Savage Garden Rd', 6, 42)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (23, N'205', N'Ski Mountain Rd', 6, 42)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (42, N'208', N'Prince St', 9, 42)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (31, N'211', N'Valley Dr', 7, 42)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (40, N'214', N'Cedar St', 9, 42)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (33, N'216', N'Pine Mountain Rd', 7, 42)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (24, N'253', N'Long Branch Rd', 6, 42)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (34, N'2615', N'Teaster Ln', 7, 42)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (8, N'268', N'River Rd', 6, 42)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (9, N'269', N'River Rd', 6, 42)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (63, N'27', N'Washington St', 5, 33)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (10, N'272', N'River Rd', 6, 42)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (30, N'3061', N'Old Mill Ave', 7, 42)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (67, N'315', N'Tombigbee St', 12, 25)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (41, N'317', N'Parkway', 9, 42)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (38, N'331', N'James Agee St', 8, 42)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (44, N'340', N'Forks of the River Parkway', 9, 42)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (53, N'3471', N'Virginia Dr', 3, 1)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (51, N'37', N'Apple Rd', 3, 1)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (66, N'380', N'South Lamar St', 12, 25)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (64, N'40', N'Wall St', 5, 33)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (32, N'403', N'Shirley Ave', 7, 42)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (27, N'408', N'Ownby St', 6, 42)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (29, N'413', N'Ski Mountain Rd', 6, 42)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (55, N'4200', N'Clermont College Dr', 11, 1)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (74, N'428', N'Funston Ave', 13, 7)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (14, N'428', N'Hilltop Rd', 6, 42)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (72, N'4391', N'Fulton St', 13, 7)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (13, N'443', N'Loop Rd', 6, 42)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (52, N'5', N'Chapel Rd', 3, 1)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (16, N'500', N'Historic Nature Trail', 6, 42)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (17, N'501', N'Historic Nature Trail', 6, 42)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (18, N'502', N'Historic Nature Trail', 6, 42)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (19, N'503', N'Historic Nature Trail', 6, 42)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (20, N'504', N'Historic Nature Trail', 6, 42)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (28, N'514', N'Ski Mountain Rd', 6, 42)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (15, N'516', N'Forrest Springs Dr', 6, 42)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (25, N'516', N'Sunset Dr', 6, 42)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (26, N'537', N'Winfield Heights Rd', 6, 42)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (22, N'55', N'M and O St', 6, 42)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (73, N'706', N'Funston Ave', 13, 7)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (68, N'711', N'Tombigbee St', 12, 25)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (71, N'739', N'12th Ave', 13, 7)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (70, N'762', N'Funston Ave', 13, 7)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (35, N'802', N'Cumberland Ave', 8, 42)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (65, N'822', N'South West St', 12, 25)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (61, N'93', N'Pearl St', 5, 33)
GO
INSERT [dbo].[tAddress] ([AddressID], [HouseNumber], [StreetName], [CityID], [StateID]) VALUES (62, N'99', N'Water St', 5, 33)
GO
SET IDENTITY_INSERT [dbo].[tAddress] OFF
GO
SET IDENTITY_INSERT [dbo].[tCity] ON 

GO
INSERT [dbo].[tCity] ([CityID], [City]) VALUES (3, N'Amelia')
GO
INSERT [dbo].[tCity] ([CityID], [City]) VALUES (11, N'Batavia')
GO
INSERT [dbo].[tCity] ([CityID], [City]) VALUES (10, N'Dandridge')
GO
INSERT [dbo].[tCity] ([CityID], [City]) VALUES (6, N'Gatlinburg')
GO
INSERT [dbo].[tCity] ([CityID], [City]) VALUES (12, N'Jackson')
GO
INSERT [dbo].[tCity] ([CityID], [City]) VALUES (8, N'Knoxville')
GO
INSERT [dbo].[tCity] ([CityID], [City]) VALUES (5, N'New York')
GO
INSERT [dbo].[tCity] ([CityID], [City]) VALUES (7, N'Pigeon Forge')
GO
INSERT [dbo].[tCity] ([CityID], [City]) VALUES (13, N'San Francisco')
GO
INSERT [dbo].[tCity] ([CityID], [City]) VALUES (9, N'Sevierville')
GO
SET IDENTITY_INSERT [dbo].[tCity] OFF
GO
SET IDENTITY_INSERT [dbo].[tState] ON 

GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (5, N'AK', N'Alaska')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (4, N'AL', N'Alabama')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (6, N'AR', N'Arizona')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (7, N'CA', N'California')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (8, N'CO', N'Colorado')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (9, N'CT', N'Connecticut')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (11, N'DC', N'District of Columbia')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (10, N'DE', N'Delaware')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (12, N'FL', N'Florida')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (13, N'GA', N'Georgia')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (14, N'HI', N'Hawaii')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (17, N'IA', N'Iowa')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (15, N'ID', N'Idaho')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (16, N'IL', N'Illinois')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (2, N'IN', N'Indiana')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (18, N'KS', N'Kansas')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (3, N'KY', N'Kentucky')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (19, N'LA', N'Louisiana')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (22, N'MA', N'Massachusetts')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (21, N'MD', N'Mayland')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (20, N'ME', N'Maine')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (23, N'MI', N'Michigan')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (24, N'MN', N'Minnesota')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (26, N'MO', N'Missouri')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (25, N'MS', N'Mississippi')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (27, N'MT', N'Montana')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (34, N'NC', N'North Carolina')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (35, N'ND', N'North Dakota')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (28, N'NE', N'Nebraska')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (30, N'NH', N'New Hampshire')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (31, N'NJ', N'New Jersey')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (32, N'NM', N'New Mexico')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (29, N'NV', N'Nevada')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (33, N'NY', N'New York')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (1, N'OH', N'Ohio')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (36, N'OK', N'Oklahoma')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (37, N'OR', N'Oregon')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (38, N'PA', N'Pennsylvania')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (39, N'RI', N'Rhode Island')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (40, N'SC', N'South Carolina')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (41, N'SD', N'South Dakota')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (42, N'TN', N'Tennessee')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (43, N'TX', N'Texas')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (44, N'UT', N'Utah')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (46, N'VA', N'Virginia')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (45, N'VT', N'Vermont')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (47, N'WA', N'Washington')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (49, N'WI', N'Wisconsin')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (48, N'WV', N'West Virginia')
GO
INSERT [dbo].[tState] ([StateID], [StateAbr], [State]) VALUES (50, N'WY', N'Wyoming')
GO
SET IDENTITY_INSERT [dbo].[tState] OFF
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_tAddress]    Script Date: 1/22/2017 11:13:34 AM ******/
ALTER TABLE [dbo].[tAddress] ADD  CONSTRAINT [IX_tAddress] UNIQUE NONCLUSTERED 
(
	[HouseNumber] ASC,
	[StreetName] ASC,
	[CityID] ASC,
	[StateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_tCity]    Script Date: 1/22/2017 11:13:34 AM ******/
ALTER TABLE [dbo].[tCity] ADD  CONSTRAINT [IX_tCity] UNIQUE NONCLUSTERED 
(
	[City] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_tState]    Script Date: 1/22/2017 11:13:34 AM ******/
ALTER TABLE [dbo].[tState] ADD  CONSTRAINT [IX_tState] UNIQUE NONCLUSTERED 
(
	[StateAbr] ASC,
	[State] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tAddress]  WITH CHECK ADD  CONSTRAINT [FK_tAddress_tAddress] FOREIGN KEY([CityID])
REFERENCES [dbo].[tCity] ([CityID])
GO
ALTER TABLE [dbo].[tAddress] CHECK CONSTRAINT [FK_tAddress_tAddress]
GO
ALTER TABLE [dbo].[tAddress]  WITH CHECK ADD  CONSTRAINT [FK_tAddress_tState] FOREIGN KEY([StateID])
REFERENCES [dbo].[tState] ([StateID])
GO
ALTER TABLE [dbo].[tAddress] CHECK CONSTRAINT [FK_tAddress_tState]
GO
