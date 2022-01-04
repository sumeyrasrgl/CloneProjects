using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpForce;
    public GameObject paintSplashPrefab;
    private GameManager GameManager;
     private void Start() {
        GameManager=GameObject.FindObjectOfType<GameManager>();

    }
    private void OnCollisionEnter(Collision other)
    {
        rb.AddForce(Vector3.up * jumpForce);
        GameObject splash = Instantiate(paintSplashPrefab, transform.position+new Vector3(0f,-0.23f,0f), transform.rotation);
        splash.transform.SetParent(other.gameObject.transform);
        string materialName = other.gameObject.GetComponent<MeshRenderer>().material.name;
         if (materialName == "CrashAreaMat (Instance)")
        {
            GameManager.RestartGame();
        }
        else if (materialName == "EndLevelMat (Instance)")
        {
            Debug.Log("Next Level");
        }
    }
}
