using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DropdownControl : MonoBehaviour
{
    Dropdown carModelsDropdown;
    List<string> carModelsList = new List<string> { "Arcade Car", "Race Car" };
    string recentSelectedModel = "Arcade Car";

    Dropdown carColoursDropdown;
    List<string> colourListOne = new List<string> { "Black", "Blue", "Red", "Yellow" };



    CarController carOne;

    List<string> colourListTwo = new List<string> { "Yellow", "Blue", "Red", "Grey", "Purple" };
    CarController carTwo;

    public CarController currentCar;
    public List<string> currentColours;

    string recentSelectedColour = "Yellow";

    float basePrice = 500;
    float colourPrice = 0;

    public TextMeshProUGUI tmproText;

    private void Start()
    {
        carModelsDropdown = GameObject.Find("Car Models").GetComponent<Dropdown>();
        carModelsDropdown.ClearOptions();
        carModelsDropdown.AddOptions(carModelsList);

        carColoursDropdown = GameObject.Find("Car Colour").GetComponent<Dropdown>();
        carColoursDropdown.ClearOptions();
        carColoursDropdown.AddOptions(colourListOne);

        carOne = GameObject.Find("Race Car Controller").GetComponent<CarController>();
        carTwo = GameObject.Find("Arcade Car Controller").GetComponent<CarController>();

        currentCar = carOne;
        currentColours = colourListOne;

        tmproText = GameObject.Find("Text (TMP)").GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        float calculatePrice = basePrice + colourPrice;
        tmproText.text = "Total Price: " + (calculatePrice.ToString());

        string currentlySelectedCar = carModelsDropdown.options[carModelsDropdown.value].text;
        string currentlySelectedColour = carColoursDropdown.options[carColoursDropdown.value].text;

        if(currentlySelectedCar != recentSelectedModel)
        {
            recentSelectedModel = currentlySelectedCar;
            if(currentlySelectedCar == carModelsList[0])
            {
                InitialiseModelOne();
            }
            else if (currentlySelectedCar == carModelsList[1])
            {
                InitialiseModelTwo();
            }
        }

        if(currentlySelectedColour != recentSelectedColour)
        {
            recentSelectedColour = currentlySelectedColour;
            int colourChoice = FindIndexInList(currentColours, recentSelectedColour);
            colourPrice = currentCar.ChangeColour(colourChoice);
        }
    }

    void InitialiseModelOne()
    {
        carColoursDropdown.ClearOptions();
        carColoursDropdown.AddOptions(colourListOne);
        basePrice = carOne.EnableCar(true);
        carTwo.EnableCar(false);

        currentCar = carOne;
        currentColours = colourListOne;
    }

    void InitialiseModelTwo()
    {
        carColoursDropdown.ClearOptions();
        carColoursDropdown.AddOptions(colourListTwo);
        carOne.EnableCar(false);
        basePrice = carTwo.EnableCar(true);

        currentCar = carTwo;
        currentColours = colourListTwo;
    }

    int FindIndexInList(List<string> strings, string targetString)
    {
        for(int i = 0; i < strings.Count; i++)
        {
            if (strings[i] == targetString)
            {
                Debug.Log(i);
                return i;
            }
        }

        return -1;
    }
}






















    /*
    public Dropdown carModelsDropdown;
    List<string> carModelsList = new List<string> { "Car A", "Car B" };


    Dropdown carColoursDropdown;
    List<string> carColourListOne = new List<string>() { "Yellow", "Blue", "Red", "Grey", "Purple" };           // arcade car
    public List<Texture2D> carTextureListOne = new List<Texture2D>();

    List<string> carColourListTwo = new List<string>() { "Black", "Blue", "Red", "Yellow" };                // race car
    public List<Texture2D> carTextureListTwo = new List<Texture2D>();

    string recentlySelectedCar;
    GameObject carA;
    GameObject carB;

    Texture textureA;
    Texture textureB;

    Material carAMaterial;
    Material carBMaterial;
    private void Start()
    {
        carModelsDropdown = GameObject.Find("Car Models").GetComponent<Dropdown>();
        carModelsDropdown.ClearOptions();
        carModelsDropdown.AddOptions(carModelsList);

        carColoursDropdown = GameObject.Find("Car Colour").GetComponent<Dropdown>();
        carColoursDropdown.ClearOptions();
        carColoursDropdown.AddOptions(carColourListOne);

        carA = GameObject.Find("ArcadeCar");
        carB = GameObject.Find("RaceCar");


        carAMaterial = 

    }

    private void Update()
    {
        string currentlySelectedCar = carModelsDropdown.options[carModelsDropdown.value].text;
       // Debug.Log(Time.time + " " + currentlySelectedCar);

        if(recentlySelectedCar != currentlySelectedCar)
        {
            recentlySelectedCar = currentlySelectedCar;
            carColoursDropdown.ClearOptions();
            if (currentlySelectedCar == carModelsList[0])
            {
                carColoursDropdown.AddOptions(carColourListOne);
                carB.SetActive(false);
                carA.SetActive(true);

                textureA = carTextureListOne[0];
                textureB = carTextureListOne[0];
            }
            else
            {
                carColoursDropdown.AddOptions(carColourListTwo);
                carB.SetActive(true);
                carA.SetActive(false);

                textureA = carTextureListTwo[0];
                textureB = carTextureListTwo[0];
            }
        }

        if(currentlySelectedCar == carModelsList[1])
        {
            Debug.Log("1");
        }
        else if(currentlySelectedCar == carModelsList[0])
        {
            Debug.Log("0");
        }
    }




}
    */
    /*
    Dropdown dropDownOne;
    Dropdown dropDownTwo;
    //   public bool carColour;

    List<string> carColourListOne = new List<string>() { "Yellow", "Blue", "Red", "Grey", "Purple" };
    public List<Texture2D> carTextureListOne = new List<Texture2D>();


    List<string> carColourListTwo = new List<string>() { "Black", "Blue", "Red", "Yellow" };
    public List<Texture2D> carTextureListTwo = new List<Texture2D>();

    List<string> carMakesList = new List<string> { "Car A", "Car B" };
    public List<GameObject> carObjects = new List<GameObject>();

    string recentSelectedCar;
    int activeCar = 0;

    public Material currentlySelectedMaterial;
    float currentAlphaValue = 0;

    //  bool targetCarA = true;


    void Start()
    {
        dropDownOne = GameObject.Find("Car Make").GetComponent<Dropdown>();
        dropDownTwo = GameObject.Find("Car Colour").GetComponent<Dropdown>();

        dropDownOne.ClearOptions();
        dropDownOne.AddOptions(carMakesList);

        dropDownTwo.AddOptions(carColourListOne);
        recentSelectedCar = carMakesList[0];

        //  carObjects[1].SetActive(false);

        currentlySelectedMaterial = carObjects[0].GetComponent<Renderer>().material;
        //   activeCar = carObjects[0];


    }

    // Update is called once per frame
    void Update()
    {

    }
}
    */
        /*
        string currentlySelectedCar = dropDownOne.options[dropDownOne.value].text;
        if(recentSelectedCar != currentlySelectedCar)
        {
            recentSelectedCar = currentlySelectedCar;
            if (currentlySelectedCar == "Car A")
            {
                dropDownTwo.ClearOptions();
                dropDownTwo.AddOptions(carColourListOne);
            }
            else
            {
                dropDownTwo.ClearOptions();
                dropDownTwo.AddOptions(carColourListTwo);
            }
        }

        if(currentlySelectedCar == "Car A")
        {
            if(activeCar == 0)
            {
                if(currentAlphaValue != 0)
                {
                    currentAlphaValue -= 0.1f * Time.deltaTime;
                    if(currentAlphaValue < 0)
                    {
                        currentAlphaValue = 0;
                        Debug.Log("currentAlphaValue = 0;");
                    }
                }
            }
            else
            {
                if (currentAlphaValue != 1)
                {
                    currentAlphaValue += 0.1f * Time.deltaTime;
                    if(currentAlphaValue > 1)
                    {
                        currentAlphaValue = 1;
                        Debug.Log("currentAlphaValue = 1;");
                    }
                }
            }

            currentlySelectedMaterial.SetFloat("_AlphaValue", currentAlphaValue);
        }
        else
        {

        }

    }
}
        */






//     dropDown = GetComponent<Dropdown>();
//   InitialiseList(0);

//    if (carColour)
//    {
//        InitialiseColourList(0);
//    }
//   else
//   {
//      InitialiseCarMakeList();
//    }

