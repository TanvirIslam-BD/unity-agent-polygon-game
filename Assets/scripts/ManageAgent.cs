using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageAgent : MonoBehaviour
{
    public Transform parent;
     public Transform prefabCircle;
     public int cloneCount = 2;
    // Start is called before the first frame update
    void Start()
     {

        Vector3  prefabCirclePosition = prefabCircle.transform.position;

         for (int i = 0; i < cloneCount; i++) {
             var newObject =  Instantiate(prefabCircle, new Vector3(i * 1.5F, prefabCirclePosition.y, 0), Quaternion.identity) ;
           newObject.parent = parent.transform;
           newObject.localScale = prefabCircle.localScale;
         }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
