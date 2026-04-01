namespace _03._31
{
    internal class CardService : ICardService
    {
        public static Card[] Cards = [];

        public void Add(Card card)
        {
            var exsist = Find(card.CardNumber);
            if (exsist == null)
            {
                Array.Resize(ref Cards, Cards.Length + 1);
                Cards[Cards.Length - 1] = card;
            }
            else
                throw new ComplictException("Bu nomre ile kart var");


        }

        public Card Find(string cardnumber)
        {
            foreach (var item in Cards)
            {
                if (item.CardNumber == cardnumber)
                    return item;
            }
            return null;
        }
    }
}
