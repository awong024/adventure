using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Base class for any card

public enum Attribute {
    Strength,
    Dexterity,
    Intellect,
    Charisma
}

public class Card {
    public enum Type {
        Skill,
        Ally,
        Item
    }

    string card_name;
    string card_cost;
    Attribute category_attribute;

    //Require:
    //Card Art
}

public class SkillCard : Card {
    //Require:
    //Card Abilities
}

public class AllyCard : Card {
    int health;
    int attack;

    //Require:
    //Ally Abilities
}

public class ItemCard : Card {
    //Require:
    //Item Abilities
}