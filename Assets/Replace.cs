using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Replace : MonoBehaviour
{
    [SerializeField] private List<GameObject> instruments = new List<GameObject>();
    [SerializeField] private GameObject nativeInstrument;
    [SerializeField] private int index;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space)) {
            if (index > instruments.Count - 1) {

                index = 0;
                
            }
            

           var newInstrument = Instantiate(instruments[index], nativeInstrument.transform.parent);
           Destroy(nativeInstrument);
           nativeInstrument = newInstrument;
           index++;

        }
    }
}
