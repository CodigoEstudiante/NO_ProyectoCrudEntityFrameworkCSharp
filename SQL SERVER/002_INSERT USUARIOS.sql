USE [DBPRUEBAS]
GO
SET IDENTITY_INSERT [dbo].[PERSONA] ON 

INSERT [dbo].[PERSONA] ([IdPersona], [Nombres], [Telefono]) VALUES (1, N'Regina', N'690577998')
INSERT [dbo].[PERSONA] ([IdPersona], [Nombres], [Telefono]) VALUES (2, N'Macy', N'270411465')
INSERT [dbo].[PERSONA] ([IdPersona], [Nombres], [Telefono]) VALUES (3, N'Sophia', N'757428589')
INSERT [dbo].[PERSONA] ([IdPersona], [Nombres], [Telefono]) VALUES (4, N'Rhiannon', N'794799685')
INSERT [dbo].[PERSONA] ([IdPersona], [Nombres], [Telefono]) VALUES (5, N'Aubrey', N'711648390')

SET IDENTITY_INSERT [dbo].[PERSONA] OFF

go

select * from [dbo].[PERSONA]