USE [dbhotelhona]
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'375d0b87-205b-4073-818d-da0025b75df2', N'Admin', N'ADMIN', N'8ced0b53-4fb6-4e13-ae54-3d7b01f15d52')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'609d8ccf-c903-4d6e-acec-33d77ff2bf1a', N'User', N'USER', N'243d9008-7483-43b2-8250-89cd56afea4b')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'04d14f0b-8151-40ca-ad44-5c0b1250c480', N'client@gmail.com', N'CLIENT@GMAIL.COM', N'client@gmail.com', N'CLIENT@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEDSWUTBHFqvaM0bjbOMuAI9APxtaTFZNZmAVd9QHX39UZd3Y4f8ow4NN9FdrZvrh0w==', N'CXG27ZVD5QUX3Y7DHVNKPITUB6IRBBHI', N'6f5a9bf4-5ba7-448c-b12e-c9353aed9942', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'e880d66b-c751-45bc-b36f-ecae2bc28b9c', N'admin@admin.com', N'ADMIN@ADMIN.COM', N'admin@admin.com', N'ADMIN@ADMIN.COM', 1, N'AQAAAAEAACcQAAAAENourBIP2FzAuwzi75F3Isqa4oJrYogQlm130xaE6/9QKZvtPUdORm8huCNyXAt7LA==', N'2VTQ6QKUHOTAXAU76SAAP5GAAVYSDZU4', N'fc59b622-a092-4f34-babf-c450e41904ad', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e880d66b-c751-45bc-b36f-ecae2bc28b9c', N'375d0b87-205b-4073-818d-da0025b75df2')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'04d14f0b-8151-40ca-ad44-5c0b1250c480', N'609d8ccf-c903-4d6e-acec-33d77ff2bf1a')
SET IDENTITY_INSERT [dbo].[tbclient] ON 

INSERT [dbo].[tbclient] ([id], [identification], [name], [lastname], [email]) VALUES (1, CAST(123456789 AS Numeric(15, 0)), N'System', N'Admin', N'system@admin.com')
INSERT [dbo].[tbclient] ([id], [identification], [name], [lastname], [email]) VALUES (2, CAST(888888888 AS Numeric(15, 0)), N'Anthony', N'Salazar Araya', N'asalazar0592@gmail.com')
INSERT [dbo].[tbclient] ([id], [identification], [name], [lastname], [email]) VALUES (3, CAST(304480039 AS Numeric(15, 0)), N'Néstor', N'Sánchez', N'nestorsg1@hotmail.com')
INSERT [dbo].[tbclient] ([id], [identification], [name], [lastname], [email]) VALUES (4, CAST(702020722 AS Numeric(15, 0)), N'mario', N'salas m', N'mma1323@hotmail.com')
INSERT [dbo].[tbclient] ([id], [identification], [name], [lastname], [email]) VALUES (5, CAST(301230123 AS Numeric(15, 0)), N'Heller', N'A.', N'arguedas3023@gmail.com')
SET IDENTITY_INSERT [dbo].[tbclient] OFF
SET IDENTITY_INSERT [dbo].[tbtyperoom] ON 

INSERT [dbo].[tbtyperoom] ([id], [quantityperson], [quantitybed], [description], [amount], [urlimage], [descriptiontyperoom]) VALUES (2, CAST(1 AS Numeric(2, 0)), CAST(1 AS Numeric(2, 0)), N'Standard', 15000, N'/images/TipoHabitacion/tipohabitacion3.jpeg', N'   Habitación con una cama matrimonial, aire acondicionado, TV con cable, abanico de techo y baño privado.  Nueva habitacion.  Si')
INSERT [dbo].[tbtyperoom] ([id], [quantityperson], [quantitybed], [description], [amount], [urlimage], [descriptiontyperoom]) VALUES (3, CAST(2 AS Numeric(2, 0)), CAST(1 AS Numeric(2, 0)), N'Junior', 30, N'/images/TipoHabitacion/tipohabitacion3.jpeg', N' Suite con balcón o terraza privado, vistas panorámicas del océano, la selva tropical y las montañas..')
INSERT [dbo].[tbtyperoom] ([id], [quantityperson], [quantitybed], [description], [amount], [urlimage], [descriptiontyperoom]) VALUES (4, CAST(4 AS Numeric(2, 0)), CAST(2 AS Numeric(2, 0)), N'VIP', 40, N'/images/TipoHabitacion/tipohabitacion3.jpeg', N'Habitaciones de lujo completamente equipadas, diseñadas para brindarle comodidad y conveniencia y permitirle conectarse con el mar y el santuario de vida marina')
SET IDENTITY_INSERT [dbo].[tbtyperoom] OFF
SET IDENTITY_INSERT [dbo].[tbroom] ON 

INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (41, 2, CAST(1 AS Numeric(1, 0)), CAST(11 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (42, 2, CAST(1 AS Numeric(1, 0)), CAST(12 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (43, 2, CAST(1 AS Numeric(1, 0)), CAST(13 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (44, 2, CAST(1 AS Numeric(1, 0)), CAST(14 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (45, 2, CAST(1 AS Numeric(1, 0)), CAST(15 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (46, 2, CAST(1 AS Numeric(1, 0)), CAST(16 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (47, 2, CAST(1 AS Numeric(1, 0)), CAST(17 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (48, 2, CAST(1 AS Numeric(1, 0)), CAST(18 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (49, 2, CAST(1 AS Numeric(1, 0)), CAST(19 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (50, 2, CAST(1 AS Numeric(1, 0)), CAST(20 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (51, 3, CAST(1 AS Numeric(1, 0)), CAST(21 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (52, 3, CAST(1 AS Numeric(1, 0)), CAST(22 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (53, 3, CAST(1 AS Numeric(1, 0)), CAST(23 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (54, 3, CAST(1 AS Numeric(1, 0)), CAST(24 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (55, 3, CAST(1 AS Numeric(1, 0)), CAST(25 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (56, 3, CAST(1 AS Numeric(1, 0)), CAST(26 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (57, 3, CAST(1 AS Numeric(1, 0)), CAST(27 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (58, 3, CAST(1 AS Numeric(1, 0)), CAST(28 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (59, 3, CAST(1 AS Numeric(1, 0)), CAST(29 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (60, 3, CAST(1 AS Numeric(1, 0)), CAST(30 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (61, 4, CAST(1 AS Numeric(1, 0)), CAST(21 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (62, 4, CAST(1 AS Numeric(1, 0)), CAST(22 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (63, 4, CAST(1 AS Numeric(1, 0)), CAST(23 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (64, 4, CAST(1 AS Numeric(1, 0)), CAST(24 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (65, 4, CAST(1 AS Numeric(1, 0)), CAST(25 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (66, 4, CAST(1 AS Numeric(1, 0)), CAST(26 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (67, 4, CAST(1 AS Numeric(1, 0)), CAST(27 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (68, 4, CAST(1 AS Numeric(1, 0)), CAST(28 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (69, 4, CAST(1 AS Numeric(1, 0)), CAST(29 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (70, 4, CAST(1 AS Numeric(1, 0)), CAST(30 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (72, 2, CAST(1 AS Numeric(1, 0)), CAST(32 AS Numeric(2, 0)))
SET IDENTITY_INSERT [dbo].[tbroom] OFF
SET IDENTITY_INSERT [dbo].[tbreservation] ON 

INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [arrivaldate], [departuredate], [creationdate], [amount]) VALUES (11, 41, 1, CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-05T00:00:00.000' AS DateTime), 70)
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [arrivaldate], [departuredate], [creationdate], [amount]) VALUES (12, 42, 1, CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-05T00:00:00.000' AS DateTime), 70)
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [arrivaldate], [departuredate], [creationdate], [amount]) VALUES (13, 43, 1, CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-05T00:00:00.000' AS DateTime), 70)
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [arrivaldate], [departuredate], [creationdate], [amount]) VALUES (14, 44, 1, CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-05T00:00:00.000' AS DateTime), 70)
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [arrivaldate], [departuredate], [creationdate], [amount]) VALUES (15, 45, 1, CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-05T00:00:00.000' AS DateTime), 70)
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [arrivaldate], [departuredate], [creationdate], [amount]) VALUES (16, 46, 1, CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-05T00:00:00.000' AS DateTime), 70)
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [arrivaldate], [departuredate], [creationdate], [amount]) VALUES (17, 47, 1, CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-05T00:00:00.000' AS DateTime), 70)
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [arrivaldate], [departuredate], [creationdate], [amount]) VALUES (18, 48, 1, CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-05T00:00:00.000' AS DateTime), 70)
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [arrivaldate], [departuredate], [creationdate], [amount]) VALUES (19, 49, 1, CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-05T00:00:00.000' AS DateTime), 70)
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [arrivaldate], [departuredate], [creationdate], [amount]) VALUES (20, 50, 1, CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-05T00:00:00.000' AS DateTime), 70)
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [arrivaldate], [departuredate], [creationdate], [amount]) VALUES (21, 51, 1, CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-05T00:00:00.000' AS DateTime), 70)
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [arrivaldate], [departuredate], [creationdate], [amount]) VALUES (22, 52, 1, CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-05T00:00:00.000' AS DateTime), 70)
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [arrivaldate], [departuredate], [creationdate], [amount]) VALUES (23, 53, 1, CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-05T00:00:00.000' AS DateTime), 70)
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [arrivaldate], [departuredate], [creationdate], [amount]) VALUES (24, 54, 1, CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-05T00:00:00.000' AS DateTime), 70)
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [arrivaldate], [departuredate], [creationdate], [amount]) VALUES (25, 55, 1, CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-05T00:00:00.000' AS DateTime), 70)
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [arrivaldate], [departuredate], [creationdate], [amount]) VALUES (26, 56, 1, CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-05T00:00:00.000' AS DateTime), 70)
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [arrivaldate], [departuredate], [creationdate], [amount]) VALUES (27, 57, 1, CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-05T00:00:00.000' AS DateTime), 70)
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [arrivaldate], [departuredate], [creationdate], [amount]) VALUES (28, 58, 1, CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-05T00:00:00.000' AS DateTime), 70)
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [arrivaldate], [departuredate], [creationdate], [amount]) VALUES (29, 59, 1, CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-05T00:00:00.000' AS DateTime), 70)
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [arrivaldate], [departuredate], [creationdate], [amount]) VALUES (30, 60, 1, CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-05T00:00:00.000' AS DateTime), 70)
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [arrivaldate], [departuredate], [creationdate], [amount]) VALUES (31, 61, 1, CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-05T00:00:00.000' AS DateTime), 70)
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [arrivaldate], [departuredate], [creationdate], [amount]) VALUES (32, 62, 1, CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-05T00:00:00.000' AS DateTime), 70)
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [arrivaldate], [departuredate], [creationdate], [amount]) VALUES (33, 63, 1, CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-05T00:00:00.000' AS DateTime), 70)
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [arrivaldate], [departuredate], [creationdate], [amount]) VALUES (34, 64, 1, CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-05T00:00:00.000' AS DateTime), 70)
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [arrivaldate], [departuredate], [creationdate], [amount]) VALUES (35, 65, 1, CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-05T00:00:00.000' AS DateTime), 70)
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [arrivaldate], [departuredate], [creationdate], [amount]) VALUES (36, 66, 1, CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-05T00:00:00.000' AS DateTime), 70)
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [arrivaldate], [departuredate], [creationdate], [amount]) VALUES (37, 67, 1, CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-05T00:00:00.000' AS DateTime), 70)
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [arrivaldate], [departuredate], [creationdate], [amount]) VALUES (38, 68, 1, CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-05T00:00:00.000' AS DateTime), 70)
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [arrivaldate], [departuredate], [creationdate], [amount]) VALUES (39, 69, 1, CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-05T00:00:00.000' AS DateTime), 70)
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [arrivaldate], [departuredate], [creationdate], [amount]) VALUES (40, 70, 1, CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-05T00:00:00.000' AS DateTime), 70)
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [arrivaldate], [departuredate], [creationdate], [amount]) VALUES (56, 51, 1, CAST(N'2020-05-29T00:00:00.000' AS DateTime), CAST(N'2020-05-31T00:00:00.000' AS DateTime), CAST(N'2020-05-29T20:24:03.000' AS DateTime), 60)
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [arrivaldate], [departuredate], [creationdate], [amount]) VALUES (57, 61, 2, CAST(N'2020-05-29T00:00:00.000' AS DateTime), CAST(N'2020-06-07T00:00:00.000' AS DateTime), CAST(N'2020-05-29T22:21:07.000' AS DateTime), 880)
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [arrivaldate], [departuredate], [creationdate], [amount]) VALUES (58, 52, 2, CAST(N'2020-05-30T00:00:00.000' AS DateTime), CAST(N'2020-06-03T00:00:00.000' AS DateTime), CAST(N'2020-05-29T22:23:08.000' AS DateTime), 810)
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [arrivaldate], [departuredate], [creationdate], [amount]) VALUES (59, 41, 2, CAST(N'2020-06-02T00:00:00.000' AS DateTime), CAST(N'2020-06-04T00:00:00.000' AS DateTime), CAST(N'2020-06-02T00:32:46.000' AS DateTime), 30000)
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [arrivaldate], [departuredate], [creationdate], [amount]) VALUES (60, 42, 3, CAST(N'2020-06-02T00:00:00.000' AS DateTime), CAST(N'2020-06-04T00:00:00.000' AS DateTime), CAST(N'2020-06-02T16:44:27.000' AS DateTime), 30000)
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [arrivaldate], [departuredate], [creationdate], [amount]) VALUES (61, 43, 5, CAST(N'2020-06-02T00:00:00.000' AS DateTime), CAST(N'2020-06-04T00:00:00.000' AS DateTime), CAST(N'2020-06-02T19:09:31.000' AS DateTime), 30000)
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [arrivaldate], [departuredate], [creationdate], [amount]) VALUES (62, 51, 3, CAST(N'2020-06-07T00:00:00.000' AS DateTime), CAST(N'2020-06-10T00:00:00.000' AS DateTime), CAST(N'2020-06-02T19:28:01.000' AS DateTime), 90)
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [arrivaldate], [departuredate], [creationdate], [amount]) VALUES (63, 61, 3, CAST(N'2020-06-02T00:00:00.000' AS DateTime), CAST(N'2020-06-03T00:00:00.000' AS DateTime), CAST(N'2020-06-02T20:40:19.000' AS DateTime), 40)
SET IDENTITY_INSERT [dbo].[tbreservation] OFF
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'00000000000000_CreateIdentitySchema', N'2.1.14-servicing-32113')
SET IDENTITY_INSERT [dbo].[tbcontentpage] ON 

INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (1, N'facility', N'/images/Facilidades/facilidad-06.jpg', N'1', N'El hotel ofrece conserje, para que tu estancia sea incluso más agradable. El establecimiento también cuenta con piscina y desayuno incluido. Los huéspedes que lleguen en coche tienen acceso a parking gratis.Mientras estás aquí, asegúrate de ir a restaurantes de marisco como Costa Coral Restaurant, Mar y Sol y Cristobal Restaurant, que se encuentran cerca de Tango Mar Beachfront Boutique Hotel & Villas.Hotel Patito está deseando darte la bienvenida cuando visites la zona.')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (2, N'facility', N'/images/Facilidades/facilidad-07.jpg', N'1', N'El Hotel Patito también cuenta con recepción abierta las 24 horas, tienda de regalos, instalaciones para practicar deportes acuáticos, punto de venta de forfaits y bar. Hay conexión Wi-Fi gratuita en todas las instalaciones y se facilita aparcamiento privado gratuito. El establecimiento está rodeado por el lago con la presencia imponente de las montañas de la zona.')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (3, N'home', N'/images/Hotel_Patito-02.svg', N'2', N'')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (4, N'publicity', N'/images/Publicidad/publicity_01.png', N'1', N'https://www.fifco.com/')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (5, N'publicity', N'/images/Publicidad/publicity_02.jpg', N'1', N'https://movistar.cr/')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (6, N'publicity', N'/images/Publicidad/publicity_03.gif', N'1', N'www.cocacola.com')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (7, N'facility', N'/images/Galeria/img_03.jpg', N'2', N'facility')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (8, N'facility', N'/images/Galeria/img_04.jpg', N'2', N'facility')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (9, N'facility', N'/images/Galeria/img_05.jpg', N'2', N'facility')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (10, N'facility', N'/images/Galeria/img_06.jpg', N'2', N'facility')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (11, N'facility', N'/images/Galeria/img_07.jpg', N'2', N'facility')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (12, N'facility', N'/images/Galeria/img_08.jpg', N'2', N'facility')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (13, N'facility', N'/images/Facilidades/facilidad-06.jpg', N'1', N'El hotel ofrece conserje, para que tu estancia sea incluso más agradable. El establecimiento también cuenta con piscina y desayuno incluido. Los huéspedes que lleguen en coche tienen acceso a parking gratis.Mientras estás aquí, asegúrate de ir a restaurantes de marisco como Costa Coral Restaurant, Mar y Sol y Cristobal Restaurant, que se encuentran cerca de Tango Mar Beachfront Boutique Hotel & Villas.Hotel Patito está deseando darte la bienvenida cuando visites la zona.')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (14, N'facility', N'/images/Facilidades/facilidad-07.jpg', N'1', N'El Hotel Patito también cuenta con recepción abierta las 24 horas, tienda de regalos, instalaciones para practicar deportes acuáticos, punto de venta de forfaits y bar. Hay conexión Wi-Fi gratuita en todas las instalaciones y se facilita aparcamiento privado gratuito. El establecimiento está rodeado por el lago con la presencia imponente de las montañas de la zona.')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (16, N'publicity', N'/images/Publicidad/publicity_01.png', N'1', N'https://www.fifco.com/')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (17, N'publicity', N'/images/Publicidad/publicity_02.jpg', N'1', N'https://movistar.cr/')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (18, N'publicity', N'/images/Publicidad/publicity_03.gif', N'1', N'www.cocacola.com')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (19, N'facility', N'/images/Galeria/img_03.jpg', N'2', N'facility')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (20, N'facility', N'/images/Galeria/img_04.jpg', N'2', N'facility')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (21, N'facility', N'/images/Galeria/img_05.jpg', N'2', N'facility')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (22, N'facility', N'/images/Galeria/img_06.jpg', N'2', N'facility')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (23, N'facility', N'/images/Galeria/img_07.jpg', N'2', N'facility')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (24, N'facility', N'/images/Galeria/img_08.jpg', N'2', N'facility')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (25, N'facility', N'/images/Facilidades/facilidad-06.jpg', N'1', N'El hotel ofrece conserje, para que tu estancia sea incluso más agradable. El establecimiento también cuenta con piscina y desayuno incluido. Los huéspedes que lleguen en coche tienen acceso a parking gratis.Mientras estás aquí, asegúrate de ir a restaurantes de marisco como Costa Coral Restaurant, Mar y Sol y Cristobal Restaurant, que se encuentran cerca de Tango Mar Beachfront Boutique Hotel & Villas.Hotel Patito está deseando darte la bienvenida cuando visites la zona.')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (26, N'facility', N'/images/Facilidades/facilidad-07.jpg', N'1', N'El Hotel Patito también cuenta con recepción abierta las 24 horas, tienda de regalos, instalaciones para practicar deportes acuáticos, punto de venta de forfaits y bar. Hay conexión Wi-Fi gratuita en todas las instalaciones y se facilita aparcamiento privado gratuito. El establecimiento está rodeado por el lago con la presencia imponente de las montañas de la zona.')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (28, N'publicity', N'/images/Publicidad/publicity_01.png', N'1', N'https://www.fifco.com/')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (29, N'publicity', N'/images/Publicidad/publicity_02.jpg', N'1', N'https://movistar.cr/')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (30, N'publicity', N'/images/Publicidad/publicity_03.gif', N'1', N'www.cocacola.com')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (31, N'facility', N'/images/Galeria/img_03.jpg', N'2', N'facility')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (32, N'facility', N'/images/Galeria/img_04.jpg', N'2', N'facility')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (33, N'facility', N'/images/Galeria/img_05.jpg', N'2', N'facility')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (34, N'facility', N'/images/Galeria/img_06.jpg', N'2', N'facility')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (35, N'facility', N'/images/Galeria/img_07.jpg', N'2', N'facility')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (36, N'facility', N'/images/Galeria/img_08.jpg', N'2', N'facility')
SET IDENTITY_INSERT [dbo].[tbcontentpage] OFF
SET IDENTITY_INSERT [dbo].[tbhotel] ON 

INSERT [dbo].[tbhotel] ([id], [name], [description], [aboutus], [address], [pobox], [email]) VALUES (15, N'Hotel Patito', N'El hotel Patito dispone de 100 maravillosas habitaciones inspiradas en un estilo propio de la zona y en las que cada espacio tiene su propia y exclusiva personalidad. Gracias a su ubicación en un entorno mágico, los huéspedes podrán descansar en uno de los más bonitos parajes de Costa Rica, escenario natural único en el mundo. Todas ellas cuentan con suelo de baldosa y una decoración elegante, además de disponer de un balcón o terraza con vistas al mar o al jardín. Ofrecemos un ambiente pacífico y ecológicamente equilibrado, donde los huéspedes pueden disfrutar de una estancia sana y tranquila con un ambiente subtropical. El hotel ofrece servicios de alta calidad a un costo razonable y por lo tanto permite a los huéspedes disfrutar de unas vacaciones de ensueño a un precio atractivo.', N'Misión, Visión y Valores
Patito Hotel & Resort es la realización de un sueño cuando se creó la siguiente declaración sobre la misión, visión y valores del resort:
Misión
La misión de la compañía es fomentar una marca única de ecoturismo que expone a los visitantes internacionales y los niños de Costa Rica a las maravillas naturales del país en la forma de un negocio rentable que practica los principios del desarrollo sostenible.
Visión
Para lograr esta misión mientras:
-Lograr y mantener negocios exitosos
-Educar en verdadero ecologismo y ecología
-Invertir en los niños como una inversión en nuestro futuro
-Exhibiendo la belleza natural de Costa Rica

Valores
Los valores de la compañía alcanzarán esta misión al mantener nuestro hotel y asociación con nuestros huéspedes y niños, al exponer a las personas a la importancia de la ecología. El resultado es una relación ganar-ganar para las empresas con respecto al retorno de la inversión y el medio ambiente.»
Haciendo hincapié en la comunidad, la sostenibilidad y el medio ambiente
El hotel pone gran énfasis en mantener el medio ambiente y apoyar a las personas que viven en las pequeñas comunidades en los alrededores del hotel.
También administramos un centro de rescate para animales que brinda refugio a las especies de aves que han resultado heridas.
Consideramos que es nuestra obligación garantizar que tanto la población local como los visitantes internacionales disfruten de la belleza natural y las cualidades del entorno.
El complejo ofrece inmensas oportunidades para educar a los huéspedes y lugareños sobre el medio ambiente.
También apoyamos programas para que los niños aprendan sobre el medio ambiente.
Nuestra compañía tiene una asociación con escuelas en Costa Rica para traer niños a expensas del resort para una experiencia de un día de aprendizaje sobre las maravillas naturales de Costa Rica.
', N'Al salir del aeropuerto, gire a la derecha en 21 y avance 27.6 km (desde Adobe Car Rental, gire a la izquierda en 21 y avance 20.7 km) hacia Belén, donde verá una gran estación de servicio a su derecha.
 
Gire a la derecha en 155 siguiendo las indicaciones hacia Playa Conchal y Reserva Conchal y Westin Hotel.
 
Avance 24.7 km (a 4 km, hay un trote en la carretera en Santa Anna donde gira a la izquierda para continuar por 155 siguiendo las indicaciones hacia Playa Conchal y Westin Hotel)
 
En Huacas, gire a la derecha siguiendo las indicaciones hacia Reserva Conchal y Westin Hotel, a 3.5 km hasta la puerta de seguridad de Reserva Conchal.', N'4006', N'hotelpatito@gmail.com')
SET IDENTITY_INSERT [dbo].[tbhotel] OFF
SET IDENTITY_INSERT [dbo].[tbpaymentcard] ON 

INSERT [dbo].[tbpaymentcard] ([id], [idclient], [cvv], [type], [number], [date]) VALUES (4, 1, CAST(133 AS Numeric(4, 0)), N'credito', 123456789123456, N'12/22')
INSERT [dbo].[tbpaymentcard] ([id], [idclient], [cvv], [type], [number], [date]) VALUES (1002, 2, CAST(447 AS Numeric(4, 0)), N'credito', 888888852369745, N'12/22')
INSERT [dbo].[tbpaymentcard] ([id], [idclient], [cvv], [type], [number], [date]) VALUES (1003, 3, CAST(447 AS Numeric(4, 0)), N'credito', 999966662222123, N'12/22')
INSERT [dbo].[tbpaymentcard] ([id], [idclient], [cvv], [type], [number], [date]) VALUES (1004, 4, CAST(915 AS Numeric(4, 0)), N'credito', 789432165555123, N'12/22')
INSERT [dbo].[tbpaymentcard] ([id], [idclient], [cvv], [type], [number], [date]) VALUES (1010, 301230123, CAST(123 AS Numeric(4, 0)), N'PayPal', 454545656523658, N'1222')
INSERT [dbo].[tbpaymentcard] ([id], [idclient], [cvv], [type], [number], [date]) VALUES (1011, 304480039, CAST(123 AS Numeric(4, 0)), N'PayPal', 12345678965215, N'0222')
SET IDENTITY_INSERT [dbo].[tbpaymentcard] OFF
