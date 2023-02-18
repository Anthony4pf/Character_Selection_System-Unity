using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelector : MonoBehaviour
{
     //private Vector3 spawnPos = new Vector3(0, 1, -5);
     public Text playerName;
     public Text health;
     public GameObject characterSelectPanel;
     public GameObject gamePanel;
     public GameObject player;
     public GameObject playerClone;
     public CharacterData[] characters;
     public void StartGame(int characterChoice)
     {
          CharacterData selectedCharacter = characters[characterChoice];
          playerName.text = selectedCharacter.name.ToString();
          health.text = selectedCharacter.health.ToString();
          characterSelectPanel.SetActive(false);
          gamePanel.SetActive(true);
          player = selectedCharacter.player;
          playerClone = Instantiate(player, player.transform);
     }
     public void Cancel()
     {
          characterSelectPanel.SetActive(true);
          gamePanel.SetActive(false);
          Destroy(playerClone);
     }
}
