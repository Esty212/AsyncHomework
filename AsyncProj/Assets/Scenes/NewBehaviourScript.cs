using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    async void Start()
    {
        //task 1
        Debug.Log("I'm hungry");
        CookMeals();
        Debug.Log("going to order food");

        //task 2
        Debug.Log("Went to the resataurant");
        await ItalianFood();
        Debug.Log("Ate food");

        //task 5
        await RunAll();
        Debug.Log("The end");
    }

    //task 1
    private async void CookMeals()
    {
        Debug.Log("Making food");
        await Task.Delay(5000);
        Debug.Log("The food is burnt...");
    }

    //task 2
    private async Task ItalianFood()
    {
        Debug.Log("Pizza");
        await Task.Delay(2000);
        Debug.Log("Pasta");

        await MetAHomeless();
    }

    //task 3

    private async Task MetAHomeless()
    {
        Debug.Log("Met with a homeless guy");
        await Task.Delay(1500);
        Debug.Log("Gave my food to the homeless guy");

        CookMeals();
    }

    //task 5
    private async Task RunAll()
    {
        await Task.WhenAll(
            ItalianFood(),
            MetAHomeless()
            );
    }

}
