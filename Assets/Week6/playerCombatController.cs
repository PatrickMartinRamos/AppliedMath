using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCombatController : MonoBehaviour
{
    public GameObject leftHandWeap;
    public GameObject rightHandWeap;

    private Rigidbody rb;

    private void Start()
    {
        leftHandWeap.GetComponent<Rigidbody>().useGravity = false;
        rightHandWeap.GetComponent<Rigidbody>().useGravity = false;
    }
    private void Update()
    {
        throwWeapon();
    }

    void throwWeapon()
    {
        var mousePos = Input.mousePosition;
        mousePos.z = 0.1f;
        Vector3 screenPos = Camera.main.ScreenToWorldPoint(mousePos);
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            
        }
    }

    IEnumerator Throw(float dist, float width, Vector3 direction, float time)
    {
        Vector3 pos = transform.position;
        float height = transform.position.y;
        Quaternion q = Quaternion.FromToRotation(Vector3.forward, direction);
        float timer = 0.0f;
        GetComponent<Rigidbody>().AddTorque(0.0f, 400.0f, 0.0f);
        while (timer < time)
        {
            float t = Mathf.PI * 2.0f * timer / time - Mathf.PI / 2.0f;
            float x = width * Mathf.Cos(t);
            float z = dist * Mathf.Sin(t);
            Vector3 v = new Vector3(x, height, z + dist);
            GetComponent<Rigidbody>().MovePosition(pos + (q * v));
            timer += Time.deltaTime;
            yield return null;
        }

        GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        GetComponent<Rigidbody>().rotation = Quaternion.identity;
        GetComponent<Rigidbody>().MovePosition(pos);
    }
}
