[System.Serializable]
public class Timer {

    public float duration;
    public float timeRemaining;
    public bool finished = false;

    public Timer(float duration) {

        this.duration = duration;
    }

    public void Start() {

        timeRemaining = duration;
        this.finished = false;
    }

    public void Update() {

        if (timeRemaining >= 0f){

            timeRemaining -= Time.deltaTime;
        }
        else {
            Finish();
        }
    }

    public void Finish() {
        this.finished = true;
    }
}