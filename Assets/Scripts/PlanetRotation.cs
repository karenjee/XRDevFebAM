using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public MeshRenderer myAwesomeMR; 
    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log(transform.rotation.eulerAngles.x);
        myAwesomeMR.material.SetFloat("Size", Random.Range(10, 50));

        myAwesomeMR.material.SetColor("ColorA", Color.HSVToRGB(Random.value, 1, 1));
        myAwesomeMR.material.SetColor("ColorB", Color.HSVToRGB(Random.value, 1, 1));
    }

    // Update is called once per frame
    private void Update()
    {
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + 1, transform.rotation.eulerAngles.z);
            
            }
}