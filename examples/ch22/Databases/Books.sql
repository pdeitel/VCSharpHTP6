CREATE TABLE [dbo].[Authors] (
    [AuthorID]  INT          IDENTITY (1, 1) NOT NULL,
    [FirstName] VARCHAR (50) NOT NULL,
    [LastName]  VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Authors] PRIMARY KEY CLUSTERED ([AuthorID] ASC)
);

CREATE TABLE [dbo].[Titles] (
    [ISBN]          VARCHAR (20)  NOT NULL,
    [Title]         VARCHAR (100) NOT NULL,
    [EditionNumber] INT           NOT NULL,
    [Copyright]     VARCHAR (4)   NOT NULL,
    CONSTRAINT [PK_Titles] PRIMARY KEY CLUSTERED ([ISBN] ASC)
);

CREATE TABLE [dbo].[AuthorISBN] (
    [AuthorID] INT          NOT NULL,
    [ISBN]     VARCHAR (20) NOT NULL,
    CONSTRAINT [PK_AuthorISBN] PRIMARY KEY CLUSTERED ([AuthorID] ASC, [ISBN] ASC),
    CONSTRAINT [FK_AuthorISBN_Authors] FOREIGN KEY ([AuthorID]) REFERENCES [dbo].[Authors] ([AuthorID]),
    CONSTRAINT [FK_AuthorISBN_Titles] FOREIGN KEY ([ISBN]) REFERENCES [dbo].[Titles] ([ISBN])
);


SET IDENTITY_INSERT [dbo].[Authors] ON
INSERT INTO [dbo].[Authors] ([AuthorID], [FirstName], [LastName]) VALUES (1, N'Paul', N'Deitel')
INSERT INTO [dbo].[Authors] ([AuthorID], [FirstName], [LastName]) VALUES (2, N'Harvey', N'Deitel')
INSERT INTO [dbo].[Authors] ([AuthorID], [FirstName], [LastName]) VALUES (3, N'Abbey', N'Deitel')
INSERT INTO [dbo].[Authors] ([AuthorID], [FirstName], [LastName]) VALUES (4, N'Sue', N'Green')
INSERT INTO [dbo].[Authors] ([AuthorID], [FirstName], [LastName]) VALUES (5, N'John', N'Purple')
SET IDENTITY_INSERT [dbo].[Authors] OFF


INSERT INTO [dbo].[Titles] ([ISBN], [Title], [EditionNumber], [Copyright]) VALUES (N'0132151006', N'Internet & World Wide Web How to Program', 5, N'2012')
INSERT INTO [dbo].[Titles] ([ISBN], [Title], [EditionNumber], [Copyright]) VALUES (N'0133807800', N'Java How to Program', 10, N'2015')
INSERT INTO [dbo].[Titles] ([ISBN], [Title], [EditionNumber], [Copyright]) VALUES (N'0132575655', N'Java How to Program, Late Objects Version', 10, N'2015')
INSERT INTO [dbo].[Titles] ([ISBN], [Title], [EditionNumber], [Copyright]) VALUES (N'0133976890', N'C How to Program', 8, N'2016')
INSERT INTO [dbo].[Titles] ([ISBN], [Title], [EditionNumber], [Copyright]) VALUES (N'0133406954', N'Visual Basic 2012 How to Program', 6, N'2014')
INSERT INTO [dbo].[Titles] ([ISBN], [Title], [EditionNumber], [Copyright]) VALUES (N'0134601548', N'Visual C# How to Program', 6, N'2017')
INSERT INTO [dbo].[Titles] ([ISBN], [Title], [EditionNumber], [Copyright]) VALUES (N'0134448235', N'C++ How to Program', 10, N'2016')
INSERT INTO [dbo].[Titles] ([ISBN], [Title], [EditionNumber], [Copyright]) VALUES (N'0134444302', N'Android How to Program', 3, N'2016')
INSERT INTO [dbo].[Titles] ([ISBN], [Title], [EditionNumber], [Copyright]) VALUES (N'0134289366', N'Android 6 for Programmers: An App-Driven Approach', 3, N'2016')
INSERT INTO [dbo].[Titles] ([ISBN], [Title], [EditionNumber], [Copyright]) VALUES (N'0133965260', N'iOS 8 for Programmers: An App-Driven Approach with Swift', 3, N'2015')
INSERT INTO [dbo].[Titles] ([ISBN], [Title], [EditionNumber], [Copyright]) VALUES (N'0134021363', N'Swift for Programmers', 1, N'2015')

