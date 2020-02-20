using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToCursor : MonoBehaviour
{
    private Camera cam;

    // Start is called before the first frame update
    void Start()
    {

        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        var point = cam.ScreenToWorldPoint( Input.mousePosition );
        Utils.SetAxisTowards(Enums.Directions.Up, transform, point - transform.position);
    }
}
