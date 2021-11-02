using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ayylmao : MonoBehaviour
{
    public string funnyMeme;
    public float nine = 11;
    private int levelTen = 10;

    void Start()
    {
        Debug.Log(funnyComment(funnyMeme, levelTen));
        
    }
    int funnyComment(string name, int levelTen)
    {
        Debug.Log("what's 9+10?");
        Debug.Log((name + this.levelTen));
        return ++levelTen;
    }
}
