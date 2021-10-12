using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassiveSkill : MonoBehaviour
{
    public bool attackPassiveSkill;
    public bool defencePassiveSkill;
    public bool healPassiveSkill;
    public bool movePassiveSkill;

    // Start is called before the first frame update
    void Start()
    {
        if(attackPassiveSkill == true)
        {
            AttackPassiveSkill();
        }
        else if (defencePassiveSkill == true)
        {
            DefencePassiveSkill();
        }
        else if (healPassiveSkill == true)
        {
            HealPassiveSkill();
        }
        else if(movePassiveSkill == true)
        {
            MovePassiveSkill();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //攻撃系パッシブスキル
    private void AttackPassiveSkill()
    {

    }

    //守備系パッシブスキル
    private void DefencePassiveSkill()
    {

    }

    //回復系パッシブスキル
    private void HealPassiveSkill()
    {

    }

    //移動系パッシブスキル
    private void MovePassiveSkill()
    {

    }
}
