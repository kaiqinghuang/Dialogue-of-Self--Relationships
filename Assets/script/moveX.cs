using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed = 1.0f; // 你可以调整这个值来改变速度

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.PingPong(Time.time * speed, 7.8f) - 0.8f; // x在-0.8到7之间来回移动
        transform.position = new Vector3(x, transform.position.y, transform.position.z); // y和z保持不变
    }
}