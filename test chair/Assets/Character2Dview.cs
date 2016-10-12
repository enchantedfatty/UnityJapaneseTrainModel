using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Character2Dview : MonoBehaviour {


    public Transform tempCamera;
    public List<SpriteRenderer> imageList;
    public SpriteRenderer activeImage;
    public float startRotation;
	// Use this for initialization
	void Start () {

        foreach(SpriteRenderer sprite in imageList)
        {
            sprite.enabled = false;
        }
        activeImage = imageList[0];
        activeImage.enabled = true;
        startRotation = transform.rotation.eulerAngles.y;
    }
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(tempCamera);
        Vector3 tempRotation = new Vector3(0, transform.rotation.eulerAngles.y,0);
        transform.rotation = Quaternion.Euler(tempRotation);
        
        if(transform.rotation.eulerAngles.y + startRotation <= 45)
        {
            activeImage.enabled = false;
            activeImage = imageList[0];
            activeImage.enabled = true;
        }
        else if (transform.rotation.eulerAngles.y + startRotation <= 135)
        {
            activeImage.enabled = false;
            activeImage = imageList[1];
            activeImage.enabled = true;
        }
        else if (transform.rotation.eulerAngles.y + startRotation <= 225)
        {
            activeImage.enabled = false;
            activeImage = imageList[2];
            activeImage.enabled = true;
        }
        else if (transform.rotation.eulerAngles.y + startRotation <= 315)
        {
            activeImage.enabled = false;
            activeImage = imageList[3];
            activeImage.enabled = true;
        }
        else
        {
            activeImage.enabled = false;
            activeImage = imageList[0];
            activeImage.enabled = true;
        }
    }
    private float AngleBetweenVector2(Vector2 vec1, Vector2 vec2)
    {
        Vector2 diference = vec2 - vec1;
        float sign = (vec2.y < vec1.y) ? -1.0f : 1.0f;
        return Vector2.Angle(Vector2.right, diference) * sign;
    }

}