INSERT INTO [dbo].[AuthorISBN] ([AuthorID], [ISBN]) VALUES (1, N'0132151006')
INSERT INTO [dbo].[AuthorISBN] ([AuthorID], [ISBN]) VALUES (1, N'0133807800')
INSERT INTO [dbo].[AuthorISBN] ([AuthorID], [ISBN]) VALUES (1, N'0132575655')
INSERT INTO [dbo].[AuthorISBN] ([AuthorID], [ISBN]) VALUES (1, N'0133976890')
INSERT INTO [dbo].[AuthorISBN] ([AuthorID], [ISBN]) VALUES (1, N'0133406954')
INSERT INTO [dbo].[AuthorISBN] ([AuthorID], [ISBN]) VALUES (1, N'0134601548')
INSERT INTO [dbo].[AuthorISBN] ([AuthorID], [ISBN]) VALUES (1, N'0134448235')
INSERT INTO [dbo].[AuthorISBN] ([AuthorID], [ISBN]) VALUES (1, N'0134444302')
INSERT INTO [dbo].[AuthorISBN] ([AuthorID], [ISBN]) VALUES (1, N'0134289366')
INSERT INTO [dbo].[AuthorISBN] ([AuthorID], [ISBN]) VALUES (1, N'0133965260')
INSERT INTO [dbo].[AuthorISBN] ([AuthorID], [ISBN]) VALUES (1, N'0134021363')
INSERT INTO [dbo].[AuthorISBN] ([AuthorID], [ISBN]) VALUES (2, N'0132151006')
INSERT INTO [dbo].[AuthorISBN] ([AuthorID], [ISBN]) VALUES (2, N'0133807800')
INSERT INTO [dbo].[AuthorISBN] ([AuthorID], [ISBN]) VALUES (2, N'0132575655')
INSERT INTO [dbo].[AuthorISBN] ([AuthorID], [ISBN]) VALUES (2, N'0133976890')
INSERT INTO [dbo].[AuthorISBN] ([AuthorID], [ISBN]) VALUES (2, N'0133406954')
INSERT INTO [dbo].[AuthorISBN] ([AuthorID], [ISBN]) VALUES (2, N'0134601548')
INSERT INTO [dbo].[AuthorISBN] ([AuthorID], [ISBN]) VALUES (2, N'0134448235')
INSERT INTO [dbo].[AuthorISBN] ([AuthorID], [ISBN]) VALUES (2, N'0134444302')
INSERT INTO [dbo].[AuthorISBN] ([AuthorID], [ISBN]) VALUES (2, N'0134289366')
INSERT INTO [dbo].[AuthorISBN] ([AuthorID], [ISBN]) VALUES (2, N'0133965260')
INSERT INTO [dbo].[AuthorISBN] ([AuthorID], [ISBN]) VALUES (2, N'0134021363')
INSERT INTO [dbo].[AuthorISBN] ([AuthorID], [ISBN]) VALUES (3, N'0132151006')
INSERT INTO [dbo].[AuthorISBN] ([AuthorID], [ISBN]) VALUES (3, N'0133406954')
INSERT INTO [dbo].[AuthorISBN] ([AuthorID], [ISBN]) VALUES (4, N'0134289366')
INSERT INTO [dbo].[AuthorISBN] ([AuthorID], [ISBN]) VALUES (5, N'0134289366')
