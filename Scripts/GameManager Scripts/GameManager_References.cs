/// <summary>
/// Game manager references.
/// This script will keep track of important information about objects throughout
/// the game to be used by other scripts as a reference
/// </summary>
using UnityEngine;
using System.Collections;

namespace S1
{
	public class GameManager_References : MonoBehaviour {

		public string playerTag;
		public static string _playerTag;

		public string enemyTag;
		public static string _enemyTag;

		public static GameObject _player;

		void OnEnable() {
			if (playerTag == "") {
				Debug.LogWarning ("Please type in the name of the player tag in GameManager_References" +
				" slot in the inspector or else the system will not work");
			}

			if (enemyTag == "") {
				Debug.LogWarning ("Please type in the name of the enemy tag in GameManager_References" +
					" slot in the inspector or else the system will not work");
			}

			_playerTag = playerTag;
			_enemyTag = enemyTag;

			_player = GameObject.FindGameObjectWithTag (_playerTag);
		}

		void OnDisable() {

		}

	}

}