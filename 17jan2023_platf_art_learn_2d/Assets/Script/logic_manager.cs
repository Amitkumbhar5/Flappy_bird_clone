using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class logic_manager : MonoBehaviour
{
    public int player_score;
    public Text score;
    public GameObject Gameoverscreen;
    
    [ContextMenu("Increase score")]
    public void add_score(int score_to_add)
    {
        player_score = player_score + score_to_add;
        score.text = player_score.ToString();
    }

    public void restartgame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    public void Game_over()
    {
        Gameoverscreen.SetActive(true);
    }
}
