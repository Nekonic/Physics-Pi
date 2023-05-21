using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class block : MonoBehaviour
{
    int CollisionCount = 0;
    public Text text;
    private void OnCollisionEnter2D(Collision2D col)
    {
        CollisionCount++;
        text.text=CollisionCount.ToString();
    }
}
