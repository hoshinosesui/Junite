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

    //�U���n�p�b�V�u�X�L��
    private void AttackPassiveSkill()
    {

    }

    //����n�p�b�V�u�X�L��
    private void DefencePassiveSkill()
    {

    }

    //�񕜌n�p�b�V�u�X�L��
    private void HealPassiveSkill()
    {

    }

    //�ړ��n�p�b�V�u�X�L��
    private void MovePassiveSkill()
    {

    }
}
