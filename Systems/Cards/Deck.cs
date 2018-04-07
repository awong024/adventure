using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck {
    List<Card> cards = new List<Card>();

    public void Shuffle() {
        for (int i = 0; i < cards.Count - 1; i++) {
            int k = UnityEngine.Random.Range(0, cards.Count);
            Card temp = cards[i];
            cards[i] = cards[k];
            cards[k] = temp;
        }
    }

    public void AddToDeck(Card card) {
        cards.Add(card);
    }
}
