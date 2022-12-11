using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{ 
    //for checking if the driver has the package
    bool hasPackage;

    //color of the car if the car has package
    [SerializeField] Color32 hasPackageColor = new Color32(255, 255, 255, 255);

    //color of the car if the car does not have a package
    [SerializeField] Color32 noPackageColor = new Color32(255, 255, 255, 255);

    //the sprite renderer component from the driver
    SpriteRenderer spriteRenderer;

    private void Start()
    {
        //Getting the sprite renderer compoenent and assigning it to spriteRenderer.
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        //if the collision tag is package and if the driver car does not have the package.
        if(collision.tag == "package" && !hasPackage)
        {
            //Debug.Log("P");
            //To check if the driver object has the package
            hasPackage = true;
            //change the color of the car sprite
            spriteRenderer.color = hasPackageColor;
            // retrieve the package and destroy the game object in the view with delay 1sec.
            Destroy(collision.gameObject, 0.5f);
        }
        //checks if the tag is customer and delivers only if the driver object has package.
        if (collision.tag == "customer" && hasPackage)
        {
            //Debug.Log("c");
            //the package has been delivered and package with the driver has been made false.
            hasPackage = false;
            //change the color of the car sprite
            spriteRenderer.color = noPackageColor;
        }
    }
}
