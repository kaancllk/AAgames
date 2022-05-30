using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    [SerializeField] Text _scoretext;
    public int _score;
    private void Update()
    {
        _scoretext.text = _score.ToString();
    }
}
