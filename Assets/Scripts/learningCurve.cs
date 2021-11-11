using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class learningCurve : MonoBehaviour
{
    //Global variables are declared here
    public int inputAge = 21;

    // Start is called before the first frame update
    void Start()
    {

        //local variables are declared here
        int currentAge = 21;
        int addedAge = 1;

        //local method ComputeAge is declared and local variables are added to in it's ()
        ComputeAge(currentAge, addedAge);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ComputeAge(int inputAge, int inputIncrease)
    {
        int intermediateCaluclation = inputAge + inputIncrease;
        Debug.LogFormat("The intial age was: {0} " + " and now it is: {1].", inputAge, intermediateCaluclation);
    }
}
