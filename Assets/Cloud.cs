using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Cloud : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private List<Transform> villagers = new List<Transform>();
    [SerializeField] private int index;
    [SerializeField] private float speed = 0.1f;
    [SerializeField] private bool isMoving = false;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Z))
        {
            StartMovement();
        }

        if (isMoving)
        {
            MoveToTarget();
        }

    }
    private void StartMovement()
    {
        isMoving = true;
    }
    private void MoveToTarget()
    {
        if (index > villagers.Count - 1)
        {

            index = 0;

        }

        if (villagers[index] != null)
        {

            Vector3 villagerPosition = villagers[index].position + (Vector3.up * 25f);

            transform.position = Vector3.Lerp(transform.position, villagerPosition, speed * Time.deltaTime);

            if (Vector3.Distance(transform.position, villagerPosition) < 0.01f)
            {
                isMoving = false;
                index++;
            }
        }
    }
}
