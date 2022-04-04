/**
 * Created By: Aidan Pohl
 * Date Created: April 4, 2022
 * 
 * Last Edited By:
 * Date Last Edited: April 4, 2022
 * */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerAttacking : MonoBehaviour
{
    /**VARIABLES**/
    [Header("Tower Stats")]
    public float sightRadius = 0; //How far it can see/attack
    public float footprint = 1;
    public float attacksPerSecond = 1; //How quickly it attacks
    public int attackStrength = 1; //How much damage each attack does
    public GameObject target;
    public TargetingTypes targeting;
    [Header("Attack Stats")]
    public GameObject attackPrefab;
    public AttackTypes attackType = AttackTypes.Projectile;
    public enum AttackTypes {Projectile, Beam, Pulsar}
    public enum TargetingTypes {First, Last, Close, Self}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartFire() {
        switch (attackType) {
            case AttackTypes.Projectile:
                ProjectileFire();
                break;
        }
    }

    private void ProjectileFire()
    {
        if(target != null)
        {
            Instantiate(attackPrefab,transform);
        }
    }
}