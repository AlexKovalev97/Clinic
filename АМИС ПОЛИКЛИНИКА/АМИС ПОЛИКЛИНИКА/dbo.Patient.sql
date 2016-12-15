CREATE TABLE [dbo].[Patient] (
    [id]      INT           NOT NULL,
    [fio]     NVARCHAR (50) NOT NULL,
    [gender]  NCHAR (10)    NOT NULL,
    [db]      DATETIME      NOT NULL,
    [address] NVARCHAR (50) NOT NULL,
    [dr]      DATETIME      CONSTRAINT [DF_Patient_dr] DEFAULT (getdate()) NULL,
    [docid]   INT           NULL,
    CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [df_fio_patient_unique] UNIQUE NONCLUSTERED ([fio] ASC),
    CONSTRAINT [FK_Patient_AddrList] FOREIGN KEY ([address]) REFERENCES [dbo].[AddrList] ([address]),
    CONSTRAINT [FK_Patient_Doctor] FOREIGN KEY ([docid]) REFERENCES [dbo].[Doctor] ([id]),
    CONSTRAINT [FK_Patient_Card] FOREIGN KEY ([id]) REFERENCES [dbo].[Card] ([id]),
    CHECK ([gender]='ж' OR [gender]='м'),
    CHECK ([gender]='ж' OR [gender]='м')
);

