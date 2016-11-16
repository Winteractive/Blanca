using UnityEngine;
using System.Collections;

public class FollowTarget : MonoBehaviour
{
    public Transform target;
    public Vector3 rotationOffset;
    public Vector3 positionOffset;
    public float distance;
    public float rotationLerpSpeed;
    public float positionLerpSpeed;
    public Vector3 newPosition;
    public Quaternion newRotation;
    public float maxDistance;
    public float minDistance;

    public int reverser;

    public bool insideWall;
    public BoxCollider rememberedSpot;
    public Transform positionWhenContactedWall;
    public float distanceLerp;
    // Use this for initialization
    void Start()
    {
        maxDistance = distance;
        minDistance = 2;
        reverser = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null && !insideWall)
        {

            if (!insideWall)
            {
                newPosition = target.position;
                newPosition += positionOffset;
                newPosition -= target.transform.forward * distance * reverser;
            }

            newRotation = target.transform.localRotation;
            newRotation *= Quaternion.EulerRotation(rotationOffset);


            this.transform.localPosition = Vector3.Lerp(this.transform.position, newPosition, Time.deltaTime * positionLerpSpeed);
            this.transform.localRotation = Quaternion.Lerp(this.transform.localRotation, newRotation, Time.deltaTime * rotationLerpSpeed);
        }
        else if (target != null)
        {
            Vector3 direction = target.transform.position - transform.position;
            Quaternion toRotation = Quaternion.FromToRotation(transform.forward, direction * 1.25f);
            transform.rotation = Quaternion.Lerp(transform.rotation, toRotation, 5 * Time.deltaTime);
            //  transform.LookAt(target);
        }


    }






}
