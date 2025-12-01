namespace Software.Design.Patterns.Signleton;

public class SingletonLoadBalancer
{
    private static SingletonLoadBalancer _instance;
    // Static key object to be referenced by all threads
    private static readonly object _padlock = new object();
    private List<string> _servers = new List<string>();
    
    // Private / Protected constructor to prevent instantiation
    private SingletonLoadBalancer()
    {
        _servers.Add("Server 1");
        _servers.Add("Server 2");
        _servers.Add("Server 3");
    }

    public static SingletonLoadBalancer GetInstance()
    {
        if (_instance == null)
        {
            lock (_padlock)
            {
                // Critical Section for Multithreading
                
                // The second If statement (repeated) is necessary
                // since if a thread A is inside the critical section and thread B waiting for lock (after first if)
                // the second If statement will prevent thread B from creating another instance
                if (_instance == null)
                {
                    _instance = new SingletonLoadBalancer();
                }

            }
        }
        return _instance;
    }
}