using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[CreateAssetMenu(fileName = "Rooms", menuName = "NewRoom/RoomDetails", order = 1)]
public class Rooms : ScriptableObject
{
    [SerializeField] private Material colorMaterial;
    [SerializeField] private GameObject room;
    [SerializeField] private Collider roomCollider;
    [SerializeField] private TextMeshPro RoomName;






}
