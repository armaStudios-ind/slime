using Unity.VisualScripting;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{

    public GameObject cam;

    private float startingX;

    private float startingY;

    private float length;

    public float parallaxEffect;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
        startingX = transform.position.x;
        startingY = transform.position.y;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float distance = cam.transform.position.x * parallaxEffect;
        float movement = cam.transform.position.x * (1 - parallaxEffect);

       
        

        transform.position = new Vector3(startingX + distance, startingY, transform.position.z);

        if (movement > startingX + length)
        {

            startingX += length;
        }
        else if (movement < startingX - length)
        {
            startingX -= length;
        }
    }
}
