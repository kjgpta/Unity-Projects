using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class navmeshagentbrain : MonoBehaviour
{
    public bool ShouldIMove = true;
    public GameObject Point;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ShouldIMove == true){
            GetComponent<UnityEngine.AI.NavMeshAgent>().SetDestination(Point.transform.position);
        }
    }
}
