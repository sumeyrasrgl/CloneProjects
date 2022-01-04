using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterGenerate : MonoBehaviour
{
    public GameObject[] characterSelect;
    public int charNum;
    void Start()
    {
        charNum=Random.Range(0,3);
        characterSelect[charNum].SetActive(true);
    }
}
