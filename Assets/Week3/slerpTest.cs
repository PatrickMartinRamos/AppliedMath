using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class slerpTest : MonoBehaviour
{

    public Transform startPoint, endPoint, center;
    public int count;
    public float radius;

    private float startTime;
    public GameObject sphere;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        sphere.transform.position = startPoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        moveSphere(startPoint.position, endPoint.position, center.position);
    }

    public void OnDrawGizmos()
    {

        foreach(var point in EvaluateSlerpPoints(startPoint.position,endPoint.position,center.position,count))
        {
            Gizmos.DrawWireSphere(point,radius);
        }
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(center.position, radius * 2);
    }

    IEnumerable<Vector3> EvaluateSlerpPoints(Vector3 start, Vector3 end, Vector3 center, int count)
    {
        var startRelativeCenter = start - center;
        var endRelativeCenter = end - center;

        var f = 1f / count;

        for (float i = 0; i < 1+f; i+=f)
        {
            yield return Vector3.Slerp(startRelativeCenter, endRelativeCenter, i) + center;
            
        }
    }
    void moveSphere(Vector3 start, Vector3 end, Vector3 center)
    {
        var startRelativeCenter = start - center;
        var endRelativeCenter = end - center;

        float fracComplete = (Time.time - startTime) / 5f;

        sphere.transform.transform.position = Vector3.Slerp(startRelativeCenter, endRelativeCenter, fracComplete);
        sphere.transform.position += center;
    }
}
