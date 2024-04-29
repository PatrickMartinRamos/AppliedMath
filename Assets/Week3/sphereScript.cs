using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereScript : MonoBehaviour
{

    public float magnitude, sphereSpeed;
    public Vector3 starPOS;
    // Start is called before the first frame update
    void Start()
    {
        starPOS = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0, SineAmount(),0);
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(starPOS, .25f);
    }

    public float PingPongY()
    {
        return Mathf.PingPong(Time.time * sphereSpeed, magnitude);
    }
    public float PingPongX()
    {
        return Mathf.PingPong(Time.time * sphereSpeed, magnitude);
    }

    public float SineAmount()
    {
        return Mathf.Sin(Time.time * sphereSpeed);
    }
}
