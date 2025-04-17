using UnityEngine;

public class Snapping : MonoBehaviour
{
    public GameObject griffschutz;
    public GameObject klinge;
    private Vector3 position1;
    private Vector3 position2;
    private Vector3 distance;
    public GameObject griffschutz_origin;
    public GameObject klinge_origin;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        position1 = griffschutz.transform.position;
        position2 = klinge.transform.position;
        
        distance = position1 - position2;
        float d = distance.magnitude;

        if (d < 1f)
        {
            Debug.Log("Snapped");
            griffschutz.transform.position = klinge.transform.position;
            griffschutz.transform.rotation =klinge.transform.rotation;
           
        }
        
    }

    public void Reset()
    {
        griffschutz.transform.position = griffschutz_origin.transform.position;
        klinge.transform.position= klinge_origin.transform.position;
    }
}
