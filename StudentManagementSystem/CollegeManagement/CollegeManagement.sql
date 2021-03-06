USE [CollegeManagement]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 19-03-2021 8.04.30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](20) NOT NULL,
	[Username] [varchar](20) NOT NULL,
	[Password] [varchar](10) NOT NULL,
	[Malayalam] [int] NULL,
	[English] [int] NULL,
	[Maths] [int] NULL,
	[Color] [varchar](20) NULL,
	[Left_Offset] [int] NULL,
	[Top_Offset] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([Id], [Name], [Username], [Password], [Malayalam], [English], [Maths], [Color], [Left_Offset], [Top_Offset]) VALUES (1, N'Arya', N'Arya', N'Arya123', 90, 90, 90, N'-65536', 306, 218)
INSERT [dbo].[Student] ([Id], [Name], [Username], [Password], [Malayalam], [English], [Maths], [Color], [Left_Offset], [Top_Offset]) VALUES (2, N'Sanu', N'Sanu', N'Sanu123', 98, 67, 68, N'-65536', 317, 162)
INSERT [dbo].[Student] ([Id], [Name], [Username], [Password], [Malayalam], [English], [Maths], [Color], [Left_Offset], [Top_Offset]) VALUES (3, N'Ammu', N'Ammu', N'pavu2hd4eU', 90, 67, 78, N'-65536', 0, 0)
INSERT [dbo].[Student] ([Id], [Name], [Username], [Password], [Malayalam], [English], [Maths], [Color], [Left_Offset], [Top_Offset]) VALUES (4, N'Anuraj', N'Anuraj', N'2dc1qFvOcG', 90, 89, 78, N'-65536', 377, 6)
INSERT [dbo].[Student] ([Id], [Name], [Username], [Password], [Malayalam], [English], [Maths], [Color], [Left_Offset], [Top_Offset]) VALUES (5, N'Ashly', N'Ashly', N'RjmM96NG7D', 78, 88, 77, N'-65536', 0, 0)
INSERT [dbo].[Student] ([Id], [Name], [Username], [Password], [Malayalam], [English], [Maths], [Color], [Left_Offset], [Top_Offset]) VALUES (6, N'Sandra', N'Sandra', N'Sandra1234', 90, 77, 99, N'-65536', 0, 0)
INSERT [dbo].[Student] ([Id], [Name], [Username], [Password], [Malayalam], [English], [Maths], [Color], [Left_Offset], [Top_Offset]) VALUES (7, N'Emy', N'Emy', N'Emy1234', 90, 88, 99, N'-65536', 0, 0)
INSERT [dbo].[Student] ([Id], [Name], [Username], [Password], [Malayalam], [English], [Maths], [Color], [Left_Offset], [Top_Offset]) VALUES (8, N'Priya', N'Priya', N'UIY7A2Ax8t', 90, 88, 55, N'-65536', 0, 0)
INSERT [dbo].[Student] ([Id], [Name], [Username], [Password], [Malayalam], [English], [Maths], [Color], [Left_Offset], [Top_Offset]) VALUES (9, N'Chinnu', N'Chinnu', N'', 89, 88, 66, N'-65536', 0, 0)
INSERT [dbo].[Student] ([Id], [Name], [Username], [Password], [Malayalam], [English], [Maths], [Color], [Left_Offset], [Top_Offset]) VALUES (10, N'Rahul', N'Rahul', N'', 90, 66, 77, N'-65536', 0, 0)
INSERT [dbo].[Student] ([Id], [Name], [Username], [Password], [Malayalam], [English], [Maths], [Color], [Left_Offset], [Top_Offset]) VALUES (11, N'Don', N'Don', N'', 90, 77, 99, N'-65536', 0, 0)
INSERT [dbo].[Student] ([Id], [Name], [Username], [Password], [Malayalam], [English], [Maths], [Color], [Left_Offset], [Top_Offset]) VALUES (12, N'Ram', N'Ram', N'', 99, 55, 88, N'-65536', 0, 0)
INSERT [dbo].[Student] ([Id], [Name], [Username], [Password], [Malayalam], [English], [Maths], [Color], [Left_Offset], [Top_Offset]) VALUES (13, N'Shinu', N'Shinu', N'', 90, 88, 77, N'-65536', 0, 0)
INSERT [dbo].[Student] ([Id], [Name], [Username], [Password], [Malayalam], [English], [Maths], [Color], [Left_Offset], [Top_Offset]) VALUES (14, N'Aslam', N'Aslam', N'', 90, 77, 99, N'-65536', 0, 0)
INSERT [dbo].[Student] ([Id], [Name], [Username], [Password], [Malayalam], [English], [Maths], [Color], [Left_Offset], [Top_Offset]) VALUES (15, N'Arunima', N'Arunima', N'', 89, 77, 90, N'-65536', 0, 0)
INSERT [dbo].[Student] ([Id], [Name], [Username], [Password], [Malayalam], [English], [Maths], [Color], [Left_Offset], [Top_Offset]) VALUES (16, N'Nihal', N'Nihal', N'', 89, 90, 99, N'-65536', 0, 0)
INSERT [dbo].[Student] ([Id], [Name], [Username], [Password], [Malayalam], [English], [Maths], [Color], [Left_Offset], [Top_Offset]) VALUES (17, N'Preethi', N'Preethi', N'', 90, 66, 77, N'-65536', 0, 0)
INSERT [dbo].[Student] ([Id], [Name], [Username], [Password], [Malayalam], [English], [Maths], [Color], [Left_Offset], [Top_Offset]) VALUES (18, N'Swathi', N'Swathi', N'', 90, 67, 90, N'-65536', 0, 0)
INSERT [dbo].[Student] ([Id], [Name], [Username], [Password], [Malayalam], [English], [Maths], [Color], [Left_Offset], [Top_Offset]) VALUES (19, N'', N'', N'9883', 0, 0, 0, N'-65536', 0, 0)
INSERT [dbo].[Student] ([Id], [Name], [Username], [Password], [Malayalam], [English], [Maths], [Color], [Left_Offset], [Top_Offset]) VALUES (20, N'Ann', N'Ann', N'', 90, 45, 55, N'-65536', 0, 0)
INSERT [dbo].[Student] ([Id], [Name], [Username], [Password], [Malayalam], [English], [Maths], [Color], [Left_Offset], [Top_Offset]) VALUES (21, N'Sona', N'Sona', N'', 90, 78, 77, N'-65536', 0, 0)
INSERT [dbo].[Student] ([Id], [Name], [Username], [Password], [Malayalam], [English], [Maths], [Color], [Left_Offset], [Top_Offset]) VALUES (22, N'Sonu', N'Sonu', N'', 90, 88, 99, N'-65536', 0, 0)
INSERT [dbo].[Student] ([Id], [Name], [Username], [Password], [Malayalam], [English], [Maths], [Color], [Left_Offset], [Top_Offset]) VALUES (23, N'', N'', N'xwe7vk5dvp', 0, 0, 0, N'-65536', 0, 0)
INSERT [dbo].[Student] ([Id], [Name], [Username], [Password], [Malayalam], [English], [Maths], [Color], [Left_Offset], [Top_Offset]) VALUES (24, N'', N'', N'2DtbxV2u', 0, 0, 0, N'-65536', 0, 0)
INSERT [dbo].[Student] ([Id], [Name], [Username], [Password], [Malayalam], [English], [Maths], [Color], [Left_Offset], [Top_Offset]) VALUES (25, N'', N'', N'', 0, 0, 0, N'-65536', 0, 0)
INSERT [dbo].[Student] ([Id], [Name], [Username], [Password], [Malayalam], [English], [Maths], [Color], [Left_Offset], [Top_Offset]) VALUES (26, N'', N'', N'Sebi123', 0, 0, 0, N'-65536', 0, 0)
INSERT [dbo].[Student] ([Id], [Name], [Username], [Password], [Malayalam], [English], [Maths], [Color], [Left_Offset], [Top_Offset]) VALUES (27, N'', N'', N'Lal', 0, 0, 0, N'-65536', 0, 0)
INSERT [dbo].[Student] ([Id], [Name], [Username], [Password], [Malayalam], [English], [Maths], [Color], [Left_Offset], [Top_Offset]) VALUES (28, N'Binu', N'Binu', N'', 89, 90, 89, N'-65536', 0, 0)
INSERT [dbo].[Student] ([Id], [Name], [Username], [Password], [Malayalam], [English], [Maths], [Color], [Left_Offset], [Top_Offset]) VALUES (29, N'', N'', N'OFLHWJf496', 0, 0, 0, N'-65536', 0, 0)
INSERT [dbo].[Student] ([Id], [Name], [Username], [Password], [Malayalam], [English], [Maths], [Color], [Left_Offset], [Top_Offset]) VALUES (30, N'Aswindas', N'Aswindas', N'Aswindas12', 90, 90, 78, N'-65536', 0, 0)
INSERT [dbo].[Student] ([Id], [Name], [Username], [Password], [Malayalam], [English], [Maths], [Color], [Left_Offset], [Top_Offset]) VALUES (31, N'Midhun', N'Midhun', N'', 78, 56, 45, N'-65536', 0, 0)
INSERT [dbo].[Student] ([Id], [Name], [Username], [Password], [Malayalam], [English], [Maths], [Color], [Left_Offset], [Top_Offset]) VALUES (32, N'Sara', N'Sara', N'', 90, 89, 99, N'-65536', 0, 0)
INSERT [dbo].[Student] ([Id], [Name], [Username], [Password], [Malayalam], [English], [Maths], [Color], [Left_Offset], [Top_Offset]) VALUES (33, N'', N'', N'n6UwGBkdi6', 0, 0, 0, N'-65536', 0, 0)
INSERT [dbo].[Student] ([Id], [Name], [Username], [Password], [Malayalam], [English], [Maths], [Color], [Left_Offset], [Top_Offset]) VALUES (34, N'Sam', N'Sam', N'', 90, 90, 90, N'-65536', 0, 0)
INSERT [dbo].[Student] ([Id], [Name], [Username], [Password], [Malayalam], [English], [Maths], [Color], [Left_Offset], [Top_Offset]) VALUES (35, N'Saran', N'Saran', N'inBSadtUco', 89, 90, 90, N'-65536', 0, 0)
INSERT [dbo].[Student] ([Id], [Name], [Username], [Password], [Malayalam], [English], [Maths], [Color], [Left_Offset], [Top_Offset]) VALUES (36, N'Deepak', N'Deepak', N'Deepak123', 90, 99, 77, N'-65536', 0, 0)
INSERT [dbo].[Student] ([Id], [Name], [Username], [Password], [Malayalam], [English], [Maths], [Color], [Left_Offset], [Top_Offset]) VALUES (37, N'Chithra', N'Chithra', N'Chithra123', 89, 90, 78, N'-65536', 0, 0)
INSERT [dbo].[Student] ([Id], [Name], [Username], [Password], [Malayalam], [English], [Maths], [Color], [Left_Offset], [Top_Offset]) VALUES (38, N'Christy', N'Christy', N'3940', 67, 77, 44, N'-65536', 0, 0)
INSERT [dbo].[Student] ([Id], [Name], [Username], [Password], [Malayalam], [English], [Maths], [Color], [Left_Offset], [Top_Offset]) VALUES (39, N'Alwin', N'Alwin', N'Alwin123', 90, 78, 56, N'-65536', 0, 0)
SET IDENTITY_INSERT [dbo].[Student] OFF
GO
ALTER TABLE [dbo].[Student] ADD  DEFAULT ('-65536') FOR [Color]
GO
ALTER TABLE [dbo].[Student] ADD  DEFAULT ('0') FOR [Left_Offset]
GO
ALTER TABLE [dbo].[Student] ADD  DEFAULT ('0') FOR [Top_Offset]
GO
/****** Object:  StoredProcedure [dbo].[SetColor]    Script Date: 19-03-2021 8.04.31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SetColor]
	@Id		INT
	,	@Color	VARCHAR(20)
AS
BEGIN
	UPDATE	[dbo].[Student]
	SET [Color]=@Color
	WHERE [Id]=@Id
	
END
GO
/****** Object:  StoredProcedure [dbo].[StudentLogin]    Script Date: 19-03-2021 8.04.31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[StudentLogin]
@Username	VARCHAR(20)
	,	@Password	VARCHAR(10)

AS
BEGIN
	SELECT * FROM [dbo].[Student] WHERE [Username]=@Username AND [Password]=@Password
END
	
GO
/****** Object:  StoredProcedure [dbo].[StudentRegister]    Script Date: 19-03-2021 8.04.31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[StudentRegister]
@Name	VARCHAR(20)
	,	@Username	VARCHAR(20)
	,	@Password	VARCHAR(10)
	,	@Malayalam	INT
	,	@English	INT
	,	@Maths		INT
	
AS
BEGIN
INSERT INTO [dbo].[Student]
(
	[Name]
	,	[Username]
	,	[Password]
	,	[Malayalam]
	,	[English]
	,	[Maths]
)
VALUES
(
	@Name	
	,	@Username	
	,	@Password	
	,	@Malayalam	
	,	@English	
	,	@Maths		
)

END
	
GO
/****** Object:  StoredProcedure [dbo].[UpdateLoginPassword]    Script Date: 19-03-2021 8.04.31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UpdateLoginPassword]
	@Id			INT
	,	@Password	VARCHAR(20)
AS
BEGIN
UPDATE 	[dbo].[Student]
SET [Password]=@Password
WHERE [Id]=@Id
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateWindowPosition]    Script Date: 19-03-2021 8.04.31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateWindowPosition]
	@Id					INT
	,	@Left_Offset	INT
	,	@Top_Offset		INT
AS
BEGIN
UPDATE [dbo].[Student]
SET	[Left_Offset]=@Left_Offset,
[Top_Offset]=@Top_Offset
WHERE [Id]=@Id
END
GO
