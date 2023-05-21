﻿DECLARE @CurrentMigration [nvarchar](max)

IF object_id('[dbo].[__MigrationHistory]') IS NOT NULL
    SELECT @CurrentMigration =
        (SELECT TOP (1) 
        [Project1].[MigrationId] AS [MigrationId]
        FROM ( SELECT 
        [Extent1].[MigrationId] AS [MigrationId]
        FROM [dbo].[__MigrationHistory] AS [Extent1]
        WHERE [Extent1].[ContextKey] = N'Моделювання.DataAccess.ClothShopContext'
        )  AS [Project1]
        ORDER BY [Project1].[MigrationId] DESC)

IF @CurrentMigration IS NULL
    SET @CurrentMigration = '0'

IF @CurrentMigration < '202305210016570_Creation'
BEGIN
    CREATE TABLE [dbo].[ClothDocs] (
        [ClothDocId] [int] NOT NULL IDENTITY,
        [Date] [datetime] NOT NULL,
        [Count] [int] NOT NULL,
        [ClothId] [int] NOT NULL,
        [ClothShopId] [int] NOT NULL,
        CONSTRAINT [PK_dbo.ClothDocs] PRIMARY KEY ([ClothDocId])
    )
    CREATE INDEX [IX_ClothId] ON [dbo].[ClothDocs]([ClothId])
    CREATE INDEX [IX_ClothShopId] ON [dbo].[ClothDocs]([ClothShopId])
    CREATE TABLE [dbo].[Clothes] (
        [ClothId] [int] NOT NULL IDENTITY,
        [Name] [nvarchar](25) NOT NULL,
        [Description] [nvarchar](max),
        [Price] [decimal](18, 2) NOT NULL,
        CONSTRAINT [PK_dbo.Clothes] PRIMARY KEY ([ClothId])
    )
    CREATE TABLE [dbo].[ClothShops] (
        [ClothShopId] [int] NOT NULL IDENTITY,
        [Name] [nvarchar](20) NOT NULL,
        [Address] [nvarchar](30) NOT NULL,
        CONSTRAINT [PK_dbo.ClothShops] PRIMARY KEY ([ClothShopId])
    )
    CREATE TABLE [dbo].[Invoices] (
        [InvoiceId] [int] NOT NULL IDENTITY,
        [Number] [nvarchar](12),
        [Date] [datetime] NOT NULL,
        [ClothShopId] [int] NOT NULL,
        CONSTRAINT [PK_dbo.Invoices] PRIMARY KEY ([InvoiceId])
    )
    CREATE INDEX [IX_ClothShopId] ON [dbo].[Invoices]([ClothShopId])
    CREATE TABLE [dbo].[InvoiceItems] (
        [InvoiceItemId] [int] NOT NULL IDENTITY,
        [InvoiceId] [int] NOT NULL,
        [ClothId] [int] NOT NULL,
        [Count] [int] NOT NULL,
        CONSTRAINT [PK_dbo.InvoiceItems] PRIMARY KEY ([InvoiceItemId])
    )
    CREATE INDEX [IX_InvoiceId] ON [dbo].[InvoiceItems]([InvoiceId])
    CREATE INDEX [IX_ClothId] ON [dbo].[InvoiceItems]([ClothId])
    ALTER TABLE [dbo].[ClothDocs] ADD CONSTRAINT [FK_dbo.ClothDocs_dbo.Clothes_ClothId] FOREIGN KEY ([ClothId]) REFERENCES [dbo].[Clothes] ([ClothId]) ON DELETE CASCADE
    ALTER TABLE [dbo].[ClothDocs] ADD CONSTRAINT [FK_dbo.ClothDocs_dbo.ClothShops_ClothShopId] FOREIGN KEY ([ClothShopId]) REFERENCES [dbo].[ClothShops] ([ClothShopId]) ON DELETE CASCADE
    ALTER TABLE [dbo].[Invoices] ADD CONSTRAINT [FK_dbo.Invoices_dbo.ClothShops_ClothShopId] FOREIGN KEY ([ClothShopId]) REFERENCES [dbo].[ClothShops] ([ClothShopId]) ON DELETE CASCADE
    ALTER TABLE [dbo].[InvoiceItems] ADD CONSTRAINT [FK_dbo.InvoiceItems_dbo.Clothes_ClothId] FOREIGN KEY ([ClothId]) REFERENCES [dbo].[Clothes] ([ClothId]) ON DELETE CASCADE
    ALTER TABLE [dbo].[InvoiceItems] ADD CONSTRAINT [FK_dbo.InvoiceItems_dbo.Invoices_InvoiceId] FOREIGN KEY ([InvoiceId]) REFERENCES [dbo].[Invoices] ([InvoiceId]) ON DELETE CASCADE
    CREATE TABLE [dbo].[__MigrationHistory] (
        [MigrationId] [nvarchar](150) NOT NULL,
        [ContextKey] [nvarchar](300) NOT NULL,
        [Model] [varbinary](max) NOT NULL,
        [ProductVersion] [nvarchar](32) NOT NULL,
        CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY ([MigrationId], [ContextKey])
    )
    INSERT [dbo].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
    VALUES (N'202305210016570_Creation', N'Моделювання.DataAccess.ClothShopContext',  0x1F8B0800000000000400D55C6B6EE33610FE5FA07710F4AB2DB29193A0C036B077913AD922E8E6813859F4DF82916847A844A9121538287A85F6023D4451B4BF16DB5EC17B925EA1A45E96F890A8871D190B2C1C8A1C0E67BEE10CA9CFFEEFC3BFE3D74BD7D11E6110DA1E9AE807FB235D83C8F42C1B2D267A84E72F5EEAAF5F7DFED9F8CC7297DABBACDF11ED4746A270A23F60EC1F1B46683E401784FBAE6D065EE8CDF1BEE9B906B03CE37034FAC63838302011A113599A36BE8910B65D18FF41FE9C7AC8843E8E8073E159D009D376F264164BD52E810B431F9870A2AF7E5FFDB3FA6BF5F7EAC3A75F577FAEFE587D5C7DFCF4DBFE29C0E0C4346118EADA896303A2D80C3A735D0308791860A2F6F15D086738F0D062E69306E0DC3EF990F49B032784E9728ED7DD5557363AA42B33D6033351661462CF6D28F0E0283595C10E6F65703D372531E619313A7EA2AB8E0D3AD1A78E871F4E3D53D7D8C98EA74E403B4AED1D3B6A3F13B0A789BBEDE59021C8A2FFF6B469E4E028801304231C00674FBB8EEE1DDBFC1E3EDD7A3F42344191E314B5267A9367A506D2741D783E0CF0D30D9C336B39B774CD288F375801F970C1D864D5E7081F1DEADA255106DC3B300749C14233EC05F03B88600030B4AE01C630203E3EB7606C664E0B664E025898CD463FDF9278104C582D64EA9140AAD3B946045D7BFDC21584CC1E3CBFB1A04BF0682F62838A44EADA0D74E2A7E183ED27219D83EE7DDAE54DE0B9379E53F063F2E4FDCC8B02931AD9133EBE05C102E2861AD1452A6895749369469FD668177711693836D6615C1FDCDD227B2861DD3AA6B719D0F4FF6C3692664802D5B50BB07C0BD1023F4CF4C3AF091EEC25B4B28654813B6493744BC6E0206ABE019CC2D00C6C3FC90FD2B9C947A5C9ABE7BA0E6C73BD6541D37681A36BD701F994560F2F756D6602AA7C5DE4374371124D5D904C250C05CDD93ED90AD16A9BECF6503DDA04AA4F2C2B882B39E9BC473DCCAB8CC173F4E8C5D06F89C074FC00F0976AD2067D85A15BC35EE4DEC3A0020507873D6C6BFD14621B2A80A4E546EA0E71B5C13DE48A0DBE47A75A230307866ED728A132061429449B2ED1920EDF56C42807E936CE042DCE262D4E03054BF30702EEA12C100A3D9A1E0BF2EC50A35CDE4FAC5E1691550A667D9AC4EA49187AA61D2BC69C765373959779862CADFA30956CC6C5230FD9934914DA3E893BA2C044FF8A339E546AB612562A2BF2406743F60A9D420762A89D98C9E5CA148426B0784C11BB58E51612E530A001059C297117D9376C84F92DC146A6ED03A75271665493230C552D9F847D720A7D8868D0573AA3E3ECF9248CC1EAEC33360AA06A82B5384FA921A39CB5FAC45C29DBB192934C3A6CEC1517A08C00F1A1A303068B0EEA418B2D60912F996480A9A89FD678C9F7737520CAABAEDDC0A154FF6DC250EA9C9D4261A15EA9418BA878E1509854DE8D9128287B869F89A5BA6F2B194B1D33FC7C2C2A485530C255A7BD2290AD6BEB77D961A190D15F0506D29B98D648645CD45989DED1989C4FC8184C46C080DD91E903B8C482FB83BB10A65708617AA5C3828A0A9E41CC149DA1AEADCF445CFDC8215320841A562A454D045D9A544492E66BC4A45E1209C9A34351846C3DA518666415BCC99B383B72173A89DFD2B1F0AA3D67E64B28F9938369EDC99295939A80DD14CAAB6C6C81C4917556E08B4ED51350476B946A4D56568AD0CE16115C49F206A929C215CBF0C212D6D151610D79E1BD616314AFA5A4C690D5828AD5A0C01842902B16809B0A18E15D58B54D84158A728DD2D92E6C59A280BA0ABB6417747902CC9F8D8D84E694368C0D091F6A7C017CDF468B023F2A6DD16609396AFA62D69C26E426320CB2A354A4EB7C26EC05600199A7F4BAD7826FEC20C49489750FE8E5EED472F96E6CBA9724AE6C3A36A3F39ECB525936827E4E46D552C5D6D5005F2DA5E2DE90C5BAB4E08A6FE605DB303F54A3B435E080A0826534F59CC84575CCA52A69C96BABA29CA4455D427A415F5225696A20233BCD700B6AB69AD2B99C93253BB0D35861FCC495B11C40B8D3401971EA784C36930D00B22D1A1B42B107B725EC80A290A4A5018C8B0496129A8B0FD4E5A52495A2A4B46958E049EA8C0D80475453A902483CB6EF98DD1C9872DE485148DE381800E4C543BFEE97544B0ACE978E9419BA7071503475C57D4285DB539647C9F169DB56D3E16EA5A07249BB1124C5D701ADD1241E5D87A89430214295908AA122B30F94F656E83428BA368A2CEE38C276C967CF8F25CCF1639C1E05EABFB3C19D0D922E943CEA3DDA163D17CC9E42E2DF1884FBB39F9CA963436A94ACC30540F61C863821F5E887234AFD2A7DCF6338DFB930C2D072044729D1172FCAFE7A862F3AD8D4CAB5ACA3A6ACE402A5CE229F71E7EF36C46A766331C522B8BBE57364C1E544FF391E73AC9DFFF03E1DB6A75D050478C7DA48FBA50F3A60A3E993A10D5468F8AD80B6B0EB8188BF11C01559CAE81104E6030838F67D776A7D26FA0B172CBF2C0A6C4C9FB7B64E9F6FEBF21ED9EACFE4FA5157FEB950EC519DD8C6F4F2161EEA93CFBD19EF9428DC42431E1C368DA47ED2CB60B76869FDFC7CCCE58D60438C4005FBE703BBE7E8672A0F9A95369BA1F66E99EAC3BF9A6CC9EB6CCFA0DC3A5B770708414D09BAC97BDDADD31507801EC9C5EAE6F9B6BB456CDC1920E5EFA0DB707A770846F26BE101A348811EFBBC49ACC4986ACB86DC8154567D153CB46CD682DEBA75B6E91030D4644FE89DA9BA3BD4548ED2C27A52CC3BADA49D2657DFE4E07AEF11A72735BF94D2279E424E48950A173095A46CD56AB2AA740A31734EC244ADE2B28A6690F2AD24F293D8A9E6B956CC23E6BC6D8509CB13F094789E428AE88069AE45A0310484E75C6EEF1CD62E8B6562A5F4AA7E800CD536F015842BF70E79D8D45315EF6C70C90D58A5FCEB5A92310B3FC4477276682FD622E8CFF22168967265DEE71CCDBD2C6B331A655D984BAF0B888145390601B6E7C0C4E431251BC4BFE9F10E3811E972E6DE43EB1C5D45D88F30593274EF9DD26F1ED0D45F357F4C9D2DEB3CBE8A5FE1847D2C81A869D30BE72BF46D643B56AEF71BC19D9D4404AD29D23B54EA4B4CEF52174FB9A44B0F290A4ACD979742B7D0F51D222CBC4233F008DBE87617C2B77001CCA7ECADBB5C48BD23CA661F9FDA601100374C65ACC7933F09862D77F9EA7F37B231AF8F520000 , N'6.4.4')
END

