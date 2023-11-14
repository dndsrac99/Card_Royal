using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Card_Base : MonoBehaviour
{
    public int hp;
    public int atk;
    public int def;
    public string nameC;
    public string effect;
    public Enums.HeroTypes ht;
    public Enums.SubTypes st;
    public Enums.Weapon wp;
    public Enums.ManaTypes mt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public abstract void Effect();

    public void attack (Card_Base target)
    {
        int atktotal = (atk - target.def);
        if (atktotal < 0  ) {
        
        }
        else
        {
            if(wp == Enums.Weapon.Blade && target.wp == Enums.Weapon.Blunt)
            {

            }
        }
    }


}
