using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// object jumps on mouse click
/// </summary>
public class MosueJumper : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 pos = Input.mousePosition;
            pos.z = -Camera.main.transform.position.z;
            pos = Camera.main.ScreenToWorldPoint(pos);
            transform.position = pos;
        }
    }
}
