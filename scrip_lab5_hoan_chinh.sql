USE [master]
GO
IF EXISTS (SELECT name FROM sys.databases WHERE name = 'QuanLySinhVien')
    DROP DATABASE QuanLySinhVien;
GO
--Drop table Faculty
--Drop table Student

CREATE DATABASE [QuanLySinhVien]
GO

USE [QuanLySinhVien]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Faculty](
	[FacultyID] [int],
	[FacultyName] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Faculty] PRIMARY KEY CLUSTERED 
(
	[FacultyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Student](
	[StudentID] [nvarchar](10) NOT NULL,
	[FullName] [nvarchar](255) NOT NULL,
	[AverageScore] [float] NOT NULL,
	[FacultyID] [int] NOT NULL,
	[MajorID] [int] NOT NULL,
	[Avatar] [nvarchar](255) NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create table [dbo].[Major] (
	[FacultyID] [int],
	[MajorID] [int],
	[Name] [nvarchar](255) NOT NULL,
	CONSTRAINT [PK_Major_1] PRIMARY KEY CLUSTERED 
(
	[MajorID] ASC,
	[FacultyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO



-- Insert data into Faculty table
INSERT [dbo].[Faculty] ([FacultyID], [FacultyName]) VALUES (1, N'Công nghệ thông tin')
INSERT [dbo].[Faculty] ([FacultyID], [FacultyName]) VALUES (2, N'Ngôn ngữ Anh')
INSERT [dbo].[Faculty] ([FacultyID], [FacultyName]) VALUES (3, N'Quản trị kinh doanh')


-- Insert data into Student table 
INSERT [dbo].[Student] ([StudentID], [FullName], [AverageScore], [FacultyID], [MajorID], [Avatar]) 
VALUES (N'1611061916', N'Nguyễn Trần Hoàng Lan', 4.5, 1, 1, null);
INSERT [dbo].[Student] ([StudentID], [FullName], [AverageScore], [FacultyID], [MajorID], [Avatar]) 
VALUES (N'1711060596', N'Đảm Minh Đức', 10, 1, 3, null);
INSERT [dbo].[Student] ([StudentID], [FullName], [AverageScore], [FacultyID], [MajorID], [Avatar]) 
VALUES (N'1811061004', N'Nguyễn Quốc An', 8, 1, 2, null);
INSERT [dbo].[Student] ([StudentID], [FullName], [AverageScore], [FacultyID], [MajorID], [Avatar]) 
VALUES (N'2111062201', N'Dương Quốc Minh', 6.5, 1, 1, null);
INSERT [dbo].[Student] ([StudentID], [FullName], [AverageScore], [FacultyID], [MajorID], [Avatar]) 
VALUES (N'2111061113', N'Nguyễn Thị B', 5.5, 2, 1, null);
INSERT [dbo].[Student] ([StudentID], [FullName], [AverageScore], [FacultyID], [MajorID], [Avatar]) 
VALUES (N'1711061233', N'Trần Văn A', 7, 2, 2, null);
INSERT [dbo].[Student] ([StudentID], [FullName], [AverageScore], [FacultyID], [MajorID], [Avatar]) 
VALUES (N'1911060023', N'Lê Hoàng Phương', 7.8,  1, 3, null);
INSERT [dbo].[Student] ([StudentID], [FullName], [AverageScore], [FacultyID], [MajorID], [Avatar]) 
VALUES (N'2011061205', N'Phạm Văn Cường', 9.1, 2, 1, null);
INSERT [dbo].[Student] ([StudentID], [FullName], [AverageScore], [FacultyID], [MajorID], [Avatar]) 
VALUES (N'2111062234', N'Trần Thị Hoa', 6.9, 2, 2, null);
INSERT [dbo].[Student] ([StudentID], [FullName], [AverageScore], [FacultyID], [MajorID], [Avatar]) 
VALUES (N'2211063312', N'Nguyễn Minh Tú', 8.5, 1, 2, null);
INSERT [dbo].[Student] ([StudentID], [FullName], [AverageScore], [FacultyID], [MajorID], [Avatar]) 
VALUES (N'2211063419', N'Hoàng Thị Minh', 9.0, 2, 1, null);


-- Insert data into Major table
INSERT [dbo].[Major] ([FacultyID], [MajorID], [Name]) VALUES (1, 1, N'Công Nghệ Phần Mềm')
INSERT [dbo].[Major] ([FacultyID], [MajorID], [Name]) VALUES (2, 1, N'Tiếng Anh Thương Mại')
INSERT [dbo].[Major] ([FacultyID], [MajorID], [Name]) VALUES (1, 2, N'Hệ Thống Thông Tin')
INSERT [dbo].[Major] ([FacultyID], [MajorID], [Name]) VALUES (2, 2, N'Tiếng Anh Truyền Thông')
INSERT [dbo].[Major] ([FacultyID], [MajorID], [Name]) VALUES (1, 3, N'An Toàn Thông Tin')
GO

ALTER TABLE [dbo].[Major]  WITH CHECK ADD  CONSTRAINT [FK_Major_Faculty] FOREIGN KEY([FacultyID])
REFERENCES [dbo].[Faculty] ([FacultyID])
GO
ALTER TABLE [dbo].[Major] CHECK CONSTRAINT [FK_Major_Faculty]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Faculty] FOREIGN KEY([FacultyID])
REFERENCES [dbo].[Faculty] ([FacultyID])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Faculty]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Major] FOREIGN KEY([MajorID], [FacultyID])
REFERENCES [dbo].[Major] ([MajorID], [FacultyID])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Major]
GO
USE [master]
GO
ALTER DATABASE [QuanLySinhVien] SET  READ_WRITE 
GO
