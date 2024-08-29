USE [Marvel]
GO

/****** Object:  Table [dbo].[Comics]    Script Date: 29/08/2024 16:57:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ComicsTest](
	[comic_name] [varchar](max) NOT NULL,
	[active_years] [nvarchar](50) NOT NULL,
	[issue_title] [varchar](max) NOT NULL,
	[publish_date] [date] NULL,
	[issue_description] [varchar](max) NOT NULL,
	[penciler] [nvarchar](100) NOT NULL,
	[writer] [nvarchar](100) NOT NULL,
	[cover_artist] [nvarchar](50) NOT NULL,
	[Imprint] [nvarchar](50) NOT NULL,
	[Format] [nvarchar](50) NOT NULL,
	[Rating] [nvarchar](50) NOT NULL,
	[Price] [nvarchar](50) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO




INSERT INTO ComicsTest
SELECT TOP 30* FROM Comics WHERE issue_title LIKE '%Boba Fett%'

SELECT * FROM ComicsTest