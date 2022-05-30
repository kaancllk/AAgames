using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool _gamehasEnded = false;
    [SerializeField] Animator _anim;
    [SerializeField] Rotator _rotator;
    [SerializeField] Spawner _spawner;
  public void EndGame()
    {
        if (_gamehasEnded)
        {
            return;
        }
        _rotator.enabled = false;
        _spawner.enabled = false;
        _gamehasEnded = true;
        _anim.SetTrigger("__endgame");
        Debug.Log("EndGame");
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
