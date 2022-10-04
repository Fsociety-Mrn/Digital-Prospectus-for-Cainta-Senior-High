﻿CREATE TABLE [dbo].[ICT]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [name] VARCHAR(MAX) NULL, 
    [region] VARCHAR(10) NULL, 
    [Start Year] NCHAR(10) NULL, 
    [End Year] NCHAR(10) NULL, 
    [irregular] BIT NULL, 
    [Transferee] BIT NULL, 
    [ALS] BIT NULL, 
    [Last School] VARCHAR(MAX) NULL, 
    [Oral] BIT NULL, 
    [1st Oral] NCHAR(10) NULL, 
    [2nd Oral] NCHAR(10) NULL, 
    [RaW] BIT NULL, 
    [1st RaW] NCHAR(10) NULL, 
    [2ns RaW] NCHAR(10) NULL, 
    [Kom Filipino] BIT NULL, 
    [ 1st Kom filipino] NCHAR(10) NULL, 
    [2nd Kom filipino] NCHAR(10) NULL, 
    [Pagbasa] BIT NULL, 
    [1st Pagbasa] NCHAR(10) NULL, 
    [2nd Pagbasa] NCHAR(10) NULL, 
    [21st] BIT NULL, 
    [1st 21st] NCHAR(10) NULL, 
    [2nd 21st] NCHAR(10) NULL, 
    [Contempt Arts] BIT NULL, 
    [1st Contempory] NCHAR(10) NULL, 
    [2nd Contempory] NCHAR(10) NULL, 
    [Media] BIT NULL, 
    [1st Media] NCHAR(10) NULL, 
    [2nd Media] NCHAR(10) NULL, 
    [Gen Math] BIT NULL, 
    [1st Gen Math] NCHAR(10) NULL, 
    [2nd Gen Math] NCHAR(10) NULL, 
    [Stat] BIT NULL, 
    [1st Stat] NCHAR(10) NULL, 
    [2nd Stat] NCHAR(10) NULL, 
    [EarthSci] BIT NULL, 
    [1st Earth] NCHAR(10) NULL, 
    [2nd Earth] NCHAR(10) NULL, 
    [Physics] BIT NULL, 
    [1st Physics] NCHAR(10) NULL, 
    [2nd Physics] NCHAR(10) NULL, 
    [Philiosophy] BIT NULL, 
    [1st Philo] NCHAR(10) NULL, 
    [2nd Philo] NCHAR(10) NULL, 
    [PE] BIT NULL, 
    [1st PE] NCHAR(10) NULL, 
    [2nd PE] NCHAR(10) NULL, 
    [PerdDev] BIT NULL, 
    [1st Per] NCHAR(10) NULL, 
    [2nd Per] NCHAR(10) NULL, 
    [ucsp] BIT NULL, 
    [1st ucsp] NCHAR(10) NULL, 
    [2nd ucsp] NCHAR(10) NULL, 
    [EAPP] BIT NULL, 
    [1st EAPP] NCHAR(10) NULL, 
    [2nd EAPP] NCHAR(10) NULL, 
    [Prac I] BIT NULL, 
    [1st Prac I] NCHAR(10) NULL, 
    [2nd Prac I] NCHAR(10) NULL, 
    [Prac II] BIT NULL, 
    [1st prac II] NCHAR(10) NULL, 
    [2ndprac II] NCHAR(10) NULL, 
    [Filipino] BIT NULL, 
    [1st Filipino] NCHAR(10) NULL, 
    [2nd Filipino] NCHAR(10) NULL, 
    [Empower Tech] BIT NULL, 
    [1st Tech] NCHAR(10) NULL, 
    [2nd tech] NCHAR(10) NULL, 
    [iii] BIT NULL, 
    [1st iii] NCHAR(10) NULL, 
    [2nd iii] NCHAR(10) NULL, 
    [Oracle] BIT NULL, 
    [1st Oracle] NCHAR(10) NULL, 
    [2nd Oracle] NCHAR(10) NULL, 
    [net] BIT NULL, 
    [1st Net] NCHAR(10) NULL, 
    [2nd Net] NCHAR(10) NULL, 
    [java] BIT NULL, 
    [1st Java] NCHAR(10) NULL, 
    [2nd Java] NCHAR(10) NULL, 
    [Animation] BIT NULL, 
    [1st Animation] NCHAR(10) NULL, 
    [2nd Animation] NCHAR(10) NULL, 
    [Broad] BIT NULL, 
    [1st Broa] NCHAR(10) NULL, 
    [2nd Broa] NCHAR(10) NULL, 
    [System] BIT NULL, 
    [1st System] NCHAR(10) NULL, 
    [2nd System] NCHAR(10) NULL, 
    [immersion] BIT NULL, 
    [hours] NCHAR(10) NULL, 
    [final grade] NCHAR(10) NULL, 
    [started] DATE NULL, 
    [ended] DATE NULL
)
