using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	// Хранит ссылку на объект Player
	public GameObject player;

	// Хранит растояние до камеры от инрока в любое время
	private Vector3 offset;
    
	void Start ()
	{
		// Создает смещение вычитая положение камеры из позиции игрока
		offset = transform.position - player.transform.position;
	}

	void LateUpdate ()
	{
		// Устанавливает положение камеры 
		transform.position = player.transform.position + offset;
	}
}