using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enums : MonoBehaviour{
public enum ManaTypes
{
    orange, Black, Red, Blue
}

public enum cardStatus
{
    activeM, inactiveM, active, used, inactive
}

public enum HeroTypes
{
    Authorithy,Fighter, Army, Underdog
}

public enum SubTypes
{
    Hun,Usa,Ger,Rus
}
    
public enum CardTypes
{
    Hero,Mana, Equipment,Vehicle,Tactic
}

public enum Weapon
    {
        Blade,Blunt,Ranged, None
    }

//public enum ManaTypes
//{
//    1 = "orange", 2 = "Black", 3 = "Red", 4 = "Blue"
//}

//public enum HeroTypes
//{
//    1 = "Authorithy", 2 = "Fighter", 3 = "Army", 4 = "Underdog"
//}

//public enum SubType
//{
//    1 = "Hun", 2 = "Usa", 3 = "Ger", 4 = "Rus"
//}

//public enum CardType
//{
//    1 = "Hero", 2 = "Mana", 3 = "Equipment", 4 = "Vehicle", 5 = "Tactic"
//}
}
