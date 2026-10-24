using UnityEngine;
using TMPro;

public class TextController : MonoBehaviour
{
    public TextMeshProUGUI myTextElement;
    public string[] Ingredients;
    public int index;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Ingredients = new string[] { "Bread", "Mayo Swirl", "Lettuce", "Tomato", "Onion", "Cucumber", "Cheese", "Waffle", "Pickle", "Avocado", "Pineapple", "Pepper", "Ketchup Swirl", "Mushroom", "Bread" };
        myTextElement.text = "Grab the bread slice closest to the transparent goal and place it on the bottom";
    }

    // Update is called once per frame
    public void UpdateText()
    {
        if (index > 14)
        {
            myTextElement.text = "Zoinks! Enjoy your scooby snack!";
        }
        else
        {
            myTextElement.text = "Next, place the " + Ingredients[index] + " on top of the " + Ingredients[index - 1];
            index++;
        }
    }
}
