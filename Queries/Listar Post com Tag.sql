SELECT
    [Post].*,
    [Tag].[Id],
    [Tag].[Name] AS [Tag]
FROM
    [Post]
    LEFT JOIN [PostTag] ON [PostTag].[PostId] = [Post].[Id]
    LEFT JOIN [Tag] ON [PostTag].[TagId] = [Tag].[Id]