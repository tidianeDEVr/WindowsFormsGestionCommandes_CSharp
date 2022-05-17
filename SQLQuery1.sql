CREATE TABLE [dbo].[commande_produit] (
    [commande_id] INT            NULL,
    [produit_id] INT            NULL,
    FOREIGN KEY ([commande_id]) REFERENCES [dbo].[commande] ([ID]),
    FOREIGN KEY ([produit_id]) REFERENCES [dbo].[produit] ([ID])
);

