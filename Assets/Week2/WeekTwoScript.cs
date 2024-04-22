    using System.Collections;
    using System.Collections.Generic;
    using UnityEditor;
    using UnityEngine;

    public class WeekTwoScript : MonoBehaviour
    {
        public Transform enemyTF;
        [Range(0f, 5f)] public float radius;
        [SerializeField]private bool isInside = false;
    #if UNITY_EDITOR
        private void OnDrawGizmos()
        {
            Vector2 origin = transform.position;
            Vector2 enemyPOS = enemyTF.transform.position;
            
            //float distance = Vector2.Distance(origin, enemyPOS);

            float num = enemyPOS.x - origin.y;
            float num2 = enemyPOS.y - origin.y;

            float dist = Mathf.Sqrt(num * num + num2 * num2);

            isInside = dist <= radius;
       
            Handles.color = isInside ? Color.green : Color.red;
            Handles.DrawWireDisc(origin, new Vector3(0, 0, 1), radius);
       
        }
    #endif
    }
