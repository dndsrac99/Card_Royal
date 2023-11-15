using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mana : MonoBehaviour
{
    public Enums.ManaTypes type;

    public Enums.cardStatus status;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void useMana()
    {
        status = Enums.cardStatus.inactiveM;
    }

    void resetMana()
    {
        status = Enums.cardStatus.activeM;
    }
}
