public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        // Show starting message
        DisplayStartingMessage();

        // Each breathe takes 10 seconds
        for (int i = 0; i < _duration; i += 10) 
        {
            Console.Write("Breathe in... ");
            ShowCountDown(4);
            Console.Write("Now breathe out... ");
            ShowCountDown(6);
            Console.WriteLine();
        }

        // Show ending message
        DisplayEndingMessage();
    }
}