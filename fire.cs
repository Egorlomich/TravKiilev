using UnityEngine;
using System.Collections;

public class fire : MonoBehaviour
{

    public float speed = 10; // скорость пули
    public Rigidbody2D pul; // префаб нашей пули
    public Transform gunPoint; // точка рождения
    public float fireRate = 1; // скорострельность

    private float curTimeout;
    public static fire instance;
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
   

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Fire();
        }
        else
        {
            curTimeout = 100;
        }
    }

    void Fire()
    {
        curTimeout += Time.deltaTime;
        if (curTimeout > fireRate)
        {
            curTimeout = 0;
            Rigidbody2D clone = Instantiate(pul, gunPoint.position, Quaternion.identity) as Rigidbody2D;
            clone.velocity = transform.TransformDirection(gunPoint.right * speed);
            clone.transform.right = gunPoint.right;
        }
    }
}