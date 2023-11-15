using System.Collections;
using System.Collections.Generic;
using Palmmedia.ReportGenerator.Core.Reporting.Builders;
using Unity.VisualScripting;
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
        int attackingAtk = this.atk;

        if ((this.wp == Enums.Weapon.Blade && target.wp == Enums.Weapon.Blunt) ||
            (this.wp == Enums.Weapon.Blunt && target.wp == Enums.Weapon.Ranged) ||
            (this.wp == Enums.Weapon.Ranged && target.wp == Enums.Weapon.Blade))
        {
            attackingAtk += 5;
        }
        else if ((this.wp == Enums.Weapon.Blade && target.wp == Enums.Weapon.Ranged) ||
                 (this.wp == Enums.Weapon.Blunt && target.wp == Enums.Weapon.Blade) ||
                 (this.wp == Enums.Weapon.Ranged && target.wp == Enums.Weapon.Blunt))
        {
            attackingAtk -= 5;
        }
        else{ }
        int atktotal = (attackingAtk - target.def);
        target.hp -= atktotal;


    }


}
