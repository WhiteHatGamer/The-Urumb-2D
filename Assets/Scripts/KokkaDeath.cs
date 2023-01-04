using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class KokkaDeath : MonoBehaviour
{
    [SerializeField] GameObject GameOver;
    [SerializeField] Text CurrentScore;
    int tempscore=0;
    [SerializeField] Text FinalScore;
    public GameObject player;
    public Vector3 pos;
    private void Awake()
    {
        player.SetActive(true);
        GameOver.SetActive(false);
        CurrentScore.gameObject.SetActive(true);
    }
    public void SetGameOver()
    {
        player.SetActive(false);
        GameOver.SetActive(true);
        CurrentScore.gameObject.SetActive(false);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
    void Start()
    {
        //float health = 100;
    }
    void Update()
    {
        if (tempscore<pos.x)
        {
            pos.x=tempscore=(int)pos.x;
            CurrentScore.text="SCORE: " + pos.x.ToString();
        }
        pos = player.transform.position;
        if ( (pos.y<-20) )//|| (health<=0)
        {
            SetGameOver();
            FinalScore.text = "FINAL " + CurrentScore.text;
        }
    }
}
