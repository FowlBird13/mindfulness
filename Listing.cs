public class Listing:Activity
{
    private List<string> _GBprompts = new List<string>
    {
        "Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"
    };
    private List<string> _GBuserResponse;

    public Listing()
    {
        setName("Listing");
        setDescrip("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        setDuration(0);
        _GBuserResponse = [];
    }
    public Listing(int duration)
    {
        setName("Listing");
        setDescrip("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        setDuration(duration);
        _GBuserResponse = [];
    }
    public void setPrompts(List<string>prompts)
    {
        _GBprompts = prompts;
    }
    public void setResponse(List<string>reponses)
    {
        _GBuserResponse = reponses;
    }
    public List<string> getPrompts()
    {
        return _GBprompts;
    }
    public List<string> getResponses()
    {
        return _GBuserResponse;
    }
    public void displayString(){
        Random GBrnd = new Random();
        int rdNum = GBrnd.Next(0,_GBprompts.Count()-1);
        Console.WriteLine(_GBprompts[rdNum]);
    }
    public void userInputs()
    {
        DateTime now = DateTime.Now;
        DateTime future = now.AddSeconds(getDuration());
        while (DateTime.Now < future){
            Console.Write(">");
            _GBuserResponse.Add(Console.ReadLine());
        }

    }
    public int countResponses()
    {
        return _GBuserResponse.Count();
    }
}