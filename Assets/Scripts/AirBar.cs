using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
public class AirBar : MonoBehaviour
{

    public UnityEvent<int> OnScoreChanged;

	public int Score => score;

	public  int score = 1;

	[SerializeField] Timer timer;

	[SerializeField] float timePeriod;

	[SerializeField] int scoreIncrease;

	private UDateTime lastUpdatedTime;


    void Awake() 
    {
        timer.OnTimeUpdated.AddListener(UpdateTimeScore);
    }
    // Start is called before the first frame update
    void Start()
    {
        lastUpdatedTime = timer.CurrentTime;
    }

    private void UpdateTimeScore(float delta) 
    {
        var difference = timer.CurrentTime - lastUpdatedTime;
        if(difference.TotalSeconds > timePeriod) 
        {
            IncreaseScore(scoreIncrease);
            lastUpdatedTime = timer.CurrentTime;
        }
    }

    public void IncreaseScore(int increase) 
    {
        this.score = Mathf.Max(this.score + increase, 0);
        OnScoreChanged?.Invoke(increase);

        if(score == 0) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void ResetScore() 
    {
        int savedScore = Score;
        this.score = 0;
        OnScoreChanged?.Invoke(-savedScore);
    }
}
