using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager main;
    public Transform startPosition;
    public Transform[] path;
    public int totalHealth = 50;

    private void Awake(){
        main = this;
    }

    public void removeHealth(int x){
        totalHealth -= x;
    }
    public int getHealth(){
        return totalHealth;
    }
}
