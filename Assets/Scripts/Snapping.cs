using UnityEngine;

public class Snapping : MonoBehaviour
{
    public GameObject guard;
    public GameObject blade;
    public GameObject handle;
    private Vector3 positionGuard;
    private Vector3 positionBlade;
    private Vector3 positionHandle;
    private Vector3 distance1;
    private Vector3 distance2;
    public GameObject guard_origin;
    public GameObject blade_origin;
    public GameObject handle_origin;
    public GameObject newBladePos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        positionGuard = guard.transform.position;
        positionBlade = blade.transform.position;
        positionHandle = handle.transform.position;
        
        distance1 = positionGuard - positionBlade;
        distance2 = positionGuard - positionHandle;

        float a = distance1.magnitude;

       

        float b = distance2.magnitude;

        if(b < 0.5f)
        {
            guard.transform.position = handle_origin.transform.position;
            guard.transform.rotation = handle_origin.transform.rotation;
            
        }

        if (a < 0.5f)
        {
            Debug.Log("Snapped");
            //blade.transform.position = guard_origin.transform.position;
            blade.transform.position = newBladePos.transform.position;
          //  blade_origin.transform.rotation = guard_origin.transform.rotation;
            blade.transform.rotation = guard_origin.transform.rotation;
        }

    }

   
}
