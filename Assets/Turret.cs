using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class Turret : MonoBehaviour
{   
    [Header("Refrences")]
    [SerializeField] public Transform turretRotationPoint; 
    [SerializeField] public LayerMask enemyMask;

    [Header("Attribute")]
    [SerializeField] public float targetingRange = 5f;

    private Transform target;

    private void Update(){
        if(target==null){
            FindTarget();
            return;
        }
        RotateTowardsTarget();
    }
    
    private void OnDrawGizmosSelected(){
        Handles.color = Color.cyan;
        Handles.DrawWireDisc(transform.position, transform.forward, targetingRange);
    }

    private void FindTarget(){
        RaycastHit2D[] hits = Physics2D.CircleCastAll(transform.position, targetingRange,(Vector2)transform.position, 0f, enemyMask);
        if(hits.Length> 0){
            target = hits[0].transform;
        }
    }
    private void RotateTowardsTarget(){
        float angle = Mathf.Atan2(target.position.y - transform.position.y, target.position.x - transform.position.x) * Mathf.Rad2Deg + 180f;

        Quaternion targetRotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
        turretRotationPoint.rotation = targetRotation;
    }
}
