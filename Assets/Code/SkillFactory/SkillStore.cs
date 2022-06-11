using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class SkillStore : HeroHUD
{
    
    public void GetNewSkill(int indx)
    {
        Spell d;
        d = _abilityManager.spells[indx];

        d.User = _hero.gameObject;
        _castSystem.AddSpell(d);

       
    }
}
