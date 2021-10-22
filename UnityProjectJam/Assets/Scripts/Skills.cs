using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skills : MonoBehaviour
{
    public float SkillCooldown;
    public float SkillCurrentCooldown;
    public GameObject Bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SkillCurrentCooldown -= Time.deltaTime;
        if (Input.GetKeyDown("e") && SkillCurrentCooldown <= 0) 
        {
            SkillCurrentCooldown = SkillCooldown; 
            switch (GetComponent<TurnSystem>().PlayerNumber)
            {
                case 1:
                    GameObject BulletInstance = Instantiate(Bullet, transform.position, Quaternion.identity);
                    BulletInstance.transform.right = transform.right;
                    break;
            }
        }


    }
}
