using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task1Script : MonoBehaviour
{
    public Transform lerpMovement;
    public Transform moveTowardsMovement;

    public float lerpStartPos;
    public float lerpEndPos;

    public float moveTowardStartPos;
    public float moveTowardEndPos;

    public float speed;

    private void Start()
    {
      
    }

    void Update()
    {
        useLerpMovement();
        useTowardsMovement();
    }

    void useLerpMovement()
    {
        float yPOS = 2f;
        Vector3 endPOS = new Vector3(lerpEndPos, yPOS, 0f);
        lerpMovement.position = Vector3.Lerp(lerpMovement.position, endPOS, speed * Time.deltaTime);
    }

    void useTowardsMovement()
    {
        float yPOS = -1f;
        Vector3 endPOS = new Vector3(moveTowardEndPos, yPOS, 0f);
        moveTowardsMovement.position = Vector3.MoveTowards(moveTowardsMovement.position, endPOS, speed * Time.deltaTime);
    }
}
