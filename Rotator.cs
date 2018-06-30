using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	void Update () 
	{
        // Поварачивает объект на 15 по X, 30 по Y, и 45 по Z, 
        //умноженной на deltaTime, чтобы сделать ее в секунду а не на кадр
        transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
	}
}	