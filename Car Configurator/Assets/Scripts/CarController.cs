using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public GameObject carObject;
    Material carMaterial;

    public GameObject materialTarget;
    public List<Texture2D> carTextures = new List<Texture2D>();

    public List<float> colourPrices = new List<float>();

    public float basePrice;

    Texture2D currentTexture;
    Texture2D recentTexture;

    float value = 8;
    private void Start()
    {
        carMaterial = materialTarget.GetComponent<Renderer>().material;

    }

    private void Update()
    {
        if (value != 3)
        {
            value -= 3.5f * Time.deltaTime;
            if (value < -3)
            {
                value = -3;
            }
        }


        carMaterial.SetFloat("_Transition", value);
    }

    public float EnableCar(bool enabled)
    {
        carObject.SetActive(enabled);
        if(enabled)
        {
            Initialise();
            return basePrice;
        }

        return -1;
    }

    public void Initialise()
    {
        carMaterial.SetTexture("_Texture2DB", carTextures[0]);
        carMaterial.SetTexture("_Texture2DA", carTextures[0]);
    }

    public float ChangeColour(int textureIndex)
    {
        value = 8;
        currentTexture = recentTexture;
        recentTexture = carTextures[textureIndex];

        carMaterial.SetTexture("_Texture2DB", currentTexture);
        carMaterial.SetTexture("_Texture2DA", recentTexture);

        return colourPrices[textureIndex];
    }

}
