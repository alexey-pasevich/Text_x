using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Falling : MonoBehaviour
{
    [SerializeField] private GameObject objectFallPrefab;
    [SerializeField] private KeyCode fallKey = KeyCode.X;
    [SerializeField] private GameObject objectFall;

    private void Start()
    {
        
    }

    private void Update()
    {

       if(Input.GetKeyUp(fallKey)) {
            if (objectFall != null) {
                Destroy(objectFall);
            }
            objectFall = Instantiate(objectFallPrefab, transform);
        
       }
    }

   
}
