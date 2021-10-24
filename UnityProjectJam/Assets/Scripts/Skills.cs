using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skills : MonoBehaviour
{
    public float SkillCooldown;
    public float SkillCurrentCooldown;
    public GameObject Bullet;
    public GameObject MeleeAttack;
    private Vector3 AttackPosition;
    public SpriteRenderer SR;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AttackPosition = transform.position;
        AttackPosition.x = transform.position.x + 1;
        if (SR.flipX == false) { AttackPosition.x = transform.position.x - 1; }
        SkillCurrentCooldown -= Time.deltaTime;
        if (Input.GetKeyDown("e") && SkillCurrentCooldown <= 0) 
        {
            SkillCurrentCooldown = SkillCooldown; 
            switch (GetComponent<TurnSystem>().PlayerNumber)
            {
                case 1:
                    GameObject BulletInstance = Instantiate(Bullet, AttackPosition, Quaternion.identity);
                    BulletInstance.transform.right = transform.right;
                    if (SR.flipX == false) { BulletInstance.transform.right = -transform.right;}
                    break;
                case 2:
                    GameObject MeleeAttackInstance = Instantiate(MeleeAttack, AttackPosition, Quaternion.identity);
                    MeleeAttackInstance.transform.right = transform.right;
                    if (SR.flipX == false) { MeleeAttackInstance.transform.right = -transform.right; }
                    break;

            }
        }


    }
}
