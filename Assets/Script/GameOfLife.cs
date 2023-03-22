using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOfLife : MonoBehaviour
{
    [SerializeField]
    private TextAsset _cellPrefab;
    
    void LoadCellStatus()
    {
        string[] lines = this.stageTextAsset.text.Split("\n");
        string[] first_words = lines[0].Split(",");
    }
}
