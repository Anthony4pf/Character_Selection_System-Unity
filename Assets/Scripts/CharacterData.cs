using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Character", menuName = "Character")]
public class CharacterData : ScriptableObject
{
    public new string name;
    public int health;
    public float speed;
    public float attackPoints;
    public Sprite image;
    public GameObject player;
}