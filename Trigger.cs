using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour
{

    bool triggered;

    void Start()
    {
        triggered = false;
        FindObjectOfType<FollowTarget>().insideWall = triggered;

    }

    void OnTriggerEnter(Collider collision)
    {
        Debug.Log(collision.name);
        if (collision.tag == "Wall")
        {
            triggered = true;
            FindObjectOfType<FollowTarget>().insideWall = triggered;
        }


    }

    void OnTriggerExit(Collider collision)
    {
        Debug.Log(collision.name);

        if (collision.tag == "Wall")
        {
            triggered = false;
            FindObjectOfType<FollowTarget>().insideWall = triggered;
        }
    }
}
