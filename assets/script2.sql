USE [Lift]
GO

/****** Object:  Table [dbo].[LiftEvents]    Script Date: 11/11/2024 11:15:18 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[LiftEvents](
	[EventId] [int] IDENTITY(1,1) NOT NULL,
	[EventType] [varchar](50) NOT NULL,
	[EventTimestamp] [datetime2](3) NULL,
	[Floor] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EventId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[LiftEvents] ADD  DEFAULT (sysdatetime()) FOR [EventTimestamp]
GO
