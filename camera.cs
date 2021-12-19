using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera: MonoBehaviour
{
    public GameObject hero;
    public Vector3 cameraChagePos;
    public Vector3 playerChangePos;
    private Camera cam;
    void Start()
    {
        cam = Camera.main.GetComponent<Camera>();
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.name == "hero")
        {
            collision.transform.position += playerChangePos;
            cam.transform.position += cameraChagePos;
        }
    }
}
