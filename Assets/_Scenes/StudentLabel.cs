using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentLabel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 20), "Jeongyeon Hong, 101198653");
        GUI.Label(new Rect(10, 25, 200, 20), "Pauleen Lam, 101065605");
    }
}
