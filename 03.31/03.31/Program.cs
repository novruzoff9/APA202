using _03._31;

Card card1 = new()
{
    Balance = 360000000,
    CardNumber = "4169738891812244",
    Bank = Bank.Kapital,
};
Card card2 = new()
{
    Balance = 360000000,
    CardNumber = "4169738891812234",
    Bank = Bank.Kapital,
};


CardService cardService = new();
cardService.Add(card1);
cardService.Add(card2);

Card card3 = new()
{
    Balance = 1200,
    CardNumber = "4169738891812234",
    Bank = Bank.Abb,
};
cardService.Add(card3);
