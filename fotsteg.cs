using UnityEngine;
using System.Collections;

public class fotsteg : MonoBehaviour
{
    public GameObject soundMaker;
    public float timer;
    // Use this for initialization
    void Start()
    {
        timer = 0.5f;
    }

    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0)
        {
            timer = 1;
            AkSoundEngine.PostEvent("playerFootstep", soundMaker);
        }
    }
}
