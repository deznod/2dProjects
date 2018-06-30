using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	
	public float speed;
	public Text countText;
	public Text winText;

	
	private Rigidbody rb;
	private int count;

	
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
        SetCountText(); // Запускаем функцию SetCountText для обновления пользовательского интерфейса
		winText.text = "";// Устанавливаем победный текст
	}

	
	void FixedUpdate ()
	{
		//создаем горизонтальные и вертикальные переменные
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		//создаем переменную вектор 3 и назначаем X и Z для отоборажения горизонтальных и вертикальных перменных
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		//добавляем физику нашему игроку  с помощью (движения) вектор3 умножая его на скорость - скорость которая отобразится в инспекторе 
		rb.AddForce (movement * speed);
	}

    /*
      *Работа метода заключается в том если игрок подбирает объект с указыным тегом то объект становится неактивным и исчезает
      * прибавляя очко к счечику очков и вызывает метод SetCountText()
    */
    void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Pick Up"))
		{
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();
		}
	}

    /*
     * Работа метода заключается в обновление нашего текстового поля и проверки не была ли досигнута сумма очков для победы.
     */
    void SetCountText()
	{
		countText.text = "Count: " + count.ToString ();	
		if (count >= 12) 
		{
			winText.text = "You Win!";// Задаем текстовое значение для нашего текстового поля.
		}
	}
}
 