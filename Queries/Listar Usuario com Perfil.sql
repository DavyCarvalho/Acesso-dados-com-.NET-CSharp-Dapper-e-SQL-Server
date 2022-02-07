SELECT
    [User].*,
    [Role].[Id],
    [Role].[Name] AS [TipoDePerfil]
FROM
    [User]
    LEFT JOIN [UserRole] ON [UserRole].[UserId] = [User].[Id]
    LEFT JOIN [Role] ON [UserRole].[RoleId] = [Role].[Id]