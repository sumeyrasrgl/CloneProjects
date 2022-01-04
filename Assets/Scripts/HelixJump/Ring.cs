using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{
    public Transform ball;
   private GameManager GameManager;
     private void Start() {
        GameManager=GameObject.FindObjectOfType<GameManager>();
    }
    private void Update() {
        if(transform.position.y+12.5f>=ball.position.y){
            Destroy(gameObject);
            GameManager.GameScore(25);
        }
    }
}
