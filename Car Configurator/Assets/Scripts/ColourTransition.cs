using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourTransition : MonoBehaviour
{

}
    /*
    public Material targetMaterialOne;
                                                // arcade car 
    public Texture2D textureA;
    public Texture2D textureB;
    public Texture2D textureC;
    public Texture2D textureD;
    public Texture2D textureE;
                                                // race car

    public Material targetMaterialTwo;

    public Texture2D textureF;
    public Texture2D textureG;
    public Texture2D textureH;
    public Texture2D textureI; 

  //  int i = 0;

    public float value;

   // public int targetTexture = 1;

    public Texture2D recentTexture;
    public Texture2D targetTexture;

    void Start()
    {
        recentTexture = textureA;
        recentTexture = textureB;
        Renderer rend = GameObject.Find("Body").GetComponent<Renderer>();
        targetMaterialOne = rend.material;

    //    rend = GameObject
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            TransitionTexture(textureB);
        }
        else if(Input.GetKeyDown(KeyCode.B))
        {
            TransitionTexture(textureC);
        }

        if(value != 3)
        {
            value -= 3.5f * Time.deltaTime;
            if(value < -3)
            {
                value = -3; 
            }
        }
 

  //      targetMaterial.SetFloat("_Transition", value);
    }

    public void TransitionTexture(Texture2D newTexture)
    {
        recentTexture = targetTexture;
        targetTexture = newTexture;

   //     targetMaterial.SetTexture("_Texture2DB", recentTexture);
    //    targetMaterial.SetTexture("_Texture2DA", targetTexture);
        value = 8;
    }

    public void TransitionCarType()
    {

    }
}
    */

        /*

        targetMaterial.SetFloat("_Transition", value);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            i++;
        }

        if(i == 0)
        {
            targetMaterial.SetTexture("_Texture2DA", textureA);
        }
        else if(i == 1)
        {
            targetMaterial.SetTexture("_Texture2DA", textureB);
        }
        else if(i == 2)
        {
            targetMaterial.SetTexture("_Texture2DA", textureC);
        }
    }

    // Update is called once per frame

    public void ChangeTexture()
    {

    }
}

        */