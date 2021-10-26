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
    private Vector3 AttackPositionYellow;
    public SpriteRenderer SR;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        AttackPositionYellow = transform.position;
        AttackPositionYellow.x = transform.position.x + 0.1f;
        AttackPosition = transform.position;
        AttackPosition.x = transform.position.x + 0.5f;
        if (SR.flipX == false) { AttackPosition.x = transform.position.x - 1; }
        SkillCurrentCooldown -= Time.deltaTime;
        if (Input.GetKeyDown("e") && SkillCurrentCooldown <= 0) 
        {
            animator.SetTrigger("Skill");
            SkillCurrentCooldown = SkillCooldown; 
            switch (GetComponent<TurnSystem>().PlayerNumber)
            {
                case 1:
                    GameObject BulletInstance = Instantiate(Bullet, AttackPositionYellow, Quaternion.identity);
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
